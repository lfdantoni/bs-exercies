﻿using ProductosSite.Utils;
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

        public bool InsertProduct(int code, string name, string category, decimal costPrice,
            double margin, double iva, decimal grossPrice, decimal sellPrice)
        {
            int resp = -1;

            try
            {  
                using (SqlConnection sqlConnection = new SqlConnection(this._connectionString))
                {
                    sqlConnection.Open();

                    string qInsertProduct = @"INSERT INTO [BaseProductos].[dbo].[Productos]
                                                   ([codigo]
                                                   ,[nombre]
                                                   ,[categoria]
                                                   ,[preciocosto]
                                                   ,[margen]
                                                   ,[iva]
                                                   ,[preciobruto]
                                                   ,[precioventa])
                                             VALUES
                                                   (@code
                                                   ,@name
                                                   ,@category
                                                   ,@costPrice
                                                   ,@margin
                                                   ,@iva
                                                   ,@grossPrice
                                                   ,@sellPrice)";

                    SqlCommand cmd = new SqlCommand(qInsertProduct, sqlConnection);

                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@costPrice", costPrice);
                    cmd.Parameters.AddWithValue("@margin", margin);
                    cmd.Parameters.AddWithValue("@iva", iva);
                    cmd.Parameters.AddWithValue("@grossPrice", grossPrice);
                    cmd.Parameters.AddWithValue("@sellPrice", sellPrice);

                    resp = cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

                return false;
            }

            return resp > 0;
        }
    }
}