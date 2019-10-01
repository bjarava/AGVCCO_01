using AgvCco.Common.Models;
using AgvCco.Repositories;
using AgvCco.Repositories.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Managers
{
    /// <summary>
    /// Manejador de productos
    /// </summary>
    public class ProductManager
    {
        /// <summary>
        /// Member de factoria de repositorio
        /// </summary>
        readonly RepositoryFactory<RequestResponse<List<Product>>, object> repositoryFactoryImplementorGetAllProduc;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="ConnectionString"></param>
        public ProductManager(RepositoryDatabaseProvider provider, string ConnectionString)
        {
            repositoryFactoryImplementorGetAllProduc = new RepositoryFactory<RequestResponse<List<Product>>, object>(RepositoryType.DatabaseManager);
            repositoryFactoryImplementorGetAllProduc.GetRepository("GetAllPro", provider, ConnectionString);
        }
        /// <summary>
        /// Obtener todos los productos
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RequestResponse<List<Product>> GetAllPro(object request)
        {
            return repositoryFactoryImplementorGetAllProduc.Get(request);
        }

    }
}
