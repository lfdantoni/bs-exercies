using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class Controles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void test_btn_Click(object sender, EventArgs e)
        {
            if(!validate.IsValid)
            {
                error.Text = "test message";
            }
            else
            {
                error.Text = string.Empty;
            }
            //validate.Validate();
        }
    }
}