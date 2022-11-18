
using System.Data;

namespace Dapper.Data
{
    public interface  IdbStrategy
    {
       IDbConnection GetConnection(string connectionString);
    }
}
