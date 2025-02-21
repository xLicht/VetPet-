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
    public partial class CitaAgendar : FormPadre
    {
        public CitaAgendar()
        {
            InitializeComponent();
        }

        public CitaAgendar(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void CitaAgendar_Load(object sender, EventArgs e)
        {

        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new CitasMascota(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioAgregarProducto
        }

        private void btnDueño_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new CitaDueños(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioAgregarProducto
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }
    }
}
