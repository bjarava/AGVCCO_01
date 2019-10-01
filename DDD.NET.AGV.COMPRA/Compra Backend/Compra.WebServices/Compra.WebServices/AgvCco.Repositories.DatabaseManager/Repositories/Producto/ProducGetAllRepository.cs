using AgvCco.Common.Models;
using AgvCco.Common.Reads;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Repositories.DatabaseManager 
{
    /// <summary>
    /// repositorio para obtener lista de todos los productos
    /// </summary>
    public class ProducGetAllRepository : RepositoryBase<RequestResponse<List<Product>>, object>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="connectionString"></param>
        public ProducGetAllRepository(RepositoryDatabaseProvider provider, string connectionString)
        {
            Provider = provider;
            ConnectionString = connectionString;
        }
        /// <summary>
        /// consultar listado de productos
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public override RequestResponse<List<Product>> Get(object Parameters)
        {
            return ProductHandler.GetAllPro(Provider.ToString(), ConnectionString.ToString());

        }
    }
}
