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
    public partial class AgregarUltrasonidos : FormPadre
    {
        string idSer;
        public AgregarUltrasonidos()
        {
            InitializeComponent();
        }
        public AgregarUltrasonidos(Form1 parent, string id)
        {
            InitializeComponent();
            parentForm = parent;  // Guardamos la referencia del formulario principal
            idSer = id;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            //parentForm.formularioHijo(new ListaUltrasonidos(parentForm));
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //parentForm.formularioHijo(new ListaUltrasonidos(parentForm));
        }

        private void AgregarUltrasonidos_Load(object sender, EventArgs e)
        {

        }
    }
}
