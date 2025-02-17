using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VetPet_
{
    public partial class Menu_AtencionAlCliente : Form
    {
        public Menu_AtencionAlCliente()
        {
            InitializeComponent();
            //parentForm = parent;
        }

        Menu_AtencionAlCliente_Dueños_Andryk MACDA;

        private Form1 parentForm;

        private void btnMascotas_Click(object sender, EventArgs e)
        {
        }

        private void btnDueños_Click(object sender, EventArgs e)
        {
           // parentForm.formularioHijo(new Menu_AtencionAlCliente_Dueños_Andryk(parentForm)); // Pasamos la referencia de Form1 a AlmacenInventarioProductos
        }
    }
}
