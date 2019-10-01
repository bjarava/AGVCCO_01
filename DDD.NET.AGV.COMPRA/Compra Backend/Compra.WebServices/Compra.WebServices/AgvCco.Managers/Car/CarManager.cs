using AgvCco.Common.Models;
using AgvCco.Repositories;
using AgvCco.Repositories.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Managers
{
    /// <summary>
    /// Manajador de Carrito
    /// </summary>
    public class CarManager
    {
        /// <summary>
        /// Member de factoria de repositorios
        /// </summary>
        readonly RepositoryFactory<RequestResponse<int>, Car> repositoryFactoryImplementorAddCar;
        /// <summary>
        /// Factoria de ADD
        /// </summary>
        readonly RepositoryFactory<RequestResponse<List<Car>>, Tuple<string, int>> repositoryFactoryImplementorGetAdd;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="ConnectionString"></param>
        public CarManager(RepositoryDatabaseProvider provider, string ConnectionString)
        {
            repositoryFactoryImplementorAddCar = new RepositoryFactory<RequestResponse<int>, Car>(RepositoryType.DatabaseManager);
            repositoryFactoryImplementorAddCar.GetRepository("AddCar", provider, ConnectionString);

            repositoryFactoryImplementorGetAdd = new RepositoryFactory<RequestResponse<List<Car>>, Tuple<string, int>>(RepositoryType.DatabaseManager);
            repositoryFactoryImplementorGetAdd.GetRepository("GetCarSta", provider, ConnectionString);

        }
        /// <summary>
        /// Adicionar al carrito
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RequestResponse<int> AddCar(Car car)
        {
            return repositoryFactoryImplementorAddCar.Post(car);
        } 
        /// <summary>
        /// Obtener datos adicionados antes de grabar
        /// </summary>
        /// <param name="State"></param>
        /// <param name="Carusu"></param>
        /// <returns></returns>
        public RequestResponse<List<Car>> GetCarSta(string State, int Carusu)
        {
            return repositoryFactoryImplementorGetAdd.Get(new Tuple<string, int>(State, Carusu));
        }
    }
}
