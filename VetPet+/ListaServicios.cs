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
    public partial class ListaServicios : Form
    {
        private float originalWidth;
        private float originalHeight;
        private Dictionary<Control, (float width, float height, float left, float top, float fontSize)> controlInfo = new Dictionary<Control, (float width, float height, float left, float top, float fontSize)>();

        private Form1 parentForm;
        public ListaServicios()
        {
            InitializeComponent();
            this.Load += ListaServicios_Load;       // Evento Load
            this.Resize += ListaServicios_Resize;
        }
        public ListaServicios(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;  // Guardamos la referencia del formulario principal
        }

        private void ListaServicios_Load(object sender, EventArgs e)
        {
            // Guardar el tamaño original del formulario
            originalWidth = this.ClientSize.Width;
            originalHeight = this.ClientSize.Height;
            dataGridView1.Rows.Add("Cirugias", "Medico", "Veterinario");
            dataGridView1.Rows.Add("Rayos X", "Medico", "Veterinario");
            dataGridView1.Rows.Add("Pruebas de Laboratorio", "Medico", "Veterinario");
            dataGridView1.Rows.Add("Ultrasonidos", "Medico", "Veterinario");
            dataGridView1.Rows.Add("Vacunas", "Medico", "Veterinario");
            dataGridView1.Rows.Add("Radiografías", "Medico", "Veterinario");
            // Guardar información original de cada control
            foreach (Control control in this.Controls)
            {
                controlInfo[control] = (control.Width, control.Height, control.Left, control.Top, control.Font.Size);
            }
        }

        private void ListaServicios_Resize(object sender, EventArgs e)
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

        private void BtnRegresar_Click_1(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new MenuServicios(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioProductos
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new AgregarServicios(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioProductos
        }

        private void BtnTipoDeServicios_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new ModificarServicios(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioProductos
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Asegúrate de que el clic sea dentro de los límites válidos
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Aquí puedes obtener el valor de la celda clickeada
                string valorCelda = cell.Value.ToString();

                // Dependiendo del valor o cualquier otro criterio, puedes abrir el formulario correspondiente
                switch (valorCelda)
                {
                    case "Cirugias":
                        parentForm.formularioHijo(new ListaCirugias(parentForm));
                        break;
                    case "Rayos X":
                        parentForm.formularioHijo(new ListaRayosX(parentForm));
                        break;
                    case "Pruebas de Laboratorio":
                        parentForm.formularioHijo(new ListaPLab(parentForm));
                        break;
                    case "Ultrasonidos":
                        parentForm.formularioHijo(new ListaUltrasonidos(parentForm));
                        break;
                    case "Vacunas":
                        parentForm.formularioHijo(new ListaVacunas(parentForm));
                        break;
                    case "Radiografías":
                        parentForm.formularioHijo(new ListaRadiografias(parentForm));
                        break;
                    // Agrega más casos según los tipos de servicio que tengas
                    default:
                        MessageBox.Show("No se encontró formulario para este servicio.");
                        break;
                }
            }
        }
    }
}
