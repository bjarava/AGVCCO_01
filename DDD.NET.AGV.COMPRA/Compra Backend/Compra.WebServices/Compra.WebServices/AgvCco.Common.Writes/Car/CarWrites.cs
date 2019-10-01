using AgvCco.Common.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AgvCco.Common.Writes
{
    /// <summary>
    /// Entidad carrito
    /// </summary>
    public class CarWrites
    {
        /// <summary>
        /// Adicionar producto
        /// </summary>
        /// <param name="car"></param>
        /// <param name="provider"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static RequestResponse<int> AddCar(Car car, string provider, string connectionString)
        {
            ///Respuesta
            RequestResponse<int> response = new RequestResponse<int>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(ResourceHelper.GetQuery(ReadResources.Queries, provider, ReadsConstants.INSERT_PRO_CAR), connection);

                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@as_carpro", car.Carpro);
                    command.Parameters.AddWithValue("@as_carcan", car.Carcan);
                    if(car.Carusu.HasValue)
                        command.Parameters.AddWithValue("@as_carusu", car.Carusu);
                    else
                        command.Parameters.AddWithValue("@as_carusu", 999999); 

                    command.Parameters.AddWithValue("@as_carfeh", car.Carfeh);
                    command.Parameters.AddWithValue("@as_carest", car.Carest);

                    var index = command.ExecuteNonQuery();
                    response.Successful = true;
                    response.Result = index;
                }
            }
            catch (Exception ex)
            {
                response.Successful = false;
                response.Message = ex.Message;
            }
            return response;
        }        
    }
}
