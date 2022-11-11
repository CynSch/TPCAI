using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

                if (IngresoLength > 10)
                {
                    MessageBox.Show("Puede ingresar 10 carcateres como maximo");
                    txtNumeroOrden.Clear();
                    return;
                }
    
                if (!correcto)
                {
                    MessageBox.Show("Debe ingresar un valor numerico");
                    txtNumeroOrden.Clear();
                    return;
                }
                else
                {
                int nro;
                bool ingresoCorrecto = int.TryParse(ingreso, out nro);

              //  SolicitudDeOrden solicitud = BuscarOrden(nro);

                    foreach (SolicitudDeOrden solicitud in SolicitudDeOrden.SolicitudesExistentes)
                    {
                        if (solicitud.NumeroDeOrden == nro)
                        {
                            TxtNroOrden.Text = solicitud.NumeroDeOrden.ToString();
                            TxtFechaOrden.Text = solicitud.Fecha.ToString();
                            TxtImporteOrden.Text = solicitud.Importe.ToString();

                            TxtDestinoOrden.Text = _Destino(solicitud);
                            //Destino destino = BuscarDestino(solicitud.NumeroDeOrden);
                            
                            
                            TxtDestinoOrden.Text = "Av. Cabildo 2000, Belgrano, Metropolitana CABA";

                             EstadoDeOrden estado = BuscarEstado(solicitud.CodigoDeEstado);
                             string nombreEstado = estado.Descripcion;
                             TxtEstadoOrden.Text = nombreEstado;
                            
                        }
                        else
                        {
                            MessageBox.Show("La orden ingresada no existe. Intente con otro número");
                            txtNumeroOrden.Clear();

                        }

                      
                    }

            

                }
                

                if()
                
               /* if (txtNumeroOrden.Text != "1111111111")
                {


                    MessageBox.Show("La orden ingresada no existe. Intente con otro número");
                    txtNumeroOrden.Clear();
                    return;
                }*/

                if (txtNumeroOrden.Text == "1111111111")
                {
                txtNumeroOrden.Clear();

                TxtNroOrden.Text = "1111111111";
                TxtFechaOrden.Text = "10/09/2022";
                TxtImporteOrden.Text = "$600";
                TxtDestinoOrden.Text = "Av. Cabildo 2000, Belgrano, Metropolitana CABA";

                TxtEstadoOrden.Text = "EN CENTRO DE DISTRIBUCION";

                //"en centro de distribucion"
                }

               

                


        }
        private EstadoDeOrden BuscarEstado(int codigoestado)
        {
            return EstadoDeOrden.EstadosDisponibles.Find(e => e.CodigoDeEstado == codigoestado);
        }

        private Destino BuscarDestino(int nroOrden)
        {
            return Destino.DestinosExistentes.Find(d => d.NumeroDeOrden == nroOrden);
        }

        private string _Destino(SolicitudDeOrden solicitud)
        {
            Destino destino = BuscarDestino(solicitud.NumeroDeOrden);
            int nroOrden = destino.NumeroDeOrden;
            bool internacional = destino.EsInternacional;
            bool nacional = destino.EsNacional;
            bool entregaDomicilio = destino.EntregaEnDomicilio;
            bool entregaEnSucursal = destino.EntregaEnSucursal;
            int codRegionMundial = destino.CodigoDeRegionMundial;
            int codPais = destino.CodigoDePais;
            int codRegNacional = destino.CodigoDeRegionNacional;
            int codProvincia = destino.CodigoDeProvincia;
            int codLocalidad = destino.CodigoDeLocalidad;
            string direccion = destino.Direccion;
            int nroSucursal = destino.NroSucursal;

          //  string destinoAMostrar = Destino.MostrarDestino(nacional, internacional,entregaDomicilio, entregaEnSucursal, codRegionMundial, 
                //codPais, codRegNacional, codProvincia, codLocalidad, direccion, nroSucursal);


                return "o";

        }

        private SolicitudDeOrden BuscarOrden(int numeroOrden)
        {

            return SolicitudDeOrden.SolicitudesExistentes.Find(s => s.NumeroDeOrden == numeroOrden);
        }


        private void btnMenu(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }

        private void Form_consulta_orden_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form_consulta_orden_Load(object sender, EventArgs e)
        {

        }

        private void txtNumeroOrden_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
