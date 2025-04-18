﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetPet_.Angie.Mascotas;

namespace VetPet_.Angie.Ventas
{
    public partial class MenuMascotas : Form
    {
        private float originalWidth;
        private float originalHeight;
        private Dictionary<Control, (float width, float height, float left, float top, float fontSize)> controlInfo = new Dictionary<Control, (float width, float height, float left, float top, float fontSize)>();
        private Mismetodos mismetodos;

        private Form1 parentForm;
        public MenuMascotas(Form1 parent)
        {
            InitializeComponent();
            this.Load += MenuMascotas_Load;       // Evento Load
            this.Resize += MenuMascotas_Resize;   // Evento Resize

            parentForm = parent;  // Guardamos la referencia de Form
        }

        private void MenuMascotas_Load(object sender, EventArgs e)
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

        private void MenuMascotas_Resize(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new MascotasListado (parentForm)); // Pasamos la referencia de Form1 a 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new MascotasVerSensibilidades(parentForm)); // Pasamos la referencia de Form1 a 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new MascotasVerEspecies(parentForm)); // Pasamos la referencia de Form1 a 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new MascotasVerRazas(parentForm)); // Pasamos la referencia de Form1 a 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new MascotasVerEnfermedades(parentForm)); // Pasamos la referencia de Form1 a 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new MascotasVerAlergias(parentForm)); // Pasamos la referencia de Form1 a 
        }
    }
}
