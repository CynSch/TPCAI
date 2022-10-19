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
    public partial class Form_LogIn : Form
    {
        public Form_LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "AndresPanitsch" || txtContraseña.Text != "soyprofesor")
            {
                MessageBox.Show("Usuario o contraseña incorrecto. Intente nuevamente");
                return;
            }
        }
    }
}
