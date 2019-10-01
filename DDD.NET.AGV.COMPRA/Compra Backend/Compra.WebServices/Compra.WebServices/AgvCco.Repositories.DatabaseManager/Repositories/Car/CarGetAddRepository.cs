using AgvCco.Common.Models;
using AgvCco.Common.Reads;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Repositories.DatabaseManager 
{
    public class CarGetAddRepository : RepositoryBase<RequestResponse<List<Car>>, Tuple<string, int>>
    {
        public CarGetAddRepository(RepositoryDatabaseProvider provider, string connectionString)
        {
            Provider = provider;
            ConnectionString = connectionString;
        }

        public override RequestResponse<List<Car>> Get(Tuple<string, int> Parameters)
        {
            return CarHandler.GetCarSta(Parameters.Item1, Parameters.Item2, Provider.ToString(), ConnectionString.ToString());
        }
    }
}
