using System.Data;
using System.Text.RegularExpressions;

namespace Flex.Infrastructure.Data.Extensions
{
    public static class DapperExtension
    {
        public static Task<IEnumerable<dynamic>> SearchAndPaginateAsync(this IDbConnection connection,string sql)
        {


            return null;
        }

        public static string BuildCountQuery(string baseQuery)
        {
            var cleanedQuery = Regex.Replace(baseQuery, @"--.*?$|/\*.*?\*/", string.Empty, RegexOptions.Singleline | RegexOptions.Multiline).Trim();

            // Tìm vị trí của từ khóa FROM sử dụng biểu thức chính quy
            var fromRegex = new Regex(@"\bFROM\b", RegexOptions.IgnoreCase);
            var match = fromRegex.Match(cleanedQuery);

            if (!match.Success)
            {
                throw new ArgumentException("Invalid query sql!");
            }

            // Xây dựng câu lệnh COUNT
            string countQuery = $"SELECT COUNT(*) {cleanedQuery.Substring(match.Index)}";
            return countQuery;
        }
    }
}
