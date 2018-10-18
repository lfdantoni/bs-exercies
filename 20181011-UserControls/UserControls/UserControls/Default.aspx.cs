using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string phone = PhoneNumber.PhoneNumber;

            if(string.IsNullOrEmpty(phone))
            {
                Label1.Text = "Invalid Number";
            }
            else
            {
                Label1.Text = phone;
            }

        }
    }
}