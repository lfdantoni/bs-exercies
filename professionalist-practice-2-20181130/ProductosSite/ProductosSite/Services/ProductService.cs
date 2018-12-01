using ProductosSite.Utils;
using System;
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

        public DataRow GetProduct(int code)
        {
            DataSet ds = new DataSet();

            using (SqlConnection sqlConnection = new SqlConnection(this._connectionString))
            {
                sqlConnection.Open();

                string qGetProduct = "SELECT *  FROM [BaseProductos].[dbo].[Productos] WHERE Codigo = @Code";

                SqlCommand cmd = new SqlCommand(qGetProduct, sqlConnection);
    
                cmd.Parameters.AddWithValue("@Code", code);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                sqlDataAdapter.Fill(ds);
            }

            if (ds.Tables[0].Rows.Count == 0)
            {
                throw new Exception("El producto no existe");
            }

            return ds.Tables[0].Rows[0];
        }
    }
}