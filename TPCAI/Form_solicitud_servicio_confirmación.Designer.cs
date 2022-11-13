namespace TPCAI
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
            this.lbl_alto = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_tipo_paquete = new System.Windows.Forms.Label();
            this.lbl_largo = new System.Windows.Forms.Label();
            this.lbl_ancho = new System.Windows.Forms.Label();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_moneda_peso = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Importe = new System.Windows.Forms.TextBox();
            this.textBox_Urgencia = new System.Windows.Forms.TextBox();
            this.textBox_Origen = new System.Windows.Forms.TextBox();
            this.textBoxT_Envio = new System.Windows.Forms.TextBox();
            this.textBox_Alto = new System.Windows.Forms.TextBox();
            this.textBox_Largo = new System.Windows.Forms.TextBox();
            this.textBox_Ancho = new System.Windows.Forms.TextBox();
            this.textBox_Peso = new System.Windows.Forms.TextBox();
            this.textBox_TPaquete = new System.Windows.Forms.TextBox();
            this.textBox_Destino = new System.Windows.Forms.TextBox();
            this.lbl_urgencia = new System.Windows.Forms.Label();
            this.lbl_tipo_envio = new System.Windows.Forms.Label();
            this.btn_volver_menu_ppal = new System.Windows.Forms.Button();
            this.textBox_Orden = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_solicitud_exitosa
            // 
            this.lbl_solicitud_exitosa.AutoSize = true;
            this.lbl_solicitud_exitosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_solicitud_exitosa.Location = new System.Drawing.Point(28, 12);
            this.lbl_solicitud_exitosa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_solicitud_exitosa.Name = "lbl_solicitud_exitosa";
            this.lbl_solicitud_exitosa.Size = new System.Drawing.Size(330, 17);
            this.lbl_solicitud_exitosa.TabIndex = 0;
            this.lbl_solicitud_exitosa.Text = "SOLICITUD DE SERVICIO GENERADA CON ÉXITO";
            // 
            // lbl_nro_orden
            // 
            this.lbl_nro_orden.AutoSize = true;
            this.lbl_nro_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_nro_orden.ForeColor = System.Drawing.Color.Red;
            this.lbl_nro_orden.Location = new System.Drawing.Point(28, 46);
            this.lbl_nro_orden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nro_orden.Name = "lbl_nro_orden";
            this.lbl_nro_orden.Size = new System.Drawing.Size(77, 17);
            this.lbl_nro_orden.TabIndex = 1;
            this.lbl_nro_orden.Text = "ORDEN #";
            // 
            // lbl_alto
            // 
            this.lbl_alto.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_alto.AutoSize = true;
            this.lbl_alto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alto.Location = new System.Drawing.Point(25, 146);
            this.lbl_alto.Name = "lbl_alto";
            this.lbl_alto.Size = new System.Drawing.Size(29, 13);
            this.lbl_alto.TabIndex = 19;
            this.lbl_alto.Text = "Alto";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peso.Location = new System.Drawing.Point(25, 56);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(35, 13);
            this.lbl_peso.TabIndex = 15;
            this.lbl_peso.Text = "Peso";
            // 
            // lbl_tipo_paquete
            // 
            this.lbl_tipo_paquete.AutoSize = true;
            this.lbl_tipo_paquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_paquete.Location = new System.Drawing.Point(25, 27);
            this.lbl_tipo_paquete.Name = "lbl_tipo_paquete";
            this.lbl_tipo_paquete.Size = new System.Drawing.Size(100, 13);
            this.lbl_tipo_paquete.TabIndex = 14;
            this.lbl_tipo_paquete.Text = "Tipo de paquete";
            // 
            // lbl_largo
            // 
            this.lbl_largo.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_largo.AutoSize = true;
            this.lbl_largo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_largo.Location = new System.Drawing.Point(25, 116);
            this.lbl_largo.Name = "lbl_largo";
            this.lbl_largo.Size = new System.Drawing.Size(39, 13);
            this.lbl_largo.TabIndex = 18;
            this.lbl_largo.Text = "Largo";
            // 
            // lbl_ancho
            // 
            this.lbl_ancho.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_ancho.AutoSize = true;
            this.lbl_ancho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ancho.Location = new System.Drawing.Point(25, 85);
            this.lbl_ancho.Name = "lbl_ancho";
            this.lbl_ancho.Size = new System.Drawing.Size(43, 13);
            this.lbl_ancho.TabIndex = 17;
            this.lbl_ancho.Text = "Ancho";
            // 
            // lbl_origen
            // 
            this.lbl_origen.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_origen.Location = new System.Drawing.Point(26, 207);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(44, 13);
            this.lbl_origen.TabIndex = 23;
            this.lbl_origen.Text = "Origen";
            // 
            // lbl_destino
            // 
            this.lbl_destino.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_destino.Location = new System.Drawing.Point(25, 237);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(50, 13);
            this.lbl_destino.TabIndex = 24;
            this.lbl_destino.Text = "Destino";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(27, 294);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(49, 13);
            this.lbl_precio.TabIndex = 25;
            this.lbl_precio.Text = "Importe";
            // 
            // lbl_moneda_peso
            // 
            this.lbl_moneda_peso.AutoSize = true;
            this.lbl_moneda_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moneda_peso.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_moneda_peso.Location = new System.Drawing.Point(82, 292);
            this.lbl_moneda_peso.Name = "lbl_moneda_peso";
            this.lbl_moneda_peso.Size = new System.Drawing.Size(17, 17);
            this.lbl_moneda_peso.TabIndex = 33;
            this.lbl_moneda_peso.Text = "$";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Importe);
            this.groupBox1.Controls.Add(this.textBox_Urgencia);
            this.groupBox1.Controls.Add(this.textBox_Origen);
            this.groupBox1.Controls.Add(this.textBoxT_Envio);
            this.groupBox1.Controls.Add(this.textBox_Alto);
            this.groupBox1.Controls.Add(this.textBox_Largo);
            this.groupBox1.Controls.Add(this.textBox_Ancho);
            this.groupBox1.Controls.Add(this.textBox_Peso);
            this.groupBox1.Controls.Add(this.textBox_TPaquete);
            this.groupBox1.Controls.Add(this.textBox_Destino);
            this.groupBox1.Controls.Add(this.lbl_urgencia);
            this.groupBox1.Controls.Add(this.lbl_tipo_envio);
            this.groupBox1.Controls.Add(this.lbl_moneda_peso);
            this.groupBox1.Controls.Add(this.lbl_precio);
            this.groupBox1.Controls.Add(this.lbl_destino);
            this.groupBox1.Controls.Add(this.lbl_origen);
            this.groupBox1.Controls.Add(this.lbl_alto);
            this.groupBox1.Controls.Add(this.lbl_peso);
            this.groupBox1.Controls.Add(this.lbl_tipo_paquete);
            this.groupBox1.Controls.Add(this.lbl_largo);
            this.groupBox1.Controls.Add(this.lbl_ancho);
            this.groupBox1.Location = new System.Drawing.Point(31, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(423, 322);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_Importe
            // 
            this.textBox_Importe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Importe.Location = new System.Drawing.Point(105, 294);
            this.textBox_Importe.Name = "textBox_Importe";
            this.textBox_Importe.ReadOnly = true;
            this.textBox_Importe.Size = new System.Drawing.Size(222, 13);
            this.textBox_Importe.TabIndex = 48;
            // 
            // textBox_Urgencia
            // 
            this.textBox_Urgencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Urgencia.Location = new System.Drawing.Point(100, 266);
            this.textBox_Urgencia.Name = "textBox_Urgencia";
            this.textBox_Urgencia.ReadOnly = true;
            this.textBox_Urgencia.Size = new System.Drawing.Size(59, 13);
            this.textBox_Urgencia.TabIndex = 47;
            // 
            // textBox_Origen
            // 
            this.textBox_Origen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Origen.Location = new System.Drawing.Point(97, 207);
            this.textBox_Origen.Name = "textBox_Origen";
            this.textBox_Origen.ReadOnly = true;
            this.textBox_Origen.Size = new System.Drawing.Size(285, 13);
            this.textBox_Origen.TabIndex = 46;
            // 
            // textBoxT_Envio
            // 
            this.textBoxT_Envio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxT_Envio.Location = new System.Drawing.Point(134, 173);
            this.textBoxT_Envio.Name = "textBoxT_Envio";
            this.textBoxT_Envio.ReadOnly = true;
            this.textBoxT_Envio.Size = new System.Drawing.Size(88, 13);
            this.textBoxT_Envio.TabIndex = 45;
            // 
            // textBox_Alto
            // 
            this.textBox_Alto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Alto.Location = new System.Drawing.Point(134, 143);
            this.textBox_Alto.Name = "textBox_Alto";
            this.textBox_Alto.ReadOnly = true;
            this.textBox_Alto.Size = new System.Drawing.Size(25, 13);
            this.textBox_Alto.TabIndex = 44;
            // 
            // textBox_Largo
            // 
            this.textBox_Largo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Largo.Location = new System.Drawing.Point(134, 113);
            this.textBox_Largo.Name = "textBox_Largo";
            this.textBox_Largo.ReadOnly = true;
            this.textBox_Largo.Size = new System.Drawing.Size(25, 13);
            this.textBox_Largo.TabIndex = 43;
            // 
            // textBox_Ancho
            // 
            this.textBox_Ancho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Ancho.Location = new System.Drawing.Point(134, 82);
            this.textBox_Ancho.Name = "textBox_Ancho";
            this.textBox_Ancho.ReadOnly = true;
            this.textBox_Ancho.Size = new System.Drawing.Size(25, 13);
            this.textBox_Ancho.TabIndex = 42;
            // 
            // textBox_Peso
            // 
            this.textBox_Peso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Peso.Location = new System.Drawing.Point(134, 48);
            this.textBox_Peso.Name = "textBox_Peso";
            this.textBox_Peso.ReadOnly = true;
            this.textBox_Peso.Size = new System.Drawing.Size(25, 13);
            this.textBox_Peso.TabIndex = 41;
            // 
            // textBox_TPaquete
            // 
            this.textBox_TPaquete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_TPaquete.Location = new System.Drawing.Point(134, 20);
            this.textBox_TPaquete.Name = "textBox_TPaquete";
            this.textBox_TPaquete.ReadOnly = true;
            this.textBox_TPaquete.Size = new System.Drawing.Size(88, 13);
            this.textBox_TPaquete.TabIndex = 40;
            // 
            // textBox_Destino
            // 
            this.textBox_Destino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Destino.Location = new System.Drawing.Point(97, 237);
            this.textBox_Destino.Name = "textBox_Destino";
            this.textBox_Destino.ReadOnly = true;
            this.textBox_Destino.Size = new System.Drawing.Size(285, 13);
            this.textBox_Destino.TabIndex = 39;
            // 
            // lbl_urgencia
            // 
            this.lbl_urgencia.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_urgencia.AutoSize = true;
            this.lbl_urgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_urgencia.Location = new System.Drawing.Point(25, 266);
            this.lbl_urgencia.Name = "lbl_urgencia";
            this.lbl_urgencia.Size = new System.Drawing.Size(58, 13);
            this.lbl_urgencia.TabIndex = 37;
            this.lbl_urgencia.Text = "Urgencia";
            // 
            // lbl_tipo_envio
            // 
            this.lbl_tipo_envio.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbl_tipo_envio.AutoSize = true;
            this.lbl_tipo_envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_envio.Location = new System.Drawing.Point(25, 176);
            this.lbl_tipo_envio.Name = "lbl_tipo_envio";
            this.lbl_tipo_envio.Size = new System.Drawing.Size(88, 13);
            this.lbl_tipo_envio.TabIndex = 35;
            this.lbl_tipo_envio.Text = "Tipo de Envío";
            // 
            // btn_volver_menu_ppal
            // 
            this.btn_volver_menu_ppal.AutoSize = true;
            this.btn_volver_menu_ppal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_volver_menu_ppal.Location = new System.Drawing.Point(331, 407);
            this.btn_volver_menu_ppal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_volver_menu_ppal.Name = "btn_volver_menu_ppal";
            this.btn_volver_menu_ppal.Size = new System.Drawing.Size(131, 23);
            this.btn_volver_menu_ppal.TabIndex = 36;
            this.btn_volver_menu_ppal.Text = "Volver al Menú Principal";
            this.btn_volver_menu_ppal.UseVisualStyleBackColor = true;
            this.btn_volver_menu_ppal.Click += new System.EventHandler(this.btn_volver_menu_ppal_Click);
            // 
            // textBox_Orden
            // 
            this.textBox_Orden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_Orden.ForeColor = System.Drawing.Color.Red;
            this.textBox_Orden.Location = new System.Drawing.Point(110, 47);
            this.textBox_Orden.Name = "textBox_Orden";
            this.textBox_Orden.ReadOnly = true;
            this.textBox_Orden.Size = new System.Drawing.Size(143, 16);
            this.textBox_Orden.TabIndex = 41;
            // 
            // Form_solicitud_servicio_confirmación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 438);
            this.Controls.Add(this.textBox_Orden);
            this.Controls.Add(this.btn_volver_menu_ppal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_nro_orden);
            this.Controls.Add(this.lbl_solicitud_exitosa);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lbl_alto;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_tipo_paquete;
        private System.Windows.Forms.Label lbl_largo;
        private System.Windows.Forms.Label lbl_ancho;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_moneda_peso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_tipo_envio;
        private System.Windows.Forms.Button btn_volver_menu_ppal;
        private System.Windows.Forms.Label lbl_urgencia;
        private System.Windows.Forms.TextBox textBox_Importe;
        private System.Windows.Forms.TextBox textBox_Urgencia;
        private System.Windows.Forms.TextBox textBox_Origen;
        private System.Windows.Forms.TextBox textBoxT_Envio;
        private System.Windows.Forms.TextBox textBox_Alto;
        private System.Windows.Forms.TextBox textBox_Largo;
        private System.Windows.Forms.TextBox textBox_Ancho;
        private System.Windows.Forms.TextBox textBox_Peso;
        private System.Windows.Forms.TextBox textBox_TPaquete;
        private System.Windows.Forms.TextBox textBox_Destino;
        private System.Windows.Forms.TextBox textBox_Orden;
    }
}