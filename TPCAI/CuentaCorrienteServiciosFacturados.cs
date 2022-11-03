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
    public partial class CuentaCorrienteServiciosFacturados : Form
    {
        public CuentaCorrienteServiciosFacturados()
        {
            InitializeComponent();
        }

        public void MostrarDatos()
        {
            TxtFactura.Text = "0934567";

            ListViewItem Orden1 = new ListViewItem("1111116485");
            Orden1.SubItems.Add("01/09/2022");
            Orden1.SubItems.Add("Nicolas Avellaneda 2520, San Fernando, Buenos Aires");
            Orden1.SubItems.Add("$15.000");
            listView1.Items.Add(Orden1);

            ListViewItem Orden2 = new ListViewItem("1111116486");
            Orden2.SubItems.Add("05/09/2022");
            Orden2.SubItems.Add("Belgrano 2577, Victoria, Buenos Aires");
            Orden2.SubItems.Add("$5.000");
            listView1.Items.Add(Orden2);

            ListViewItem Orden3 = new ListViewItem("1111116489");
            Orden3.SubItems.Add("12/09/2022");
            Orden3.SubItems.Add("Avenida Cazon 4849, Tigre, Buenos Aires");
            Orden3.SubItems.Add("$35.000");
            listView1.Items.Add(Orden3);

            TxtImporteTotal.Text = "$55.000"; 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            
        }
    }
}
