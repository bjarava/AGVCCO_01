using AgvCco.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AgvCco.Common.Reads
{
    /// <summary>
    /// Administrador de consultas para productos
    /// </summary>
    public class ProductHandler
    {
        public static RequestResponse<List<Product>> GetAllPro(string provider, string connectionString)
        {
            RequestResponse<List<Product>> response = new RequestResponse<List<Product>>();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = ResourceHelper.GetQuery(ReadResources.Queries, provider, ReadsConstants.GET_ALL_PRODUCT);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandText = cmd.CommandText;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    response.Result = new List<Product>();
                    response.Successful = true;
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            Proide = reader.GetInt64(reader.GetOrdinal("proide")),
                            Pronom = reader.GetString(reader.GetOrdinal("pronom")),
                            Propre = reader.GetDecimal(reader.GetOrdinal("propre")),
                            Profcr = reader.GetDateTime(reader.GetOrdinal("profcr")),
                            Procan = reader.GetInt32(reader.GetOrdinal("catcan")),
                            Proref = reader.GetString(reader.GetOrdinal("catref"))
                        };
                        response.Result.Add(product);
                    }
                }
                else
                {
                    
                    response.Successful = false;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Successful = false;
            }
            return response;
        }
    }
}
