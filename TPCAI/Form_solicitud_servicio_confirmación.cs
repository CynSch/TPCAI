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
            textBox_Orden.Show(); //Mostrar Nro de Orden
            textBox_TPaquete.Show();
            textBox_Peso.Show();
            textBox_Ancho.Show();
            textBox_Largo.Show();
            textBox_Alto.Show();
            textBoxT_Envio.Show();
            textBox_Origen.Show(/*Origen.MostrarOrigen()*/);
            textBox_Destino.Show(/*Destino.MostrarDestino() */);
            textBox_Urgencia.Show();
            textBox_Importe.Show();
        }

        private void Form_solicitud_servicio_confirmación_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tipo_paquete_servicio_Click(object sender, EventArgs e)
        {

        }

        private void lbl_origen_servicio_Click(object sender, EventArgs e)
        {

        }

        private void btn_volver_menu_ppal_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }

        private void lbl_peso_servicio_Click(object sender, EventArgs e)
        {

        }

        private void Form_solicitud_servicio_confirmación_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lbl_nro_orden_servicio_Click(object sender, EventArgs e)
        {

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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lbl_destino_servicio_Click(object sender, EventArgs e)
        {
            
        }
    }
}
