using AgvCco.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Repositories.DatabaseManager
{
    /// <summary>
    /// Admon de repositorios
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    public class ManagerRepository<T ,K> : RepositoryBase<T , K>
    {
        /// <summary>
        /// Member 
        /// </summary>
        readonly object repository;
        /// <summary>
        /// Member tipo de repositorio
        /// </summary>
        readonly ManagerRepositoryType repositoryType;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="connectionString"></param>
        public ManagerRepository(string name, RepositoryDatabaseProvider provider, string connectionString)
        {
            switch (name)
            {
                case "GetAllPro":
                    repositoryType = ManagerRepositoryType.GetAllPro;
                    repository = new ProducGetAllRepository(provider, connectionString);
                    break;
                case "AddCar":
                    repositoryType = ManagerRepositoryType.AddCar;
                    repository = new CarPostRepository(provider, connectionString);
                    break;
                case "GetCarSta":
                    repositoryType = ManagerRepositoryType.GetCarSta;
                    repository = new CarGetAddRepository(provider, connectionString);
                    break;

                default:
                    break;
            }
        }
        /// <summary>
        /// Eliminar generico
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public override int Delete(K Data)
        {
            return base.Delete(Data);
        }
        /// <summary>
        /// Comparador generico
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        /// <summary>
        /// Obtener datos
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public override T Get(K Parameters)
        {
            switch (repositoryType)
            {
                case ManagerRepositoryType.GetAllPro:
                    return (T)(object)((ProducGetAllRepository)repository).Get(Parameters as string);
                case ManagerRepositoryType.GetCarSta:
                    return (T)(object)((CarGetAddRepository)repository).Get(Parameters as Tuple<string, int>);
                default:
                    break;
            }
            return base.Get(Parameters);
        }
        /// <summary>
        /// Insertar datos generico
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public override T Post(K data)
        {
            switch (repositoryType)
            {
                case ManagerRepositoryType.AddCar:
                    return (T)(object)((CarPostRepository)repository).Post(data as Car);  
                default:
                    break;
            }
            return base.Post(data);
        }
        /// <summary>
        /// Actualizar
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public override int Put(K Data)
        {
            return base.Put(Data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
