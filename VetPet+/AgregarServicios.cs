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
    public partial class AgregarServicios : Form
    {
        private float originalWidth;
        private float originalHeight;
        private Dictionary<Control, (float width, float height, float left, float top, float fontSize)> controlInfo = new Dictionary<Control, (float width, float height, float left, float top, float fontSize)>();

        private Form1 parentForm;
        public AgregarServicios()
        {
            InitializeComponent();
            this.Load += AgregarServicios_Load;       // Evento Load
            this.Resize += AgregarServicios_Resize;
        }
        public AgregarServicios(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;  // Guardamos la referencia del formulario principal
        }

        private void AgregarServicios_Load(object sender, EventArgs e)
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

        private void AgregarServicios_Resize(object sender, EventArgs e)
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

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new MenuServicios(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioProductos
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Logica de Agregado
        }

        private void BtnModificarServicios_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new ModificarServicios(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioProductos
        }
    }
}
