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
    public partial class ListaRayosX : FormPadre
    {
        //Variables SQL
        public SqlConnection conexion;
        public SqlCommand comando;
        public SqlDataReader Lector;
        public string q;
        public string mensaje;
        public ListaRayosX()
        {
            InitializeComponent();
        }
        public ListaRayosX(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;  // Guardamos la referencia del formulario principal
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new ModificarServicios(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioProductos
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new ModificarRayosX(parentForm));
        }

        private void BtnAgregarTipoDeRayosX_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new AgregarTipoRayosX(parentForm));
        }

        private void BtnAgregarRayosX_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new AgregarRayosX(parentForm));
        }

        private void ListaRayosX_Load(object sender, EventArgs e)
        {
            //Consultas SQL
            conexion = new SqlConnection(@"Data Source=DESKTOP-GQ6Q9HG\SQLEXPRESS;Initial Catalog=Servicio;Integrated Security=True;");
            conexion.Open();

            //Primera Tabla
            q = "SELECT NombreServicio FROM Servicios";
            comando = new SqlCommand(q, conexion);
            Lector = comando.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(Lector);
            dataGridView1.DataSource = dt;

            //Segunda Tabla
            q = "SELECT ID FROM Servicios";
            comando = new SqlCommand(q, conexion);
            Lector = comando.ExecuteReader();

            DataTable dt2 = new DataTable();
            dt2.Load(Lector);
            dataGridView2.DataSource = dt2;

            conexion.Close();
        }
    }
}
