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

namespace VetPet_
{
    public partial class DueModificarDueño : FormPadre
    {
        public DueModificarDueño(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void DueModificarDueño_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarMascota_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new DueMascotadeDue(parentForm));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new DueConsultarDueño(parentForm));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new DueConsultarDueño(parentForm));
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new DueConsultarDueño(parentForm));
        }
    }
}
