using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
namespace AgvCompra.WebServices
{
    /// <summary>
    /// Clase base para un controlador MVC
    /// </summary>
    public abstract class ApiControllerBase : ControllerBase
    {
        /// <summary>
        /// Member de Cadena de conexion
        /// </summary>
        internal readonly ConnectionContext ConnectionContext;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connectionContext"></param>
        public ApiControllerBase(IOptions<ConnectionContext> connectionContext)
        {
            ConnectionContext = connectionContext?.Value;
        }
    }
}
