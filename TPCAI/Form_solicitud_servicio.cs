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
    public partial class Form_solicitud_servicio : Form
    {
        public Form_solicitud_servicio()
        {
            InitializeComponent();            
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
            foreach (Provincia p in Provincia.TodasLasProvincias)
            {
                cmb_provincia_origen.Items.Add(p.NombreDeProvincia);
            }

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
            //Limpio el dropdown
            cmb_localidad_nacional.Items.Clear();

            //Almaceno la provincia seleccionada
            string provinciaSeleccionada = cmb_provincia_nacional.SelectedText;
            int codigoDeProvincia = -1;
            foreach (Provincia p in Provincia.TodasLasProvincias)
            {
                if (p.NombreDeProvincia == provinciaSeleccionada)
                {
                    codigoDeProvincia = p.CodigoDeProvincia; 
                }               
            }

            //Llamo al metodo que muestra las localidades asociadas a la provincia. 
            List<Localidad> localidadesAsociadas = new List<Localidad>();
            localidadesAsociadas = Localidad.ListarLocalidadesAsociadas(codigoDeProvincia);

            //Asocio la lista con el elemento dropdown
            foreach (Localidad localidad in localidadesAsociadas)
            {
                cmb_localidad_nacional.Items.Add(localidad.NombreDeLocalidad);
            }
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
                int cuitCliente;
                bool esEncomienda = false;
                bool esCorrespondencia = false;
                decimal peso;
                decimal ancho;
                decimal largo;
                decimal alto;
                bool origen_retiroEnDomicilio = false;
                bool origen_entregaEnSucursal = false;
                string domicilio_origen;
                Sucursal sucursal_origen;
                bool esUrgente=false;
                bool esInternacional = false ;
                bool esNacional=false;
                Pais pais;
                string direccion_destino;
                //string direccion_destino_internacional;
                Provincia destino_provincia;
                Localidad destino_localidad;
                bool entregaADomicilio_destino=false;
                bool entregaEnSucursal_destino=false;
                //string direccion_destino_nacional;
                Sucursal sucursal_destino=null;
                Provincia origen_provincia;
                Localidad origen_localidad;
                DateTime fecha = DateTime.Now;

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
                else
                {
                    esEncomienda = false;
                    esCorrespondencia = true;
                    peso = 0;
                    ancho = 0;
                    largo = 0;
                    alto = 0;
                }

                string provinciaSeleccionada = cmb_provincia_origen.SelectedText;
                /*foreach (Provincia p in Provincia.TodasLasProvincias)
                {
                    if (p.NombreDeProvincia == provinciaSeleccionada)
                    {
                        origen_provincia = p;
                    }
                    
                }*/
                //SolicitudesExistentes.Find(solicitud => solicitud.NumeroDeOrden == NumDeOrdenABuscar);
                origen_provincia = Provincia.TodasLasProvincias.Find(prov => prov.NombreDeProvincia == provinciaSeleccionada);

                string localidadSeleccionada = cmb_localidad_origen.SelectedText;
                /*foreach (Localidad l in Localidad.LstLocalidades)
                {
                    if (l.NombreDeLocalidad == localidadSeleccionada)
                    {
                        origen_localidad = l;
                    }
                }*/
                origen_localidad = Localidad.LstLocalidades.Find(loc => loc.NombreDeLocalidad == localidadSeleccionada);

                if (rd_btn_retiro_domicilio.Checked)
                {
                    origen_retiroEnDomicilio = true;
                    origen_entregaEnSucursal = false;
                    domicilio_origen = txt_domicilio_retirodomicilio.Text;
                    sucursal_origen = null;

                }
                else
                {
                    domicilio_origen = null;
                    origen_retiroEnDomicilio = false;
                    origen_entregaEnSucursal = true;

                    string direccSucursalSeleccionada = cmb_sucursal_entregaensucursal_origen.SelectedText;
                    /*foreach (Sucursal s in Sucursal.TodasLasSucursales)
                    {
                        if (s.Direccion == direccSucursalSeleccionada)
                        {
                            sucursal_origen = s;
                        }
                    }*/
                    sucursal_origen = Sucursal.TodasLasSucursales.Find(suc => suc.Direccion == direccSucursalSeleccionada);
                }

                if (chkbx_urgencia.Checked)
                {
                    esUrgente = true;
                }
                else
                {
                    esUrgente = false;
                }

                if (rd_btn_internacional.Checked)
                {
                    esInternacional = true;
                    esNacional = false;
                    string paisSeleccionado = cmb_pais_internacional.SelectedText;
                    pais = Pais.TodosLosPaises.Find(pa => pa.NombreDePais == paisSeleccionado);
                    direccion_destino = txt_direccion_internacional.Text;
                    destino_localidad = null;
                    destino_provincia = null;
                }
                else
                {
                    pais = null;
                    esInternacional = false;
                    esNacional = true;

                    string provinciaElegida = cmb_provincia_nacional.SelectedText;
                    /*foreach (Provincia p in Provincia.TodasLasProvincias)
                    {
                        if (p.NombreDeProvincia == provinciaElegida)
                        {
                            destino_provincia = p;
                        }
                    }*/
                    destino_provincia = Provincia.TodasLasProvincias.Find(prov => prov.NombreDeProvincia == provinciaElegida);
                    string localidadElegida = cmb_localidad_nacional.SelectedText;
                    destino_localidad = Localidad.LstLocalidades.Find(loc => loc.NombreDeLocalidad == localidadElegida);


                    if (rd_btn_entrega_domicilio.Checked)
                    {
                        entregaADomicilio_destino = true;
                        entregaEnSucursal_destino = false;
                        direccion_destino = txt_direccion_nacional.Text;
                        sucursal_destino = null;
                    }
                    else
                    {
                        entregaEnSucursal_destino = true;
                        entregaADomicilio_destino = false;
                        direccion_destino = null;
                        string sucursalElegida = cmb_sucursal_entregaensucursal_destino.SelectedText;
                        sucursal_destino = Sucursal.TodasLasSucursales.Find(suc => suc.Direccion == sucursalElegida);
                    }
                }

                decimal importe = Tarifa.CalcularImporte(esUrgente,esCorrespondencia,peso,origen_retiroEnDomicilio,entregaADomicilio_destino,origen_localidad.CodigoDeLocalidad,sucursal_origen.NroSucursal,esNacional,pais.CodigoDePais,destino_localidad.CodigoDeLocalidad);

                cuitCliente = 1111111;

                //CREACIÓN DEL OBJETO SOLICITUD, ORIGEN, DESTINO, DSERVICIO

                SolicitudDeOrden nuevaSolicitud = SolicitudDeOrden.GrabarNuevaSolicitud(cuitCliente,esUrgente,fecha,importe);
                Destino nuevoDestino = Destino.GrabarNuevoDestino(nuevaSolicitud.NumeroDeOrden,esInternacional,esNacional,entregaADomicilio_destino,entregaEnSucursal_destino,pais.CodigoDeRegionMundial,pais.CodigoDePais,destino_provincia.CodigoDeRegionNacional,destino_provincia.CodigoDeProvincia,destino_localidad.CodigoDeLocalidad,direccion_destino,sucursal_destino.NroSucursal);
                Origen nuevoOrigen = Origen.GrabarNuevoOrigen(nuevaSolicitud.NumeroDeOrden, origen_retiroEnDomicilio, origen_entregaEnSucursal, origen_provincia.CodigoDeRegionNacional, origen_provincia.CodigoDeProvincia, origen_localidad.CodigoDeLocalidad, domicilio_origen, sucursal_origen.NroSucursal);  
                Servicio nuevoServicio = Servicio.GrabarNuevoServicio();

                //LLAMADO AL FORM DE CONFIRMACIÓN
                Form_solicitud_servicio_confirmación form_de_confirmacion = new Form_solicitud_servicio_confirmación();
                this.Visible = false;

                //ACÁ LINKEAR LOS ELEMENTOS DEL FORM CON LA NUEVA SOLICITUD
                form_de_confirmacion._NroOrdenGenerada = nuevaSolicitud.NumeroDeOrden;
                if (rd_btn_correspondencia.Checked)
                {
                    form_de_confirmacion._TipoPaquete = "correspondencia";
                    form_de_confirmacion._Peso = null;
                    form_de_confirmacion._Ancho = null;
                    form_de_confirmacion._Largo = null;
                    form_de_confirmacion._Alto = null;
                }
                else if (rd_btn_encomienda.Checked)
                {
                    form_de_confirmacion._TipoPaquete = "encomienda";
                    form_de_confirmacion._Peso = nuevoServicio.Peso.ToString();
                    form_de_confirmacion._Ancho = nuevoServicio.Ancho.ToString();
                    form_de_confirmacion._Largo = nuevoServicio.Largo.ToString();
                    form_de_confirmacion._Alto = nuevoServicio.Alto.ToString();
                }

                if (rd_btn_nacional.Checked)
                {
                    form_de_confirmacion._TipoEnvio = "Nacional";
                }
                else if(rd_btn_internacional.Checked)
                {
                    form_de_confirmacion._TipoEnvio = "Internacional";
                }
                form_de_confirmacion._Origen = Origen.MostrarOrigen(origen_retiroEnDomicilio,origen_entregaEnSucursal, origen_provincia.CodigoDeRegionNacional, origen_provincia.CodigoDeProvincia, origen_localidad.CodigoDeLocalidad,domicilio_origen, sucursal_origen.NroSucursal);
                form_de_confirmacion._Destino = Destino.MostrarDestino(esNacional,esInternacional,entregaADomicilio_destino,entregaEnSucursal_destino, pais.CodigoDeRegionMundial, pais.CodigoDePais, destino_provincia.CodigoDeRegionNacional, destino_provincia.CodigoDeProvincia, destino_localidad.CodigoDeLocalidad, direccion_destino, sucursal_destino.NroSucursal);

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
            foreach (Pais p in Pais.TodosLosPaises)
            {
                cmb_pais_internacional.Items.Add(p.NombreDePais);
            }
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

            //Limpio el dropdown
            cmb_provincia_nacional.Items.Clear();
            foreach (Provincia p in Provincia.TodasLasProvincias)
            {
                cmb_provincia_nacional.Items.Add(p.NombreDeProvincia);
            }
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
            
            //Limpio el dropdown
            cmb_sucursal_entregaensucursal_origen.Items.Clear();

            //Saco el dato de la provincia y localidad seleccionadas
            Provincia provinciaSeleccionada = (Provincia)cmb_provincia_origen.SelectedItem;
            Localidad localidadSeleccionada = (Localidad)cmb_localidad_origen.SelectedItem;

            //Creo una lista para almacenar las sucursales disponibles
            List<Sucursal> sucursalesAsociadas = new List<Sucursal>();
            sucursalesAsociadas = Sucursal.ListarSucursalesAsociadas(provinciaSeleccionada.CodigoDeProvincia, localidadSeleccionada.CodigoDeLocalidad);

            //Linkeo la lista de sucursales con el drodpwon     
            foreach (Sucursal sucursal in sucursalesAsociadas)
            {
                cmb_sucursal_entregaensucursal_origen.Items.Add(sucursal.Direccion);
            }
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
            //Limpio el dropdown
            cmb_localidad_origen.Items.Clear();

            //Almaceno la provincia seleccionada en una variable. 
            Provincia provinciaSeleccionada = (Provincia)cmb_provincia_origen.SelectedItem;

            //Llamo al metodo que muestra las localidades asociadas a la provincia. 
            List<Localidad> localidadesAsociadas = new List<Localidad>();
            localidadesAsociadas = Localidad.ListarLocalidadesAsociadas(provinciaSeleccionada.CodigoDeProvincia);

            //Asocio la lista con el elemento dropdown
            foreach (Localidad loc in localidadesAsociadas)
            {
                cmb_localidad_origen.Items.Add(loc.NombreDeLocalidad);
            }
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

            //Limpio el dropdown
            cmb_sucursal_entregaensucursal_destino.Items.Clear();

            //Saco el dato de la provincia y localidad seleccionadas
            Provincia provinciaSeleccionada = (Provincia)cmb_provincia_nacional.SelectedItem;
            Localidad localidadSeleccionada = (Localidad)cmb_localidad_nacional.SelectedItem;

            //Creo una lista para almacenar las sucursales disponibles
            List<Sucursal> sucursalesAsociadas = new List<Sucursal>();
            sucursalesAsociadas = Sucursal.ListarSucursalesAsociadas(provinciaSeleccionada.CodigoDeProvincia, localidadSeleccionada.CodigoDeLocalidad);

            //Linkeo la lista de sucursales con el drodpwon     
            foreach (Sucursal sucursal in sucursalesAsociadas)
            {
                cmb_sucursal_entregaensucursal_destino.Items.Add(sucursal.Direccion);
            }
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
