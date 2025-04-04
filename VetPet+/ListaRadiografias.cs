﻿using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetPet_;

namespace VetPet_
{
    public partial class ListaRadiografias : FormPadre
    {
        string idStr;
        string nombreServicio;
        public ListaRadiografias()
        {
            InitializeComponent();
        }
        public ListaRadiografias(Form1 parent, int idConseguido, string nombre)
        {
            InitializeComponent();
            parentForm = parent;  // Guardamos la referencia del formulario principal
            idStr = idConseguido.ToString();
            nombreServicio=nombre;
        }
        private void BtnAgregarRadiografia_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new AgregarRadiografias(parentForm, idStr,nombreServicio));
        }
        private void BtnAgregarTipoDeRadiografía_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new AgregarTipoRadiografias(parentForm, Convert.ToInt32(idStr),nombreServicio));
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new ListaServicios(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioProductos
        }
        private void ListaRadiografias_Load(object sender, EventArgs e)
        {
            label2.Text = "Lista de " +nombreServicio;
            label4.Text = "Información de " + nombreServicio;
            BtnAgregarRadiografia.Text = "Agregar Nueva " + nombreServicio;
            BtnAgregarTipoDeRadiografía.Text = "Agregar Tipo de " + nombreServicio;
            int centerX = (this.ClientSize.Width - label2.Width) / 2;
            int centerY = (this.ClientSize.Height - label2.Height) / 2;
            label2.Location = new Point(centerX, centerY);

            conexionAlex conexion = new conexionAlex();
            conexion.AbrirConexion();
            conexion.CargarTipodeServicio(dataGridView1, idStr);
            conexion.CargarInformaciondeServicio(dataGridView2, idStr);
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conexionAlex conexion = new conexionAlex();
            conexion.AbrirConexion();
            conexion.Buscar(dataGridView1, TxtBuscar, idStr);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            conexionAlex conexion = new conexionAlex();
            conexion.AbrirConexion();
            conexion.Buscar(dataGridView1, TxtBuscar, idStr);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Asegúrate de que el clic sea dentro de los límites válidos
            {
                if (e.ColumnIndex == 0) // Verificar si es la primera columna
                {
                    // Aquí puedes obtener el valor de la celda clickeada
                    DataGridViewRow filaSeleccionada = dataGridView2.Rows[e.RowIndex];
                    string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();

                    conexionAlex conexion = new conexionAlex();
                    conexion.AbrirConexion();


                    string queryIdServicio = "SELECT idServicioEspecificoNieto FROM ServicioEspecificoNieto WHERE nombre = @NombreServicio";

                    // Crear el comando para obtener el idServicioEspecificoHijo
                    using (SqlCommand cmd = new SqlCommand(queryIdServicio, conexion.GetConexion()))
                    {
                        try
                        {
                            // Agregar el parámetro del nombre del ServicioEspecificoHijo
                            cmd.Parameters.AddWithValue("@NombreServicio", nombre);

                            // Ejecutar la consulta y obtener el id
                            object result = cmd.ExecuteScalar(); // ExecuteScalar retorna el primer valor de la consulta (idServicioEspecificoHijo)

                            if (result != null)
                            {
                                // Convertir el resultado a int (si el id es entero)
                                int idServicioEspecificoNieto = Convert.ToInt32(result);
                                parentForm.formularioHijo(new ModificarRadiografias(parentForm, idServicioEspecificoNieto, idStr,nombreServicio));

                            }
                            else
                            {
                                MessageBox.Show("No se encontró el Servicio Especificado.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cargar las presentaciones: " + ex.Message);
                        }
                        finally
                        {
                            conexion.CerrarConexion();
                        }
                    }
                }
            }
        }
    }
}
