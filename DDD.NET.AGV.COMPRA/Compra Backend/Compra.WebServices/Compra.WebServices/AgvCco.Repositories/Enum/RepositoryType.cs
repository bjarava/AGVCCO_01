using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Repositories
{
    /// <summary>
    /// Tipos de repositorios para tecnologías de despliegue
    /// </summary>
    public enum RepositoryType
    {
        ORM = 0,
        DatabaseManager = 1,
        NoSql = 2,
        Integration = 3
    }
}
