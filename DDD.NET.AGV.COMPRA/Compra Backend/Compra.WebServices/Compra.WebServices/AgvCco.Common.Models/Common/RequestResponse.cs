using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Common.Models 
{
    /// <summary>
    /// Respueta de operaciones
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RequestResponse<T>
    {
        /// <summary>
        /// Mensaje de respuesta
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Estado de la respuesta
        /// </summary>
        public bool Successful { get; set; }
        /// <summary>
        /// Ressult
        /// </summary>
        public T Result { get; set; }
    }
}
