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
    public partial class Form_consulta_cuenta : Form
    {
        public Form_consulta_cuenta()
        {
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var saldo = MostrarSaldo();
           // listBox1.Items.Add(saldo);
           // MessageBox.Show(saldo);
        }

        public string MostrarSaldo()
        {
           var saldo = "$1000000";
           return saldo; 
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // saldo de cuenta corriente
            var saldo = MostrarSaldo();
            listBox1.Items.Add(saldo);


            // listado de facturas: 
            ListViewItem factura1 = new ListViewItem("1111225");
            factura1.SubItems.Add("$5000");
            factura1.SubItems.Add("15/09/2022");
            factura1.SubItems.Add("Paga");
            ListadoFacturas.Items.Add(factura1);

            ListViewItem factura2 = new ListViewItem("1234567");
            factura2.SubItems.Add("$55000");
            factura2.SubItems.Add("15/06/2022");
            factura2.SubItems.Add("Paga");
            ListadoFacturas.Items.Add(factura2);

            ListViewItem factura3 = new ListViewItem("1682694");
            factura3.SubItems.Add("$21500");
            factura3.SubItems.Add("05/10/2022");
            factura3.SubItems.Add("Impaga");
            ListadoFacturas.Items.Add(factura3);

            ListViewItem factura4 = new ListViewItem("1825663");
            factura4.SubItems.Add("$150630");
            factura4.SubItems.Add("10/10/2022");
            factura4.SubItems.Add("Impaga");
            ListadoFacturas.Items.Add(factura4);

            // ordenes pendientes de facturacion
            ListViewItem orden = new ListViewItem("1111111111");
            orden.SubItems.Add("$15630");
            orden.SubItems.Add("14/10/2022");
            PendientesFacturacion.Items.Add(orden);

            ListViewItem orden1 = new ListViewItem("1111114563");
            orden1.SubItems.Add("$18600");
            orden1.SubItems.Add("14/10/2022");
            PendientesFacturacion.Items.Add(orden1);

            ListViewItem orden2 = new ListViewItem("1111214583");
            orden2.SubItems.Add("$9050");
            orden2.SubItems.Add("15/10/2022");
            PendientesFacturacion.Items.Add(orden2);


        }

        //volver al menu principal
        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }       
}
