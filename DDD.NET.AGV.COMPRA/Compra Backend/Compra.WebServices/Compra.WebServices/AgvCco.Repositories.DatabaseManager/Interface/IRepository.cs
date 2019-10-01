using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Repositories.DatabaseManager
{
    /// <summary>
    /// Interface con métodos de entrada, retorno  y registros
    /// </summary>
    /// <typeparam name="T">Objeto a retornar</typeparam>
    /// <typeparam name="K">Parámetro de entrada</typeparam>
    public interface IRepository<T, K>
    {
        /// <summary>
        /// Eliminar
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        int Delete(K Data);
        /// <summary>
        /// Obtener datos
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        T Get(K Parameters);
        /// <summary>
        /// Insertar datos
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        T Post(K Parameters);
        /// <summary>
        /// Actualizar datos
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        int Put(K Data);
    }
}
