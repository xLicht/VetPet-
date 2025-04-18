﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetPet_
{
    public partial class ListadoMascotas : Form
    {
        private float originalWidth;
        private float originalHeight;
        private Dictionary<Control, (float width, float height, float left, float top, float fontSize)> controlInfo = new Dictionary<Control, (float width, float height, float left, float top, float fontSize)>();

        private Form1 parentForm;


        public ListadoMascotas()
        {
            InitializeComponent();
            this.Load += ListadoMascotas_Load;       // Evento Load
            this.Resize += ListadoMascotas_Resize;   // Evento Resize

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 128); // Azul oscuro
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255); // Blanco
            dataGridView1.EnableHeadersVisualStyles = false; // Para que los cambios se apliquen



        }

        public ListadoMascotas(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;  // Guardamos la referencia de Form1
        }

        private void ListadoMascotas_Load(object sender, EventArgs e)
        {
            // Guardar el tamaño original del formulario
            originalWidth = this.ClientSize.Width;
            originalHeight = this.ClientSize.Height;

            // Guardar información original de cada control
            foreach (Control control in this.Controls)
            {
                controlInfo[control] = (control.Width, control.Height, control.Left, control.Top, control.Font.Size);
            }
        }
 
        private void ListadoMascotas_Resize(object sender, EventArgs e)
        {
            // Calcular el factor de escala
            float scaleX = this.ClientSize.Width / originalWidth;
            float scaleY = this.ClientSize.Height / originalHeight;

            foreach (Control control in this.Controls)
            {
                if (controlInfo.ContainsKey(control))
                {
                    var info = controlInfo[control];

                    // Ajustar las dimensiones
                    control.Width = (int)(info.width * scaleX);
                    control.Height = (int)(info.height * scaleY);
                    control.Left = (int)(info.left * scaleX);
                    control.Top = (int)(info.top * scaleY);

                    // Ajustar el tamaño de la fuente
                    control.Font = new Font(control.Font.FontFamily, info.fontSize * Math.Min(scaleX, scaleY));
                }
            }
        }


    }
}
