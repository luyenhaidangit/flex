namespace Flex.Common.Extensions
{
    public static class StringExtension
    {
        public static string TrimAndUpper(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return str.Trim().ToUpper();
        }
    }
}