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
            this.listView1 = new System.Windows.Forms.ListView();
            this.NroOrden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.ImporteOrden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxtImporteTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura Nº: ";
            // 
            // TxtFactura
            // 
            this.TxtFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFactura.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtFactura.Location = new System.Drawing.Point(95, 13);
            this.TxtFactura.Name = "TxtFactura";
            this.TxtFactura.ReadOnly = true;
            this.TxtFactura.Size = new System.Drawing.Size(125, 13);
            this.TxtFactura.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NroOrden,
            this.Fecha,
            this.Destino,
            this.ImporteOrden});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(638, 301);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // Destino
            // 
            this.Destino.Text = "Destino";
            this.Destino.Width = 335;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "IMPORTE TOTAL:";
            // 
            // ImporteOrden
            // 
            this.ImporteOrden.Text = "Importe";
            this.ImporteOrden.Width = 109;
            // 
            // TxtImporteTotal
            // 
            this.TxtImporteTotal.BackColor = System.Drawing.SystemColors.Control;
            this.TxtImporteTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporteTotal.Location = new System.Drawing.Point(520, 388);
            this.TxtImporteTotal.Name = "TxtImporteTotal";
            this.TxtImporteTotal.Size = new System.Drawing.Size(143, 15);
            this.TxtImporteTotal.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CuentaCorrienteServiciosFacturados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtImporteTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TxtFactura);
            this.Controls.Add(this.label1);
            this.Name = "CuentaCorrienteServiciosFacturados";
            this.Text = "Servicios Facturados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFactura;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NroOrden;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader Destino;
        private System.Windows.Forms.ColumnHeader ImporteOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtImporteTotal;
        private System.Windows.Forms.Button button1;
    }
}