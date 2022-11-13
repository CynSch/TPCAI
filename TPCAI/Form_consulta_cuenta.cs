using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPCAI
{
    public partial class Form_consulta_cuenta : Form
    {
        public Form_consulta_cuenta()
        {
            InitializeComponent();
        }

        public void MostrarDatos()
        {
            //CUIT del cliente
            lbl_CUIT.Text = "CUIT = " + ClienteCorporativo.ClienteActual.CUIT.ToString();

            // saldo de cuenta corriente
            var saldo = "$" + ClienteCorporativo.ClienteActual.Saldo.ToString();
            textBox1.Text = saldo;

            // listado de facturas: 
            ListadoFacturas.FullRowSelect = true;

            int fila = 0;
            while (fila < Factura.FacturasExistentes.Count())
            {
                foreach (Factura factura in Factura.FacturasExistentes)
                {
                    if (factura.CUIT == ClienteCorporativo.ClienteActual.CUIT)
                    {
                        if (factura.EstaPaga == true)
                        {
                            ListViewItem facturaN = new ListViewItem(factura.NroFactura.ToString());
                            facturaN.SubItems.Add(factura.Monto.ToString());
                            facturaN.SubItems.Add(factura.FechaFactura.ToString());
                            facturaN.SubItems.Add("Paga");
                            ListadoFacturas.Items.Add(facturaN);
                        }
                        else
                        {
                            ListViewItem facturaN = new ListViewItem(factura.NroFactura.ToString());
                            facturaN.SubItems.Add(factura.Monto.ToString());
                            facturaN.SubItems.Add(factura.FechaFactura.ToString());
                            facturaN.SubItems.Add("Impaga");
                            ListadoFacturas.Items.Add(facturaN);
                        }
                        fila++;
                    }
                    else
                    {
                        fila++;
                        continue;
                    }
                }
            }

            ListadoFacturas.Sorting = SortOrder.Ascending;

            // ordenes pendientes de facturacion
            foreach (SolicitudDeOrden orden in SolicitudDeOrden.SolicitudesExistentes)
            {
                if (orden.CUITCliente == ClienteCorporativo.ClienteActual.CUIT)
                {
                    if (orden.NumeroDeFactura != 0)
                    {
                        continue;
                    }
                    {
                        ListViewItem ordenN = new ListViewItem(orden.NumeroDeOrden.ToString()); //nro
                        ordenN.SubItems.Add(orden.Importe.ToString());  //monto
                        ordenN.SubItems.Add(orden.Fecha.ToString()); //fecha
                        if (Destino.BuscarDestino(orden.NumeroDeOrden).EntregaEnDomicilio == true || Destino.BuscarDestino(orden.NumeroDeOrden).EsInternacional == true)
                        {
                            if(Destino.BuscarDestino(orden.NumeroDeOrden).EsInternacional == true)
                            {
                                ordenN.SubItems.Add(Destino.BuscarDestino(orden.NumeroDeOrden).Direccion+", "+ Pais.BucarNombrePais(Destino.BuscarDestino(orden.NumeroDeOrden).CodigoDePais)); //destino internacional
                            }
                            ordenN.SubItems.Add(Destino.BuscarDestino(orden.NumeroDeOrden).Direccion); //destino
                        }
                        else
                        {
                            ordenN.SubItems.Add("Sucursal "+Destino.BuscarDestino(orden.NumeroDeOrden).NroSucursal.ToString() + " - " + Sucursal.BuscarDireccion(Destino.BuscarDestino(orden.NumeroDeOrden).NroSucursal)); //Sucursal
                        }
                        PendientesFacturacion.Items.Add(ordenN);
                    }
                }
            }
            PendientesFacturacion.Sorting = SortOrder.Ascending;
        }

        private void BtnDetalleFactura_Click(object sender, EventArgs e)
        {
            ListadoFacturas.FullRowSelect = true;
            string idfacturaseleccionada = ListadoFacturas.SelectedItems[0].SubItems[0].Text;
            var FC = new CuentaCorrienteServiciosFacturados();
            FC.Show();
            FC.MostrarDatos(idfacturaseleccionada);
        }

        //volver al menu principal
        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }

        private void Form_consulta_cuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManejoDeArchivos.ActualizarArchivos();
            Application.Exit();
        }

    }
}
