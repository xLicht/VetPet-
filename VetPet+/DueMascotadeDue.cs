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
    public partial class DueMascotadeDue : FormPadre
    {
        public DueMascotadeDue(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;

        }

        private void DueMascotadeDue_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new DueAgregarMascota(parentForm));
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new DueConsultarDueño(parentForm));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            parentForm.formularioHijo(new DueConsultarMascota(parentForm));
        }
    } 
}
