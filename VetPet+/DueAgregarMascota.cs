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
    public partial class DueAgregarMascota : FormPadre
    {
        public DueAgregarMascota(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void DueAgregarMascota_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //parentForm.formularioHijo(new DueMascotadeDue(parentForm));
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ///parentForm.formularioHijo(new DueMascotadeDue(parentForm));
        }
    }
}
