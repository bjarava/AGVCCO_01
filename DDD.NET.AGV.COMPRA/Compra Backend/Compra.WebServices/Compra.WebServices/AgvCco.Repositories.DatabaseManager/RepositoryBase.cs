using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Repositories.DatabaseManager
{
    /// <summary>
    /// Repositorio Base
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    public class RepositoryBase<T, K> : IRepository<T, K>
    {
        /// <summary>
        /// Proveedor
        /// </summary>
        public RepositoryDatabaseProvider Provider { get; protected set; }
        /// <summary>
        /// Conexion
        /// </summary>
        public string ConnectionString { get; protected set; }
        /// <summary>
        /// Eliminar
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public virtual int Delete(K Data)
        {
            return 0;
        }
        /// <summary>
        /// Obtener
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public virtual T Get(K Parameters)
        {
            return default(T);
        }
        /// <summary>
        /// Insertar
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public virtual T Post(K Parameters)
        {
            return default(T);
        }
        /// <summary>
        /// Actualizar
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public virtual int Put(K Data)
        {
            return 0;
        }
    }
}
