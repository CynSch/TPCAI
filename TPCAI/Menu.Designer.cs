﻿
namespace TPCAI
{
    partial class Menu
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
            this.butsolicitarservicio = new System.Windows.Forms.Button();
            this.butcuentacorriente = new System.Windows.Forms.Button();
            this.butconsultarorden = new System.Windows.Forms.Button();
            this.LabelBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butsolicitarservicio
            // 
            this.butsolicitarservicio.Location = new System.Drawing.Point(130, 175);
            this.butsolicitarservicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butsolicitarservicio.Name = "butsolicitarservicio";
            this.butsolicitarservicio.Size = new System.Drawing.Size(417, 48);
            this.butsolicitarservicio.TabIndex = 0;
            this.butsolicitarservicio.Text = "Solicitar Servicio";
            this.butsolicitarservicio.UseVisualStyleBackColor = true;
            this.butsolicitarservicio.Click += new System.EventHandler(this.butsolicitarservicio_Click);
            // 
            // butcuentacorriente
            // 
            this.butcuentacorriente.Location = new System.Drawing.Point(130, 325);
            this.butcuentacorriente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butcuentacorriente.Name = "butcuentacorriente";
            this.butcuentacorriente.Size = new System.Drawing.Size(417, 48);
            this.butcuentacorriente.TabIndex = 1;
            this.butcuentacorriente.Text = "Consultar estado de cuenta corriente";
            this.butcuentacorriente.UseVisualStyleBackColor = true;
            this.butcuentacorriente.Click += new System.EventHandler(this.butcuentacorriente_Click);
            // 
            // butconsultarorden
            // 
            this.butconsultarorden.Location = new System.Drawing.Point(130, 477);
            this.butconsultarorden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butconsultarorden.Name = "butconsultarorden";
            this.butconsultarorden.Size = new System.Drawing.Size(417, 48);
            this.butconsultarorden.TabIndex = 2;
            this.butconsultarorden.Text = "Consultar estado de orden";
            this.butconsultarorden.UseVisualStyleBackColor = true;
            this.butconsultarorden.Click += new System.EventHandler(this.butconsultarorden_Click);
            // 
            // LabelBienvenido
            // 
            this.LabelBienvenido.AutoSize = true;
            this.LabelBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBienvenido.Location = new System.Drawing.Point(176, 65);
            this.LabelBienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBienvenido.Name = "LabelBienvenido";
            this.LabelBienvenido.Size = new System.Drawing.Size(130, 26);
            this.LabelBienvenido.TabIndex = 3;
            this.LabelBienvenido.Text = "Bienvenido";
            this.LabelBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 777);
            this.Controls.Add(this.LabelBienvenido);
            this.Controls.Add(this.butconsultarorden);
            this.Controls.Add(this.butcuentacorriente);
            this.Controls.Add(this.butsolicitarservicio);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butsolicitarservicio;
        private System.Windows.Forms.Button butcuentacorriente;
        private System.Windows.Forms.Button butconsultarorden;
        private System.Windows.Forms.Label LabelBienvenido;
    }
}