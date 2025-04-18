﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        int idDueño = DueMascotadeDue.DatoEmpleadoGlobal;

        public MascotasAgregarMascota(Form1 parent)
        {
            InitializeComponent();
            this.Load += MascotasAgregarMascota_Load;       // Evento Load
            this.Resize += MascotasAgregarMascota_Resize;   // Evento Resize
            comboBox1.KeyDown += comboBox1_KeyDown;                                        
            parentForm = parent;  // Guardamos la referencia de Form1
            mismetodos = new Mismetodos();

            CargarDatos();

        }
        private void CargarDatos()
        {
            try
            {
                mismetodos.AbrirConexion();

                //string querySens = "SELECT nombre FROM Sensibilidad ORDER BY nombre";
                //using (SqlCommand comandoSens = new SqlCommand(querySens, mismetodos.GetConexion()))
                //{
                //    using (SqlDataReader readerSens = comandoSens.ExecuteReader())
                //    {
                //        listBox1.Items.Clear();
                //        while (readerSens.Read())
                //        {
                //            listBox1.Items.Add(readerSens["nombre"].ToString());
                //        }
                //    }
                //}
                string queryPersona = "SELECT nombre FROM Persona ORDER BY nombre";
                using (SqlCommand comando = new SqlCommand(queryPersona, mismetodos.GetConexion()))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        comboBox1.Items.Clear(); // Se limpia antes de agregar datos
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["nombre"].ToString());
                        }
                    }
                }

                // 🔹 Cargar Especies
                string queryEsp = "SELECT nombre FROM Especie ORDER BY nombre";
                using (SqlCommand comandoEsp = new SqlCommand(queryEsp, mismetodos.GetConexion()))
                {
                    using (SqlDataReader readerEsp = comandoEsp.ExecuteReader())
                    {
                        comboBox2.Items.Clear(); // Se limpia antes de agregar datos
                        while (readerEsp.Read())
                        {
                            comboBox2.Items.Add(readerEsp["nombre"].ToString());
                        }
                    }
                }

                // 🔹 Cargar Razas
                string queryRazas = "SELECT nombre FROM Raza ORDER BY nombre";
                using (SqlCommand comandoRazas = new SqlCommand(queryRazas, mismetodos.GetConexion()))
                {
                    using (SqlDataReader readerRazas = comandoRazas.ExecuteReader())
                    {
                        comboBox3.Items.Clear(); // Se limpia antes de agregar datos
                        while (readerRazas.Read())
                        {
                            comboBox3.Items.Add(readerRazas["nombre"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error");
            }
            finally
            {
                mismetodos.CerrarConexion();
            }
        }
        private void InsertarMascota()
        {
            try
            {
                mismetodos.AbrirConexion();

                // Obtener los datos de los controles
                string nombreMascota = textBox1.Text.Trim();
                string especie = comboBox2.SelectedItem?.ToString()?.Trim();
                string raza = comboBox3.SelectedItem?.ToString()?.Trim();
                DateTime fechaNacimiento = dateTimePicker1.Value;
                decimal peso = Convert.ToDecimal(textBox6.Text.Replace(" kg", "").Trim());
                string sexo = radioButton1.Checked ? "M" : "F"; // M para macho, F para hembra
                string esterilizado = radioButton6.Checked ? "S" : "N"; // S para sí, N para no
                string dueño = comboBox1.SelectedItem?.ToString()?.Trim();

                if (string.IsNullOrEmpty(nombreMascota) || string.IsNullOrEmpty(dueño) || string.IsNullOrEmpty(especie) || string.IsNullOrEmpty(raza))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                // Obtener idPersona
                int idPersona;
                string queryPersona = "SELECT idPersona FROM Persona WHERE nombre = @nombre";
                using (SqlCommand cmd = new SqlCommand(queryPersona, mismetodos.GetConexion()))
                {
                    cmd.Parameters.AddWithValue("@nombre", dueño);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idPersona = Convert.ToInt32(result);
                    }
                    else
                    {
                        // Insertar persona si no existe
                        string insertPersona = "INSERT INTO Persona (nombre) OUTPUT INSERTED.idPersona VALUES (@nombre)";
                        using (SqlCommand insertCmd = new SqlCommand(insertPersona, mismetodos.GetConexion()))
                        {
                            insertCmd.Parameters.AddWithValue("@nombre", dueño);
                            idPersona = (int)insertCmd.ExecuteScalar();
                        }
                    }
                }

                // Insertar la mascota (SIN idMascota, porque es IDENTITY)
                string insertMascota = @"
            INSERT INTO Mascota (nombre, esterilizado, muerto, peso, fechaNacimiento, sexo, idRaza, 
                                 idEspecie, idPersona, fechaRegistro) 
            VALUES (
                @nombreMascota, @esterilizado, 'N', @peso, @fechaNacimiento, @sexo, 
                (SELECT idRaza FROM Raza WHERE nombre = @raza), 
                (SELECT idEspecie FROM Especie WHERE nombre = @especie), 
                @idPersona, GETDATE()
            );
            SELECT SCOPE_IDENTITY();"; // Obtiene el último ID insertado

                int idMascota;
                using (SqlCommand cmd = new SqlCommand(insertMascota, mismetodos.GetConexion()))
                {
                    cmd.Parameters.AddWithValue("@nombreMascota", nombreMascota);
                    cmd.Parameters.AddWithValue("@esterilizado", esterilizado);
                    cmd.Parameters.AddWithValue("@peso", peso);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    cmd.Parameters.AddWithValue("@raza", raza);
                    cmd.Parameters.AddWithValue("@especie", especie);
                    cmd.Parameters.AddWithValue("@idPersona", idPersona);

                    // Obtener el idMascota recién insertado
                    idMascota = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Insertar sensibilidades
                //if (!string.IsNullOrEmpty(richTextBox1.Text) && richTextBox1.Text != "Sin sensibilidades registradas")
                //{
                //    string[] sensibilidadesArray = richTextBox1.Text.Split(new[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                //    foreach (string sensibilidad in sensibilidadesArray)
                //    {
                //        string sensibilidadTrim = sensibilidad.Trim();
                //        if (string.IsNullOrEmpty(sensibilidadTrim)) continue;

                //        // Obtener idSensibilidad
                //        int idSensibilidad;
                //        string querySensibilidad = "SELECT idSensibilidad FROM Sensibilidad WHERE nombre = @nombre";
                //        using (SqlCommand cmd = new SqlCommand(querySensibilidad, mismetodos.GetConexion()))
                //        {
                //            cmd.Parameters.AddWithValue("@nombre", sensibilidadTrim);
                //            object result = cmd.ExecuteScalar();
                //            if (result != null)
                //            {
                //                idSensibilidad = Convert.ToInt32(result);
                //            }
                //            else
                //            {
                //                // Insertar sensibilidad si no existe
                //                string insertSensibilidad = "INSERT INTO Sensibilidad (nombre) OUTPUT INSERTED.idSensibilidad VALUES (@nombre)";
                //                using (SqlCommand insertCmd = new SqlCommand(insertSensibilidad, mismetodos.GetConexion()))
                //                {
                //                    insertCmd.Parameters.AddWithValue("@nombre", sensibilidadTrim);
                //                    idSensibilidad = (int)insertCmd.ExecuteScalar();
                //                }
                //            }
                //        }

                //        // Insertar relación en Mascota_Sensibilidad
                //        string insertMascotaSensibilidad = "INSERT INTO Mascota_Sensibilidad (idMascota, idSensibilidad) VALUES (@idMascota, @idSensibilidad)";
                //        using (SqlCommand cmd = new SqlCommand(insertMascotaSensibilidad, mismetodos.GetConexion()))
                //        {
                //            cmd.Parameters.AddWithValue("@idMascota", idMascota);
                //            cmd.Parameters.AddWithValue("@idSensibilidad", idSensibilidad);
                //            cmd.ExecuteNonQuery();
                //        }
                //    }
                //}

                MessageBox.Show("Mascota registrada correctamente.", "Éxito");
                parentForm.formularioHijo(new MascotasListado(parentForm)); // Pasamos la referencia de Form1 a 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la mascota: " + ex.Message, "Error");
            }
            finally
            {
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
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si la tecla presionada es "Enter"
            if (e.KeyCode == Keys.Enter)
            {
                // Obtener el texto ingresado por el usuario
                string nuevaEspecie = ValidarYFormatearTexto(comboBox2.Text);

                // Verificar si la especie ya existe en la base de datos
                if (!mismetodos.Existe("SELECT COUNT(*) FROM especie WHERE nombre = @nombre", nuevaEspecie))
                {
                    // Preguntar al usuario si desea crear la nueva especie
                    DialogResult result = MessageBox.Show(
                        $"La especie '{nuevaEspecie}' no existe. ¿Desea crearla?",
                        "Crear nueva especie",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    // Si el usuario elige "Sí", insertar la nueva especie en la base de datos
                    if (result == DialogResult.Yes)
                    {
                        mismetodos.Insertar("INSERT INTO especie (nombre) VALUES (@nombre)", nuevaEspecie);
                        MessageBox.Show("Especie creada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mismetodos.ActualizarComboBox(comboBox1, "SELECT nombre FROM especie", "nombre");
                        CargarDatos();
                    }
                }
                else
                {

                }
            }
        }
        public string ValidarYFormatearTexto(string texto)
        {
            // Verificar si el texto está vacío o es nulo
            if (string.IsNullOrEmpty(texto))
                return texto;

            // Validar que el texto contenga solo letras (incluyendo acentos y espacios)
            if (!Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                throw new ArgumentException("El texto solo puede contener letras y espacios.");
            }

            // Formatear el texto: primera letra en mayúscula y el resto en minúscula
            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si la tecla presionada es "Enter"
            if (e.KeyCode == Keys.Enter)
            {
                // Obtener el texto ingresado por el usuario

                string nuevaEspecie = ValidarYFormatearTexto(comboBox3.Text);

                // Verificar si la especie ya existe en la base de datos
                if (!mismetodos.Existe("SELECT COUNT(*) FROM raza WHERE nombre = @nombre", nuevaEspecie))
                {
                    // Preguntar al usuario si desea crear la nueva especie
                    DialogResult result = MessageBox.Show(
                        $"La raza '{nuevaEspecie}' no existe. ¿Desea crearla?",
                        "Crear nueva raza",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    // Si el usuario elige "Sí", insertar la nueva especie en la base de datos
                    if (result == DialogResult.Yes)
                    {
                        //parentForm.formularioHijo(new MascotasAgregarRaza(parentForm, nuevaEspecie));
                    }
                }
                else
                {

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InsertarMascota();
        }

        private void button3_Click(object sender, EventArgs e)
        {         
            if (idDueño != 0)
            {
                int idEmpleadoSeleccionado = Convert.ToInt32(idDueño);
                DueMascotadeDue formularioHijo = new DueMascotadeDue(parentForm, "DueConsultarDue");
                formularioHijo.DatoEmpleado = idEmpleadoSeleccionado;
                parentForm.formularioHijo(formularioHijo);
            }
            else
            {
                parentForm.formularioHijo(new MascotasListado(parentForm)); // Pasamos la referencia de Form1 a 
            }
        }
    }
}
