﻿using System;
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
    public partial class Form_consulta_orden : Form
    {
        public Form_consulta_orden()
        {
            InitializeComponent();
        }

  
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string ingreso = txtNumeroOrden.Text;
            bool correcto = int.TryParse(ingreso, out int entero);
            int IngresoLength = ingreso.Length;


                 if (string.IsNullOrEmpty(ingreso))
                 {
                     MessageBox.Show("El campo no puede quedar vacio. Debe ingresar un dato.");
                     txtNumeroOrden.Clear();
                     return;
                 }

                if (IngresoLength > 10)
                {
                    MessageBox.Show("Puede ingresar 10 carcateres como maximo");
                    txtNumeroOrden.Clear();
                    return;
                }
    
                if (!correcto)
                {
                    MessageBox.Show("Debe ingresar un valor numerico");
                    txtNumeroOrden.Clear();
                    return;
                }

                if (txtNumeroOrden.Text != "1111111111")
                {
                    MessageBox.Show("La orden ingresada no existe. Intente con otro número");
                    txtNumeroOrden.Clear();
                    return;
                }

                if (txtNumeroOrden.Text == "1111111111")
                {
                txtNumeroOrden.Clear();

                TxtNroOrden.Text = "1111111111";
                TxtFechaOrden.Text = "10/09/2022";
                TxtImporteOrden.Text = "600";
                TxtDestinoOrden.Text = "Av. Cabildo 2000, Belgrano, Metropolitana CABA";

                TxtEstadoOrden.Text = "EN CENTRO DE DISTRIBUCION";

                //"en centro de distribucion"
                }

               

                


        }

        
       
        private void btnMenu(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }

        private void Form_consulta_orden_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form_consulta_orden_Load(object sender, EventArgs e)
        {

        }
    }
}
