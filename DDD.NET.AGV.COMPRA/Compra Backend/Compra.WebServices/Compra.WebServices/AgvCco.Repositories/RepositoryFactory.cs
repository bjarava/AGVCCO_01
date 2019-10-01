using AgvCco.Repositories.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Repositories
{
    /// <summary>
    /// Fabrica de repositorios 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    public class RepositoryFactory<T, K> : IRepository<T, K>
    {
        /// <summary>
        /// Member de repositorios
        /// </summary>
        readonly RepositoryType repository; 

        public RepositoryBase<T , K> Repository { get; private set; }

        public RepositoryFactory(RepositoryType repositoryType)
        {
            repository = repositoryType;
        }
        /// <summary>
        /// Eliminar
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public int Delete(K Data)
        {
            return Repository.Delete(Data);
        }
        /// <summary>
        /// Obtener datos
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public T Get(K Parameters)
        {
            return Repository.Get(Parameters);
        }
        /// <summary>
        /// Insertar datos
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public T Post(K Parameters)
        {
            return Repository.Post(Parameters);
        }
        /// <summary>
        /// Actiualizar datos
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public int Put(K Data)
        {
            return Repository.Put(Data);
        }
        /// <summary>
        /// Obtener repositorios Data
        /// </summary>
        /// <param name="RepositoryName"></param>
        /// <param name="provider"></param>
        /// <param name="ConnectionString"></param>
        public void GetRepository(string RepositoryName, RepositoryDatabaseProvider provider, string ConnectionString)
        {
            switch (repository)
            {
                case RepositoryType.ORM:
                    break;
                case RepositoryType.DatabaseManager:
                    Repository = new ManagerRepository<T, K>(RepositoryName, provider, ConnectionString);
                    break;
                case RepositoryType.NoSql:
                    break;
                case RepositoryType.Integration:
                    break;
                default:
                    break;
            }
        }
    }
}
