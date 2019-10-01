using AgvCco.Common.Models;
using AgvCco.Managers;
using AgvCco.Repositories.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgvCompra.WebServices 
{
    /// <summary>
    /// View models
    /// </summary>
    public class ViewModelCar
    {
        /// <summary>
        /// Manager
        /// </summary>
        readonly CarManager manager;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="connectionString"></param>
        public ViewModelCar(RepositoryDatabaseProvider provider, string connectionString)
        {
            manager = new CarManager(provider, connectionString);
        }
        /// <summary>
        /// Adicinar al carrito
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public RequestResponse<int> AddCar(Car car)
        {
            return manager.AddCar(car);
        }
        /// <summary>
        /// Obtener datos add
        /// </summary>
        /// <param name="State"></param>
        /// <param name="Carusu"></param>
        /// <returns></returns>
        public RequestResponse<List<Car>> GetCarSta(string State, Int32 Carusu)
        {
            return manager.GetCarSta(State, Carusu);
        }
    }
}
