﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VetPet_
{
    public partial class VeterianiaGestionarHistorialM : Form
    {
        private float anchoOriginal;
        private float alturaOriginal;
        private Dictionary<Control, (float width, float height, float left, float top, float fontSize)> controlInfo = new Dictionary<Control, (float width, float height, float left, float top, float fontSize)>();
        private Form1 parentForm;
        public VeterianiaGestionarHistorialM(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;  // Guardamos la referencia del formulario principal
            this.Load += VeterianiaGestionarHistorialM_Load;       // Evento Load
            this.Resize += VeterianiaGestionarHistorialM_Resize;   // Evento Resize
            this.Controls.SetChildIndex(pictureBox1, 0); // Índice 0 = Capa superior
        }

        private void VeterianiaGestionarHistorialM_Load(object sender, EventArgs e)
        {
            // Guardar el tamaño original del formulario
            anchoOriginal = this.ClientSize.Width;
            alturaOriginal = this.ClientSize.Height;

            // Guardar información original de cada control
            foreach (Control control in this.Controls)
            {
                controlInfo[control] = (control.Width, control.Height, control.Left, control.Top, control.Font.Size);
            }
        }

        private void VeterianiaGestionarHistorialM_Resize(object sender, EventArgs e)
        {
            // Calcular el factor de escala
            float escalaX = this.ClientSize.Width / anchoOriginal;
            float escalaY = this.ClientSize.Height / alturaOriginal;

            foreach (Control control in this.Controls)
            {
                if (controlInfo.ContainsKey(control))
                {
                    var info = controlInfo[control];

                    // Ajustar las dimensiones
                    control.Width = (int)(info.width * escalaX);
                    control.Height = (int)(info.height * escalaY);
                    control.Left = (int)(info.left * escalaX);
                    control.Top = (int)(info.top * escalaY);

                    // Ajustar el tamaño de la fuente
                    control.Font = new Font(control.Font.FontFamily, info.fontSize * Math.Min(escalaX, escalaY));
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new VeterinariaModificarHistorial(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioProductos
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new CitasMascota(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioProductos
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }
    }
}
