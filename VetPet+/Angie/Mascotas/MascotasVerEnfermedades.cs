﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetPet_.Angie.Ventas;

namespace VetPet_.Angie.Mascotas
{
    public partial class MascotasVerEnfermedades : Form
    {
        private float originalWidth;
        private float originalHeight;
        private Dictionary<Control, (float width, float height, float left, float top, float fontSize)> controlInfo = new Dictionary<Control, (float width, float height, float left, float top, float fontSize)>();
        private Mismetodos mismetodos;
        string tipo = "";
        private Form1 parentForm;
        public MascotasVerEnfermedades(Form1 parent)
        {
            InitializeComponent();
            this.Load += MascotasVerEnfermedades_Load;       // Evento Load
            this.Resize += MascotasVerEnfermedades_Resize;   // Evento Resize
            PersonalizarDataGridView();
            parentForm = parent;  // Guardamos la referencia de Form
        }
        private void MascotasVerEnfermedades_Load(object sender, EventArgs e)
        {
            // Guardar el tamaño original del formulario
            originalWidth = this.ClientSize.Width;
            originalHeight = this.ClientSize.Height;

            // Guardar información original de cada control
            foreach (Control control in this.Controls)
            {
                controlInfo[control] = (control.Width, control.Height, control.Left, control.Top, control.Font.Size);
            }
            foreach (Control control in this.Controls)
            {
                controlInfo[control] = (control.Width, control.Height, control.Left, control.Top, control.Font.Size);
            }
            try
            {
                // Crear instancia de Mismetodos
                mismetodos = new Mismetodos();

                // Abrir conexión
                mismetodos.AbrirConexion();

                // Consulta SQL con nombres personalizados
                string query = @"
                SELECT 
                    idEnfermedad, 
                    nombre AS [Nombre], 
                    descripcion AS [Descripción de Enfermedad] 
                FROM Enfermedad
                WHERE estado <> 'D'";

                // Usar `using` para asegurar la correcta liberación de recursos
                using (SqlCommand comando = new SqlCommand(query, mismetodos.GetConexion()))
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    // Crear un DataTable y llenar los datos
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    // Asignar el DataTable al DataGridView
                    dataGridView1.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                // Manejar el error si ocurre algún problema
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión al finalizar
                mismetodos.CerrarConexion();
                dataGridView1.Columns["idEnfermedad"].Visible = false; // Oculta la columna
            }

        }

        private void MascotasVerEnfermedades_Resize(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new MascotasAgregarEnfermedad(parentForm, tipo)); // Pasamos la referencia de Form1 a
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tipo = "Raza";
            parentForm.formularioHijo(new MascotasAgregarEnfermedad(parentForm, tipo)); // Pasamos la referencia de Form1 a
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tipo = "Especie";
            parentForm.formularioHijo(new MascotasAgregarEnfermedad(parentForm, tipo)); // Pasamos la referencia de Form1 a
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new MenuMascotas(parentForm)); // Pasamos la referencia de Form1 a
        }
        public void PersonalizarDataGridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None; // Elimina bordes
            dataGridView1.BackgroundColor = Color.White; // Fondo blanco

            // Alternar colores de filas
            dataGridView1.DefaultCellStyle.BackColor = Color.White;

            // Color de la selección
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Encabezados más elegantes
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightPink;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // Bordes y alineación
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ajustar el alto de los encabezados
            dataGridView1.ColumnHeadersHeight = 30;

            // Autoajustar el tamaño de las columnas
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener el idAlergia de la fila seleccionada
                    int idEnfermedad = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idEnfermedad"].Value);

                    // Pasar el idAlergia al nuevo formulario
                    parentForm.formularioHijo(new MascotasVerEnfermedad(parentForm, idEnfermedad));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
    }
}

