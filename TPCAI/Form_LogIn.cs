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
        bool accesoPermitido = false;

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

        private void Form_LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            while (accesoPermitido)
            {
                accesoPermitido = ClienteCorporativo.BuscarClienteCorporativo(validador)
            }


            if (txtUsuario.Text != "AndresPanitsch" || txtContraseña.Text != "soyprofesor")
            {
                MessageBox.Show("Usuario o contraseña incorrecto. Intente nuevamente");
                return;
            }
            else
            {
                Menu elMenu = new Menu();
                this.Hide();
                elMenu.Show();
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (!(txtUsuario.Text is null) && txtUsuario.Text != "")
            {
                if (!(txtContraseña.Text is null) && txtContraseña.Text != "")
                {
                    btnAceptar.Enabled = true;
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
