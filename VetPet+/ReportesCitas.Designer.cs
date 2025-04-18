﻿namespace VetPet_
{
    partial class ReportesCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesCitas));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRazonMasFrec = new System.Windows.Forms.Button();
            this.BtnRazonMenFrec = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.dateTime2 = new System.Windows.Forms.DateTimePicker();
            this.lblA = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.pdfViewCita = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewCita)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 106);
            this.label1.TabIndex = 25;
            this.label1.Text = "Reportes: Citas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnRazonMasFrec
            // 
            this.BtnRazonMasFrec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.BtnRazonMasFrec.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRazonMasFrec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.BtnRazonMasFrec.Location = new System.Drawing.Point(53, 142);
            this.BtnRazonMasFrec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRazonMasFrec.Name = "BtnRazonMasFrec";
            this.BtnRazonMasFrec.Size = new System.Drawing.Size(349, 81);
            this.BtnRazonMasFrec.TabIndex = 26;
            this.BtnRazonMasFrec.Tag = "1";
            this.BtnRazonMasFrec.Text = "Razón de Cita más Frecuente";
            this.BtnRazonMasFrec.UseVisualStyleBackColor = false;
            this.BtnRazonMasFrec.Click += new System.EventHandler(this.BtnRazonMasFrec_Click);
            // 
            // BtnRazonMenFrec
            // 
            this.BtnRazonMenFrec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.BtnRazonMenFrec.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRazonMenFrec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.BtnRazonMenFrec.Location = new System.Drawing.Point(53, 242);
            this.BtnRazonMenFrec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRazonMenFrec.Name = "BtnRazonMenFrec";
            this.BtnRazonMenFrec.Size = new System.Drawing.Size(349, 81);
            this.BtnRazonMenFrec.TabIndex = 27;
            this.BtnRazonMenFrec.Tag = "1";
            this.BtnRazonMenFrec.Text = "Razón de Cita menos Frecuente";
            this.BtnRazonMenFrec.UseVisualStyleBackColor = false;
            this.BtnRazonMenFrec.Click += new System.EventHandler(this.BtnRazonMenFrec_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.lblPreview.Location = new System.Drawing.Point(1204, 103);
            this.lblPreview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(207, 35);
            this.lblPreview.TabIndex = 47;
            this.lblPreview.Tag = "1";
            this.lblPreview.Text = "Vista Previa";
            this.lblPreview.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPreview.Visible = false;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.BtnImprimir.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.BtnImprimir.Location = new System.Drawing.Point(588, 620);
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(219, 55);
            this.BtnImprimir.TabIndex = 48;
            this.BtnImprimir.Tag = "1";
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Visible = false;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.BtnGenerar.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.BtnGenerar.Location = new System.Drawing.Point(1193, 620);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(219, 55);
            this.BtnGenerar.TabIndex = 49;
            this.BtnGenerar.Tag = "1";
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Visible = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.lblFecha.Location = new System.Drawing.Point(953, 665);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(95, 35);
            this.lblFecha.TabIndex = 51;
            this.lblFecha.Tag = "1";
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFecha.Visible = false;
            // 
            // dateTime1
            // 
            this.dateTime1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.dateTime1.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime1.Location = new System.Drawing.Point(815, 635);
            this.dateTime1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(159, 26);
            this.dateTime1.TabIndex = 50;
            this.dateTime1.Tag = "1";
            this.dateTime1.Visible = false;
            // 
            // dateTime2
            // 
            this.dateTime2.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.dateTime2.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime2.Location = new System.Drawing.Point(1027, 635);
            this.dateTime2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTime2.Name = "dateTime2";
            this.dateTime2.Size = new System.Drawing.Size(159, 26);
            this.dateTime2.TabIndex = 52;
            this.dateTime2.Tag = "1";
            this.dateTime2.Visible = false;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.lblA.Location = new System.Drawing.Point(985, 628);
            this.lblA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(31, 35);
            this.lblA.TabIndex = 60;
            this.lblA.Tag = "1";
            this.lblA.Text = "a";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblA.Visible = false;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.BtnVolver.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.BtnVolver.Location = new System.Drawing.Point(265, 628);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(180, 48);
            this.BtnVolver.TabIndex = 61;
            this.BtnVolver.Tag = "1";
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Visible = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(492, 142);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 554);
            this.panel1.TabIndex = 62;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.BtnMenu.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.BtnMenu.Location = new System.Drawing.Point(36, 628);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(180, 48);
            this.BtnMenu.TabIndex = 63;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // pdfViewCita
            // 
            this.pdfViewCita.Enabled = true;
            this.pdfViewCita.Location = new System.Drawing.Point(588, 142);
            this.pdfViewCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pdfViewCita.Name = "pdfViewCita";
            this.pdfViewCita.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfViewCita.OcxState")));
            this.pdfViewCita.Size = new System.Drawing.Size(823, 441);
            this.pdfViewCita.TabIndex = 69;
            this.pdfViewCita.Tag = "1";
            this.pdfViewCita.Visible = false;
            // 
            // ReportesCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1443, 710);
            this.Controls.Add(this.pdfViewCita);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.dateTime2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dateTime1);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.BtnRazonMenFrec);
            this.Controls.Add(this.BtnRazonMasFrec);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportesCitas";
            this.Text = "ReportesCitas";
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRazonMasFrec;
        private System.Windows.Forms.Button BtnRazonMenFrec;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.DateTimePicker dateTime2;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMenu;
        private AxAcroPDFLib.AxAcroPDF pdfViewCita;
    }
}