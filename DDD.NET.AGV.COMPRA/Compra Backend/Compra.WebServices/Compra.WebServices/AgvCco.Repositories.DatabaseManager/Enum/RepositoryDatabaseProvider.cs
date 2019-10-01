using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Repositories.DatabaseManager
{
    /// <summary>
    /// Proveedor de motores de DB
    /// </summary>
    public enum RepositoryDatabaseProvider
    {
        Informix,
        Oracle,
        SqlServer,
        NoSql
    }
}
