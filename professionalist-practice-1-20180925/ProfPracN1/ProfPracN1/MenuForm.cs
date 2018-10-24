using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfPracN1
{
    public partial class MenuForm : Form
    {
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
    }
}
