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
    public partial class OlvideConstraseña : FormPadre
    {
        public OlvideConstraseña()
        {
            InitializeComponent();
        }
        public OlvideConstraseña(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;  // Guardamos la referencia del formulario principal
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new InicioSesion(parentForm));
        }

        private void BtnOlvideMiContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
