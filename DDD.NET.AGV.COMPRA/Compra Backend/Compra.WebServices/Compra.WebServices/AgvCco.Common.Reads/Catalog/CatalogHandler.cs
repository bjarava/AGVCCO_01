using AgvCco.Common.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AgvCco.Common.Reads
{
    /// <summary>
    /// Catalogo
    /// </summary>
    public class CatalogHandler
    {
        /// <summary>
        /// Obtener catalogo adicionado
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static RequestResponse<List<Catalog>> GetCatalog(string provider, string connectionString)
        {
            RequestResponse<List<Catalog>> response = new RequestResponse<List<Catalog>>();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = ResourceHelper.GetQuery(ReadResources.Queries, provider, ReadsConstants.GET_CAR_ADD);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandText = cmd.CommandText;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    response.Result = new List<Catalog>();
                    response.Successful = true;
                    while (reader.Read())
                    {
                        Catalog catalog = new Catalog
                        {
                            Catide = reader.GetInt32(reader.GetOrdinal("catide")),
                            Catpro = reader.GetInt32(reader.GetOrdinal("catpro")),
                            Catcan = reader.GetInt32(reader.GetOrdinal("catcan")),
                            Catref = reader.GetString(reader.GetOrdinal("catref"))
                        };
                        response.Result.Add(catalog);
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
