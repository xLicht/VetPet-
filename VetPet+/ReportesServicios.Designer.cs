﻿namespace VetPet_
{
    partial class ReportesServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesServicios));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCirgMasRea = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCirgMenRea = new System.Windows.Forms.Button();
            this.BtnServMasFrec = new System.Windows.Forms.Button();
            this.BtnServMenFrec = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.dateTime2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.pdfViewServ = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewServ)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(938, 106);
            this.label1.TabIndex = 25;
            this.label1.Text = "Reportes: Servicios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnCirgMasRea
            // 
            this.BtnCirgMasRea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.BtnCirgMasRea.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCirgMasRea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.BtnCirgMasRea.Location = new System.Drawing.Point(53, 142);
            this.BtnCirgMasRea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCirgMasRea.Name = "BtnCirgMasRea";
            this.BtnCirgMasRea.Size = new System.Drawing.Size(349, 81);
            this.BtnCirgMasRea.TabIndex = 26;
            this.BtnCirgMasRea.Tag = "1";
            this.BtnCirgMasRea.Text = "Cirugías más Realizadas";
            this.BtnCirgMasRea.UseVisualStyleBackColor = false;
            this.BtnCirgMasRea.Click += new System.EventHandler(this.BtnCirgMasRea_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(1204, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 35);
            this.label2.TabIndex = 49;
            this.label2.Tag = "1";
            this.label2.Text = "Vista Previa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Visible = false;
            // 
            // BtnCirgMenRea
            // 
            this.BtnCirgMenRea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.BtnCirgMenRea.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCirgMenRea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.BtnCirgMenRea.Location = new System.Drawing.Point(53, 254);
            this.BtnCirgMenRea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCirgMenRea.Name = "BtnCirgMenRea";
            this.BtnCirgMenRea.Size = new System.Drawing.Size(349, 81);
            this.BtnCirgMenRea.TabIndex = 50;
            this.BtnCirgMenRea.Tag = "1";
            this.BtnCirgMenRea.Text = "Cirugías menos Realizadas";
            this.BtnCirgMenRea.UseVisualStyleBackColor = false;
            this.BtnCirgMenRea.Click += new System.EventHandler(this.BtnCirgMenRea_Click);
            // 
            // BtnServMasFrec
            // 
            this.BtnServMasFrec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.BtnServMasFrec.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServMasFrec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.BtnServMasFrec.Location = new System.Drawing.Point(53, 366);
            this.BtnServMasFrec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnServMasFrec.Name = "BtnServMasFrec";
            this.BtnServMasFrec.Size = new System.Drawing.Size(349, 81);
            this.BtnServMasFrec.TabIndex = 51;
            this.BtnServMasFrec.Tag = "1";
            this.BtnServMasFrec.Text = "Servicios más Frecuentes";
            this.BtnServMasFrec.UseVisualStyleBackColor = false;
            this.BtnServMasFrec.Click += new System.EventHandler(this.BtnServMasFrec_Click);
            // 
            // BtnServMenFrec
            // 
            this.BtnServMenFrec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.BtnServMenFrec.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServMenFrec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.BtnServMenFrec.Location = new System.Drawing.Point(53, 478);
            this.BtnServMenFrec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnServMenFrec.Name = "BtnServMenFrec";
            this.BtnServMenFrec.Size = new System.Drawing.Size(349, 81);
            this.BtnServMenFrec.TabIndex = 52;
            this.BtnServMenFrec.Tag = "1";
            this.BtnServMenFrec.Text = "Servicios menos Frecuentes";
            this.BtnServMenFrec.UseVisualStyleBackColor = false;
            this.BtnServMenFrec.Click += new System.EventHandler(this.BtnServMenFrec_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.button5.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.button5.Location = new System.Drawing.Point(588, 620);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 55);
            this.button5.TabIndex = 53;
            this.button5.Tag = "1";
            this.button5.Text = "Imprimir";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
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
            this.BtnGenerar.TabIndex = 54;
            this.BtnGenerar.Tag = "1";
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Visible = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(953, 665);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 35);
            this.label3.TabIndex = 56;
            this.label3.Tag = "1";
            this.label3.Text = "Fecha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Visible = false;
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
            this.dateTime1.TabIndex = 55;
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
            this.dateTime2.TabIndex = 57;
            this.dateTime2.Tag = "1";
            this.dateTime2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(985, 628);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 35);
            this.label4.TabIndex = 58;
            this.label4.Tag = "1";
            this.label4.Text = "a";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Visible = false;
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
            this.BtnVolver.TabIndex = 66;
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
            this.panel1.TabIndex = 65;
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
            this.BtnMenu.TabIndex = 67;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // pdfViewServ
            // 
            this.pdfViewServ.Enabled = true;
            this.pdfViewServ.Location = new System.Drawing.Point(588, 142);
            this.pdfViewServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pdfViewServ.Name = "pdfViewServ";
            this.pdfViewServ.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfViewServ.OcxState")));
            this.pdfViewServ.Size = new System.Drawing.Size(823, 441);
            this.pdfViewServ.TabIndex = 68;
            this.pdfViewServ.Tag = "1";
            this.pdfViewServ.Visible = false;
            // 
            // ReportesServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1443, 710);
            this.Controls.Add(this.pdfViewServ);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTime2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTime1);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnServMenFrec);
            this.Controls.Add(this.BtnServMasFrec);
            this.Controls.Add(this.BtnCirgMenRea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCirgMasRea);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportesServicios";
            this.Text = "ReportesServicios";
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewServ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCirgMasRea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCirgMenRea;
        private System.Windows.Forms.Button BtnServMasFrec;
        private System.Windows.Forms.Button BtnServMenFrec;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.DateTimePicker dateTime2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMenu;
        private AxAcroPDFLib.AxAcroPDF pdfViewServ;
    }
}