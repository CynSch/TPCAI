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
            MostrarDatos();
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

            foreach (Factura factura in Factura.FacturasExistentes)
            {
                if (factura.CUIT == ClienteCorporativo.ClienteActual.CUIT)
                {
                    string Paga = "";
                    if (factura.EstaPaga == true)
                    {
                        Paga = "Paga";
                    }
                    else
                    {
                        Paga = "Impaga";
                    }
                    ListViewItem facturaN = new ListViewItem(factura.NroFactura.ToString());
                    facturaN.SubItems.Add(factura.Monto.ToString());
                    facturaN.SubItems.Add(factura.FechaFactura.ToString());
                    facturaN.SubItems.Add(Paga);
                    ListadoFacturas.Items.Add(facturaN);
                }
            }

            ListadoFacturas.Sorting = SortOrder.Ascending;

            // ordenes pendientes de facturacion
            foreach (SolicitudDeOrden orden in SolicitudDeOrden.SolicitudesExistentes)
            {
                if (orden.CUITCliente == ClienteCorporativo.ClienteActual.CUIT)
                {
                    if (orden.NumeroDeFactura == 0)
                    {
                        continue;
                    }
                    {
                        ListViewItem ordenN = new ListViewItem(orden.NumeroDeOrden.ToString()); //nro
                        ordenN.SubItems.Add(orden.Importe.ToString());  //monto
                        ordenN.SubItems.Add(orden.Fecha.ToString()); //fecha
                        ordenN.SubItems.Add(Destino.BuscarDestino(orden.NumeroDeOrden).Direccion); //destino
                        PendientesFacturacion.Items.Add(ordenN);
                    }
                }
            }
            PendientesFacturacion.Sorting = SortOrder.Ascending;
        }

        private void BtnDetalleFactura_Click(object sender, EventArgs e)
        {
            ListadoFacturas.FullRowSelect = true;
            string item = ListadoFacturas.SelectedItems.ToString();

            MessageBox.Show(item);
        
                  // var FC = new CuentaCorrienteServiciosFacturados();
                  // FC.Show();
                  // FC.MostrarDatos();
            
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
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ListadoFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_consulta_cuenta_Load(object sender, EventArgs e)
        {

        }

        private void ListadoFacturas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
