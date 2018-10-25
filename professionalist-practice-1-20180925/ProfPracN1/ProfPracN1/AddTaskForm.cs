using ProfPracN1.Constants;
using ProfPracN1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProfPracN1
{
    public partial class AddTaskForm : Form
    {
        public MenuForm MenuForm { get; set; }

        public List<Task> Tasks
        {
            get
            {
                return MenuForm.Tasks;
            }
        }

        public AddTaskForm()
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

        private void AddTaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MenuForm.Show();
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            dpDate.Value = DateTime.Now;
            dpDate.MinDate = DateTime.Now;

            txtDeliveryDaysControl.ValueChanged += updateDaliveryDate;
            txtDeliveryDaysControl.MaxValue = 180;
            txtDeliveryDaysControl.MinValue = 30;

            dataGridView1.DataSource = ConvertListToDataTable();
        }

        private void updateDaliveryDate(object sender, EventArgs e)
        {
            txtDeliveryDate.Text = dpDate.Value.AddDays(this.txtDeliveryDaysControl.Value).ToShortDateString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDeliveryDaysControl.IsValid &&
                taskCode.IsValid &&
                !string.IsNullOrEmpty(cmbDescription.SelectedItem?.ToString()))
            {
                Tasks.Add(new Task()
                {
                    Code = taskCode.Value,
                    Date = dpDate.Value,
                    DeliveryDays = txtDeliveryDaysControl.Value,
                    Description = cmbDescription.SelectedItem.ToString()
                });

                UpdateDataGrid();
                CleanFields();
            }
        }

        private void UpdateDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ConvertListToDataTable();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                var taskCode = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                Tasks.RemoveAll(task => task.Code == taskCode);

                UpdateDataGrid();

                CleanFields();
            }
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

        private DataTable ConvertListToDataTable()
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 5;

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
                
            }

            table.Columns[0].ColumnName = "Codigo";
            table.Columns[1].ColumnName = "Descripcion";
            table.Columns[2].ColumnName = "Fecha";
            table.Columns[3].ColumnName = "Dias de entrega";
            table.Columns[4].ColumnName = "Fecha de entrega";


            // Add rows.
            foreach (var task in Tasks)
            {
                string[] values = new string[columns];
                values[0] = task.Code.ToString();
                values[1] = task.Description;
                values[2] = task.Date.ToShortDateString();
                values[3] = task.DeliveryDays.ToString();
                values[4] = task.DeliveryDate.ToShortDateString();

                table.Rows.Add(values);
            }

            return table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var taskCodeVar = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            var task = Tasks.Where(t => t.Code == taskCodeVar).ToList()[0];

            taskCode.Value = task.Code;
            cmbDescription.SelectedItem = task.Description;
            dpDate.Value = task.Date;
            txtDeliveryDaysControl.Value = task.DeliveryDays;
        }

        private void CleanFields()
        {
            taskCode.Value = 0;
            cmbDescription.SelectedIndex = -1;
            dpDate.Value = DateTime.Now;
            txtDeliveryDaysControl.Value = 0;
        }
    }
}
