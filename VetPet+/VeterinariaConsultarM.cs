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
using VetPet_;
using System.Data.SqlClient;

namespace VetPet_
{
    public partial class VeterinariaConsultarM : FormPadre
    {
        public int DatoCita { get; set; }
        private conexionDaniel conexionDB = new conexionDaniel();
        public VeterinariaConsultarM(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void btnRecetar_Click(object sender, EventArgs e)
        {
            int idCitaSeleccionada = Convert.ToInt32(DatoCita);
            VeterinariaRecetar formularioHijo = new VeterinariaRecetar(parentForm);
            formularioHijo.DatoCita = idCitaSeleccionada;
            parentForm.formularioHijo(formularioHijo);


            //parentForm.formularioHijo(new VeterinariaRecetar(parentForm));
        }

        private void VeterinariaConsultarM_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Dato Recibido :" + DatoCita);
            CargarServiciosPadre();
            MostrarDatosBasicosCita();
        }
        private void MostrarDatosBasicosCita()
        {
            try
            {
                conexionDB.AbrirConexion();

                string query = @"SELECT 
                p.nombre AS NombreCliente, 
                p.apellidoP AS ApellidoPaterno, 
                p.celularPrincipal AS Telefono, 
                m.nombre AS NombreMascota, 
                e.nombre AS Especie, 
                r.nombre AS Raza, 
                m.esterilizado AS Esterilizado, 
                m.muerto AS Fallecido
            FROM Cita c
            INNER JOIN Mascota m ON c.idMascota = m.idMascota
            INNER JOIN Persona p ON m.idPersona = p.idPersona
            INNER JOIN Especie e ON m.idEspecie = e.idEspecie
            INNER JOIN Raza r ON m.idRaza = r.idRaza
            WHERE c.idCita = @idCita";

                using (SqlCommand cmd = new SqlCommand(query, conexionDB.GetConexion()))
                {
                    cmd.Parameters.AddWithValue("@idCita", DatoCita);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtNombre.Text = reader["NombreCliente"].ToString();
                        txtApellidoPat.Text = reader["ApellidoPaterno"].ToString();
                        txtTelefono.Text = reader["Telefono"].ToString();
                        txtMascota.Text = reader["NombreMascota"].ToString();
                        txtEspecie.Text = reader["Especie"].ToString();
                        txtRaza.Text = reader["Raza"].ToString();

                        cbCastrado.Checked = reader["Esterilizado"] != DBNull.Value && reader["Esterilizado"].ToString() == "S";
                        cbFallecido.Checked = reader["Fallecido"] != DBNull.Value && reader["Fallecido"].ToString() == "S";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos básicos de la cita: " + ex.Message);
            }
            finally
            {
                conexionDB.CerrarConexion();
            }
        }

        private void CargarServiciosPadre()
        {
            try
            {
                conexionDB.AbrirConexion();
                string query = @"SELECT sp.idServicioPadre, sp.nombre FROM ServicioPadre sp
                                  INNER JOIN ClaseServicio cs ON sp.idClaseServicio = cs.idClaseServicio
                                  WHERE cs.nombre <> 'Estético'";
                using (SqlCommand cmd = new SqlCommand(query, conexionDB.GetConexion()))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cbServicioP.DataSource = dt;
                    cbServicioP.DisplayMember = "nombre";
                    cbServicioP.ValueMember = "idServicioPadre";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar servicios: " + ex.Message);
            }
            finally
            {
                conexionDB.CerrarConexion();
            }
        }

        private void CargarServiciosHijos(int idServicioPadre)
        {
            string query = "SELECT nombre FROM ServicioEspecificoHijo WHERE idServicioPadre = @idServicioPadre";

            try
            {
                conexionDB.AbrirConexion();
                using (SqlCommand cmd = new SqlCommand(query, conexionDB.GetConexion()))
                {
                    cmd.Parameters.AddWithValue("@idServicioPadre", idServicioPadre);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbServicioEspecifico.Items.Clear(); // Limpiar ComboBox antes de cargar nuevos valores

                    while (reader.Read())
                    {
                        cbServicioEspecifico.Items.Add(reader["nombre"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los servicios específicos hijos: " + ex.Message);
            }
            finally
            {
                conexionDB.CerrarConexion();
            }
        }
        private void CargarServiciosNietos(int idServicioHijo)
        {
            string query = "SELECT nombre FROM ServicioEspecificoNieto WHERE idServicioEspecificoHijo = @idServicioHijo";

            try
            {
                conexionDB.AbrirConexion();
                using (SqlCommand cmd = new SqlCommand(query, conexionDB.GetConexion()))
                {
                    cmd.Parameters.AddWithValue("@idServicioHijo", idServicioHijo);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbServicioNieto.Items.Clear(); // Limpiar ComboBox antes de cargar nuevos valores

                    while (reader.Read())
                    {
                        cbServicioNieto.Items.Add(reader["nombre"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los servicios nietos: " + ex.Message);
            }
            finally
            {
                conexionDB.CerrarConexion();
            }
        }

        private void cbServicioEspecifico_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbServicioNieto.Text = "";
            if (cbServicioEspecifico.SelectedItem != null)
            {
                string servicioHijoSeleccionado = cbServicioEspecifico.Text; // Obtiene el nombre seleccionado

                string query = "SELECT idServicioEspecificoHijo FROM ServicioEspecificoHijo WHERE nombre = @nombre";

                try
                {
                    conexionDB.AbrirConexion();
                    using (SqlCommand cmd = new SqlCommand(query, conexionDB.GetConexion()))
                    {
                        cmd.Parameters.AddWithValue("@nombre", servicioHijoSeleccionado);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int idServicioHijo = Convert.ToInt32(result);

                            // Llamar al método que carga los servicios nietos
                            CargarServiciosNietos(idServicioHijo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el ID del servicio hijo: " + ex.Message);
                }
                finally
                {
                    conexionDB.CerrarConexion();
                }
            }
        }

        private void cbServicioNieto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbServicioP_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbServicioEspecifico.Text = "";
            if (cbServicioP.SelectedItem != null)
            {
                string servicioSeleccionado = cbServicioP.Text; // Obtiene el nombre seleccionado

                string query = "SELECT idServicioPadre FROM ServicioPadre WHERE nombre = @nombre";

                try
                {
                    conexionDB.AbrirConexion();
                    using (SqlCommand cmd = new SqlCommand(query, conexionDB.GetConexion()))
                    {
                        cmd.Parameters.AddWithValue("@nombre", servicioSeleccionado);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int idServicioPadre = Convert.ToInt32(result);

                            // Llamar al método que carga los servicios específicos hijos
                            CargarServiciosHijos(idServicioPadre);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el ID del servicio padre: " + ex.Message);
                }
                finally
                {
                    conexionDB.CerrarConexion();
                }
            }
        }
    }
}
