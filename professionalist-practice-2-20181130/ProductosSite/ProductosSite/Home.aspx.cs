using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductosSite
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var connectionString = WebConfigurationManager.ConnectionStrings["ConnStringProducts"].ConnectionString;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {

                    sqlConnection.Open();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT *  FROM [BaseProductos].[dbo].[Productos]", sqlConnection);

                    DataSet dataSet = new DataSet();

                    sqlDataAdapter.Fill(dataSet);

                    GVProducts.DataSource = dataSet.Tables[0];
                    GVProducts.DataBind();
                }

            }
            catch (Exception ex)
            {

                //Write code here to handle exception

            }
        }
    }
}