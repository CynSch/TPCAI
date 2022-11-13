using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
    public partial class Form_consulta_orden : Form
    {
        public Form_consulta_orden()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string ingreso = txtNumeroOrden.Text;
            bool correcto = int.TryParse(ingreso, out int entero);
            int IngresoLength = ingreso.Length;


            if (string.IsNullOrEmpty(ingreso))
            {
                MessageBox.Show("El campo no puede quedar vacio. Debe ingresar un dato.");
                txtNumeroOrden.Clear();
                return;
            }
            else if (IngresoLength > 10)
            {
                MessageBox.Show("Puede ingresar 10 carcateres como maximo");
                txtNumeroOrden.Clear();
                return;
            }
            else if (!correcto)
            {
                MessageBox.Show("Debe ingresar un valor numerico");
                txtNumeroOrden.Clear();
                return;
            }
            else
            {
                //  SolicitudDeOrden solicitud = BuscarOrden(nro);
                bool encontrado = false;

                foreach (SolicitudDeOrden solicitud in SolicitudDeOrden.SolicitudesExistentes)
                {
                    if (solicitud.NumeroDeOrden == entero)
                    {
                        if (solicitud.CUITCliente == ClienteCorporativo.ClienteActual.CUIT)
                        {

                            TxtNroOrden.Text = solicitud.NumeroDeOrden.ToString();
                            TxtFechaOrden.Text = solicitud.Fecha.ToString();
                            TxtImporteOrden.Text = solicitud.Importe.ToString();
                            Destino destino = _Destino(solicitud);
                            TxtDestinoOrden.Text = Destino.MostrarDestino(destino.EsNacional, destino.EsInternacional, destino.EntregaEnDomicilio, destino.EntregaEnSucursal, destino.CodigoDeRegionMundial, destino.CodigoDePais, destino.CodigoDeRegionNacional, destino.CodigoDeProvincia, destino.CodigoDeLocalidad, destino.Direccion, destino.NroSucursal);

                            TxtEstadoOrden.Text = SolicitudDeOrden.BuscarEstadoDeOrden(solicitud.NumeroDeOrden);
                            encontrado = true;
                        }
                        else
                        {
                            encontrado = true;
                            TxtNroOrden.Text = "";
                            TxtFechaOrden.Text = "";
                            TxtImporteOrden.Text = "";
                            TxtDestinoOrden.Text = "";
                            TxtEstadoOrden.Text = "";
                            MessageBox.Show("Disculpe las molestias: No puede ver órdenes de otros clientes! Busque, en su lugar, una orden que le pertenezca." +
                                "");
                            break;
                        }
                    }
                }
                if (encontrado == false)
                {
                    MessageBox.Show("El numero de orden ingresado es inexistente");
                }
            }
        }

        private Destino _Destino(SolicitudDeOrden solicitud)
        {
            Destino destino = Destino.BuscarDestino(solicitud.NumeroDeOrden);
                return destino;
        }

        private void btnMenu(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }

        private void Form_consulta_orden_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManejoDeArchivos.ActualizarArchivos();
            Application.Exit();
        }
    }
}
