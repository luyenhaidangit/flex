namespace Flex.Domain.SecuritiesPortfolio.Entities
{
    /// <summary>
    /// Thông tin về chứng khoán.
    /// </summary>
    public class Sbsecurities
    {
        // Mã code chứng khoán
        public string CodeId { get; set; }

        /// <summary>
        /// Mệnh giá chứng khoán.
        /// Xác định giá trị, tính toán lãi suất, cổ tức...
        /// </summary>
        public string Parvalue { get; set; }
    }
}
