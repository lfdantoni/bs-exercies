using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProfPracN1.UserControls
{
    public partial class PositiveNumberControl : UserControl
    {
        public EventHandler ValueChanged { get; set; }
        private Regex regex = new Regex(@"[0-9]");
        private bool _required = false;

        public int Value {
            get {
                return !string.IsNullOrEmpty(textBox1.Text) ? int.Parse(textBox1.Text) : 0;
            }

            set
            {
                this.textBox1.Text = value.ToString();
            }
        }

        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        public bool IsValid { get { return string.IsNullOrEmpty(errorProvider1.GetError(textBox1)); } }

        public bool Required {
            set
            {
                this._required = value;
            }

            get
            {
                return this._required;
            }
        }

        public PositiveNumberControl()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox1, "Solo se pueden ingresar valores numericos positivos");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(textBox1, string.Empty);
            }
        }

        private void textBox1_Leave(object sender, System.EventArgs e)
        {
            if (_required && string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Este valor es requerido.");
            }
            else if (MaxValue > 0 && Value > MaxValue)
            {
                errorProvider1.SetError(textBox1, "El valor debe ser menor a " + MaxValue);
            }
            else if (MinValue > 0 && Value < MinValue)
            {
                errorProvider1.SetError(textBox1, "El valor debe ser mayor a " + MinValue);
            }
            else
            {
                errorProvider1.SetError(textBox1, string.Empty);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValueChanged?.Invoke(this.Value, e);
        }
    }
}
