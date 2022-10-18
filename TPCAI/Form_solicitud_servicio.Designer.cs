
namespace TPCAI
{
    partial class Form_solicitud_servicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_Tipo_Paquete = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_paquete = new System.Windows.Forms.Label();
            this.Grpbx_dimensiones = new System.Windows.Forms.GroupBox();
            this.lbl_cm_alto = new System.Windows.Forms.Label();
            this.Grp_Destino = new System.Windows.Forms.GroupBox();
            this.lbl_direccion_internacional = new System.Windows.Forms.Label();
            this.txt_direccion_internacional = new System.Windows.Forms.TextBox();
            this.cmb_pais_internacional = new System.Windows.Forms.ComboBox();
            this.lbl_pais_internacional = new System.Windows.Forms.Label();
            this.cmb_region_internacional = new System.Windows.Forms.ComboBox();
            this.lbl_region_internacional = new System.Windows.Forms.Label();
            this.lbl_direccion_nacional = new System.Windows.Forms.Label();
            this.txt_direccion_nacional = new System.Windows.Forms.TextBox();
            this.cmb_localidad_nacional = new System.Windows.Forms.ComboBox();
            this.lbl_localidad_nacional = new System.Windows.Forms.Label();
            this.cmb_provincia_nacional = new System.Windows.Forms.ComboBox();
            this.lbl_provincia_nacional = new System.Windows.Forms.Label();
            this.cmb_region_nacional = new System.Windows.Forms.ComboBox();
            this.lbl_region_nacional = new System.Windows.Forms.Label();
            this.rd_Internacional = new System.Windows.Forms.RadioButton();
            this.rd_nacional = new System.Windows.Forms.RadioButton();
            this.grp_origen = new System.Windows.Forms.GroupBox();
            this.cmb_sucursal_entregaensucursal = new System.Windows.Forms.ComboBox();
            this.lbl_sucursal_entregaensucursal = new System.Windows.Forms.Label();
            this.cmb_region_entregaensucursal = new System.Windows.Forms.ComboBox();
            this.Lbl_region_entregaensucursal = new System.Windows.Forms.Label();
            this.lbl_domicilio_retirodomicilio = new System.Windows.Forms.Label();
            this.txt_domicilio_retirodomicilio = new System.Windows.Forms.TextBox();
            this.cmb_localidad_retirodomicilio = new System.Windows.Forms.ComboBox();
            this.lbl_localidad_retirodomicilio = new System.Windows.Forms.Label();
            this.cmb_provincia_retirodomicilio = new System.Windows.Forms.ComboBox();
            this.lbl_provincia_retirodomicilio = new System.Windows.Forms.Label();
            this.cmb_region__retirodomicilio = new System.Windows.Forms.ComboBox();
            this.lbl_region_retirodomicilio = new System.Windows.Forms.Label();
            this.rd_btn_entrega_sucursal = new System.Windows.Forms.RadioButton();
            this.rd_btn_retiro_domicilio = new System.Windows.Forms.RadioButton();
            this.lbl_cm_largo = new System.Windows.Forms.Label();
            this.grp_dimensiones = new System.Windows.Forms.GroupBox();
            this.lbl_alto = new System.Windows.Forms.Label();
            this.lbl_kg = new System.Windows.Forms.Label();
            this.lbl_cm_ancho = new System.Windows.Forms.Label();
            this.num_peso = new System.Windows.Forms.NumericUpDown();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.num_alto = new System.Windows.Forms.NumericUpDown();
            this.lbl_largo = new System.Windows.Forms.Label();
            this.num_largo = new System.Windows.Forms.NumericUpDown();
            this.num_ancho = new System.Windows.Forms.NumericUpDown();
            this.lbl_ancho = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.Grpbx_dimensiones.SuspendLayout();
            this.Grp_Destino.SuspendLayout();
            this.grp_origen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_alto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_largo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ancho)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Tipo_Paquete
            // 
            this.cmb_Tipo_Paquete.FormattingEnabled = true;
            this.cmb_Tipo_Paquete.Items.AddRange(new object[] {
            "Encomienda",
            "Correspondencia"});
            this.cmb_Tipo_Paquete.Location = new System.Drawing.Point(119, 30);
            this.cmb_Tipo_Paquete.Name = "cmb_Tipo_Paquete";
            this.cmb_Tipo_Paquete.Size = new System.Drawing.Size(121, 21);
            this.cmb_Tipo_Paquete.TabIndex = 1;
            this.cmb_Tipo_Paquete.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_tipo_paquete
            // 
            this.lbl_tipo_paquete.AutoSize = true;
            this.lbl_tipo_paquete.Location = new System.Drawing.Point(21, 32);
            this.lbl_tipo_paquete.Name = "lbl_tipo_paquete";
            this.lbl_tipo_paquete.Size = new System.Drawing.Size(85, 13);
            this.lbl_tipo_paquete.TabIndex = 2;
            this.lbl_tipo_paquete.Text = "Tipo de paquete";
            this.lbl_tipo_paquete.Click += new System.EventHandler(this.lbl_tipo_paquete_Click);
            // 
            // Grpbx_dimensiones
            // 
            this.Grpbx_dimensiones.Controls.Add(this.lbl_cm_alto);
            this.Grpbx_dimensiones.Controls.Add(this.Grp_Destino);
            this.Grpbx_dimensiones.Controls.Add(this.grp_origen);
            this.Grpbx_dimensiones.Controls.Add(this.lbl_cm_largo);
            this.Grpbx_dimensiones.Controls.Add(this.grp_dimensiones);
            this.Grpbx_dimensiones.Controls.Add(this.lbl_alto);
            this.Grpbx_dimensiones.Controls.Add(this.lbl_kg);
            this.Grpbx_dimensiones.Controls.Add(this.lbl_cm_ancho);
            this.Grpbx_dimensiones.Controls.Add(this.num_peso);
            this.Grpbx_dimensiones.Controls.Add(this.lbl_peso);
            this.Grpbx_dimensiones.Controls.Add(this.num_alto);
            this.Grpbx_dimensiones.Controls.Add(this.cmb_Tipo_Paquete);
            this.Grpbx_dimensiones.Controls.Add(this.lbl_tipo_paquete);
            this.Grpbx_dimensiones.Controls.Add(this.lbl_largo);
            this.Grpbx_dimensiones.Controls.Add(this.num_largo);
            this.Grpbx_dimensiones.Controls.Add(this.num_ancho);
            this.Grpbx_dimensiones.Controls.Add(this.lbl_ancho);
            this.Grpbx_dimensiones.Location = new System.Drawing.Point(25, 12);
            this.Grpbx_dimensiones.Name = "Grpbx_dimensiones";
            this.Grpbx_dimensiones.Size = new System.Drawing.Size(547, 538);
            this.Grpbx_dimensiones.TabIndex = 3;
            this.Grpbx_dimensiones.TabStop = false;
            this.Grpbx_dimensiones.Text = "Solicitar servicio";
            this.Grpbx_dimensiones.Enter += new System.EventHandler(this.Grpbx_dimensiones_Enter);
            // 
            // lbl_cm_alto
            // 
            this.lbl_cm_alto.AutoSize = true;
            this.lbl_cm_alto.Location = new System.Drawing.Point(245, 159);
            this.lbl_cm_alto.Name = "lbl_cm_alto";
            this.lbl_cm_alto.Size = new System.Drawing.Size(21, 13);
            this.lbl_cm_alto.TabIndex = 13;
            this.lbl_cm_alto.Text = "cm";
            // 
            // Grp_Destino
            // 
            this.Grp_Destino.Controls.Add(this.lbl_direccion_internacional);
            this.Grp_Destino.Controls.Add(this.txt_direccion_internacional);
            this.Grp_Destino.Controls.Add(this.cmb_pais_internacional);
            this.Grp_Destino.Controls.Add(this.lbl_pais_internacional);
            this.Grp_Destino.Controls.Add(this.cmb_region_internacional);
            this.Grp_Destino.Controls.Add(this.lbl_region_internacional);
            this.Grp_Destino.Controls.Add(this.lbl_direccion_nacional);
            this.Grp_Destino.Controls.Add(this.txt_direccion_nacional);
            this.Grp_Destino.Controls.Add(this.cmb_localidad_nacional);
            this.Grp_Destino.Controls.Add(this.lbl_localidad_nacional);
            this.Grp_Destino.Controls.Add(this.cmb_provincia_nacional);
            this.Grp_Destino.Controls.Add(this.lbl_provincia_nacional);
            this.Grp_Destino.Controls.Add(this.cmb_region_nacional);
            this.Grp_Destino.Controls.Add(this.lbl_region_nacional);
            this.Grp_Destino.Controls.Add(this.rd_Internacional);
            this.Grp_Destino.Controls.Add(this.rd_nacional);
            this.Grp_Destino.Location = new System.Drawing.Point(305, 30);
            this.Grp_Destino.Name = "Grp_Destino";
            this.Grp_Destino.Size = new System.Drawing.Size(223, 400);
            this.Grp_Destino.TabIndex = 11;
            this.Grp_Destino.TabStop = false;
            this.Grp_Destino.Text = "Destino";
            this.Grp_Destino.Enter += new System.EventHandler(this.Grp_Destino_Enter);
            // 
            // lbl_direccion_internacional
            // 
            this.lbl_direccion_internacional.AutoSize = true;
            this.lbl_direccion_internacional.Location = new System.Drawing.Point(25, 365);
            this.lbl_direccion_internacional.Name = "lbl_direccion_internacional";
            this.lbl_direccion_internacional.Size = new System.Drawing.Size(52, 13);
            this.lbl_direccion_internacional.TabIndex = 23;
            this.lbl_direccion_internacional.Text = "Dirección";
            // 
            // txt_direccion_internacional
            // 
            this.txt_direccion_internacional.Location = new System.Drawing.Point(83, 363);
            this.txt_direccion_internacional.Name = "txt_direccion_internacional";
            this.txt_direccion_internacional.Size = new System.Drawing.Size(121, 20);
            this.txt_direccion_internacional.TabIndex = 22;
            // 
            // cmb_pais_internacional
            // 
            this.cmb_pais_internacional.FormattingEnabled = true;
            this.cmb_pais_internacional.Items.AddRange(new object[] {
            "03- Av. Cordoba 2122"});
            this.cmb_pais_internacional.Location = new System.Drawing.Point(81, 324);
            this.cmb_pais_internacional.Name = "cmb_pais_internacional";
            this.cmb_pais_internacional.Size = new System.Drawing.Size(121, 21);
            this.cmb_pais_internacional.TabIndex = 20;
            // 
            // lbl_pais_internacional
            // 
            this.lbl_pais_internacional.AutoSize = true;
            this.lbl_pais_internacional.Location = new System.Drawing.Point(25, 328);
            this.lbl_pais_internacional.Name = "lbl_pais_internacional";
            this.lbl_pais_internacional.Size = new System.Drawing.Size(27, 13);
            this.lbl_pais_internacional.TabIndex = 21;
            this.lbl_pais_internacional.Text = "Pais";
            // 
            // cmb_region_internacional
            // 
            this.cmb_region_internacional.FormattingEnabled = true;
            this.cmb_region_internacional.Items.AddRange(new object[] {
            "Europa"});
            this.cmb_region_internacional.Location = new System.Drawing.Point(81, 285);
            this.cmb_region_internacional.Name = "cmb_region_internacional";
            this.cmb_region_internacional.Size = new System.Drawing.Size(121, 21);
            this.cmb_region_internacional.TabIndex = 18;
            // 
            // lbl_region_internacional
            // 
            this.lbl_region_internacional.AutoSize = true;
            this.lbl_region_internacional.Location = new System.Drawing.Point(22, 287);
            this.lbl_region_internacional.Name = "lbl_region_internacional";
            this.lbl_region_internacional.Size = new System.Drawing.Size(41, 13);
            this.lbl_region_internacional.TabIndex = 19;
            this.lbl_region_internacional.Text = "Region";
            // 
            // lbl_direccion_nacional
            // 
            this.lbl_direccion_nacional.AutoSize = true;
            this.lbl_direccion_nacional.Location = new System.Drawing.Point(22, 200);
            this.lbl_direccion_nacional.Name = "lbl_direccion_nacional";
            this.lbl_direccion_nacional.Size = new System.Drawing.Size(52, 13);
            this.lbl_direccion_nacional.TabIndex = 17;
            this.lbl_direccion_nacional.Text = "Dirección";
            // 
            // txt_direccion_nacional
            // 
            this.txt_direccion_nacional.Location = new System.Drawing.Point(75, 198);
            this.txt_direccion_nacional.Name = "txt_direccion_nacional";
            this.txt_direccion_nacional.Size = new System.Drawing.Size(121, 20);
            this.txt_direccion_nacional.TabIndex = 16;
            // 
            // cmb_localidad_nacional
            // 
            this.cmb_localidad_nacional.FormattingEnabled = true;
            this.cmb_localidad_nacional.Items.AddRange(new object[] {
            "Balvanera"});
            this.cmb_localidad_nacional.Location = new System.Drawing.Point(75, 150);
            this.cmb_localidad_nacional.Name = "cmb_localidad_nacional";
            this.cmb_localidad_nacional.Size = new System.Drawing.Size(121, 21);
            this.cmb_localidad_nacional.TabIndex = 14;
            this.cmb_localidad_nacional.SelectedIndexChanged += new System.EventHandler(this.cmb_localidad_nacional_SelectedIndexChanged);
            // 
            // lbl_localidad_nacional
            // 
            this.lbl_localidad_nacional.AutoSize = true;
            this.lbl_localidad_nacional.Location = new System.Drawing.Point(21, 155);
            this.lbl_localidad_nacional.Name = "lbl_localidad_nacional";
            this.lbl_localidad_nacional.Size = new System.Drawing.Size(53, 13);
            this.lbl_localidad_nacional.TabIndex = 15;
            this.lbl_localidad_nacional.Text = "Localidad";
            // 
            // cmb_provincia_nacional
            // 
            this.cmb_provincia_nacional.FormattingEnabled = true;
            this.cmb_provincia_nacional.Items.AddRange(new object[] {
            "CABA"});
            this.cmb_provincia_nacional.Location = new System.Drawing.Point(77, 112);
            this.cmb_provincia_nacional.Name = "cmb_provincia_nacional";
            this.cmb_provincia_nacional.Size = new System.Drawing.Size(121, 21);
            this.cmb_provincia_nacional.TabIndex = 12;
            this.cmb_provincia_nacional.SelectedIndexChanged += new System.EventHandler(this.cmb_provincia_nacional_SelectedIndexChanged);
            // 
            // lbl_provincia_nacional
            // 
            this.lbl_provincia_nacional.AutoSize = true;
            this.lbl_provincia_nacional.Location = new System.Drawing.Point(22, 114);
            this.lbl_provincia_nacional.Name = "lbl_provincia_nacional";
            this.lbl_provincia_nacional.Size = new System.Drawing.Size(51, 13);
            this.lbl_provincia_nacional.TabIndex = 13;
            this.lbl_provincia_nacional.Text = "Provincia";
            // 
            // cmb_region_nacional
            // 
            this.cmb_region_nacional.FormattingEnabled = true;
            this.cmb_region_nacional.Items.AddRange(new object[] {
            "Metropolitana"});
            this.cmb_region_nacional.Location = new System.Drawing.Point(75, 67);
            this.cmb_region_nacional.Name = "cmb_region_nacional";
            this.cmb_region_nacional.Size = new System.Drawing.Size(121, 21);
            this.cmb_region_nacional.TabIndex = 10;
            this.cmb_region_nacional.SelectedIndexChanged += new System.EventHandler(this.cmb_region_nacional_SelectedIndexChanged);
            // 
            // lbl_region_nacional
            // 
            this.lbl_region_nacional.AutoSize = true;
            this.lbl_region_nacional.Location = new System.Drawing.Point(19, 69);
            this.lbl_region_nacional.Name = "lbl_region_nacional";
            this.lbl_region_nacional.Size = new System.Drawing.Size(41, 13);
            this.lbl_region_nacional.TabIndex = 11;
            this.lbl_region_nacional.Text = "Región";
            // 
            // rd_Internacional
            // 
            this.rd_Internacional.AutoSize = true;
            this.rd_Internacional.Location = new System.Drawing.Point(19, 252);
            this.rd_Internacional.Name = "rd_Internacional";
            this.rd_Internacional.Size = new System.Drawing.Size(86, 17);
            this.rd_Internacional.TabIndex = 9;
            this.rd_Internacional.TabStop = true;
            this.rd_Internacional.Text = "Internacional";
            this.rd_Internacional.UseVisualStyleBackColor = true;
            // 
            // rd_nacional
            // 
            this.rd_nacional.AutoSize = true;
            this.rd_nacional.Location = new System.Drawing.Point(19, 31);
            this.rd_nacional.Name = "rd_nacional";
            this.rd_nacional.Size = new System.Drawing.Size(67, 17);
            this.rd_nacional.TabIndex = 8;
            this.rd_nacional.TabStop = true;
            this.rd_nacional.Text = "Nacional";
            this.rd_nacional.UseVisualStyleBackColor = true;
            // 
            // grp_origen
            // 
            this.grp_origen.Controls.Add(this.cmb_sucursal_entregaensucursal);
            this.grp_origen.Controls.Add(this.lbl_sucursal_entregaensucursal);
            this.grp_origen.Controls.Add(this.cmb_region_entregaensucursal);
            this.grp_origen.Controls.Add(this.Lbl_region_entregaensucursal);
            this.grp_origen.Controls.Add(this.lbl_domicilio_retirodomicilio);
            this.grp_origen.Controls.Add(this.txt_domicilio_retirodomicilio);
            this.grp_origen.Controls.Add(this.cmb_localidad_retirodomicilio);
            this.grp_origen.Controls.Add(this.lbl_localidad_retirodomicilio);
            this.grp_origen.Controls.Add(this.cmb_provincia_retirodomicilio);
            this.grp_origen.Controls.Add(this.lbl_provincia_retirodomicilio);
            this.grp_origen.Controls.Add(this.cmb_region__retirodomicilio);
            this.grp_origen.Controls.Add(this.lbl_region_retirodomicilio);
            this.grp_origen.Controls.Add(this.rd_btn_entrega_sucursal);
            this.grp_origen.Controls.Add(this.rd_btn_retiro_domicilio);
            this.grp_origen.Location = new System.Drawing.Point(23, 200);
            this.grp_origen.Name = "grp_origen";
            this.grp_origen.Size = new System.Drawing.Size(265, 325);
            this.grp_origen.TabIndex = 10;
            this.grp_origen.TabStop = false;
            this.grp_origen.Text = "Origen";
            this.grp_origen.Enter += new System.EventHandler(this.grp_Origen_Enter);
            // 
            // cmb_sucursal_entregaensucursal
            // 
            this.cmb_sucursal_entregaensucursal.FormattingEnabled = true;
            this.cmb_sucursal_entregaensucursal.Items.AddRange(new object[] {
            "03- Av. Cordoba 2122"});
            this.cmb_sucursal_entregaensucursal.Location = new System.Drawing.Point(105, 283);
            this.cmb_sucursal_entregaensucursal.Name = "cmb_sucursal_entregaensucursal";
            this.cmb_sucursal_entregaensucursal.Size = new System.Drawing.Size(121, 21);
            this.cmb_sucursal_entregaensucursal.TabIndex = 20;
            // 
            // lbl_sucursal_entregaensucursal
            // 
            this.lbl_sucursal_entregaensucursal.AutoSize = true;
            this.lbl_sucursal_entregaensucursal.Location = new System.Drawing.Point(28, 285);
            this.lbl_sucursal_entregaensucursal.Name = "lbl_sucursal_entregaensucursal";
            this.lbl_sucursal_entregaensucursal.Size = new System.Drawing.Size(51, 13);
            this.lbl_sucursal_entregaensucursal.TabIndex = 21;
            this.lbl_sucursal_entregaensucursal.Text = "Sucursal ";
            // 
            // cmb_region_entregaensucursal
            // 
            this.cmb_region_entregaensucursal.FormattingEnabled = true;
            this.cmb_region_entregaensucursal.Items.AddRange(new object[] {
            "Metropolitana"});
            this.cmb_region_entregaensucursal.Location = new System.Drawing.Point(105, 250);
            this.cmb_region_entregaensucursal.Name = "cmb_region_entregaensucursal";
            this.cmb_region_entregaensucursal.Size = new System.Drawing.Size(121, 21);
            this.cmb_region_entregaensucursal.TabIndex = 18;
            // 
            // Lbl_region_entregaensucursal
            // 
            this.Lbl_region_entregaensucursal.AutoSize = true;
            this.Lbl_region_entregaensucursal.Location = new System.Drawing.Point(27, 252);
            this.Lbl_region_entregaensucursal.Name = "Lbl_region_entregaensucursal";
            this.Lbl_region_entregaensucursal.Size = new System.Drawing.Size(41, 13);
            this.Lbl_region_entregaensucursal.TabIndex = 19;
            this.Lbl_region_entregaensucursal.Text = "Region";
            // 
            // lbl_domicilio_retirodomicilio
            // 
            this.lbl_domicilio_retirodomicilio.AutoSize = true;
            this.lbl_domicilio_retirodomicilio.Location = new System.Drawing.Point(27, 168);
            this.lbl_domicilio_retirodomicilio.Name = "lbl_domicilio_retirodomicilio";
            this.lbl_domicilio_retirodomicilio.Size = new System.Drawing.Size(49, 13);
            this.lbl_domicilio_retirodomicilio.TabIndex = 17;
            this.lbl_domicilio_retirodomicilio.Text = "Domicilio";
            this.lbl_domicilio_retirodomicilio.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txt_domicilio_retirodomicilio
            // 
            this.txt_domicilio_retirodomicilio.Location = new System.Drawing.Point(105, 168);
            this.txt_domicilio_retirodomicilio.Name = "txt_domicilio_retirodomicilio";
            this.txt_domicilio_retirodomicilio.Size = new System.Drawing.Size(121, 20);
            this.txt_domicilio_retirodomicilio.TabIndex = 16;
            // 
            // cmb_localidad_retirodomicilio
            // 
            this.cmb_localidad_retirodomicilio.FormattingEnabled = true;
            this.cmb_localidad_retirodomicilio.Items.AddRange(new object[] {
            "Balvanera"});
            this.cmb_localidad_retirodomicilio.Location = new System.Drawing.Point(105, 135);
            this.cmb_localidad_retirodomicilio.Name = "cmb_localidad_retirodomicilio";
            this.cmb_localidad_retirodomicilio.Size = new System.Drawing.Size(121, 21);
            this.cmb_localidad_retirodomicilio.TabIndex = 14;
            // 
            // lbl_localidad_retirodomicilio
            // 
            this.lbl_localidad_retirodomicilio.AutoSize = true;
            this.lbl_localidad_retirodomicilio.Location = new System.Drawing.Point(27, 136);
            this.lbl_localidad_retirodomicilio.Name = "lbl_localidad_retirodomicilio";
            this.lbl_localidad_retirodomicilio.Size = new System.Drawing.Size(53, 13);
            this.lbl_localidad_retirodomicilio.TabIndex = 15;
            this.lbl_localidad_retirodomicilio.Text = "Localidad";
            this.lbl_localidad_retirodomicilio.Click += new System.EventHandler(this.lbl_localidad_retirodomicilio_Click);
            // 
            // cmb_provincia_retirodomicilio
            // 
            this.cmb_provincia_retirodomicilio.FormattingEnabled = true;
            this.cmb_provincia_retirodomicilio.Items.AddRange(new object[] {
            "CABA"});
            this.cmb_provincia_retirodomicilio.Location = new System.Drawing.Point(105, 99);
            this.cmb_provincia_retirodomicilio.Name = "cmb_provincia_retirodomicilio";
            this.cmb_provincia_retirodomicilio.Size = new System.Drawing.Size(121, 21);
            this.cmb_provincia_retirodomicilio.TabIndex = 12;
            // 
            // lbl_provincia_retirodomicilio
            // 
            this.lbl_provincia_retirodomicilio.AutoSize = true;
            this.lbl_provincia_retirodomicilio.Location = new System.Drawing.Point(27, 101);
            this.lbl_provincia_retirodomicilio.Name = "lbl_provincia_retirodomicilio";
            this.lbl_provincia_retirodomicilio.Size = new System.Drawing.Size(51, 13);
            this.lbl_provincia_retirodomicilio.TabIndex = 13;
            this.lbl_provincia_retirodomicilio.Text = "Provincia";
            // 
            // cmb_region__retirodomicilio
            // 
            this.cmb_region__retirodomicilio.FormattingEnabled = true;
            this.cmb_region__retirodomicilio.Items.AddRange(new object[] {
            "Metropolitana"});
            this.cmb_region__retirodomicilio.Location = new System.Drawing.Point(105, 64);
            this.cmb_region__retirodomicilio.Name = "cmb_region__retirodomicilio";
            this.cmb_region__retirodomicilio.Size = new System.Drawing.Size(121, 21);
            this.cmb_region__retirodomicilio.TabIndex = 10;
            this.cmb_region__retirodomicilio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lbl_region_retirodomicilio
            // 
            this.lbl_region_retirodomicilio.AutoSize = true;
            this.lbl_region_retirodomicilio.Location = new System.Drawing.Point(23, 66);
            this.lbl_region_retirodomicilio.Name = "lbl_region_retirodomicilio";
            this.lbl_region_retirodomicilio.Size = new System.Drawing.Size(41, 13);
            this.lbl_region_retirodomicilio.TabIndex = 11;
            this.lbl_region_retirodomicilio.Text = "Región";
            this.lbl_region_retirodomicilio.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rd_btn_entrega_sucursal
            // 
            this.rd_btn_entrega_sucursal.AutoSize = true;
            this.rd_btn_entrega_sucursal.Location = new System.Drawing.Point(26, 217);
            this.rd_btn_entrega_sucursal.Name = "rd_btn_entrega_sucursal";
            this.rd_btn_entrega_sucursal.Size = new System.Drawing.Size(119, 17);
            this.rd_btn_entrega_sucursal.TabIndex = 9;
            this.rd_btn_entrega_sucursal.TabStop = true;
            this.rd_btn_entrega_sucursal.Text = "Entrega en sucursal";
            this.rd_btn_entrega_sucursal.UseVisualStyleBackColor = true;
            // 
            // rd_btn_retiro_domicilio
            // 
            this.rd_btn_retiro_domicilio.AutoSize = true;
            this.rd_btn_retiro_domicilio.Location = new System.Drawing.Point(26, 27);
            this.rd_btn_retiro_domicilio.Name = "rd_btn_retiro_domicilio";
            this.rd_btn_retiro_domicilio.Size = new System.Drawing.Size(111, 17);
            this.rd_btn_retiro_domicilio.TabIndex = 8;
            this.rd_btn_retiro_domicilio.TabStop = true;
            this.rd_btn_retiro_domicilio.Text = "Retiro en domicilio";
            this.rd_btn_retiro_domicilio.UseVisualStyleBackColor = true;
            // 
            // lbl_cm_largo
            // 
            this.lbl_cm_largo.AutoSize = true;
            this.lbl_cm_largo.Location = new System.Drawing.Point(245, 124);
            this.lbl_cm_largo.Name = "lbl_cm_largo";
            this.lbl_cm_largo.Size = new System.Drawing.Size(21, 13);
            this.lbl_cm_largo.TabIndex = 13;
            this.lbl_cm_largo.Text = "cm";
            // 
            // grp_dimensiones
            // 
            this.grp_dimensiones.Location = new System.Drawing.Point(14, 109);
            this.grp_dimensiones.Name = "grp_dimensiones";
            this.grp_dimensiones.Size = new System.Drawing.Size(0, 0);
            this.grp_dimensiones.TabIndex = 7;
            this.grp_dimensiones.TabStop = false;
            this.grp_dimensiones.Text = "Dimensiones";
            // 
            // lbl_alto
            // 
            this.lbl_alto.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_alto.AutoSize = true;
            this.lbl_alto.Location = new System.Drawing.Point(21, 157);
            this.lbl_alto.Name = "lbl_alto";
            this.lbl_alto.Size = new System.Drawing.Size(25, 13);
            this.lbl_alto.TabIndex = 11;
            this.lbl_alto.Text = "Alto";
            // 
            // lbl_kg
            // 
            this.lbl_kg.AutoSize = true;
            this.lbl_kg.Location = new System.Drawing.Point(244, 64);
            this.lbl_kg.Name = "lbl_kg";
            this.lbl_kg.Size = new System.Drawing.Size(19, 13);
            this.lbl_kg.TabIndex = 6;
            this.lbl_kg.Text = "kg";
            // 
            // lbl_cm_ancho
            // 
            this.lbl_cm_ancho.AutoSize = true;
            this.lbl_cm_ancho.Location = new System.Drawing.Point(244, 94);
            this.lbl_cm_ancho.Name = "lbl_cm_ancho";
            this.lbl_cm_ancho.Size = new System.Drawing.Size(21, 13);
            this.lbl_cm_ancho.TabIndex = 12;
            this.lbl_cm_ancho.Text = "cm";
            // 
            // num_peso
            // 
            this.num_peso.AutoSize = true;
            this.num_peso.DecimalPlaces = 2;
            this.num_peso.Location = new System.Drawing.Point(119, 62);
            this.num_peso.Name = "num_peso";
            this.num_peso.Size = new System.Drawing.Size(120, 20);
            this.num_peso.TabIndex = 5;
            this.num_peso.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbl_peso
            // 
            this.lbl_peso.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(21, 63);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(31, 13);
            this.lbl_peso.TabIndex = 4;
            this.lbl_peso.Text = "Peso";
            this.lbl_peso.Click += new System.EventHandler(this.label1_Click);
            // 
            // num_alto
            // 
            this.num_alto.AutoSize = true;
            this.num_alto.DecimalPlaces = 2;
            this.num_alto.Location = new System.Drawing.Point(119, 157);
            this.num_alto.Name = "num_alto";
            this.num_alto.Size = new System.Drawing.Size(120, 20);
            this.num_alto.TabIndex = 8;
            // 
            // lbl_largo
            // 
            this.lbl_largo.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_largo.AutoSize = true;
            this.lbl_largo.Location = new System.Drawing.Point(21, 124);
            this.lbl_largo.Name = "lbl_largo";
            this.lbl_largo.Size = new System.Drawing.Size(34, 13);
            this.lbl_largo.TabIndex = 10;
            this.lbl_largo.Text = "Largo";
            this.lbl_largo.Click += new System.EventHandler(this.lbl_largo_Click);
            // 
            // num_largo
            // 
            this.num_largo.AutoSize = true;
            this.num_largo.DecimalPlaces = 2;
            this.num_largo.Location = new System.Drawing.Point(119, 123);
            this.num_largo.Name = "num_largo";
            this.num_largo.Size = new System.Drawing.Size(120, 20);
            this.num_largo.TabIndex = 7;
            // 
            // num_ancho
            // 
            this.num_ancho.AutoSize = true;
            this.num_ancho.DecimalPlaces = 2;
            this.num_ancho.Location = new System.Drawing.Point(119, 93);
            this.num_ancho.Name = "num_ancho";
            this.num_ancho.Size = new System.Drawing.Size(120, 20);
            this.num_ancho.TabIndex = 6;
            // 
            // lbl_ancho
            // 
            this.lbl_ancho.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_ancho.AutoSize = true;
            this.lbl_ancho.Location = new System.Drawing.Point(21, 96);
            this.lbl_ancho.Name = "lbl_ancho";
            this.lbl_ancho.Size = new System.Drawing.Size(38, 13);
            this.lbl_ancho.TabIndex = 9;
            this.lbl_ancho.Text = "Ancho";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_cancelar.Location = new System.Drawing.Point(407, 564);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_continuar
            // 
            this.btn_continuar.Location = new System.Drawing.Point(498, 564);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(75, 23);
            this.btn_continuar.TabIndex = 24;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = true;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // Form_solicitud_servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(585, 682);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.Grpbx_dimensiones);
            this.Controls.Add(this.btn_continuar);
            this.Name = "Form_solicitud_servicio";
            this.Text = "Solicitud de servicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_solicitud_servicio_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Grpbx_dimensiones.ResumeLayout(false);
            this.Grpbx_dimensiones.PerformLayout();
            this.Grp_Destino.ResumeLayout(false);
            this.Grp_Destino.PerformLayout();
            this.grp_origen.ResumeLayout(false);
            this.grp_origen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_alto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_largo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ancho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_Tipo_Paquete;
        private System.Windows.Forms.Label lbl_tipo_paquete;
        private System.Windows.Forms.GroupBox Grpbx_dimensiones;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.NumericUpDown num_peso;
        private System.Windows.Forms.Label lbl_kg;
        private System.Windows.Forms.GroupBox grp_dimensiones;
        private System.Windows.Forms.NumericUpDown num_alto;
        private System.Windows.Forms.NumericUpDown num_largo;
        private System.Windows.Forms.NumericUpDown num_ancho;
        private System.Windows.Forms.Label lbl_alto;
        private System.Windows.Forms.Label lbl_largo;
        private System.Windows.Forms.Label lbl_ancho;
        private System.Windows.Forms.Label lbl_cm_alto;
        private System.Windows.Forms.Label lbl_cm_largo;
        private System.Windows.Forms.Label lbl_cm_ancho;
        private System.Windows.Forms.GroupBox grp_origen;
        private System.Windows.Forms.RadioButton rd_btn_entrega_sucursal;
        private System.Windows.Forms.RadioButton rd_btn_retiro_domicilio;
        private System.Windows.Forms.ComboBox cmb_region__retirodomicilio;
        private System.Windows.Forms.Label lbl_region_retirodomicilio;
        private System.Windows.Forms.Label lbl_domicilio_retirodomicilio;
        private System.Windows.Forms.TextBox txt_domicilio_retirodomicilio;
        private System.Windows.Forms.ComboBox cmb_localidad_retirodomicilio;
        private System.Windows.Forms.Label lbl_localidad_retirodomicilio;
        private System.Windows.Forms.ComboBox cmb_provincia_retirodomicilio;
        private System.Windows.Forms.Label lbl_provincia_retirodomicilio;
        private System.Windows.Forms.ComboBox cmb_region_entregaensucursal;
        private System.Windows.Forms.Label Lbl_region_entregaensucursal;
        private System.Windows.Forms.ComboBox cmb_sucursal_entregaensucursal;
        private System.Windows.Forms.Label lbl_sucursal_entregaensucursal;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox Grp_Destino;
        private System.Windows.Forms.Label lbl_direccion_internacional;
        private System.Windows.Forms.TextBox txt_direccion_internacional;
        private System.Windows.Forms.ComboBox cmb_pais_internacional;
        private System.Windows.Forms.Label lbl_pais_internacional;
        private System.Windows.Forms.ComboBox cmb_region_internacional;
        private System.Windows.Forms.Label lbl_region_internacional;
        private System.Windows.Forms.Label lbl_direccion_nacional;
        private System.Windows.Forms.TextBox txt_direccion_nacional;
        private System.Windows.Forms.ComboBox cmb_localidad_nacional;
        private System.Windows.Forms.Label lbl_localidad_nacional;
        private System.Windows.Forms.ComboBox cmb_provincia_nacional;
        private System.Windows.Forms.Label lbl_provincia_nacional;
        private System.Windows.Forms.ComboBox cmb_region_nacional;
        private System.Windows.Forms.Label lbl_region_nacional;
        private System.Windows.Forms.RadioButton rd_Internacional;
        private System.Windows.Forms.RadioButton rd_nacional;
        private System.Windows.Forms.Button btn_continuar;
    }
}

