using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Data.Context
{
  public  class dbContext
    {
          private IdbStrategy _dbStrategy;

            public dbContext SetStrategy()
            {
                _dbStrategy = new SqlServerStrategy();
                return this;
            }

            public IDbConnection GetDbContext(string connectionString)
            {
                return _dbStrategy.GetConnection(connectionString);
            }
        
    }
}
