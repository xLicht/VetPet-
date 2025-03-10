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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VetPet_.Angie.Mascotas
{
    public partial class MascotasAgregarMascota : Form
    {
        private float originalWidth;
        private float originalHeight;
        private Dictionary<Control, (float width, float height, float left, float top, float fontSize)> controlInfo = new Dictionary<Control, (float width, float height, float left, float top, float fontSize)>();
        private Mismetodos mismetodos = new Mismetodos();
        private Form1 parentForm;

        public MascotasAgregarMascota(Form1 parent)
        {
            InitializeComponent();
            this.Load += MascotasAgregarMascota_Load;       // Evento Load
            this.Resize += MascotasAgregarMascota_Resize;   // Evento Resize
                                                            //comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            parentForm = parent;  // Guardamos la referencia de Form1
            mismetodos = new Mismetodos();
            CargarDetallesMascota();
        }
        private void CargarDetallesMascota()
        {
            string query = @"
                      SELECT 
                 Mascota.nombre AS Nombre,
                 Especie.nombre AS Especie,
                 Raza.nombre AS Raza,
                 Mascota.fechaNacimiento AS FechaNacimiento,
                 Mascota.peso AS Peso,
                 Mascota.sexo AS Sexo,
                 Mascota.esterilizado AS Esterilizado,
                 STRING_AGG(Sensibilidad.nombre, ', ') AS Sensibilidades
             FROM 
                 Mascota
             INNER JOIN 
                 Especie ON Mascota.idEspecie = Especie.idEspecie
             INNER JOIN 
                 Raza ON Mascota.idRaza = Raza.idRaza
             LEFT JOIN 
                 Mascota_Sensibilidad ON Mascota.idMascota = Mascota_Sensibilidad.idMascota
             LEFT JOIN 
                 Sensibilidad ON Mascota_Sensibilidad.idSensibilidad = Sensibilidad.idSensibilidad
            WHERE Mascota.idMascota = @idMascota
             GROUP BY 
                 Mascota.nombre, Especie.nombre, Raza.nombre, Mascota.fechaNacimiento, Mascota.peso, Mascota.sexo, Mascota.esterilizado;
            ";
            try
            {
                // Abrir la conexión
                mismetodos.AbrirConexion();

                // Cargar las especies
                string queryEsp = "SELECT nombre FROM Persona ORDER BY nombre";
                using (SqlCommand comandoEsp = new SqlCommand(queryEsp, mismetodos.GetConexion()))
                {
                    using (SqlDataReader readerEsp = comandoEsp.ExecuteReader())
                    {
                        // Limpiar el ComboBox antes de agregar nuevos elementos
                        comboBox1.Items.Clear();

                        while (readerEsp.Read())
                        {
                            comboBox1.Items.Add(readerEsp["nombre"].ToString());
                        }
                    }
                }

                using (SqlCommand comando = new SqlCommand(query, mismetodos.GetConexion()))
                {
                    // Ejecutar la consulta y leer los datos
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime fechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);

                            // Calcular la edad de la mascota
                            int edad = DateTime.Now.Year - fechaNacimiento.Year;
                            if (DateTime.Now < fechaNacimiento.AddYears(edad)) edad--;

                            // Asignar valores a los controles del formulario
                            textBox1.Text = reader["Nombre"].ToString();
                            textBox2.Text = reader["Especie"].ToString();
                            textBox3.Text = reader["Raza"].ToString();
                            textBox5.Text = reader["FechaNacimiento"].ToString();
                            textBox6.Text = $"{reader["Peso"]} kg";
                            textBox4.Text = $"{edad} años";

                            // Sexo
                            string sexo = reader["Sexo"].ToString();
                            if (sexo == "M") radioButton1.Checked = true; // Masculino
                            if (sexo == "F") radioButton2.Checked = true; // Femenino

                            // Esterilizado
                            string esterilizado = reader["Esterilizado"].ToString();
                            if (esterilizado == "S") radioButton6.Checked = true; // Sí
                            if (esterilizado == "N") radioButton5.Checked = true; // No

                            // Sensibilidades
                            string sensibilidades = reader["Sensibilidades"].ToString();
                            richTextBox1.Text = string.IsNullOrEmpty(sensibilidades)
                                ? "Sin sensibilidades registradas"
                                : sensibilidades;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron detalles para esta mascota.", "Información");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                // Cerrar la conexión al finalizar
                mismetodos.CerrarConexion();
            }
        }
        private void MascotasAgregarMascota_Load(object sender, EventArgs e)
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

        private void MascotasAgregarMascota_Resize(object sender, EventArgs e)
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
