using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            LabelBienvenido.Text = "Bienvenido AndresPanitsch \nSeleccione una opción";
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void butsolicitarservicio_Click(object sender, EventArgs e)
        {
           Form_solicitud_servicio form_solicitud_servicio_nuevo = new Form_solicitud_servicio();
           this.Visible = false;
           form_solicitud_servicio_nuevo.Show();
        }

        private void butcuentacorriente_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            var CC = new Form_consulta_cuenta();
            CC.Show();
            CC.MostrarDatos();
        }


        private void butconsultarorden_Click(object sender, EventArgs e)
        {
            Form_consulta_orden form_consulta_orden_nueva = new Form_consulta_orden();
            this.Visible = false;
            form_consulta_orden_nueva.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
