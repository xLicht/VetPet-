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
    public partial class AlmacenInventarioMedicamentos : Form
    {
        private float originalWidth;
        private float originalHeight;
        private Dictionary<Control, (float width, float height, float left, float top, float fontSize)> controlInfo = new Dictionary<Control, (float width, float height, float left, float top, float fontSize)>();

        private Form1 parentForm;

        public AlmacenInventarioMedicamentos()
        {
            InitializeComponent();
            this.Load += AlmacenInventarioMedicamentos_Load;       // Evento Load
            this.Resize += AlmacenInventarioMedicamentos_Resize;   // Evento Resize
        }
        public AlmacenInventarioMedicamentos(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;  // Guardamos la referencia de Form1
        }

        private void AlmacenInventarioMedicamentos_Load(object sender, EventArgs e)
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

        private void AlmacenInventarioMedicamentos_Resize(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new AlmacenAgregarMedicamento(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioAgregarProducto
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new AlmacenMenu(parentForm)); // Pasamos la referencia de Form1 a 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {         
            if (e.RowIndex >= 0)
            {
                string nombre = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();

                // Llamar al formulario de opciones
                using (var opcionesForm = new AlmacenAvisoVerOModificar(nombre))
                {
                    if (opcionesForm.ShowDialog() == DialogResult.OK)
                    {
                        if (opcionesForm.Resultado == "Modificar")
                        {
                            parentForm.formularioHijo(new AlmacenModificarMedicamento(parentForm)); // Pasamos la referencia de Form1 a 
                        }
                        if (opcionesForm.Resultado == "Salir")
                        {
                            parentForm.formularioHijo(new AlmacenInventarioMedicamentos(parentForm)); // Pasamos la referencia de Form1 a 
                        }
                        else if (opcionesForm.Resultado == "Ver")
                        {
                           parentForm.formularioHijo(new AlmacenVerMedicamento(parentForm)); // Pasamos la referencia de Form1 a 
                        }
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
