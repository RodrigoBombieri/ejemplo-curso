using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                       
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            string direccion = txtDireccion.Text;
            string resultado = lswResultado.ToString();

            // validacion para que, si la celda esta vacía, se ponga en roja, y sino vuelva al color normal

            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;

            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;

            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Control;

            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;

            // validación para que si, paso la validación anterior (fondo rojo), se agregue a la List View cuando pulso Aceptar

            if (txtApellido.BackColor != Color.Red && txtNombre.BackColor != Color.Red)
                lswResultado.Items.Add("Apellido y Nombre: " + apellido + ", " + nombre);
            if (txtEdad.BackColor != Color.Red)
                lswResultado.Items.Add("Edad: " + edad);
            if (txtDireccion.BackColor != Color.Red)
                lswResultado.Items.Add("Dirección: " + direccion);
        }

        // para que solo acepte números en la EDAD
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar !=8)
                e.Handled = true;
        }

        private void btrCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
