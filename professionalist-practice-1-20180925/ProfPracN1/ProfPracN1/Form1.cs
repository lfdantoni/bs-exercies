using ProfPracN1.Enums;
using ProfPracN1.Helpers;
using ProfPracN1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProfPracN1
{
    public partial class Form1 : Form
    {
        public List<Employee> Employees { get; set; }
        public List<TextBox> RequiredTextControls { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!this.CheckFields())
            {
                return;
            }

            Employee employee = new Employee()
            {
                JobTitle = (JobTitleEnum)cmbJobPosition.SelectedValue,
                Name = txtName.Text,
                Lastname = txtLastname.Text

            };

            this.Employees.Add(employee);

        }

        private void btnClean_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource(EmployeeHelper.GetAllJobTitleDescriptions(), null);
            this.cmbJobPosition.DataSource = source;
            this.cmbJobPosition.ValueMember = "Key";
            this.cmbJobPosition.DisplayMember = "Value";

            this.Employees = new List<Employee>();

            this.DisableButtons();
        }

        private bool CheckFields()
        {
            return true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!this.ValidatePressedKey(e.KeyChar))
            {
                this.ShowTextInputError(txtName);
                e.Handled = true;
            }
            else
            {
                this.CleanCtrlError(txtName);

                e.Handled = false;
            }
            
        }

        private bool ValidatePressedKey(char key)
        {
            if (char.IsDigit(key) || char.IsWhiteSpace(key) || ModifierKeys == Keys.Control)
            {
                return false;
            }

            return true;
        }

        private void EnableButtons()
        {
            this.btnClean.Enabled = true;
            this.btnExit.Enabled = true;
            this.btnShow.Enabled = true;
        }

        private void DisableButtons()
        {
            this.btnClean.Enabled = false;
            this.btnExit.Enabled = false;
            this.btnShow.Enabled = false;
        }

        private void ShowTextInputError(TextBox ctrl)
        {
            this.errorProvider1.SetError(ctrl, "Debe ser solo caracteres.");
            MessageBox.Show(
                "Debe ingresar caracteres no numericos, ni espacios, ni presionar la tecla control.",
                "Error",
                MessageBoxButtons.OK);
        }

        private void CleanCtrlError(Control ctrl)
        {
            this.errorProvider1.SetError(ctrl, string.Empty);
        }


        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!this.ValidatePressedKey(e.KeyChar))
            {
                if(txtLastname.Text == string.Empty)
                {
                    this.DisableButtons();
                }

                this.ShowTextInputError(txtLastname);
                e.Handled = true;
            }
            else
            {
                this.CleanCtrlError(txtLastname);
                e.Handled = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                this.EnableButtons();
            }
            else
            {
                this.DisableButtons();
            }
        }

        private void txtSalary1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || txtSalary1.Text.IndexOf('.') >= 0))
            {
                this.errorProvider1.SetError(txtSalary1, "Debe ser solo numeros o un punto como separador decimal.");
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                this.errorProvider1.SetError(txtSalary1, string.Empty);
            }
        }
    }
}
