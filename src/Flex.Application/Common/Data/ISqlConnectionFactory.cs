using System.Data;

namespace Flex.Application.Common.Data
{
    public interface ISqlConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
