using ProductosSite.Utils;
using System;
using System.Web.Configuration;

namespace ProductosSite
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            ApplicationSettings.ConnectionString = WebConfigurationManager.ConnectionStrings["ConnStringProducts"].ConnectionString;
        }
    }
}