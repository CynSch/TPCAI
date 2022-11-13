namespace TPCAI
{
    partial class Form_consulta_cuenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListadoFacturas = new System.Windows.Forms.ListView();
            this.NFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.importe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDetalleFactura = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PendientesFacturacion = new System.Windows.Forms.ListView();
            this.orden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImporteOrden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaOrden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestinoOrden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMenu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_CUIT = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "El saldo de la cuenta corriente es: ";
            // 
            // ListadoFacturas
            // 
            this.ListadoFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NFactura,
            this.importe,
            this.fecha,
            this.estado});
            this.ListadoFacturas.HideSelection = false;
            this.ListadoFacturas.Location = new System.Drawing.Point(9, 29);
            this.ListadoFacturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListadoFacturas.Name = "ListadoFacturas";
            this.ListadoFacturas.Size = new System.Drawing.Size(1062, 272);
            this.ListadoFacturas.TabIndex = 2;
            this.ListadoFacturas.UseCompatibleStateImageBehavior = false;
            this.ListadoFacturas.View = System.Windows.Forms.View.Details;
            this.ListadoFacturas.SelectedIndexChanged += new System.EventHandler(this.ListadoFacturas_SelectedIndexChanged);
            this.ListadoFacturas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListadoFacturas_MouseClick);
            // 
            // NFactura
            // 
            this.NFactura.Text = "Nº Factura";
            this.NFactura.Width = 138;
            // 
            // importe
            // 
            this.importe.Text = "Importe";
            this.importe.Width = 150;
            // 
            // fecha
            // 
            this.fecha.Text = "Fecha";
            this.fecha.Width = 138;
            // 
            // estado
            // 
            this.estado.Text = "Estado";
            this.estado.Width = 289;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDetalleFactura);
            this.groupBox1.Controls.Add(this.ListadoFacturas);
            this.groupBox1.Location = new System.Drawing.Point(36, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1082, 369);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de facturas:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnDetalleFactura
            // 
            this.BtnDetalleFactura.Location = new System.Drawing.Point(960, 312);
            this.BtnDetalleFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDetalleFactura.Name = "BtnDetalleFactura";
            this.BtnDetalleFactura.Size = new System.Drawing.Size(112, 35);
            this.BtnDetalleFactura.TabIndex = 3;
            this.BtnDetalleFactura.Text = "Ver Detalle";
            this.BtnDetalleFactura.UseVisualStyleBackColor = true;
            this.BtnDetalleFactura.Click += new System.EventHandler(this.BtnDetalleFactura_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PendientesFacturacion);
            this.groupBox2.Location = new System.Drawing.Point(42, 454);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1076, 327);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servicios pendientes de facturacion:";
            // 
            // PendientesFacturacion
            // 
            this.PendientesFacturacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orden,
            this.ImporteOrden,
            this.FechaOrden,
            this.DestinoOrden});
            this.PendientesFacturacion.HideSelection = false;
            this.PendientesFacturacion.Location = new System.Drawing.Point(9, 29);
            this.PendientesFacturacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PendientesFacturacion.Name = "PendientesFacturacion";
            this.PendientesFacturacion.Size = new System.Drawing.Size(1044, 272);
            this.PendientesFacturacion.TabIndex = 0;
            this.PendientesFacturacion.UseCompatibleStateImageBehavior = false;
            this.PendientesFacturacion.View = System.Windows.Forms.View.Details;
            this.PendientesFacturacion.SelectedIndexChanged += new System.EventHandler(this.PendientesFacturacion_SelectedIndexChanged);
            // 
            // orden
            // 
            this.orden.Text = "Nro orden";
            this.orden.Width = 116;
            // 
            // ImporteOrden
            // 
            this.ImporteOrden.Text = "Importe";
            this.ImporteOrden.Width = 77;
            // 
            // FechaOrden
            // 
            this.FechaOrden.Text = "Fecha";
            this.FechaOrden.Width = 79;
            // 
            // DestinoOrden
            // 
            this.DestinoOrden.Text = "Destino";
            this.DestinoOrden.Width = 417;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(475, 805);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(208, 35);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "Volver al menu principal";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(871, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_CUIT
            // 
            this.lbl_CUIT.AutoSize = true;
            this.lbl_CUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CUIT.Location = new System.Drawing.Point(59, 31);
            this.lbl_CUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CUIT.Name = "lbl_CUIT";
            this.lbl_CUIT.Size = new System.Drawing.Size(46, 20);
            this.lbl_CUIT.TabIndex = 12;
            this.lbl_CUIT.Text = "CUIT";
            this.lbl_CUIT.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form_consulta_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1144, 1122);
            this.Controls.Add(this.lbl_CUIT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_consulta_cuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar estado de la cuenta corriente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_consulta_cuenta_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListadoFacturas;
        private System.Windows.Forms.ColumnHeader NFactura;
        private System.Windows.Forms.ColumnHeader importe;
        private System.Windows.Forms.ColumnHeader fecha;
        private System.Windows.Forms.ColumnHeader estado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView PendientesFacturacion;
        private System.Windows.Forms.ColumnHeader orden;
        private System.Windows.Forms.ColumnHeader ImporteOrden;
        private System.Windows.Forms.ColumnHeader FechaOrden;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_CUIT;
        private System.Windows.Forms.Button BtnDetalleFactura;
        private System.Windows.Forms.ColumnHeader DestinoOrden;
    }
}