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
using VetPet_;

namespace VetPet_
{
    public partial class CortesConsultar : FormPadre
    {
        private ConexionMaestra conexion = new ConexionMaestra();
        private int idCorteSeleccionado;

        public CortesConsultar()
        {
            InitializeComponent();
        }

        public CortesConsultar(Form1 parent, int idCorte = 0)
        {
            InitializeComponent();
            parentForm = parent;
            idCorteSeleccionado = idCorte;

            // Cargar los datos del corte seleccionado
            if (idCorteSeleccionado > 0)
            {
                CargarDatosCorte();
            }

            ConfigurarDataGridViewMontos();
        }

        

        private void CargarDatosCorte()
        {
            try
            {
                using (SqlConnection connection = conexion.CrearConexion())
                {
                    connection.Open();

                    // Consulta para obtener los datos principales del corte
                    string queryCorte = @"
                    SELECT 
                        c.fechaInicio,
                        c.fechaFin,
                        c.fondoDeCaja,
                        c.totalEfectivo,
                        c.totalTarjeta,
                        c.correcto,
                        p.nombre + ' ' + p.apellidoP AS nombreEmpleado
                    FROM Corte c
                    INNER JOIN Empleado e ON c.idEmpleado = e.idEmpleado
                    INNER JOIN Persona p ON e.idPersona = p.idPersona
                    WHERE c.idCorte = @idCorte";

                    using (SqlCommand command = new SqlCommand(queryCorte, connection))
                    {
                        command.Parameters.AddWithValue("@idCorte", idCorteSeleccionado);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Mostrar datos básicos
                                txtUsuario.Text = reader["nombreEmpleado"].ToString();
                                dtpFechaInicio.Value = Convert.ToDateTime(reader["fechaInicio"]);
                                dtpFechaFin.Value = Convert.ToDateTime(reader["fechaFin"]);

                                // Mostrar totales
                                txtEfectivoCaja.Text = Convert.ToDecimal(reader["totalEfectivo"]).ToString("N2");
                                txtDocumentosCaja.Text = Convert.ToDecimal(reader["totalTarjeta"]).ToString("N2");
                                double totalGeneral = Convert.ToDouble(reader["totalEfectivo"]) + Convert.ToDouble(reader["totalTarjeta"]);
                                txtTotalCaja.Text = totalGeneral.ToString("N2");

                                // Cargar ventas del periodo
                                CargarVentasPorRangoFechas(Convert.ToDateTime(reader["fechaInicio"]), Convert.ToDateTime(reader["fechaFin"]));

                                // Calcular diferencia
                                CalcularDiferencia();
                            }
                        }
                    }

                  

                    // Aquí deberías cargar también los detalles de billetes y monedas
                    // (Necesitarías tablas adicionales en tu base de datos para esto)
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de base de datos: {sqlEx.Message}", "Error SQL",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVentasPorRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                using (SqlConnection connection = conexion.CrearConexion())
                {
                    connection.Open();

                    // Ajustar las fechas para incluir todo el día
                    DateTime fechaInicioAjustada = fechaInicio.Date;
                    DateTime fechaFinAjustada = fechaFin.Date.AddDays(1).AddSeconds(-1);

                    string query = @"SELECT 
                        v.idVenta AS 'ID',
                        CASE 
                            WHEN v.efectivo > 0 AND v.tarjeta > 0 THEN 'Mixto'
                            WHEN v.efectivo > 0 THEN 'Efectivo'
                            WHEN v.tarjeta > 0 THEN 'Tarjeta'
                            ELSE 'No especificado'
                        END AS 'Tipo de Pago',
                        v.fechaRegistro AS 'Fecha',
                        COALESCE(v.efectivo, 0) + COALESCE(v.tarjeta, 0) AS 'Monto'
                    FROM Venta v
                    WHERE v.fechaRegistro BETWEEN @fechaInicio AND @fechaFin
                    AND v.estado = 'A'
                    ORDER BY v.fechaRegistro;";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicioAjustada);
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFinAjustada);

                    DataTable ventas = new DataTable();
                    adapter.Fill(ventas);

                    dataGridView4.DataSource = ventas;
                    ConfigurarDataGridViewCentrado();
                    CalcularTotalesVentas(ventas);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de base de datos: {sqlEx.Message}", "Error SQL",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridViewCentrado()
        {
            // Configuración básica
            dataGridView4.AutoGenerateColumns = true;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Centrar todo el contenido de las celdas
            dataGridView4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Configuración específica para columnas
            if (dataGridView4.Columns["Monto"] != null)
            {
                dataGridView4.Columns["Monto"].DefaultCellStyle.Format = "N2";
                dataGridView4.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Estilo de las cabeceras
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView4.Font, FontStyle.Bold);

            // Ocultar encabezados de fila
            dataGridView4.RowHeadersVisible = false;

            // Alternar colores de filas para mejor legibilidad
            dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }

        private void CalcularTotalesVentas(DataTable ventas)
        {
            double totalEfectivo = 0;
            double totalTarjeta = 0;
            double totalGeneral = 0;

            foreach (DataRow row in ventas.Rows)
            {
                totalGeneral += Convert.ToDouble(row["Monto"]);

                string tipoPago = row["Tipo de Pago"].ToString();
                if (tipoPago == "Efectivo")
                    totalEfectivo += Convert.ToDouble(row["Monto"]);
                else if (tipoPago == "Tarjeta")
                    totalTarjeta += Convert.ToDouble(row["Monto"]);
                else if (tipoPago == "Mixto")
                {
                    totalEfectivo += Convert.ToDouble(row["Monto"]) / 2;
                    totalTarjeta += Convert.ToDouble(row["Monto"]) / 2;
                }
            }

            txtEfectivoVentas.Text = totalEfectivo.ToString("N2");
            txtDocumentosVentas.Text = totalTarjeta.ToString("N2");
            txtTotalVentas.Text = totalGeneral.ToString("N2");
        }

        private void CalcularDiferencia()
        {
            if (decimal.TryParse(txtTotalVentas.Text, out decimal totalVentas) &&
                decimal.TryParse(txtTotalCaja.Text, out decimal totalCaja))
            {
                decimal diferencia = totalVentas - totalCaja;
                txtDiferencia.Text = diferencia.ToString("N2");

                if (diferencia > 0)
                {
                    txtDiferencia.BackColor = Color.LightPink;
                }
                else if (diferencia < 0)
                {
                    txtDiferencia.BackColor = Color.LightGreen;
                }
                else
                {
                    txtDiferencia.BackColor = SystemColors.Window;
                }
            }
        }

        private void ConfigurarDataGridViewMontos()
        {

            // Crear columnas con nombres exactos
            DataGridViewTextBoxColumn colNumero = new DataGridViewTextBoxColumn();
            colNumero.Name = "Numero";
            colNumero.HeaderText = "N°";
            colNumero.Width = 50;
            colNumero.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn colMonto = new DataGridViewTextBoxColumn();
            colMonto.Name = "Monto";
            colMonto.HeaderText = "Monto";
            colMonto.Width = 100;
            colMonto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colMonto.DefaultCellStyle.Format = "N2";

 
        }

        // Métodos vacíos necesarios para la interfaz
        private void CortesConsultar_Load(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void label19_Click(object sender, EventArgs e) { }
        private void label18_Click(object sender, EventArgs e) { }
        private void label17_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new CortesHistorial(parentForm));
        }
    }
}