﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetPet_;

namespace VetPet_
{
    public partial class CitaListaVacunas : FormPadre
    {
        public CitaListaVacunas()
        {
            InitializeComponent();
        }
        public CitaListaVacunas(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void CitaListaVacunas_Load(object sender, EventArgs e)
        {

        }
         
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CitaConsultarServicio.formularioAnterior = "CitaListaVacunas";
            parentForm.formularioHijo(new CitaConsultarServicio(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioAgregarProducto
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new CitaListaServicio(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioAgregarProducto
        }
    }
}
