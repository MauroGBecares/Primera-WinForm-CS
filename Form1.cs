using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //VALIDACION
            if(txtApellido.Text == "")
                txtApellido.BackColor = Color.LightCoral;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Window;
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.LightCoral;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Window;
            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.LightCoral;
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Window;
            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.LightCoral;
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            
            //RESULTADO DE DATOS
            string textoApellidoNombre = "Apellido y Nombre: " + txtApellido.Text + " " + txtNombre.Text;
            string textoEdad = "Edad: " + txtEdad.Text;
            string textoDireccion = "Dirección: " + txtDireccion.Text;
            txtResultado.Lines = new string[] { textoApellidoNombre, textoEdad, textoDireccion };
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void lblApellido_MouseMove(object sender, MouseEventArgs e)
        {
            lblApellido.BackColor = Color.Gold;
            lblApellido.Cursor = Cursors.Hand;
        }

        private void lblApellido_MouseLeave(object sender, EventArgs e)
        {
            lblApellido.BackColor = Color.MediumAquamarine;
        }

        private void lblNombre_MouseMove(object sender, MouseEventArgs e)
        {
            lblNombre.BackColor = Color.Gold;
            lblNombre.Cursor = Cursors.Hand;
        }

        private void lblNombre_MouseLeave(object sender, EventArgs e)
        {
            lblNombre.BackColor = Color.MediumAquamarine;
        }

        private void lblEdad_MouseMove(object sender, MouseEventArgs e)
        {
            lblEdad.BackColor = Color.Gold;
            lblEdad.Cursor = Cursors.Hand;
        }

        private void lblEdad_MouseLeave(object sender, EventArgs e)
        {
            lblEdad.BackColor= Color.MediumAquamarine;
        }

        private void lblDireccion_MouseMove(object sender, MouseEventArgs e)
        {
            lblDireccion.BackColor = Color.Gold;
            lblDireccion.Cursor= Cursors.Hand;
        }

        private void lblDireccion_MouseLeave(object sender, EventArgs e)
        {
            lblDireccion.BackColor= Color.MediumAquamarine;
        }

        private void lblResultado_MouseMove(object sender, MouseEventArgs e)
        {
            lblResultado.BackColor = Color.Gold;
            lblResultado.Cursor= Cursors.Hand;
        }

        private void lblResultado_MouseLeave(object sender, EventArgs e)
        {
            lblResultado.BackColor = Color.MediumAquamarine;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
