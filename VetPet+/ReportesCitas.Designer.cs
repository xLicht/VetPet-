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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pdfViewCita = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 85);
            this.label1.TabIndex = 25;
            this.label1.Text = "Reportes: Citas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.button1.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.button1.Location = new System.Drawing.Point(40, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 66);
            this.button1.TabIndex = 26;
            this.button1.Text = "Razón de Cita más Frecuente";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.button2.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.button2.Location = new System.Drawing.Point(40, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 66);
            this.button2.TabIndex = 27;
            this.button2.Text = "Razón de Cita menos Frecuente";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pdfViewCita
            // 
            this.pdfViewCita.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pdfViewCita.CurrentIndex = -1;
            this.pdfViewCita.CurrentPageHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.pdfViewCita.Document = null;
            this.pdfViewCita.FormHighlightColor = System.Drawing.Color.Transparent;
            this.pdfViewCita.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            this.pdfViewCita.LoadingIconText = "Loading...";
            this.pdfViewCita.Location = new System.Drawing.Point(441, 115);
            this.pdfViewCita.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            this.pdfViewCita.Name = "pdfViewCita";
            this.pdfViewCita.OptimizedLoadThreshold = 1000;
            this.pdfViewCita.Padding = new System.Windows.Forms.Padding(10);
            this.pdfViewCita.PageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pdfViewCita.PageAutoDispose = true;
            this.pdfViewCita.PageBackColor = System.Drawing.Color.White;
            this.pdfViewCita.PageBorderColor = System.Drawing.Color.Black;
            this.pdfViewCita.PageMargin = new System.Windows.Forms.Padding(10);
            this.pdfViewCita.PageSeparatorColor = System.Drawing.Color.Gray;
            this.pdfViewCita.RenderFlags = ((Patagames.Pdf.Enums.RenderFlags)((Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH)));
            this.pdfViewCita.ShowCurrentPageHighlight = true;
            this.pdfViewCita.ShowLoadingIcon = true;
            this.pdfViewCita.ShowPageSeparator = true;
            this.pdfViewCita.Size = new System.Drawing.Size(618, 381);
            this.pdfViewCita.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth;
            this.pdfViewCita.TabIndex = 36;
            this.pdfViewCita.TextSelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.pdfViewCita.TilesCount = 2;
            this.pdfViewCita.UseProgressiveRender = true;
            this.pdfViewCita.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            this.pdfViewCita.Zoom = 1F;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(903, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 47;
            this.label2.Text = "Vista Previa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.button3.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.button3.Location = new System.Drawing.Point(441, 504);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 45);
            this.button3.TabIndex = 48;
            this.button3.Text = "Imprimir";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.button4.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.button4.Location = new System.Drawing.Point(895, 504);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 45);
            this.button4.TabIndex = 49;
            this.button4.Text = "Descargar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ReportesCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1082, 577);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pdfViewCita);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ReportesCitas";
            this.Text = "ReportesCitas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfViewCita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}