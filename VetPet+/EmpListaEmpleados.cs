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
    public partial class EmpListaEmpleados : FormPadre
    {
        private conexionDaniel conexionDB = new conexionDaniel();
        public EmpListaEmpleados(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
            cbFliltrar.SelectedIndexChanged += (s, e) => CargarDatos();
            CargarDatos();
        }

        private void EmpListaEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new EmpAgregarEmpleado(parentForm));
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new EmpMenuEmpleados(parentForm));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnListaEmpleados_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new EmpListas(parentForm));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            try
            {
                conexionDB.AbrirConexion();

                string ordenColumna = "idEmpleado"; 
                if (cbFliltrar.SelectedItem != null)
                {
                    switch (cbFliltrar.SelectedItem.ToString())
                    {
                        case "Nombre":
                            ordenColumna = "p.nombre";
                            break;
                        case "ApellidoP":
                            ordenColumna = "p.apellidoP";
                            break;
                        case "ApellidoM":
                            ordenColumna = "p.apellidoM";
                            break;
                    }
                }

                string filtroNombre = txtBuscar.Text;

                string query = $@"
                    SELECT e.rfc, e.idEmpleado, p.nombre, p.apellidoP, p.apellidoM, 
                           t.nombre AS tipoEmpleado, p.CelularPrincipal
                    FROM Empleado e
                    JOIN Persona p ON e.idPersona = p.idPersona
                    JOIN TipoEmpleado t ON e.idTipoEmpleado = t.idTipoEmpleado
                    WHERE p.nombre LIKE @nombreFiltro AND p.estado = 'A' 
                    ORDER BY {ordenColumna};";

                using (SqlCommand cmd = new SqlCommand(query, conexionDB.GetConexion()))
                {
                    cmd.Parameters.AddWithValue("@nombreFiltro", "%" + filtroNombre + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtEmpleados.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dtEmpleados.Rows.Add(

                            row["idEmpleado"],
                            row["nombre"],
                            row["apellidoP"],
                            row["apellidoM"],
                            row["tipoEmpleado"],
                            row["CelularPrincipal"],
                            row["rfc"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No se pudo conectar a la BD. " + ex.Message);
            }
            finally
            {
                conexionDB.CerrarConexion();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            CargarDatos();
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void dtEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtEmpleados.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                {
                    int idEmpleadoSeleccionado = Convert.ToInt32(row.Cells[0].Value);
                    EmpConsultarEmpleado formularioHijo = new EmpConsultarEmpleado(parentForm);
                    formularioHijo.DatoEmpleado = idEmpleadoSeleccionado;
                    parentForm.formularioHijo(formularioHijo);
                    formularioHijo.MostrarDato();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID del empleado.");
                }
            }
        }
    }
}
