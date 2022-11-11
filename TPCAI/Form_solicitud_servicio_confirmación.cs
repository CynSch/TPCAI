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
        public Form_solicitud_servicio_confirmación(SolicitudDeOrden solicitud, Origen origen, Destino destino, Servicio servicio)
        {
            InitializeComponent();
            SolicitudDeOrden solicitudDeOrden = BuscarOrden(); //Lnikear nro de orden.
            Servicio servicio;
            string numeroDeOrden = solicitudDeOrden.NumeroDeOrden.ToString();

            textBox_Orden.Text = solicitudDeOrden.NumeroDeOrden.ToString(); //Mostrar Nro de Orden
            textBox_TPaquete.Text = "";
            textBox_Peso.Text = Form_consulta_orden.txtNumeroOrden.Text;
            textBox_Ancho.Text = "1.00";
            textBox_Largo.Text = "1.00";
            textBox_Alto.Text = "1.00";
            textBoxT_Envio.Text = "Nacional";
            textBox_Origen.Text = solicitudDeOrden.Origen;
            textBox_Destino.Text = solicitudDeOrden.Destino;
            textBox_Urgencia.Text = Urgencia(solicitudDeOrden.EsUrgente);
            textBox_Importe.Text = solicitudDeOrden.Importe.ToString();

        }
        private SolicitudDeOrden BuscarOrden(int numeroOrden)
        {

            return SolicitudDeOrden.SolicitudesExistentes.Find(s => s.NumeroDeOrden == numeroOrden);
        }

        private string Urgencia(bool urgencia)
        {
            string salida = "";
            if (urgencia == true)
            {
                salida = "Si";
            }
            else
            {
                salida = "No";
            }
            return salida;
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
