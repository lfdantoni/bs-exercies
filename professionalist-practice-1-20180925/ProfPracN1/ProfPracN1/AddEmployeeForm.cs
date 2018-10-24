using ProfPracN1.Constants;
using ProfPracN1.Enums;
using ProfPracN1.Helpers;
using ProfPracN1.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProfPracN1
{
    public partial class AddEmployeeForm : Form
    {
        public List<Employee> Employees {
            get
            {
                return this.MenuForm.Employees;
            }
        }

        NumberFormatInfo nf;

        private double SumTemp = 0;

        public MenuForm MenuForm { get; set; }

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!this.CheckFields())
            {
                return;
            }

            this.CleanErrors();
            this.UpdateCounters();

            Employee employee = new Employee()
            {
                JobTitle = EmployeeHelper.GetJobTitle((JobTitleComboOptionsEnum)cmbJobPosition.SelectedValue).Value,
                Name = txtName.Text,
                Lastname = txtLastname.Text,
                Salary1 = double.Parse(txtSalary1.Text, nf),
                Salary2 = double.Parse(txtSalary2.Text, nf),
                Salary3 = double.Parse(txtSalary3.Text, nf),
            };

            this.Employees.Add(employee);
            UpdateSumAve(employee);

        }

        private void UpdateSumAve(Employee employee = null)
        {
            if(employee != null)
            {
                this.SumTemp += employee.Salary1 + employee.Salary2 + employee.Salary3;
            }
            else
            {
                this.SumTemp = Employees.Count > 0 ? Employees.Sum(e => e.Total) : 0;
            }

            var average = this.Employees.Count > 0 ? this.SumTemp / this.Employees.Count : 0;
            this.txtSum.Text = this.SumTemp.ToString(nf);
            this.txtAverage.Text = average > 0 ? average.ToString(Constants.Environment.TWO_DECIMALS, nf) : "0";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtLastname.Text = string.Empty;
            cmbJobPosition.SelectedIndex = 0;
            txtSalary1.Text = string.Empty;
            txtSalary2.Text = string.Empty;
            txtSalary3.Text = string.Empty;

            this.CleanErrors();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show(
                            InformationMessageConstants.EXIT_MESSAGE,
                            InformationMessageConstants.EXIT_MODAL_TITLE,
                            MessageBoxButtons.YesNo);

            if (resp == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource(EmployeeHelper.GetComboJobTitleOptions(), null);
            this.cmbJobPosition.DataSource = source;
            this.cmbJobPosition.ValueMember = "Key";
            this.cmbJobPosition.DisplayMember = "Value";

            this.nf = new NumberFormatInfo();
            this.nf.NumberDecimalSeparator = Constants.Environment.DECIMAL_SEPARATOR;

            txtPaintersCount.Text = "0";
            txtCleaningStuffCount.Text = "0";
            txtGenStuffCount.Text = "0";

            txtAverage.Text = "0";
            txtSum.Text = "0";

            this.UpdateCounters();
            this.UpdateSumAve();

            this.DisableButtons();
        }

        private bool CheckFields()
        {
            if (txtLastname.Text == string.Empty)
            {
                ShowTextInputError(txtLastname);
                return false;
            }

            if (txtSalary1.Text == string.Empty)
            {
                ShowNumberInvalidError(txtSalary1);
                return false;
            }

            if (txtSalary3.Text == string.Empty)
            {
                ShowNumberInvalidError(txtSalary3);
                return false;
            }

            if (txtSalary2.Text == string.Empty)
            {
                ShowNumberInvalidError(txtSalary2);
                return false;
            }

            if (cmbJobPosition.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbJobPosition, ErrorMessageConstants.INVALID_JOB_TITLE);
                return false;
            }
            return true;
        }

        private void CleanErrors()
        {
            this.CleanCtrlError(txtName);
            this.CleanCtrlError(txtLastname);
            this.CleanCtrlError(cmbJobPosition);
            this.CleanCtrlError(txtSalary1);
            this.CleanCtrlError(txtSalary2);
            this.CleanCtrlError(txtSalary3);
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
            this.btnShow.Enabled = true;
        }

        private void DisableButtons()
        {
            this.btnClean.Enabled = false;
            this.btnShow.Enabled = false;
        }

        private void ShowTextInputError(TextBox ctrl)
        {
            this.errorProvider1.SetError(ctrl, ErrorMessageConstants.INVALID_CHARACTER);
            MessageBox.Show(
                ErrorMessageConstants.INVALID_CHARACTER,
                ErrorMessageConstants.ERROR_MODAL_TITLE,
                MessageBoxButtons.OK);
        }

        private void ShowNumberInvalidError(TextBox ctrl)
        {
            this.errorProvider1.SetError(ctrl, ErrorMessageConstants.INVALID_NUMBER);
            MessageBox.Show(
                ErrorMessageConstants.INVALID_NUMBER,
                ErrorMessageConstants.ERROR_MODAL_TITLE,
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
            this.ValidateNumberKeyPress(txtSalary1, e);
        }

        private void ValidateNumberKeyPress(TextBox ctrl, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
               (e.KeyChar.ToString() != Constants.Environment.DECIMAL_SEPARATOR || ctrl.Text.IndexOf(Constants.Environment.DECIMAL_SEPARATOR) >= 0))
            {
                this.ShowNumberInvalidError(ctrl);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                this.errorProvider1.SetError(ctrl, string.Empty);
            }
        }

        private void txtSalary1_Validated(object sender, EventArgs e)
        {
            this.CheckNumber(txtSalary1);
        }

        private void CheckNumber(TextBox ctrl)
        {
            double number = -1;
            if (double.TryParse(ctrl.Text, NumberStyles.AllowDecimalPoint, nf, out number))
            {
                errorProvider1.SetError(ctrl, string.Empty);
            }
        }

        private void txtSalary2_Validated(object sender, EventArgs e)
        {
            this.CheckNumber(txtSalary2);
        }

        private void txtSalary3_Validated(object sender, EventArgs e)
        {
            this.CheckNumber(txtSalary3);
        }

        private void txtSalary2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidateNumberKeyPress(txtSalary2, e);
        }

        private void txtSalary3_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidateNumberKeyPress(txtSalary3, e);
        }

        private void cmbJobPosition_SelectedValueChanged(object sender, EventArgs e)
        {
            this.UpdateCounters();
        }

        private void UpdateCounters()
        {
            if (cmbJobPosition.SelectedIndex == 0 && Employees.Count == 0)
            {
                return;
            }

            int paintersCount = this.Employees
                                .Where(x => x.JobTitle == JobTitleEnum.Painter)
                                .Count();

            int cleaningStuffCount = this.Employees
                                .Where(x => x.JobTitle == JobTitleEnum.CleaningStuff)
                                .Count();

            int generalStuffCount = this.Employees
                                .Where(x => x.JobTitle == JobTitleEnum.GenenralStaff)
                                .Count();

            if (cmbJobPosition.SelectedIndex != 0)
            {
                switch ((JobTitleComboOptionsEnum)cmbJobPosition.SelectedValue)
                {
                    case JobTitleComboOptionsEnum.Painter:
                        paintersCount++;
                        break;
                    case JobTitleComboOptionsEnum.CleaningStuff:
                        cleaningStuffCount++;
                        break;
                    case JobTitleComboOptionsEnum.GeneralStuff:
                        generalStuffCount++;
                        break;
                    default:
                        break;
                }
            }

            this.txtPaintersCount.Text = paintersCount.ToString();
            this.txtCleaningStuffCount.Text = cleaningStuffCount.ToString();
            this.txtGenStuffCount.Text = generalStuffCount.ToString();



        }

        private void AddEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm.Show();
        }
    }
}
