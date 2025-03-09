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
    public partial class EmpConsultarEmpleado : FormPadre
    {
        public int DatoEmpleado { get; set; }
        private conexionDaniel conexionDB = new conexionDaniel();
        public EmpConsultarEmpleado(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
            MostrarDato();
        }

        private void EmpConsultarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new EmpModificarEmpleado(parentForm));
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            advertencia();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            advertenciaEliminar();
        }

        private void advertencia()
        { 
                parentForm.formularioHijo(new EmpListaEmpleados(parentForm));
        }
        private void advertenciaEliminar()
        {
            DialogResult resultado = MessageBox.Show("El Empleado se ¿Desea continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                parentForm.formularioHijo(new EmpListaEmpleados(parentForm));
            }
            else
            {

            }
        }
        //public void MostrarDato()
        //{
        //    //MessageBox.Show("Dato recibido: " + DatoEmpleado.ToString());
        //    //label1.Text = "Dato recibido: " + DatoEmpleado.ToString();
        //}
        public void MostrarDato()
        {
            try
            {
                conexionDB.AbrirConexion();

                        string query = @"
                    SELECT e.usuario, e.contraseña, e.palabraClave, 
                           p.nombre, p.apellidoP, p.apellidoM, p.celular, p.correoElectronico,
                           t.nombre AS tipoEmpleado,
                           pais.nombre AS pais, calle.nombre AS calle, 
                           cp.cp, ciudad.nombre AS ciudad, colonia.nombre AS colonia
                    FROM Empleado e
                    JOIN Persona p ON e.idPersona = p.idPersona
                    JOIN TipoEmpleado t ON e.idTipoEmpleado = t.idTipoEmpleado
                    LEFT JOIN Direccion d ON e.idEmpleado = d.idPersona
                    LEFT JOIN Pais pais ON d.idPais = pais.idPais
                    LEFT JOIN Calle calle ON d.idCalle = calle.idCalle
                    LEFT JOIN Cp cp ON d.idCp = cp.idCp
                    LEFT JOIN Ciudad ciudad ON d.idCiudad = ciudad.idCiudad
                    LEFT JOIN Colonia colonia ON d.idColonia = colonia.idColonia
                    WHERE e.idEmpleado = @idEmpleado";

                using (SqlCommand cmd = new SqlCommand(query, conexionDB.GetConexion()))
                {
                    cmd.Parameters.AddWithValue("@idEmpleado", DatoEmpleado);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Asignamos los valores obtenidos de la consulta a los TextBox
                        txtUsuario.Text = reader["usuario"].ToString();
                        txtContraseña.Text = reader["contraseña"].ToString();
                        txtPalabraClave.Text = reader["palabraClave"].ToString();
                        txtNombre.Text = reader["nombre"].ToString();
                        txtApellidoP.Text = reader["apellidoP"].ToString();
                        txtApellidoM.Text = reader["apellidoM"].ToString();
                        txtCelular.Text = reader["celular"].ToString();
                        txtCorreo.Text = reader["correoElectronico"].ToString();
                        txtTipoEmpleado.Text = reader["tipoEmpleado"].ToString();
                        txtPais.Text = reader["pais"].ToString();
                        txtCalle.Text = reader["calle"].ToString();
                        txtCp.Text = reader["cp"].ToString();
                        txtCiudad.Text = reader["ciudad"].ToString();
                        txtColonia.Text = reader["colonia"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No se pudo obtener los datos del empleado. " + ex.Message);
            }
            finally
            {
                conexionDB.CerrarConexion();
            }
        }




        private void r_Click(object sender, EventArgs e)
        {
            advertencia();
        }

        private void e_Click(object sender, EventArgs e)
        {
            advertenciaEliminar();
        }
    }
}
