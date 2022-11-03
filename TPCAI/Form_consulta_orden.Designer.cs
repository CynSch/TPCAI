namespace TPCAI
{
    partial class Form_consulta_orden
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
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtNroOrden = new System.Windows.Forms.TextBox();
            this.TxtFechaOrden = new System.Windows.Forms.TextBox();
            this.TxtImporteOrden = new System.Windows.Forms.TextBox();
            this.TxtDestinoOrden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEstadoOrden = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el número de orden a consultar:";
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.Location = new System.Drawing.Point(211, 41);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(143, 20);
            this.txtNumeroOrden.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(360, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Volver al menu principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMenu);
            // 
            // TxtNroOrden
            // 
            this.TxtNroOrden.Location = new System.Drawing.Point(110, 91);
            this.TxtNroOrden.Name = "TxtNroOrden";
            this.TxtNroOrden.Size = new System.Drawing.Size(325, 20);
            this.TxtNroOrden.TabIndex = 5;
            // 
            // TxtFechaOrden
            // 
            this.TxtFechaOrden.Location = new System.Drawing.Point(110, 117);
            this.TxtFechaOrden.Name = "TxtFechaOrden";
            this.TxtFechaOrden.Size = new System.Drawing.Size(325, 20);
            this.TxtFechaOrden.TabIndex = 6;
            // 
            // TxtImporteOrden
            // 
            this.TxtImporteOrden.Location = new System.Drawing.Point(110, 143);
            this.TxtImporteOrden.Name = "TxtImporteOrden";
            this.TxtImporteOrden.Size = new System.Drawing.Size(325, 20);
            this.TxtImporteOrden.TabIndex = 7;
            // 
            // TxtDestinoOrden
            // 
            this.TxtDestinoOrden.Location = new System.Drawing.Point(110, 169);
            this.TxtDestinoOrden.Name = "TxtDestinoOrden";
            this.TxtDestinoOrden.Size = new System.Drawing.Size(325, 20);
            this.TxtDestinoOrden.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nro Orden: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Importe: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado De la Orden: ";
            // 
            // TxtEstadoOrden
            // 
            this.TxtEstadoOrden.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtEstadoOrden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEstadoOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstadoOrden.Location = new System.Drawing.Point(174, 244);
            this.TxtEstadoOrden.Name = "TxtEstadoOrden";
            this.TxtEstadoOrden.ReadOnly = true;
            this.TxtEstadoOrden.Size = new System.Drawing.Size(261, 15);
            this.TxtEstadoOrden.TabIndex = 14;
            // 
            // Form_consulta_orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 325);
            this.Controls.Add(this.TxtEstadoOrden);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDestinoOrden);
            this.Controls.Add(this.TxtImporteOrden);
            this.Controls.Add(this.TxtFechaOrden);
            this.Controls.Add(this.TxtNroOrden);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumeroOrden);
            this.Controls.Add(this.label1);
            this.Name = "Form_consulta_orden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar estado de orden";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_consulta_orden_FormClosing);
            this.Load += new System.EventHandler(this.Form_consulta_orden_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtNroOrden;
        private System.Windows.Forms.TextBox TxtFechaOrden;
        private System.Windows.Forms.TextBox TxtImporteOrden;
        private System.Windows.Forms.TextBox TxtDestinoOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEstadoOrden;
    }
}