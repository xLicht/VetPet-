using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetPet_
{
    public partial class Menu_AtencionAlCliente : Form
    {
        public Menu_AtencionAlCliente()
        {
            InitializeComponent();
        }

        private Form1 parentForm;

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            parentForm.formularioHijo(new Mascotas_Angie(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioProductos
        }
    }
}
