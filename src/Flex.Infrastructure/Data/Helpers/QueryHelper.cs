namespace Flex.Infrastructure.Data.Helpers
{
    public static class QueryHelper
    {
        public static string BuildCountQuery(string sql)
        {
            return $"SELECT COUNT(*) FROM ({sql})";
        }
    }
}