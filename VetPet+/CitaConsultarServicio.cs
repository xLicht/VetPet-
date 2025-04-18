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
    public partial class CitaConsultarServicio : FormPadre
    {
        public static string formularioAnterior; // Guarda el nombre del formulario anterior

        public CitaConsultarServicio()
        {
            InitializeComponent();
            if (formularioAnterior == "CitaGestionarServicio")
            {
                btnAgregar.Enabled = false;
            }
        }
        public CitaConsultarServicio(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }
        private void CitaConsultarServicio_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new CitaListaVacunas(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioAgregarProducto
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Verifica de qué formulario vino
            if (formularioAnterior == "CitaGestionarServicio")
            {
                parentForm.formularioHijo(new CitaGestionarServicio(parentForm));

            }
            else if (formularioAnterior == "CitaListaVacunas")
            {
                parentForm.formularioHijo(new CitaListaVacunas(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioAgregarProducto
            }
        }
    }
}
