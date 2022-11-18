using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dapper.Data.Context
{
 
        public class SqlServerStrategy : IdbStrategy
        {
            public IDbConnection GetConnection(string connectionString)
            {
             //return new SqlConnection(connectionString);
            return new SqlConnection("Data Source = DESKTOP-C1BR95S;Initial Catalog = DapperDatabase;Trusted_Connection=True;");
        }
        }
    
}
