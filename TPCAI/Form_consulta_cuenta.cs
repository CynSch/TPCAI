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

        public string MostrarSaldo()
        {
           var saldo = "$172.130";
           return saldo; 
        }

        public void MostrarDatos()
        {
            //CUIT del cliente
            lbl_CUIT.Text = "CUIT = 30-99998888-2";

            // saldo de cuenta corriente
            var saldo = MostrarSaldo();
            textBox1.Text = saldo;

            // listado de facturas: 
            ListadoFacturas.FullRowSelect = true;


            ListViewItem factura2 = new ListViewItem("0934567");
            factura2.SubItems.Add("$55.000");
            factura2.SubItems.Add("15/06/2022");
            factura2.SubItems.Add("Paga");
            ListadoFacturas.Items.Add(factura2);



            ListadoFacturas.Sorting = SortOrder.Ascending;

            // ordenes pendientes de facturacion
            ListViewItem orden = new ListViewItem("1111111111");
            orden.SubItems.Add("$15.630");
            orden.SubItems.Add("14/10/2022");
            orden.SubItems.Add("Pedro J. Frías 1080, 5220 Jesus María, Córdoba");
            PendientesFacturacion.Items.Add(orden);

            ListViewItem orden1 = new ListViewItem("1111111163");
            orden1.SubItems.Add("$18.600");
            orden1.SubItems.Add("14/10/2022");
            orden1.SubItems.Add("San Martín 1002, B7000GKV Tandil, Provincia de Buenos Aires");
            PendientesFacturacion.Items.Add(orden1);

            ListViewItem orden2 = new ListViewItem("1111214583");
            orden2.SubItems.Add("$9.050");
            orden2.SubItems.Add("15/10/2022");
            orden2.SubItems.Add("Cordero 2985, 2646 San Fernando, Buenos Aires");
            PendientesFacturacion.Items.Add(orden2);

            PendientesFacturacion.Sorting = SortOrder.Ascending;
        }

        private void BtnDetalleFactura_Click(object sender, EventArgs e)
        {

            var FC = new CuentaCorrienteServiciosFacturados();
            FC.Show();
            FC.MostrarDatos();

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

           

   
    }       
}
