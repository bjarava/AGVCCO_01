using AgvCco.Common.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AgvCco.Common.Reads
{
    public class CarHandler
    {
        /// <summary>
        /// Obtener listado de productos adicionados al carrito antes de grabar
        /// </summary>
        /// <param name="State">Parametros de entrada, estado antes de grabar</param>
        /// <param name="Carusu">Parametros de entrada</param>
        /// <param name="provider"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static RequestResponse<List<Car>> GetCarSta(string State, Int32 carusu, string provider, string connectionString)
        {
            ///Respuesta del carrito
            RequestResponse<List<Car>> response = new RequestResponse<List<Car>>();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = ResourceHelper.GetQuery(ReadResources.Queries, provider, ReadsConstants.GET_CAR_ADD);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@carest", State);
                cmd.Parameters.AddWithValue("@carusu", carusu);
                cmd.CommandText = cmd.CommandText;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    response.Result = new List<Car>();
                    response.Successful = true;
                    while (reader.Read())
                    {
                        Car car = new Car
                        {
                            Caride = reader.GetInt64(reader.GetOrdinal("caride")),
                            Carpro = reader.GetInt64(reader.GetOrdinal("carpro")),
                            Pronom = reader.GetString(reader.GetOrdinal("pronom")),
                            Carcan = reader.GetInt32(reader.GetOrdinal("carcan")), 
                            Carfeh = reader.GetDateTime(reader.GetOrdinal("carfeh"))
                        };
                        response.Result.Add(car);
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
