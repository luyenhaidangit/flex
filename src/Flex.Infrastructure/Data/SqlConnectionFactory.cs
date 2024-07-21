using Oracle.ManagedDataAccess.Client;
using System.Data;
using Flex.Application.Common.Data;

namespace Flex.Infrastructure.Data
{
    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly string _connectionString;

        public SqlConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            var con = new OracleConnection(_connectionString);
            con.Open();

            return con;
        }
    }
}
