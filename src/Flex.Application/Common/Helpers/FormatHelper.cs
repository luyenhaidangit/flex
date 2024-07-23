namespace Flex.Application.Common.Helpers
{
    public static class FormatHelper
    {
        /// <summary>
        /// Formats a custody code ABCD.999999
        /// Example: 049C.000001.
        /// </summary>
        public static string FormatCustodyCd(string pStr)
        {
            if (string.IsNullOrEmpty(pStr))
            {
                throw new ArgumentNullException(nameof(pStr), "Input string custodycd cannot be null or empty.");
            }

            if (pStr.Length < 10)
            {
                throw new ArgumentOutOfRangeException(nameof(pStr), "Input string custodycd must be at least 10 characters long.");
            }

            string result = pStr.Substring(0, 4) + "." + pStr.Substring(4, 6).ToUpper();

            return pStr;
        }

        /// <summary>
        /// Formats a afactno code ABCD.999999
        /// Example: 0001.999999
        /// </summary>
        public static string FormatAfAcctNo(string afAcctNo)
        {
            if (string.IsNullOrEmpty(afAcctNo))
            {
                throw new ArgumentNullException(nameof(afAcctNo), "Input string afacctno cannot be null or empty.");
            }

            if (afAcctNo.Length < 10)
            {
                throw new ArgumentOutOfRangeException(nameof(afAcctNo), "Input string afacctno must be at least 10 characters long.");
            }

            string result = afAcctNo.Substring(0, 4) + "." + afAcctNo.Substring(4, 6);

            return result;
        }

        public static string FormatAcctNoGetSecurities(string acctNo)
        {
            if (string.IsNullOrEmpty(acctNo))
            {
                throw new ArgumentNullException(nameof(acctNo), "Input string AcctNo cannot be null or empty.");
            }

            if (acctNo.Length < 16)
            {
                throw new ArgumentOutOfRangeException(nameof(acctNo), "Input string AcctNo must be at least 16 characters long.");
            }

            string result = acctNo.Substring(0, 4) + "." + acctNo.Substring(4, 6) + "." + acctNo.Substring(10, 6);

            return result;
        }

        /// <summary>
        /// Formats a custid code ABCD.999999
        /// Example: 0001.999999
        /// </summary>
        public static string FormatCustId(string custId)
        {
            if (string.IsNullOrEmpty(custId))
            {
                throw new ArgumentNullException(nameof(custId), "Input string cannot be null or empty.");
            }

            if (custId.Length < 10)
            {
                throw new ArgumentOutOfRangeException(nameof(custId), "Input string must be at least 10 characters long.");
            }

            string result = custId.Substring(0, 4) + "." + custId.Substring(4, 6);
            return result;
        }
    }
}
