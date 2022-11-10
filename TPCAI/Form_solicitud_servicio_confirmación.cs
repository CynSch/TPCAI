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
    public partial class Form_solicitud_servicio_confirmación : Form
    {
        public Form_solicitud_servicio_confirmación()
        {
            InitializeComponent();
            SolicitudDeOrden solicitudDeOrden = BuscarOrden();
            
            textBox_Orden.Text = "1111111111"; //Mostrar Nro de Orden
            textBox_TPaquete.Text = "Encomienda";
            textBox_Peso.Text = "2.00";
            textBox_Ancho.Text = "1.00";
            textBox_Largo.Text = "1.00";
            textBox_Alto.Text = "1.00";
            textBoxT_Envio.Text = "Nacional";
            textBox_Origen.Text = "Metropolitana,CABA,Balvanera,Av.Cordoba 2122";
            textBox_Destino.Text = "Metropolitana,CABA,Belgrano,Av.Cabildo 2000";
            textBox_Urgencia.Text = "No";
            textBox_Importe.Text = "600";
        }
        private SolicitudDeOrden BuscarOrden(int numeroOrden)
        {
            
            return SolicitudDeOrden.SolicitudesExistentes.Find(s=>s.NumeroDeOrden == numeroOrden);
        }


        private void Form_solicitud_servicio_confirmación_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void btn_volver_menu_ppal_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }



        private void Form_solicitud_servicio_confirmación_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void lbl_precio_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
