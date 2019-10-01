using AgvCco.Common.Models;
using AgvCco.Common.Writes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Repositories.DatabaseManager
{
    /// <summary>
    /// Repositorio de Carrito adicionar
    /// </summary>
    public class CarPostRepository : RepositoryBase<RequestResponse<int>, Car>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="connectionString"></param>
        public CarPostRepository(RepositoryDatabaseProvider provider, string connectionString)
        {
            Provider = provider;
            ConnectionString = connectionString;
        }
        /// <summary>
        /// modificador data
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public override RequestResponse<int> Post(Car Parameters)
        {
            return CarWrites.AddCar(Parameters, Provider.ToString(), ConnectionString.ToString());
        }
    }
}
