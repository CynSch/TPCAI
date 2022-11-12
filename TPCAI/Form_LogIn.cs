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

        private void Form_LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            bool accesoPermitido = false;
            bool usuarioEncontrado = false;
            bool usuarioValido = false;


            usuarioValido = Validador.ChequearLong(txtUsuario.Text, 10000000000,99999999999);

            if (usuarioValido)
            {
                usuarioEncontrado = ClienteCorporativo.BuscarClienteCorporativo(long.Parse(txtUsuario.Text));
                if (usuarioEncontrado)
                {
                    accesoPermitido = ClienteCorporativo.ClienteActual.Contraseña == txtContraseña.Text;
                    if (accesoPermitido)
                    {
                        Menu elMenu = new Menu();
                        this.Hide();
                        elMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta. Intente nuevamente");
                        txtUsuario.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("El C.U.I.T introducido no se encuentra registrado en el sistema. Intente nuevamente");
                    txtUsuario.Clear();
                }
            }
            else
            {
                MessageBox.Show("El valor introducido es invalido. Por favor ingrese un numero de C.U.I.T");
                txtUsuario.Clear();
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
