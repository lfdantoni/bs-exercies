using ProfPracN1.Constants;
using ProfPracN1.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProfPracN1
{
    public partial class MenuForm : Form
    {
        public readonly List<Employee> Employees = new List<Employee>();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void cargarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.MenuForm = this;
            addEmployeeForm.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listEmployeesForm = new ListEmployeesForm();
            listEmployeesForm.MenuForm = this;
            listEmployeesForm.Show();
            this.Hide();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addTaskForm = new AddTaskForm();
            addTaskForm.MenuForm = this;
            addTaskForm.Show();
            this.Hide();
        }
    }
}
