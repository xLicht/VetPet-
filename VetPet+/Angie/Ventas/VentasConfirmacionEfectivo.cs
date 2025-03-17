﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetPet_.Angie
{
    public partial class VentasConfirmacionEfectivo : Form
    {
        private float originalWidth;
        private float originalHeight;
        private Dictionary<Control, (float width, float height, float left, float top, float fontSize)> controlInfo = new Dictionary<Control, (float width, float height, float left, float top, float fontSize)>();
        decimal sumaTotalProductos = 0; 
        private Form1 parentForm;
        private static DataTable dtProductos = new DataTable();
        private int idCita;  
        public string FormularioOrigen { get; set; }

        public VentasConfirmacionEfectivo(Form1 parent, decimal sumaTotalProductos, DataTable dtProductos)
        {
            InitializeComponent();
            this.Load += VentasConfirmacionEfectivo_Load;       // Evento Load
            this.Resize += VentasConfirmacionEfectivo_Resize;   // Evento Resize
            parentForm = parent;  // Guardamos la referencia de Form1
            this.sumaTotalProductos += sumaTotalProductos;  
            textBox3.Text += sumaTotalProductos.ToString();
        }
        public VentasConfirmacionEfectivo(Form1 parent, decimal sumaTotalProductos,int idCita)
        {
            InitializeComponent();
            this.Load += VentasConfirmacionEfectivo_Load;       // Evento Load
            this.Resize += VentasConfirmacionEfectivo_Resize;   // Evento Resize
            parentForm = parent;  // Guardamos la referencia de Form1
            this.sumaTotalProductos = sumaTotalProductos;
            this.idCita = idCita;
        }
        public VentasConfirmacionEfectivo(Form1 parent)
        {
            InitializeComponent();
            this.Load += VentasConfirmacionEfectivo_Load;       // Evento Load
            this.Resize += VentasConfirmacionEfectivo_Resize;   // Evento Resize
            parentForm = parent;  
        }

       
        private void VentasConfirmacionEfectivo_Load(object sender, EventArgs e)
        {
            // Guardar el tamaño original del formulario
            originalWidth = this.ClientSize.Width;
            originalHeight = this.ClientSize.Height;

            // Guardar información original de cada control
            foreach (Control control in this.Controls)
            {
                controlInfo[control] = (control.Width, control.Height, control.Left, control.Top, control.Font.Size);
            }
        }

        private void VentasConfirmacionEfectivo_Resize(object sender, EventArgs e)
        {
            // Calcular el factor de escala
            float scaleX = this.ClientSize.Width / originalWidth;
            float scaleY = this.ClientSize.Height / originalHeight;

            foreach (Control control in this.Controls)
            {
                if (controlInfo.ContainsKey(control))
                {
                    var info = controlInfo[control];

                    // Ajustar las dimensiones
                    control.Width = (int)(info.width * scaleX);
                    control.Height = (int)(info.height * scaleY);
                    control.Left = (int)(info.left * scaleX);
                    control.Top = (int)(info.top * scaleY);

                    // Ajustar el tamaño de la fuente
                    control.Font = new Font(control.Font.FontFamily, info.fontSize * Math.Min(scaleX, scaleY));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormularioOrigen == "VentasNuevaVenta")
            {
                parentForm.formularioHijo(new VentasNuevaVenta(parentForm)); // Pasamos la referencia de Form1 a
            }
            if (FormularioOrigen == "VentasVentanadePago")
            {
               parentForm.formularioHijo(new VentasVentanadePago(parentForm, idCita)); // Pasamos la referencia de Form1 a
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar y obtener el monto pagado
                if (!decimal.TryParse(textBox4.Text, out decimal montoPagado))
                {
                    MessageBox.Show("El monto pagado no es un valor válido.");
                    return;
                }

                // Validar que el monto pagado no sea mayor que el subtotal
                if (montoPagado > sumaTotalProductos)
                {
                    MessageBox.Show("El monto pagado no puede ser mayor que el subtotal.");
                    return;
                }

                // Calcular el nuevo subtotal
                decimal nuevoSubtotal = sumaTotalProductos - montoPagado;

              
                if (FormularioOrigen == "VentasNuevaVenta")
                {
                    parentForm.formularioHijo(new VentasNuevaVenta(parentForm, nuevoSubtotal, montoPagado,dtProductos)); // Pasamos la referencia de Form1 a
                }
                if (FormularioOrigen == "VentasVentanadePago")
                {
                    parentForm.formularioHijo(new VentasVentanadePago(parentForm, idCita)); // Pasamos la referencia de Form1 a
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el pago: " + ex.Message);
            }
        }
    }
}
