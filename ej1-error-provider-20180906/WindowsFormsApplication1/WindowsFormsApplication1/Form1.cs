using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void txtEdad_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtEdad.Text,out num))
            {
                errorProvider1.SetError(txtEdad, "Ingrese un valor numerico");
            }
            else
            {
                errorProvider1.SetError(txtEdad, string.Empty);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Datos ingresados correctamente");
            }
        }

        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtEdad, string.Empty);
            errorProvider1.SetError(txtApellido, string.Empty);
            errorProvider1.SetError(txtNombre, string.Empty);
        }

        private bool ValidarCampos()
        {
            bool validar = true;

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese nombre");
                validar = false;
            }

            if (txtApellido.Text == "")
            {
                errorProvider1.SetError(txtApellido, "Ingrese apellido");
                validar = false;
            }

            if (txtEdad.Text =="" || errorProvider1.GetError(txtEdad) != "")
            {
                errorProvider1.SetError(txtEdad, "Ingrese la edad");
                validar = false;
            }

            return validar;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtNombre.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
