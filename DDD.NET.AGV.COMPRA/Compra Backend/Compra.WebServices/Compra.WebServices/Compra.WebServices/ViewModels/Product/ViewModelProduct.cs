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
    /// View Model de Productos
    /// </summary>
    public class ViewModelProduct
    {
        /// <summary>
        /// Member de producto
        /// </summary>
        readonly ProductManager manager;
        public ViewModelProduct(RepositoryDatabaseProvider provider, string connectionString)
        {
            manager = new ProductManager(provider, connectionString);
        }
        /// <summary>
        /// Lista de productos
        /// </summary>
        /// <returns></returns>
        public RequestResponse<List<Product>> GetAllPro()
        {
            return manager.GetAllPro(null);
        }
    }
}
