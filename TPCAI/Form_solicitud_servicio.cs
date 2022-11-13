using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            Provincia.TodasLasProvincias.GroupBy(Provincia => Provincia.CodigoDeProvincia);
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
            rd_btn_entrega_domicilio.Enabled = false;
            rd_btn_destino_entrega_sucursal.Enabled = false;
            txt_direccion_nacional.ResetText();
            txt_direccion_nacional.Enabled = false;
            cmb_sucursal_entregaensucursal_destino.Enabled = false;
            cmb_sucursal_entregaensucursal_destino.ResetText();
            cmb_localidad_nacional.ResetText();

            //Limpio el dropdown por si se hizo una seleccion de provincia nueva.
            cmb_localidad_nacional.ResetText();
            cmb_localidad_nacional.Items.Clear();

            //Almaceno la provincia seleccionada en una variable. 
            int codProvinciaSeleccionada = 0;
            string provinciaSeleccionada = cmb_provincia_nacional.Text;

            foreach (Provincia prov in Provincia.TodasLasProvincias)
            {
                if (prov.NombreDeProvincia == provinciaSeleccionada)
                {
                    codProvinciaSeleccionada = prov.CodigoDeProvincia;
                }
            }

            //Llamo al metodo que muestra las localidades asociadas a la provincia. 
            List<Localidad> localidadesAsociadas = new List<Localidad>();
            localidadesAsociadas = Localidad.ListarLocalidadesAsociadas(codProvinciaSeleccionada);

            //Asocio la lista con el elemento dropdown
            foreach (Localidad loc in localidadesAsociadas)
            {
                cmb_localidad_nacional.Items.Add(loc.NombreDeLocalidad);
            }

        }

        private void cmb_localidad_nacional_SelectedIndexChanged(object sender, EventArgs e)
        {
            //desmarco los radio buttons
            rd_btn_entrega_domicilio.Checked = false;
            rd_btn_destino_entrega_sucursal.Checked = false;

            //Limpio los inputs
            cmb_sucursal_entregaensucursal_destino.ResetText();
            txt_direccion_nacional.ResetText();

            //Inhabilito input - se habilitará recién cuando se seleccione un radio button
            txt_direccion_nacional.Enabled = false;
            cmb_sucursal_entregaensucursal_destino.Enabled = false;

            //Habilito radio buttons
            rd_btn_entrega_domicilio.Enabled = true;
            rd_btn_destino_entrega_sucursal.Enabled = true;
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
            //Si es moroso, no lo deja avanzar
            if (ClienteCorporativo.ClienteActual.EsMoroso == true)
            {
                MessageBox.Show("Usted está en condición de morosidad, por lo que no puede realizar nuevas solicitudes. Volviendo al menú principal.");
                this.Visible = false;
                Menu menu = new Menu();
                menu.Show();
            }
            else
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

                if (rd_btn_retiro_domicilio.Checked && txt_domicilio_retirodomicilio.Text == "")
                {
                    MessageBox.Show("Debe ingresar una dirección para el origen (retiro a domicilio).");
                }
                /*
                bool estaEnLaLista = false;
                do
                {
                    foreach (string item in cmb_provincia_origen.Items)
                    {
                        if (item == cmb_provincia_origen.Text)
                        {
                            estaEnLaLista = true;
                        }
                    }
                } while (!estaEnLaLista);
                if (!estaEnLaLista)
                {
                    MessageBox.Show("Error! Debe ingresar una provincia de la lista.");
                }*/



                if (rd_btn_origen_entrega_sucursal.Checked && cmb_sucursal_entregaensucursal_origen.Text=="")
                {
                    MessageBox.Show("Debe seleccionar una sucursal para el origen (entrega en sucursal).");
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
                    long cuitCliente;
                    bool esEncomienda = false;
                    bool esCorrespondencia = false;
                    decimal peso=0;
                    decimal ancho=0;
                    decimal largo=0;
                    decimal alto=0;
                    bool origen_retiroEnDomicilio = false;
                    bool origen_entregaEnSucursal = false;
                    string domicilio_origen="";
                    //Sucursal sucursal_origen;
                    bool esUrgente=false;
                    bool esInternacional = false ;
                    bool esNacional=false;
                    //Pais pais;
                    string direccion_destino="";
                    //string direccion_destino_internacional;
                    //Provincia destino_provincia;
                    //Localidad destino_localidad;
                    bool entregaADomicilio_destino=false;
                    bool entregaEnSucursal_destino=false;
                    //string direccion_destino_nacional;
                    //Sucursal sucursal_destino=null;
                    //Provincia origen_provincia;
                    //Localidad origen_localidad;
                    DateTime fecha = DateTime.Now;

                    int destino_pais_codRegionMundial = 0;
                    int destino_pais_codPais = 0;
                    int destino_prov_codRegionNacional = 0;
                    int destino_prov_codProv = 0;
                    int destino_loc_codLoc = 0;
                    int destino_suc_codSuc = 0;
                    int origen_prov_codRegionNacional = 0;
                    int origen_prov_codProv = 0;
                    int origeno_loc_codLoc = 0;
                    int origen_suc_codSuc = 0;

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

                    string provinciaSeleccionada = cmb_provincia_origen.Text;
                    Provincia origen_provincia = Provincia.TodasLasProvincias.Find(prov => prov.NombreDeProvincia == provinciaSeleccionada);
                    origen_prov_codProv = origen_provincia.CodigoDeProvincia;
                    origen_prov_codRegionNacional = origen_provincia.CodigoDeRegionNacional;

                    string localidadSeleccionada = cmb_localidad_origen.Text;
                    /*foreach (Localidad l in Localidad.LstLocalidades)
                    {
                        if (l.NombreDeLocalidad == localidadSeleccionada)
                        {
                            origen_localidad = l;
                        }
                    }*/
                    Localidad origen_localidad = Localidad.LstLocalidades.Find(loc => loc.NombreDeLocalidad == localidadSeleccionada);
                    origeno_loc_codLoc = origen_localidad.CodigoDeLocalidad;

                    if (rd_btn_retiro_domicilio.Checked)
                    {
                        origen_retiroEnDomicilio = true;
                        origen_entregaEnSucursal = false;
                        domicilio_origen = txt_domicilio_retirodomicilio.Text;
                        origen_suc_codSuc = 0;

                    }
                    else
                    {
                        domicilio_origen = "";
                        origen_retiroEnDomicilio = false;
                        origen_entregaEnSucursal = true;

                        string direccSucursalSeleccionada = cmb_sucursal_entregaensucursal_origen.Text;
                        /*foreach (Sucursal s in Sucursal.TodasLasSucursales)
                        {
                            if (s.Direccion == direccSucursalSeleccionada)
                            {
                                sucursal_origen = s;
                            }
                        }*/
                        Sucursal sucursal_origen = Sucursal.TodasLasSucursales.Find(suc => suc.Direccion == direccSucursalSeleccionada);
                        origen_suc_codSuc = sucursal_origen.NroSucursal;
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
                        string paisSeleccionado = cmb_pais_internacional.Text;
                        Pais pais = Pais.TodosLosPaises.Find(pa => pa.NombreDePais == paisSeleccionado);
                        destino_pais_codPais = pais.CodigoDePais;
                        destino_pais_codRegionMundial = pais.CodigoDeRegionMundial;

                        direccion_destino = txt_direccion_internacional.Text;
                    }
                    else
                    {
                        esInternacional = false;
                        esNacional = true;

                        string provinciaElegida = cmb_provincia_nacional.Text;
                        Provincia destino_provincia = Provincia.TodasLasProvincias.Find(prov => prov.NombreDeProvincia == provinciaElegida);
                        destino_prov_codProv = destino_provincia.CodigoDeProvincia;
                        destino_prov_codRegionNacional = destino_provincia.CodigoDeRegionNacional;

                        string localidadElegida = cmb_localidad_nacional.Text;
                        Localidad destino_localidad = Localidad.LstLocalidades.Find(loc => loc.NombreDeLocalidad == localidadElegida);
                        destino_loc_codLoc = destino_localidad.CodigoDeLocalidad;

                        if (rd_btn_entrega_domicilio.Checked)
                        {
                            entregaADomicilio_destino = true;
                            entregaEnSucursal_destino = false;
                            direccion_destino = txt_direccion_nacional.Text;
                        }
                        else
                        {
                            entregaEnSucursal_destino = true;
                            entregaADomicilio_destino = false;
                            direccion_destino = null;
                            string sucursalElegida = cmb_sucursal_entregaensucursal_destino.Text;
                            Sucursal sucursal_destino = Sucursal.TodasLasSucursales.Find(suc => suc.Direccion == sucursalElegida);
                            destino_suc_codSuc = sucursal_destino.NroSucursal;
                        }
                    }

                    decimal importe = Tarifa.CalcularImporte(esUrgente, esCorrespondencia, peso, origen_retiroEnDomicilio, entregaADomicilio_destino, origeno_loc_codLoc, origen_suc_codSuc, esNacional, destino_pais_codPais, destino_loc_codLoc);
                    //decimal importe = 1000;

                    cuitCliente = ClienteCorporativo.ClienteActual.CUIT;
                    //cuitCliente = 24033020220;

                    //CREACIÓN DEL OBJETO SOLICITUD, ORIGEN, DESTINO, DSERVICIO

                    SolicitudDeOrden nuevaSolicitud = SolicitudDeOrden.GrabarNuevaSolicitud(cuitCliente,esUrgente,fecha,importe);
                    //Destino nuevoDestino = new Destino(nuevaSolicitud.NumeroDeOrden, esInternacional, esNacional, entregaADomicilio_destino, entregaEnSucursal_destino, destino_pais_codRegionMundial, destino_pais_codPais, destino_prov_codRegionNacional, destino_prov_codProv, destino_loc_codLoc, direccion_destino, destino_suc_codSuc);            
                    Destino nuevoDestino = Destino.GrabarNuevoDestino(nuevaSolicitud.NumeroDeOrden, esInternacional, esNacional, entregaADomicilio_destino, entregaEnSucursal_destino, destino_pais_codRegionMundial, destino_pais_codPais, destino_prov_codRegionNacional, destino_prov_codProv, destino_loc_codLoc, direccion_destino, destino_suc_codSuc);
                    Origen nuevoOrigen = Origen.GrabarNuevoOrigen(nuevaSolicitud.NumeroDeOrden, origen_retiroEnDomicilio, origen_entregaEnSucursal, origen_prov_codRegionNacional, origen_prov_codProv, origeno_loc_codLoc, domicilio_origen, origen_suc_codSuc);  
                    Servicio nuevoServicio = Servicio.GrabarNuevoServicio(nuevaSolicitud.NumeroDeOrden,esEncomienda,esCorrespondencia,ancho,largo,alto,peso);

                    ManejoDeArchivos.ActualizarArchivos();

                    //LLAMADO AL FORM DE CONFIRMACIÓN
                    Form_solicitud_servicio_confirmación form_de_confirmacion = new Form_solicitud_servicio_confirmación();
                    this.Visible = false;

                    //ACÁ LINKEAR LOS ELEMENTOS DEL FORM CON LA NUEVA SOLICITUD
                    form_de_confirmacion._NroOrdenGenerada = nuevaSolicitud.NumeroDeOrden.ToString();
                    if (rd_btn_correspondencia.Checked)
                    {
                        form_de_confirmacion._TipoPaquete = "Correspondencia";
                        form_de_confirmacion._Peso = "-";
                        form_de_confirmacion._Ancho = "-";
                        form_de_confirmacion._Largo = "-";
                        form_de_confirmacion._Alto = "-";
                    }
                    else if (rd_btn_encomienda.Checked)
                    {
                        form_de_confirmacion._TipoPaquete = "Encomienda";
                        form_de_confirmacion._Peso = nuevoServicio.Peso.ToString() + " Kg";
                        form_de_confirmacion._Ancho = nuevoServicio.Ancho.ToString() + " cm";
                        form_de_confirmacion._Largo = nuevoServicio.Largo.ToString() + " cm";
                        form_de_confirmacion._Alto = nuevoServicio.Alto.ToString() + " cm";
                    }

                    if (rd_btn_nacional.Checked)
                    {
                        form_de_confirmacion._TipoEnvio = "Nacional";
                    }
                    else if(rd_btn_internacional.Checked)
                    {
                        form_de_confirmacion._TipoEnvio = "Internacional";
                    }
                    form_de_confirmacion._Origen = Origen.MostrarOrigen(origen_retiroEnDomicilio,origen_entregaEnSucursal, origen_prov_codRegionNacional, origen_prov_codProv, origeno_loc_codLoc,domicilio_origen, origen_suc_codSuc);
                    form_de_confirmacion._Destino = Destino.MostrarDestino(esNacional,esInternacional,entregaADomicilio_destino,entregaEnSucursal_destino, destino_pais_codRegionMundial, destino_pais_codPais, destino_prov_codRegionNacional, destino_prov_codProv, destino_loc_codLoc, direccion_destino, destino_suc_codSuc);
                    form_de_confirmacion._Urgencia = Urgencia(nuevaSolicitud.EsUrgente);
                    form_de_confirmacion._Importe = nuevaSolicitud.Importe.ToString();
                    form_de_confirmacion.Show();
                }
            }
        }

        private void lbl_tipo_paquete_Click(object sender, EventArgs e)
        {

        }

        private void Form_solicitud_servicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManejoDeArchivos.ActualizarArchivos();
            Application.Exit();
        }

        private void rd_Internacional_CheckedChanged(object sender, EventArgs e)
        {

            cmb_provincia_nacional.ResetText();
            cmb_localidad_nacional.ResetText();
            txt_direccion_nacional.ResetText();
            cmb_sucursal_entregaensucursal_destino.ResetText();
            cmb_sucursal_entregaensucursal_destino.ResetText();

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
            txt_direccion_internacional.ResetText();
            cmb_pais_internacional.ResetText();

            //cmb_region_nacional.Enabled = true;
            cmb_provincia_nacional.Enabled = true;
            cmb_localidad_nacional.Enabled = true;

            //cmb_region_internacional.Enabled = false;
            cmb_pais_internacional.Enabled = false;
            txt_direccion_internacional.Enabled = false;
            
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
            cmb_sucursal_entregaensucursal_origen.ResetText();
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
            txt_domicilio_retirodomicilio.ResetText();
            //cmb_region_entregaensucursal_origen.Enabled = true;
            cmb_sucursal_entregaensucursal_origen.Enabled = true;
            //cmb_region__retirodomicilio.Enabled = false;
            txt_domicilio_retirodomicilio.Enabled = false;
            
            //Limpio el dropdown
            cmb_sucursal_entregaensucursal_origen.Items.Clear();

            //Saco el dato de la provincia y localidad seleccionadas
            string localidadSeleccionada = cmb_localidad_origen.Text;
            int codLocSeleccionada = 0;

            foreach (Localidad l in Localidad.LstLocalidades)
            {
                if (l.NombreDeLocalidad == localidadSeleccionada)
                {
                    codLocSeleccionada = l.CodigoDeLocalidad;
                }
            }

            //sucursalesAsociadas = Sucursal.ListarSucursalesAsociadas(codProvSeleccionada, codLocSeleccionada); - este método no funciona

            //Voy agregando a la lista las sucursales de la localidad. 
            foreach (Sucursal s in Sucursal.TodasLasSucursales)
            {
                if (s.CodigoDeLocalidad == codLocSeleccionada)
                {
                    cmb_sucursal_entregaensucursal_origen.Items.Add(s.Direccion);
                }
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
            //Reseteo selección de direcc y sucursal
            cmb_sucursal_entregaensucursal_origen.ResetText();
            txt_domicilio_retirodomicilio.ResetText();

            //Deselecciono radio buttons
            rd_btn_origen_entrega_sucursal.Checked = false;
            rd_btn_retiro_domicilio.Checked = false;

            //Deshabilito campos de input
            txt_domicilio_retirodomicilio.Enabled = false;
            cmb_sucursal_entregaensucursal_origen.Enabled = false;

            rd_btn_retiro_domicilio.Enabled = false;
            rd_btn_origen_entrega_sucursal.Enabled = false;

            cmb_localidad_origen.ResetText();

            //Habilito el dropdown de localidades
            cmb_localidad_origen.Enabled = true;

            //Limpio el dropdown por si se hizo una seleccion de provincia nueva.
            cmb_localidad_origen.Items.Clear();

            //Almaceno la provincia seleccionada en una variable. 
            int codProvinciaSeleccionada = 0;
            string provinciaSeleccionada = cmb_provincia_origen.Text;

            foreach (Provincia prov in Provincia.TodasLasProvincias)
            {
                if (prov.NombreDeProvincia == provinciaSeleccionada)
                {
                    codProvinciaSeleccionada = prov.CodigoDeProvincia;
                }
            }

            //Llamo al metodo que muestra las localidades asociadas a la provincia. 
            List<Localidad> localidadesAsociadas = new List<Localidad>();
            localidadesAsociadas = Localidad.ListarLocalidadesAsociadas(codProvinciaSeleccionada);

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
            cmb_sucursal_entregaensucursal_destino.ResetText();
            cmb_sucursal_entregaensucursal_destino.Enabled= false;
            lbl_sucursal_entregaensucursal_destino.Enabled = false;

            txt_direccion_nacional.Enabled = true;
            lbl_direccion_nacional.Enabled = true;       
        }

        private void rd_btn_destino_entrega_sucursal_CheckedChanged(object sender, EventArgs e)
        {
            cmb_sucursal_entregaensucursal_destino.Enabled = true;
            lbl_sucursal_entregaensucursal_destino.Enabled = true;
            txt_direccion_nacional.Enabled = false;
            lbl_direccion_nacional.Enabled = false;
            txt_direccion_nacional.ResetText();

            //Limpio el dropdown
            cmb_sucursal_entregaensucursal_destino.Items.Clear();

            //Saco el dato de la provincia y localidad seleccionadas
            string localidadSeleccionada = cmb_localidad_nacional.Text;
            int codLocSeleccionada = 0;

            foreach (Localidad l in Localidad.LstLocalidades)
            {
                if (l.NombreDeLocalidad == localidadSeleccionada)
                {
                    codLocSeleccionada = l.CodigoDeLocalidad;
                }
            }

            //sucursalesAsociadas = Sucursal.ListarSucursalesAsociadas(codProvSeleccionada, codLocSeleccionada); - este método no funciona

            //Voy agregando a la lista las sucursales de la localidad. 
            foreach (Sucursal s in Sucursal.TodasLasSucursales)
            {
                if (s.CodigoDeLocalidad == codLocSeleccionada)
                {
                    cmb_sucursal_entregaensucursal_destino.Items.Add(s.Direccion);
                }
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
            //Reseteo selección de direcc y sucursal
            cmb_sucursal_entregaensucursal_origen.ResetText();
            txt_domicilio_retirodomicilio.ResetText();
            
            //Deselecciono radio buttons
            rd_btn_origen_entrega_sucursal.Checked = false;
            rd_btn_retiro_domicilio.Checked = false;

            //Deshabilito campos de input
            txt_domicilio_retirodomicilio.Enabled = false;
            cmb_sucursal_entregaensucursal_origen.Enabled = false;

            rd_btn_retiro_domicilio.Enabled = true;
            rd_btn_origen_entrega_sucursal.Enabled = true;

        }

        private void grp_tipo_servicio_Enter(object sender, EventArgs e)
        {

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

        private void GroupBox_destino_Enter(object sender, EventArgs e)
        {

        }
    }
}
