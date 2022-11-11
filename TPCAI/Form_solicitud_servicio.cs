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
    public partial class Form_solicitud_servicio : Form
    {
        public Form_solicitud_servicio()
        {
            InitializeComponent();

            //Linkeo dropdown con lista de Provincias. 
            cmb_provincia_origen.Items.Add(Provincia.TodasLasProvincias);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //rd_btn_retiro_domicilio.Checked = true;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grp_Origen_Enter(object sender, EventArgs e)
        {

        }

        private void Grpbx_dimensiones_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_localidad_retirodomicilio_Click(object sender, EventArgs e)
        {

        }

        private void cmb_region_nacional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_provincia_nacional_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Almaceno la provincia seleccionada
            Provincia provinciaSeleccionada = (Provincia)cmb_provincia_nacional.SelectedItem;

            //Llamo al metodo que muestra las localidades asociadas a la provincia. 
            List<Localidad> localidadesAsociadas = new List<Localidad>();
            localidadesAsociadas = Localidad.ListarLocalidadesAsociadas(provinciaSeleccionada.CodigoDeProvincia);

            //Asocio la lista con el elemento dropdown
            cmb_localidad_nacional.Items.Clear();
            cmb_localidad_nacional.Items.Add(localidadesAsociadas);
        }

        private void cmb_localidad_nacional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Grp_Destino_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_largo_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solicitud cancelada. Volviendo al menú principal.");
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }

        //DE ACÁ HAY QUE IR EXTRAYENDO LOS DATOS QUE INGRESA EL USUARIO Y LLAMAR AL METODO CREAR SOLICITUD
        private void btn_continuar_Click(object sender, EventArgs e)
        {
            //Validaciones de que se ingresen datos
            if (!rd_btn_encomienda.Checked && !rd_btn_correspondencia.Checked)
            {
                MessageBox.Show("Debe seleccionar algún tipo de servicio.");
            }

            if (!rd_btn_origen_entrega_sucursal.Checked && !rd_btn_retiro_domicilio.Checked)
            {
                MessageBox.Show("Debe seleccionar algún origen.");
            }

            if (!rd_btn_nacional.Checked && !rd_btn_internacional.Checked)
            {
                MessageBox.Show("Debe seleccionar algún tipo de destino.");
            }

            else if (rd_btn_encomienda.Checked && (num_peso.Value == 0 
                || num_alto.Value == 0 || num_largo.Value == 0 || num_ancho.Value == 0))
            {
                MessageBox.Show("Las dimensiones deben ser mayor a 0");
            }
            else if (rd_btn_retiro_domicilio.Checked && 
                (cmb_provincia_origen.SelectedIndex == -1 
                || cmb_localidad_origen.SelectedIndex == -1 
                || string.IsNullOrEmpty(txt_domicilio_retirodomicilio.Text)))
            {
                MessageBox.Show("Debe completar todos los campos visibles " +
                    "relacionados con el retiro a domicilio para continuar");
            }
            else if (rd_btn_origen_entrega_sucursal.Checked &&
                (cmb_provincia_origen.SelectedIndex == -1
                || cmb_localidad_origen.SelectedIndex == -1
                || cmb_sucursal_entregaensucursal_origen.SelectedIndex == -1))
            {
                MessageBox.Show("Debe completar todos los campos visibles " +
                    "relacionados con la entrega en sucursal para continuar");
            }

            else if (rd_btn_origen_entrega_sucursal.Checked && 
                (cmb_sucursal_entregaensucursal_origen.SelectedIndex == -1))
            {
                MessageBox.Show("Debe completar todos los campos visibles " +
                    "relacionados con la entrega en sucursal para continuar");
            }
            else if (!rd_btn_entrega_domicilio.Checked && !rd_btn_destino_entrega_sucursal.Checked && rd_btn_nacional.Checked)
            {
                MessageBox.Show("Debe completar todos los campos relacionados con un tipo de destino nacional.");
            }
            else if(rd_btn_nacional.Checked &&
                rd_btn_entrega_domicilio.Checked &&
                (cmb_provincia_nacional.SelectedIndex == -1 
                || cmb_localidad_nacional.SelectedIndex == -1 
                || string.IsNullOrEmpty(txt_direccion_nacional.Text)))
            {
                MessageBox.Show("Debe completar todos los campos visibles" +
                    " relacionados a un destino nacional a domicilio");
            }
            else if (rd_btn_nacional.Checked &&
                rd_btn_entrega_domicilio.Checked &&
                (cmb_sucursal_entregaensucursal_destino.SelectedIndex == -1))
            {
                MessageBox.Show("Debe completar todos los campos visibles" +
                    " relacionados a un destino nacional en sucursal");
            }
            else if (rd_btn_internacional.Checked && 
                (cmb_pais_internacional.SelectedIndex == -1 
                || string.IsNullOrEmpty(txt_direccion_internacional.Text)))
            {
                MessageBox.Show("Debe completar todos los campos visibles" +
                    " relacionados a un destino internacional");
            }
            else
            {
                //CREACIÓN DE VARIABLES
                bool esEncomienda;
                bool esCorrespondencia;
                decimal peso;
                decimal ancho;
                decimal largo;
                decimal alto;
                bool origen_retiroEnDomicilio;
                bool origen_entregaEnSucursal;
                string domicilio_origen;
                Sucursal sucursal_origen;
                bool esUrgente;
                bool esInternacional;
                bool esNacional;
                Pais pais;
                string direccion_destino_internacional;
                Provincia destino_provincia;
                Localidad destino_localidad;
                bool entregaADomicilio_destino;
                bool entregaEnSucursal_destino;
                string direccion_destino_nacional;
                Sucursal sucursal_destino;
                Provincia origen_provincia;
                Localidad origen_localidad;

                //ASIGNACIÓN DE INPUT A VARIABLES
                if (rd_btn_encomienda.Checked)
                {
                    esCorrespondencia = false;
                    esEncomienda = true;
                    peso = num_peso.Value;
                    ancho = num_ancho.Value;
                    largo = num_largo.Value;
                    alto = num_alto.Value;
                }
                else if (rd_btn_correspondencia.Checked)
                {
                    esEncomienda = false;
                    esCorrespondencia = true;
                }

                origen_provincia = (Provincia)cmb_provincia_origen.SelectedItem;
                origen_localidad = (Localidad)cmb_localidad_origen.SelectedItem;

                if (rd_btn_retiro_domicilio.Checked)
                {
                    origen_retiroEnDomicilio = true;
                    origen_entregaEnSucursal = false;
                    domicilio_origen = txt_domicilio_retirodomicilio.Text;

                }
                else if (rd_btn_origen_entrega_sucursal.Checked)
                {
                    origen_retiroEnDomicilio = false;
                    origen_entregaEnSucursal = true;
                    sucursal_origen = (Sucursal)cmb_sucursal_entregaensucursal_origen.SelectedItem;
                }

                if (chkbx_urgencia.Checked)
                {
                    esUrgente = true;
                }
                else if (!chkbx_urgencia.Checked)
                {
                    esUrgente = false;
                }

                if (rd_btn_internacional.Checked)
                {
                    esInternacional = true;
                    esNacional = false;
                    pais = (Pais)cmb_pais_internacional.SelectedItem;
                    direccion_destino_internacional = txt_direccion_internacional.Text;
                }
                else if (rd_btn_nacional.Checked)
                {
                    esInternacional = false;
                    esNacional = true;
                    destino_provincia = (Provincia)cmb_provincia_nacional.SelectedItem;
                    destino_localidad = (Localidad)cmb_localidad_nacional.SelectedItem;
                    if (rd_btn_entrega_domicilio.Checked)
                    {
                        entregaADomicilio_destino = true;
                        entregaEnSucursal_destino = false;
                        direccion_destino_nacional = txt_direccion_nacional.Text;
                    }
                    else if (rd_btn_destino_entrega_sucursal.Checked)
                    {
                        entregaEnSucursal_destino = true;
                        entregaADomicilio_destino = false;
                        sucursal_destino = (Sucursal)cmb_sucursal_entregaensucursal_destino.SelectedItem;
                    }
                }

                //CREACIÓN DEL OBJETO SOLICITUD, ORIGEN, DESTINO, DSERVICIO

                //LLAMADO AL FORM DE CONFIRMACIÓN
                Form_solicitud_servicio_confirmación form_de_confirmacion = 
                new Form_solicitud_servicio_confirmación();
                this.Visible = false;
                form_de_confirmacion.Show();
            }
        }

        private void lbl_tipo_paquete_Click(object sender, EventArgs e)
        {

        }

        private void Form_solicitud_servicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rd_Internacional_CheckedChanged(object sender, EventArgs e)
        {
            //cmb_region_nacional.Enabled = false;
            cmb_provincia_nacional.Enabled = false;
            cmb_localidad_nacional.Enabled = false;
            txt_direccion_nacional.Enabled = false;
            //cmb_region_internacional.Enabled = true;
            cmb_pais_internacional.Enabled = true;
            txt_direccion_internacional.Enabled = true;
            cmb_sucursal_entregaensucursal_destino.Enabled = false;
            rd_btn_entrega_domicilio.Enabled = false;
            rd_btn_destino_entrega_sucursal.Enabled = false;
            lbl_direccion_nacional.Enabled = false;
            lbl_sucursal_entregaensucursal_destino.Enabled = false;

            cmb_pais_internacional.Items.Clear();
            cmb_pais_internacional.Items.Add(Pais.TodosLosPaises);
        }

        private void lbl_region_internacional_Click(object sender, EventArgs e)
        {

        }

        private void cmb_region_internacional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_pais_internacional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_pais_internacional_Click(object sender, EventArgs e)
        {

        }

        private void lbl_direccion_internacional_Click(object sender, EventArgs e)
        {

        }

        private void txt_direccion_internacional_TextChanged(object sender, EventArgs e)
        {

        }

        private void rd_nacional_CheckedChanged(object sender, EventArgs e)
        {
            //cmb_region_nacional.Enabled = true;
            cmb_provincia_nacional.Enabled = true;
            cmb_localidad_nacional.Enabled = true;
            txt_direccion_nacional.Enabled = true;

            //cmb_region_internacional.Enabled = false;
            cmb_pais_internacional.Enabled = false;
            txt_direccion_internacional.Enabled = false;
            rd_btn_entrega_domicilio.Enabled = true;
            rd_btn_destino_entrega_sucursal.Enabled = true;
            cmb_sucursal_entregaensucursal_destino.Enabled = true;
            lbl_direccion_nacional.Enabled = true;
            lbl_sucursal_entregaensucursal_destino.Enabled = true;

            cmb_provincia_nacional.Items.Add(Provincia.TodasLasProvincias);
        }

        private void rd_btn_retiro_domicilio_CheckedChanged(object sender, EventArgs e)
        {
            //cmb_region__retirodomicilio.Enabled = true;
            cmb_provincia_origen.Enabled = true;
            cmb_localidad_origen.Enabled = true;
            txt_domicilio_retirodomicilio.Enabled = true;
            //cmb_region_entregaensucursal_origen.Enabled = false;
            cmb_sucursal_entregaensucursal_origen.Enabled = false;
        }

        private void cmb_sucursal_entregaensucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rd_btn_entrega_sucursal_CheckedChanged(object sender, EventArgs e)
        {
            //cmb_region_entregaensucursal_origen.Enabled = true;
            cmb_sucursal_entregaensucursal_origen.Enabled = true;
            //cmb_region__retirodomicilio.Enabled = false;
            txt_domicilio_retirodomicilio.Enabled = false;

            //Saco el dato de la provincia y localidad seleccionadas
            Provincia provinciaSeleccionada = (Provincia)cmb_provincia_origen.SelectedItem;
            Localidad localidadSeleccionada = (Localidad)cmb_localidad_origen.SelectedItem;

            //Creo una lista para almacenar las sucursales disponibles
            List<Sucursal> sucursalesAsociadas = new List<Sucursal>();
            sucursalesAsociadas = Sucursal.ListarSucursalesAsociadas(provinciaSeleccionada.CodigoDeProvincia, localidadSeleccionada.CodigoDeLocalidad);

            //Linkeo la lista de sucursales con el drodpwon     
            cmb_sucursal_entregaensucursal_origen.Items.Clear();
            cmb_sucursal_entregaensucursal_origen.Items.Add(sucursalesAsociadas);
        }

        private void rd_btn_correspondencia_CheckedChanged(object sender, EventArgs e)
        {
            num_peso.Enabled = false;
            num_ancho.Enabled = false;
            num_largo.Enabled = false;
            num_alto.Enabled = false;

        }

        private void rd_btn_encomienda_CheckedChanged(object sender, EventArgs e)
        {
            num_peso.Enabled = true;
            num_ancho.Enabled = true;
            num_largo.Enabled = true;
            num_alto.Enabled = true;
        }


        private void cmb_provincia_retirodomicilio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Almaceno la provincia seleccionada en una variable. 
            Provincia provinciaSeleccionada = (Provincia)cmb_provincia_origen.SelectedItem;

            //Llamo al metodo que muestra las localidades asociadas a la provincia. 
            List<Localidad> localidadesAsociadas = new List<Localidad>();
            localidadesAsociadas = Localidad.ListarLocalidadesAsociadas(provinciaSeleccionada.CodigoDeProvincia);

            //Asocio la lista con el elemento dropdown
            cmb_localidad_origen.Items.Clear();
            cmb_localidad_origen.Items.Add(localidadesAsociadas);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grp_bx_nacional_Enter(object sender, EventArgs e)
        {

        }

        private void rd_btn_entrega_domicilio_CheckedChanged(object sender, EventArgs e)
        {
            cmb_sucursal_entregaensucursal_destino.Enabled= false;
            txt_direccion_nacional.Enabled = true;
            lbl_direccion_nacional.Enabled = true;
            lbl_sucursal_entregaensucursal_destino.Enabled = false;
  

        }

        private void rd_btn_destino_entrega_sucursal_CheckedChanged(object sender, EventArgs e)
        {
            cmb_sucursal_entregaensucursal_destino.Enabled = true;
            txt_direccion_nacional.Enabled = false;
            lbl_direccion_nacional.Enabled = false;
            lbl_sucursal_entregaensucursal_destino.Enabled = true;

            //Saco el dato de la provincia y localidad seleccionadas
            Provincia provinciaSeleccionada = (Provincia)cmb_provincia_nacional.SelectedItem;
            Localidad localidadSeleccionada = (Localidad)cmb_localidad_nacional.SelectedItem;

            //Creo una lista para almacenar las sucursales disponibles
            List<Sucursal> sucursalesAsociadas = new List<Sucursal>();
            sucursalesAsociadas = Sucursal.ListarSucursalesAsociadas(provinciaSeleccionada.CodigoDeProvincia, localidadSeleccionada.CodigoDeLocalidad);

            //Linkeo la lista de sucursales con el drodpwon     
            cmb_sucursal_entregaensucursal_destino.Items.Clear();
            cmb_sucursal_entregaensucursal_destino.Items.Add(sucursalesAsociadas);
        }

        private void txt_direccion_nacional_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_ancho_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_localidad_origen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Localidad localidad_origen = (Localidad)cmb_localidad_origen.SelectedItem;
        }
    }
}
