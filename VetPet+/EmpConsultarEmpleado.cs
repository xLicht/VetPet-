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
          
        }

        private void EmpConsultarEmpleado_Load(object sender, EventArgs e)
        {
            MostrarDato();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpModificarEmpleado modificarEmpleadoForm = new EmpModificarEmpleado(parentForm);
            modificarEmpleadoForm.DatoEmpleado = this.DatoEmpleado;
            parentForm.formularioHijo(modificarEmpleadoForm);
            //parentForm.formularioHijo(new EmpModificarEmpleado(parentForm));
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
     
        public void MostrarDato()
        {
            try
            {
                conexionDB.AbrirConexion();

                string query = @"
                    SELECT e.usuario, e.contraseña, e.palabraClave, e.rfc,
                           p.nombre, p.apellidoP, p.apellidoM, p.celularPrincipal, 
                           p.correoElectronico, t.nombre AS tipoEmpleado, 
                           pais.nombre AS pais, calle.nombre AS calle, 
                           cp.cp, ciudad.nombre AS ciudad, colonia.nombre AS colonia, 
                           estado.nombre AS estado,
                           municipio.nombre AS municipio
                    FROM Empleado e
                    JOIN Persona p ON e.idPersona = p.idPersona
                    JOIN TipoEmpleado t ON e.idTipoEmpleado = t.idTipoEmpleado
                    LEFT JOIN Direccion d ON e.idEmpleado = d.idPersona
                    LEFT JOIN Pais pais ON d.idPais = pais.idPais
                    LEFT JOIN Calle calle ON d.idCalle = calle.idCalle
                    LEFT JOIN Cp cp ON d.idCp = cp.idCp
                    LEFT JOIN Ciudad ciudad ON d.idCiudad = ciudad.idCiudad
                    LEFT JOIN Colonia colonia ON d.idColonia = colonia.idColonia
                    LEFT JOIN Estado estado ON d.idEstado = estado.idEstado 
                    LEFT JOIN Municipio municipio ON d.idMunicipio = municipio.idMunicipio
                    WHERE e.idEmpleado = @idEmpleado";

                using (SqlCommand cmd = new SqlCommand(query, conexionDB.GetConexion()))
                {
                    cmd.Parameters.AddWithValue("@idEmpleado", DatoEmpleado);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtUsuario.Text = reader["usuario"].ToString();
                        txtContraseña.Text = reader["contraseña"].ToString();
                        txtPalabraClave.Text = reader["palabraClave"].ToString();
                        txtRFC.Text = reader["rfc"].ToString();
                        txtNombre.Text = reader["nombre"].ToString();
                        txtApellidoP.Text = reader["apellidoP"].ToString();
                        txtApellidoM.Text = reader["apellidoM"].ToString();
                        txtCelular.Text = reader["celularPrincipal"].ToString();
                        txtCorreo.Text = reader["correoElectronico"].ToString();
                        txtTipoEmpleado.Text = reader["tipoEmpleado"].ToString();
                        txtPais.Text = reader["pais"].ToString();
                        txtCalle.Text = reader["calle"].ToString();
                        txtCp.Text = reader["cp"].ToString();
                        txtCiudad.Text = reader["ciudad"].ToString();
                        txtColonia.Text = reader["colonia"].ToString();
                        textBox1.Text = reader["estado"].ToString();
                        txtMunicipio.Text = reader["municipio"].ToString();
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



        private void EliminarEmpleado(int idEmpleado)
        {
            try
            {
                conexionDB.AbrirConexion();

                string query = @"UPDATE Persona 
                         SET estado = 'I' 
                         WHERE idPersona = (SELECT idPersona FROM Empleado WHERE idEmpleado = @idEmpleado)";

                using (SqlCommand cmd = new SqlCommand(query, conexionDB.GetConexion()))
                {
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Empleado eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        parentForm.formularioHijo(new EmpListaEmpleados(parentForm)); 
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el empleado a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionDB.CerrarConexion();
            }
        }

        private void advertenciaEliminar()
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?","Advertencia",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                EliminarEmpleado(DatoEmpleado);
            }
        }
    }
}
