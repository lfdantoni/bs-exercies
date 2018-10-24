using ProfPracN1.Constants;
using ProfPracN1.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProfPracN1
{
    public partial class ListEmployeesForm : Form
    {
        public MenuForm MenuForm { get; set; }

        public List<Employee> Employees {
            get
            {
                return MenuForm.Employees;
            }
        }

        public ListEmployeesForm()
        {
            InitializeComponent();
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

        private void ListEmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MenuForm.Show();
        }

        private void ListEmployeesForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.Employees;
            this.SetHeadersName();
        }

        private void SetHeadersName()
        {
            this.dataGridView1.Columns[0].HeaderText = "Nombre";
            this.dataGridView1.Columns[1].HeaderText = "Apellido";
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].HeaderText = "Cargo";
            this.dataGridView1.Columns[4].HeaderText = "Salario 1";
            this.dataGridView1.Columns[5].HeaderText = "Salario 2";
            this.dataGridView1.Columns[6].HeaderText = "Salario 3";
            this.dataGridView1.Columns[7].HeaderText = "Total";
            this.dataGridView1.Columns[8].HeaderText = "Promedio";
        }
    }
}
