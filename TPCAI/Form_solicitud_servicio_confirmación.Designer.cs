﻿namespace TPCAI
{
    partial class Form_solicitud_servicio_confirmación
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
            this.lbl_solicitud_exitosa = new System.Windows.Forms.Label();
            this.lbl_nro_orden = new System.Windows.Forms.Label();
            this.lbl_cm_alto = new System.Windows.Forms.Label();
            this.lbl_cm_largo = new System.Windows.Forms.Label();
            this.lbl_alto = new System.Windows.Forms.Label();
            this.lbl_kg = new System.Windows.Forms.Label();
            this.lbl_cm_ancho = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_tipo_paquete = new System.Windows.Forms.Label();
            this.lbl_largo = new System.Windows.Forms.Label();
            this.lbl_ancho = new System.Windows.Forms.Label();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_peso_servicio = new System.Windows.Forms.Label();
            this.lbl_ancho_servicio = new System.Windows.Forms.Label();
            this.lbl_largo_servicio = new System.Windows.Forms.Label();
            this.lbl_alto_servicio = new System.Windows.Forms.Label();
            this.lbl_origen_servicio = new System.Windows.Forms.Label();
            this.lbl_destino_servicio = new System.Windows.Forms.Label();
            this.lbl_precio_servicio = new System.Windows.Forms.Label();
            this.lbl_moneda_peso = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tipo_envio_servicio = new System.Windows.Forms.Label();
            this.lbl_tipo_envio = new System.Windows.Forms.Label();
            this.lbl_tipo_paquete_servicio = new System.Windows.Forms.Label();
            this.lbl_nro_orden_servicio = new System.Windows.Forms.Label();
            this.btn_volver_menu_ppal = new System.Windows.Forms.Button();
            this.lbl_urgencia_opcion = new System.Windows.Forms.Label();
            this.lbl_urgencia = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_solicitud_exitosa
            // 
            this.lbl_solicitud_exitosa.AutoSize = true;
            this.lbl_solicitud_exitosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_solicitud_exitosa.Location = new System.Drawing.Point(42, 18);
            this.lbl_solicitud_exitosa.Name = "lbl_solicitud_exitosa";
            this.lbl_solicitud_exitosa.Size = new System.Drawing.Size(482, 25);
            this.lbl_solicitud_exitosa.TabIndex = 0;
            this.lbl_solicitud_exitosa.Text = "SOLICITUD DE SERVICIO GENERADA CON ÉXITO";
            this.lbl_solicitud_exitosa.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_nro_orden
            // 
            this.lbl_nro_orden.AutoSize = true;
            this.lbl_nro_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_nro_orden.ForeColor = System.Drawing.Color.Red;
            this.lbl_nro_orden.Location = new System.Drawing.Point(42, 71);
            this.lbl_nro_orden.Name = "lbl_nro_orden";
            this.lbl_nro_orden.Size = new System.Drawing.Size(87, 25);
            this.lbl_nro_orden.TabIndex = 1;
            this.lbl_nro_orden.Text = "ORDEN";
            this.lbl_nro_orden.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_cm_alto
            // 
            this.lbl_cm_alto.AutoSize = true;
            this.lbl_cm_alto.Location = new System.Drawing.Point(254, 225);
            this.lbl_cm_alto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cm_alto.Name = "lbl_cm_alto";
            this.lbl_cm_alto.Size = new System.Drawing.Size(30, 20);
            this.lbl_cm_alto.TabIndex = 21;
            this.lbl_cm_alto.Text = "cm";
            // 
            // lbl_cm_largo
            // 
            this.lbl_cm_largo.AutoSize = true;
            this.lbl_cm_largo.Location = new System.Drawing.Point(254, 178);
            this.lbl_cm_largo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cm_largo.Name = "lbl_cm_largo";
            this.lbl_cm_largo.Size = new System.Drawing.Size(30, 20);
            this.lbl_cm_largo.TabIndex = 22;
            this.lbl_cm_largo.Text = "cm";
            // 
            // lbl_alto
            // 
            this.lbl_alto.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_alto.AutoSize = true;
            this.lbl_alto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alto.Location = new System.Drawing.Point(38, 225);
            this.lbl_alto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_alto.Name = "lbl_alto";
            this.lbl_alto.Size = new System.Drawing.Size(41, 20);
            this.lbl_alto.TabIndex = 19;
            this.lbl_alto.Text = "Alto";
            // 
            // lbl_kg
            // 
            this.lbl_kg.AutoSize = true;
            this.lbl_kg.Location = new System.Drawing.Point(256, 86);
            this.lbl_kg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kg.Name = "lbl_kg";
            this.lbl_kg.Size = new System.Drawing.Size(26, 20);
            this.lbl_kg.TabIndex = 16;
            this.lbl_kg.Text = "kg";
            // 
            // lbl_cm_ancho
            // 
            this.lbl_cm_ancho.AutoSize = true;
            this.lbl_cm_ancho.Location = new System.Drawing.Point(254, 131);
            this.lbl_cm_ancho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cm_ancho.Name = "lbl_cm_ancho";
            this.lbl_cm_ancho.Size = new System.Drawing.Size(30, 20);
            this.lbl_cm_ancho.TabIndex = 20;
            this.lbl_cm_ancho.Text = "cm";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peso.Location = new System.Drawing.Point(38, 86);
            this.lbl_peso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(49, 20);
            this.lbl_peso.TabIndex = 15;
            this.lbl_peso.Text = "Peso";
            // 
            // lbl_tipo_paquete
            // 
            this.lbl_tipo_paquete.AutoSize = true;
            this.lbl_tipo_paquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_paquete.Location = new System.Drawing.Point(38, 41);
            this.lbl_tipo_paquete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo_paquete.Name = "lbl_tipo_paquete";
            this.lbl_tipo_paquete.Size = new System.Drawing.Size(139, 20);
            this.lbl_tipo_paquete.TabIndex = 14;
            this.lbl_tipo_paquete.Text = "Tipo de paquete";
            // 
            // lbl_largo
            // 
            this.lbl_largo.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_largo.AutoSize = true;
            this.lbl_largo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_largo.Location = new System.Drawing.Point(38, 178);
            this.lbl_largo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_largo.Name = "lbl_largo";
            this.lbl_largo.Size = new System.Drawing.Size(55, 20);
            this.lbl_largo.TabIndex = 18;
            this.lbl_largo.Text = "Largo";
            // 
            // lbl_ancho
            // 
            this.lbl_ancho.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_ancho.AutoSize = true;
            this.lbl_ancho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ancho.Location = new System.Drawing.Point(38, 131);
            this.lbl_ancho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ancho.Name = "lbl_ancho";
            this.lbl_ancho.Size = new System.Drawing.Size(60, 20);
            this.lbl_ancho.TabIndex = 17;
            this.lbl_ancho.Text = "Ancho";
            // 
            // lbl_origen
            // 
            this.lbl_origen.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_origen.Location = new System.Drawing.Point(39, 319);
            this.lbl_origen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(62, 20);
            this.lbl_origen.TabIndex = 23;
            this.lbl_origen.Text = "Origen";
            this.lbl_origen.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_destino
            // 
            this.lbl_destino.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_destino.Location = new System.Drawing.Point(38, 364);
            this.lbl_destino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(71, 20);
            this.lbl_destino.TabIndex = 24;
            this.lbl_destino.Text = "Destino";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(40, 453);
            this.lbl_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(71, 20);
            this.lbl_precio.TabIndex = 25;
            this.lbl_precio.Text = "Importe";
            this.lbl_precio.Click += new System.EventHandler(this.lbl_precio_Click);
            // 
            // lbl_peso_servicio
            // 
            this.lbl_peso_servicio.AutoSize = true;
            this.lbl_peso_servicio.Location = new System.Drawing.Point(196, 86);
            this.lbl_peso_servicio.Name = "lbl_peso_servicio";
            this.lbl_peso_servicio.Size = new System.Drawing.Size(40, 20);
            this.lbl_peso_servicio.TabIndex = 26;
            this.lbl_peso_servicio.Text = "2,00";
            this.lbl_peso_servicio.Click += new System.EventHandler(this.lbl_peso_servicio_Click);
            // 
            // lbl_ancho_servicio
            // 
            this.lbl_ancho_servicio.AutoSize = true;
            this.lbl_ancho_servicio.Location = new System.Drawing.Point(196, 131);
            this.lbl_ancho_servicio.Name = "lbl_ancho_servicio";
            this.lbl_ancho_servicio.Size = new System.Drawing.Size(40, 20);
            this.lbl_ancho_servicio.TabIndex = 27;
            this.lbl_ancho_servicio.Text = "1,00";
            // 
            // lbl_largo_servicio
            // 
            this.lbl_largo_servicio.AutoSize = true;
            this.lbl_largo_servicio.Location = new System.Drawing.Point(196, 178);
            this.lbl_largo_servicio.Name = "lbl_largo_servicio";
            this.lbl_largo_servicio.Size = new System.Drawing.Size(40, 20);
            this.lbl_largo_servicio.TabIndex = 28;
            this.lbl_largo_servicio.Text = "1,00";
            // 
            // lbl_alto_servicio
            // 
            this.lbl_alto_servicio.AutoSize = true;
            this.lbl_alto_servicio.Location = new System.Drawing.Point(196, 225);
            this.lbl_alto_servicio.Name = "lbl_alto_servicio";
            this.lbl_alto_servicio.Size = new System.Drawing.Size(40, 20);
            this.lbl_alto_servicio.TabIndex = 29;
            this.lbl_alto_servicio.Text = "1,00";
            // 
            // lbl_origen_servicio
            // 
            this.lbl_origen_servicio.AutoSize = true;
            this.lbl_origen_servicio.Location = new System.Drawing.Point(196, 319);
            this.lbl_origen_servicio.Name = "lbl_origen_servicio";
            this.lbl_origen_servicio.Size = new System.Drawing.Size(372, 20);
            this.lbl_origen_servicio.TabIndex = 30;
            this.lbl_origen_servicio.Text = "Metropolitana, CABA, Balvanera, Av. Córdoba 2122";
            this.lbl_origen_servicio.Click += new System.EventHandler(this.lbl_origen_servicio_Click);
            // 
            // lbl_destino_servicio
            // 
            this.lbl_destino_servicio.AutoSize = true;
            this.lbl_destino_servicio.Location = new System.Drawing.Point(196, 364);
            this.lbl_destino_servicio.Name = "lbl_destino_servicio";
            this.lbl_destino_servicio.Size = new System.Drawing.Size(357, 20);
            this.lbl_destino_servicio.TabIndex = 31;
            this.lbl_destino_servicio.Text = "Metropolitana, CABA, Belgrano, Av. Cabildo 2000";
            // 
            // lbl_precio_servicio
            // 
            this.lbl_precio_servicio.AutoSize = true;
            this.lbl_precio_servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_servicio.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_precio_servicio.Location = new System.Drawing.Point(217, 450);
            this.lbl_precio_servicio.Name = "lbl_precio_servicio";
            this.lbl_precio_servicio.Size = new System.Drawing.Size(48, 25);
            this.lbl_precio_servicio.TabIndex = 32;
            this.lbl_precio_servicio.Text = "600";
            // 
            // lbl_moneda_peso
            // 
            this.lbl_moneda_peso.AutoSize = true;
            this.lbl_moneda_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moneda_peso.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_moneda_peso.Location = new System.Drawing.Point(197, 449);
            this.lbl_moneda_peso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_moneda_peso.Name = "lbl_moneda_peso";
            this.lbl_moneda_peso.Size = new System.Drawing.Size(24, 25);
            this.lbl_moneda_peso.TabIndex = 33;
            this.lbl_moneda_peso.Text = "$";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_urgencia_opcion);
            this.groupBox1.Controls.Add(this.lbl_urgencia);
            this.groupBox1.Controls.Add(this.lbl_tipo_envio_servicio);
            this.groupBox1.Controls.Add(this.lbl_tipo_envio);
            this.groupBox1.Controls.Add(this.lbl_tipo_paquete_servicio);
            this.groupBox1.Controls.Add(this.lbl_moneda_peso);
            this.groupBox1.Controls.Add(this.lbl_precio_servicio);
            this.groupBox1.Controls.Add(this.lbl_destino_servicio);
            this.groupBox1.Controls.Add(this.lbl_origen_servicio);
            this.groupBox1.Controls.Add(this.lbl_alto_servicio);
            this.groupBox1.Controls.Add(this.lbl_largo_servicio);
            this.groupBox1.Controls.Add(this.lbl_ancho_servicio);
            this.groupBox1.Controls.Add(this.lbl_peso_servicio);
            this.groupBox1.Controls.Add(this.lbl_precio);
            this.groupBox1.Controls.Add(this.lbl_destino);
            this.groupBox1.Controls.Add(this.lbl_origen);
            this.groupBox1.Controls.Add(this.lbl_cm_alto);
            this.groupBox1.Controls.Add(this.lbl_cm_largo);
            this.groupBox1.Controls.Add(this.lbl_alto);
            this.groupBox1.Controls.Add(this.lbl_kg);
            this.groupBox1.Controls.Add(this.lbl_cm_ancho);
            this.groupBox1.Controls.Add(this.lbl_peso);
            this.groupBox1.Controls.Add(this.lbl_tipo_paquete);
            this.groupBox1.Controls.Add(this.lbl_largo);
            this.groupBox1.Controls.Add(this.lbl_ancho);
            this.groupBox1.Location = new System.Drawing.Point(47, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 495);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_tipo_envio_servicio
            // 
            this.lbl_tipo_envio_servicio.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_tipo_envio_servicio.AutoSize = true;
            this.lbl_tipo_envio_servicio.Location = new System.Drawing.Point(197, 271);
            this.lbl_tipo_envio_servicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo_envio_servicio.Name = "lbl_tipo_envio_servicio";
            this.lbl_tipo_envio_servicio.Size = new System.Drawing.Size(70, 20);
            this.lbl_tipo_envio_servicio.TabIndex = 36;
            this.lbl_tipo_envio_servicio.Text = "Nacional";
            // 
            // lbl_tipo_envio
            // 
            this.lbl_tipo_envio.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_tipo_envio.AutoSize = true;
            this.lbl_tipo_envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_envio.Location = new System.Drawing.Point(38, 271);
            this.lbl_tipo_envio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo_envio.Name = "lbl_tipo_envio";
            this.lbl_tipo_envio.Size = new System.Drawing.Size(117, 20);
            this.lbl_tipo_envio.TabIndex = 35;
            this.lbl_tipo_envio.Text = "Tipo de Envío";
            // 
            // lbl_tipo_paquete_servicio
            // 
            this.lbl_tipo_paquete_servicio.AutoSize = true;
            this.lbl_tipo_paquete_servicio.Location = new System.Drawing.Point(196, 41);
            this.lbl_tipo_paquete_servicio.Name = "lbl_tipo_paquete_servicio";
            this.lbl_tipo_paquete_servicio.Size = new System.Drawing.Size(98, 20);
            this.lbl_tipo_paquete_servicio.TabIndex = 34;
            this.lbl_tipo_paquete_servicio.Text = "Encomienda";
            this.lbl_tipo_paquete_servicio.Click += new System.EventHandler(this.lbl_tipo_paquete_servicio_Click);
            // 
            // lbl_nro_orden_servicio
            // 
            this.lbl_nro_orden_servicio.AutoSize = true;
            this.lbl_nro_orden_servicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nro_orden_servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_nro_orden_servicio.ForeColor = System.Drawing.Color.Red;
            this.lbl_nro_orden_servicio.Location = new System.Drawing.Point(128, 71);
            this.lbl_nro_orden_servicio.Name = "lbl_nro_orden_servicio";
            this.lbl_nro_orden_servicio.Size = new System.Drawing.Size(144, 25);
            this.lbl_nro_orden_servicio.TabIndex = 35;
            this.lbl_nro_orden_servicio.Text = "#1111111111";
            this.lbl_nro_orden_servicio.Click += new System.EventHandler(this.lbl_nro_orden_servicio_Click);
            // 
            // btn_volver_menu_ppal
            // 
            this.btn_volver_menu_ppal.AutoSize = true;
            this.btn_volver_menu_ppal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_volver_menu_ppal.Location = new System.Drawing.Point(496, 626);
            this.btn_volver_menu_ppal.Name = "btn_volver_menu_ppal";
            this.btn_volver_menu_ppal.Size = new System.Drawing.Size(186, 30);
            this.btn_volver_menu_ppal.TabIndex = 36;
            this.btn_volver_menu_ppal.Text = "Volver al Menú Principal";
            this.btn_volver_menu_ppal.UseVisualStyleBackColor = true;
            this.btn_volver_menu_ppal.Click += new System.EventHandler(this.btn_volver_menu_ppal_Click);
            // 
            // lbl_urgencia_opcion
            // 
            this.lbl_urgencia_opcion.AutoSize = true;
            this.lbl_urgencia_opcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_urgencia_opcion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_urgencia_opcion.Location = new System.Drawing.Point(196, 407);
            this.lbl_urgencia_opcion.Name = "lbl_urgencia_opcion";
            this.lbl_urgencia_opcion.Size = new System.Drawing.Size(29, 20);
            this.lbl_urgencia_opcion.TabIndex = 38;
            this.lbl_urgencia_opcion.Text = "No";
            this.lbl_urgencia_opcion.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbl_urgencia
            // 
            this.lbl_urgencia.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_urgencia.AutoSize = true;
            this.lbl_urgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_urgencia.Location = new System.Drawing.Point(38, 409);
            this.lbl_urgencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_urgencia.Name = "lbl_urgencia";
            this.lbl_urgencia.Size = new System.Drawing.Size(81, 20);
            this.lbl_urgencia.TabIndex = 37;
            this.lbl_urgencia.Text = "Urgencia";
            this.lbl_urgencia.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form_solicitud_servicio_confirmación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 674);
            this.Controls.Add(this.btn_volver_menu_ppal);
            this.Controls.Add(this.lbl_nro_orden_servicio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_nro_orden);
            this.Controls.Add(this.lbl_solicitud_exitosa);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form_solicitud_servicio_confirmación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmación de solicitud de servicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_solicitud_servicio_confirmación_FormClosing);
            this.Load += new System.EventHandler(this.Form_solicitud_servicio_confirmación_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_solicitud_exitosa;
        private System.Windows.Forms.Label lbl_nro_orden;
        private System.Windows.Forms.Label lbl_cm_alto;
        private System.Windows.Forms.Label lbl_cm_largo;
        private System.Windows.Forms.Label lbl_alto;
        private System.Windows.Forms.Label lbl_kg;
        private System.Windows.Forms.Label lbl_cm_ancho;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_tipo_paquete;
        private System.Windows.Forms.Label lbl_largo;
        private System.Windows.Forms.Label lbl_ancho;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_peso_servicio;
        private System.Windows.Forms.Label lbl_ancho_servicio;
        private System.Windows.Forms.Label lbl_largo_servicio;
        private System.Windows.Forms.Label lbl_alto_servicio;
        private System.Windows.Forms.Label lbl_origen_servicio;
        private System.Windows.Forms.Label lbl_destino_servicio;
        private System.Windows.Forms.Label lbl_precio_servicio;
        private System.Windows.Forms.Label lbl_moneda_peso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_tipo_paquete_servicio;
        private System.Windows.Forms.Label lbl_nro_orden_servicio;
        private System.Windows.Forms.Label lbl_tipo_envio_servicio;
        private System.Windows.Forms.Label lbl_tipo_envio;
        private System.Windows.Forms.Button btn_volver_menu_ppal;
        private System.Windows.Forms.Label lbl_urgencia_opcion;
        private System.Windows.Forms.Label lbl_urgencia;
    }
}