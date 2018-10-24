using ProfPracN1.Constants;
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
    public partial class AddTaskForm : Form
    {
        public MenuForm MenuForm { get; set; }
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
    }
}
