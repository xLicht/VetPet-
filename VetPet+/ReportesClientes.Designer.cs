﻿namespace VetPet_
{
    partial class ReportesClientes: VetPet_.FormPadre
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pdfViewClient = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(891, 106);
            this.label1.TabIndex = 25;
            this.label1.Text = "Reportes: Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.button1.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.button1.Location = new System.Drawing.Point(53, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 55);
            this.button1.TabIndex = 26;
            this.button1.Text = "Dueños Frecuentes";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.button2.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.button2.Location = new System.Drawing.Point(53, 220);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 55);
            this.button2.TabIndex = 27;
            this.button2.Text = "Mascotas Frecuentes";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.button3.Font = new System.Drawing.Font("Cascadia Mono", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.button3.Location = new System.Drawing.Point(53, 299);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(380, 55);
            this.button3.TabIndex = 28;
            this.button3.Text = "Dueños menos Frecuentes";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.button4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.button4.Location = new System.Drawing.Point(53, 378);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(380, 55);
            this.button4.TabIndex = 29;
            this.button4.Text = "Mascotas menos Frecuentes";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pdfViewClient
            // 
            this.pdfViewClient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pdfViewClient.CurrentIndex = -1;
            this.pdfViewClient.CurrentPageHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.pdfViewClient.Document = null;
            this.pdfViewClient.FormHighlightColor = System.Drawing.Color.Transparent;
            this.pdfViewClient.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            this.pdfViewClient.LoadingIconText = "Loading...";
            this.pdfViewClient.Location = new System.Drawing.Point(588, 142);
            this.pdfViewClient.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pdfViewClient.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            this.pdfViewClient.Name = "pdfViewClient";
            this.pdfViewClient.OptimizedLoadThreshold = 1000;
            this.pdfViewClient.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pdfViewClient.PageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pdfViewClient.PageAutoDispose = true;
            this.pdfViewClient.PageBackColor = System.Drawing.Color.White;
            this.pdfViewClient.PageBorderColor = System.Drawing.Color.Black;
            this.pdfViewClient.PageMargin = new System.Windows.Forms.Padding(10);
            this.pdfViewClient.PageSeparatorColor = System.Drawing.Color.Gray;
            this.pdfViewClient.RenderFlags = ((Patagames.Pdf.Enums.RenderFlags)((Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH)));
            this.pdfViewClient.ShowCurrentPageHighlight = true;
            this.pdfViewClient.ShowLoadingIcon = true;
            this.pdfViewClient.ShowPageSeparator = true;
            this.pdfViewClient.Size = new System.Drawing.Size(824, 469);
            this.pdfViewClient.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth;
            this.pdfViewClient.TabIndex = 37;
            this.pdfViewClient.TextSelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.pdfViewClient.TilesCount = 2;
            this.pdfViewClient.UseProgressiveRender = true;
            this.pdfViewClient.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            this.pdfViewClient.Zoom = 1F;
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
            this.button5.TabIndex = 38;
            this.button5.Text = "Imprimir";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.button6.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.button6.Location = new System.Drawing.Point(1193, 620);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 55);
            this.button6.TabIndex = 39;
            this.button6.Text = "Descargar";
            this.button6.UseVisualStyleBackColor = false;
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
            this.label2.TabIndex = 48;
            this.label2.Text = "Vista Previa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(963, 665);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 35);
            this.label3.TabIndex = 50;
            this.label3.Text = "Fecha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(815, 635);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 26);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.dateTimePicker2.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(1026, 635);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(159, 26);
            this.dateTimePicker2.TabIndex = 58;
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
            this.label4.TabIndex = 59;
            this.label4.Text = "a";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReportesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1443, 710);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pdfViewClient);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportesClientes";
            this.Text = "ReportesClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfViewClient;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
    }
}