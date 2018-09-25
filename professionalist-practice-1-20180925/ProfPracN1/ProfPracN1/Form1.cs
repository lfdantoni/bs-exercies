using ProfPracN1.Helpers;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

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
        }
    }
}
