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
    public partial class DueConsultarDueño : FormPadre
    {
        public int DatoEmpleado { get; set; }
        private conexionDaniel conexionDB = new conexionDaniel();
        public DueConsultarDueño(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void DueConsultarDueño_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Dato"+DatoEmpleado);
            MostrarDato();
            CargarNumerosSecundarios();
        }

        public void MostrarDato()
        {
            try
            {
                conexionDB.AbrirConexion();

                string query = @"SELECT 
                    p.nombre, p.apellidoP, p.apellidoM, p.celularPrincipal, 
                    p.correoElectronico, 
                    pais.nombre AS pais, calle.nombre AS calle, 
                    cp.cp, ciudad.nombre AS ciudad, colonia.nombre AS colonia, 
                    estado.nombre AS estado,
                    municipio.nombre AS municipio
                FROM 
                    Persona p
                LEFT JOIN 
                    Direccion d ON p.idPersona = d.idPersona
                LEFT JOIN 
                    Pais pais ON d.idPais = pais.idPais
                LEFT JOIN 
                    Calle calle ON d.idCalle = calle.idCalle
                LEFT JOIN 
                    Cp cp ON d.idCp = cp.idCp
                LEFT JOIN 
                    Ciudad ciudad ON d.idCiudad = ciudad.idCiudad
                LEFT JOIN 
                    Colonia colonia ON d.idColonia = colonia.idColonia
                LEFT JOIN 
                    Estado estado ON d.idEstado = estado.idEstado 
                LEFT JOIN
                    Municipio municipio ON d.idMunicipio = municipio.idMunicipio
                WHERE 
                    p.idPersona = @idPersona";

                using (SqlCommand cmd = new SqlCommand(query, conexionDB.GetConexion()))
                {
                    cmd.Parameters.AddWithValue("@idPersona", DatoEmpleado);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtNombre.Text = reader["nombre"].ToString();
                        txtApellidoP.Text = reader["apellidoP"].ToString();
                        txtApellidoM.Text = reader["apellidoM"].ToString();
                        txtCelular.Text = reader["celularPrincipal"].ToString();
                        txtCorreo.Text = reader["correoElectronico"].ToString();
                        txtPais.Text = reader["pais"].ToString();
                        txtCalle.Text = reader["calle"].ToString();
                        txtCp.Text = reader["cp"].ToString();
                        txtCiudad.Text = reader["ciudad"].ToString();
                        txtColonia.Text = reader["colonia"].ToString();
                        txtEstado.Text = reader["estado"].ToString();
                        txtMunicipio.Text = reader["municipio"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No se pudo obtener los datos del dueño. " + ex.Message);
            }
            finally
            {
                conexionDB.CerrarConexion();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new DueAtencionAlCliente(parentForm));
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new DueAtencionAlCliente(parentForm));
        }

        private void btnMostrarMascota_Click(object sender, EventArgs e)
        {

            int idEmpleadoSeleccionado = Convert.ToInt32(DatoEmpleado);
            DueMascotadeDue formularioHijo = new DueMascotadeDue(parentForm, "DueConsultarDue");
            formularioHijo.DatoEmpleado = idEmpleadoSeleccionado;
            parentForm.formularioHijo(formularioHijo);


            //parentForm.formularioHijo(new DueMascotadeDue(parentForm));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int idEmpleadoSeleccionado = Convert.ToInt32(DatoEmpleado);
            DueModificarDueño formularioHijo = new DueModificarDueño(parentForm);
            formularioHijo.DatoEmpleado = idEmpleadoSeleccionado;
            parentForm.formularioHijo(formularioHijo);

            //parentForm.formularioHijo(new DueModificarDueño(parentForm));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este dueño?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    conexionDB.AbrirConexion();

                            string query = @"
                        UPDATE Persona SET estado = 'I' WHERE idPersona = @idPersona;
                        UPDATE Celular SET estado = 'I' WHERE idPersona = @idPersona;";

                    using (SqlCommand cmd = new SqlCommand(query, conexionDB.GetConexion()))
                    {
                        cmd.Parameters.AddWithValue("@idPersona", DatoEmpleado);
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("El dueño ha sido eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); 
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el dueño.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el dueño: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionDB.CerrarConexion();
            }
            parentForm.formularioHijo(new DueAtencionAlCliente(parentForm));
        }
        private void CargarNumerosSecundarios()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Número");
                conexionDB.AbrirConexion();

                string query = "SELECT numero FROM Celular WHERE idPersona = @idPersona AND estado = 'A'";
                using (SqlCommand cmd = new SqlCommand(query, conexionDB.GetConexion()))
                {
                    cmd.Parameters.AddWithValue("@idPersona", DatoEmpleado);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dt.Rows.Add(reader["numero"].ToString());
                    }
                    reader.Close();
                }
                dtNumeros.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los números secundarios: " + ex.Message);
            }
            finally
            {
                conexionDB.CerrarConexion();
            }
        }
    } 
}
