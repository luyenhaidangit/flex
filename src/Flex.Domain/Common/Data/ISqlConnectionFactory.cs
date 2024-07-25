using System.Data;

namespace Flex.Domain.Common.Data
{
    public interface ISqlConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}