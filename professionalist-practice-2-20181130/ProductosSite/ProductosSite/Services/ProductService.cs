using ProductosSite.Utils;
using System.Data;
using System.Data.SqlClient;

namespace ProductosSite.Services
{
    public class ProductService
    {
        private string _connectionString;

        public ProductService()
        {
            this._connectionString = ApplicationSettings.ConnectionString;
        }

        public DataTable GetAllProductos()
        {
            DataTable response;

            using (SqlConnection sqlConnection = new SqlConnection(this._connectionString))
            {
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT *  FROM [BaseProductos].[dbo].[Productos]", sqlConnection);

                DataSet dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet);

                response = dataSet.Tables[0];
            }

            return response;
        }
    }
}