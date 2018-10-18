using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace UserControls
{
    public partial class PhoneNumberControl : System.Web.UI.UserControl
    {
        private string _phoneNumber;

        public string PhoneNumber {
            get
            {
                if (this.ValidateAndSetPhoneNumber())
                {
                    return this._phoneNumber;
                };

                return string.Empty;
            }
        }
   
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateAndSetPhoneNumber()
        {
            string numberStr = string.Format("({0}) {1}-{2}", this.AreaCode.Text, this.Number1.Text, this.Number2.Text);
            Regex regex = new Regex(@"^(\(0)\d{2,4}\)\s\d{2,4}-\d{4}");

            if ( regex.IsMatch(numberStr) && numberStr.Length == 15)
            {
                this._phoneNumber = numberStr;
                return true;
            }

            return false;
        }
    }
}