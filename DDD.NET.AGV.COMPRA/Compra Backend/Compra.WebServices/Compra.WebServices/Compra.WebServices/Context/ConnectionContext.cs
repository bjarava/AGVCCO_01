
using AgvCco.Repositories.DatabaseManager;

namespace AgvCompra.WebServices
{
    /// <summary>
    /// Cadena de conexion
    /// </summary>
    public class ConnectionContext
    {
        /// <summary>
        /// Proveedor de datos
        /// </summary>
        public string Provider { get; set; }
        /// <summary>
        /// Conexion de base de datos
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// Obtener cadenas de conexion
        /// </summary>
        /// <returns></returns>
        public string GetConnectionString()
        {
            return ConnectionString;
        }
        /// <summary>
        /// Obtener proveedores de datos
        /// </summary>
        /// <returns></returns>
        public RepositoryDatabaseProvider GetProvider()
        {
            if (Provider.ToLower().Contains("informix"))
                return RepositoryDatabaseProvider.Informix;
            else if (Provider.ToLower().Contains("oracle"))
                return RepositoryDatabaseProvider.Oracle;
            else if (Provider.ToLower().Contains("sqlserver"))
                return RepositoryDatabaseProvider.SqlServer;
            else return RepositoryDatabaseProvider.NoSql;
        }

    }
}
