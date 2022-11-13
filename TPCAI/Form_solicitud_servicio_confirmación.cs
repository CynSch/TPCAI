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
        public string _NroOrdenGenerada;
        public string _TipoPaquete;
        public string _Peso;
        public string _Ancho;
        public string _Largo;
        public string _Alto;
        public string _TipoEnvio;
        public string _Origen;
        public string _Destino;
        public string _Urgencia;
        public string _Importe;
       

        public Form_solicitud_servicio_confirmación()
        {
            InitializeComponent();
        }

        private void Form_solicitud_servicio_confirmación_Load(object sender, EventArgs e)
        {
            textBox_Orden.Text = _NroOrdenGenerada;
            textBox_TPaquete.Text = _TipoPaquete;
            textBox_Peso.Text = _Peso;
            textBox_Ancho.Text = _Ancho;
            textBox_Largo.Text = _Largo;
            textBox_Alto.Text = _Alto;
            textBoxT_Envio.Text = _TipoEnvio;
            textBox_Origen.Text = _Origen;
            textBox_Destino.Text = _Destino;
            textBox_Urgencia.Text = _Urgencia;
            textBox_Importe.Text = _Importe;
        }

        private void btn_volver_menu_ppal_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }
        private void Form_solicitud_servicio_confirmación_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManejoDeArchivos.ActualizarArchivos();
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
