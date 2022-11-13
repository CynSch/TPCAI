namespace TPCAI
{
    partial class CuentaCorrienteServiciosFacturados
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
            this.TxtFactura = new System.Windows.Forms.TextBox();
            this.lvordenesxfactura = new System.Windows.Forms.ListView();
            this.NroOrden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreDestino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImporteOrden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.TxtImporteTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura Nº: ";
            // 
            // TxtFactura
            // 
            this.TxtFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFactura.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtFactura.Location = new System.Drawing.Point(142, 20);
            this.TxtFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFactura.Name = "TxtFactura";
            this.TxtFactura.ReadOnly = true;
            this.TxtFactura.Size = new System.Drawing.Size(188, 19);
            this.TxtFactura.TabIndex = 1;
            // 
            // lvordenesxfactura
            // 
            this.lvordenesxfactura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NroOrden,
            this.Fecha,
            this.NombreDestino,
            this.ImporteOrden});
            this.lvordenesxfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvordenesxfactura.HideSelection = false;
            this.lvordenesxfactura.Location = new System.Drawing.Point(38, 100);
            this.lvordenesxfactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvordenesxfactura.Name = "lvordenesxfactura";
            this.lvordenesxfactura.Size = new System.Drawing.Size(955, 461);
            this.lvordenesxfactura.TabIndex = 2;
            this.lvordenesxfactura.UseCompatibleStateImageBehavior = false;
            this.lvordenesxfactura.View = System.Windows.Forms.View.Details;
            this.lvordenesxfactura.SelectedIndexChanged += new System.EventHandler(this.lvordenesxfactura_SelectedIndexChanged);
            // 
            // NroOrden
            // 
            this.NroOrden.Text = "Nro Orden";
            this.NroOrden.Width = 94;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha";
            this.Fecha.Width = 90;
            // 
            // NombreDestino
            // 
            this.NombreDestino.Text = "Destino";
            this.NombreDestino.Width = 335;
            // 
            // ImporteOrden
            // 
            this.ImporteOrden.Text = "Importe";
            this.ImporteOrden.Width = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 597);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "IMPORTE TOTAL:";
            // 
            // TxtImporteTotal
            // 
            this.TxtImporteTotal.BackColor = System.Drawing.SystemColors.Control;
            this.TxtImporteTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporteTotal.Location = new System.Drawing.Point(780, 597);
            this.TxtImporteTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtImporteTotal.Name = "TxtImporteTotal";
            this.TxtImporteTotal.Size = new System.Drawing.Size(214, 23);
            this.TxtImporteTotal.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(882, 678);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CuentaCorrienteServiciosFacturados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 732);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtImporteTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvordenesxfactura);
            this.Controls.Add(this.TxtFactura);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CuentaCorrienteServiciosFacturados";
            this.Text = "Servicios Facturados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CuentaCorrienteServiciosFacturados_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFactura;
        private System.Windows.Forms.ListView lvordenesxfactura;
        private System.Windows.Forms.ColumnHeader NroOrden;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader NombreDestino;
        private System.Windows.Forms.ColumnHeader ImporteOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtImporteTotal;
        private System.Windows.Forms.Button button1;
    }
}