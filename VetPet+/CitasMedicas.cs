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
    public partial class CitasMedicas : FormPadre
    {
        public CitasMedicas(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent; 
        }

        private void CitasMedicas_Load(object sender, EventArgs e)
        {

        }

        private void CitasMedicas_Resize(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new VeterinariaMenu(parentForm)); 
        }

        private void dtCitasMedicas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            parentForm.formularioHijo(new ConsultarCita(parentForm));
        }

        private void CitasMedicas_Load_1(object sender, EventArgs e)
        {

        }
    }
   
}
