using Flex.Domain.CorporateAction.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flex.Domain.CorporateAction.Entities
{
    /// <summary>
    /// Thông tin về các đợt thực hiện quyền.
    /// </summary>
    [Table("CAMAST")]
    public class Camast
    {
        #region Properties
        // Mã thực hiện quyền
        [Key]
        [Column("CAMASTID")]
        public string CamastId { get; set; }

        // Mã code chứng khoán
        [Column("CODEID")]
        public string CodeId { get; set; }

        /// <summary>
        /// Mệnh giá chứng khoán.
        /// Xác định giá trị, tính toán lãi suất, cổ tức...
        /// </summary>
        [Column("PARVALUE")]
        public string Parvalue { get; set; }

        /// <summary>
        /// Loại thực hiện quyền
        /// Nhận các giá trị <see cref="Flex.Domain.CorporateAction.Enums.CorporateActionType"/>.
        /// </summary>
        [Column("CATYPE")]
        public string Catype { get; set; }

        // Ngày đăng ký cuối cùng
        //public DateTime ReportDate { get; set; }
        //public string ReportDate { get; set; }

        // Trạng thái xoá thực hiện quyền
        [Column("DELTD")]
        public string Deltd { get; set; }
        #endregion

        #region Bussiness

        #region Catype
        private static readonly HashSet<CorporateActionType> PendingStockActions = new HashSet<CorporateActionType>
        {
            CorporateActionType.StockDividend,
            CorporateActionType.PurchaseRight,
            CorporateActionType.StockToStockConversion,
            CorporateActionType.BonusStock
        };

        private static readonly HashSet<CorporateActionType> PendingDividendActions = new HashSet<CorporateActionType>
        {
            CorporateActionType.StockDividend,
            CorporateActionType.BonusStock,
            CorporateActionType.StockToStockConversion,
            CorporateActionType.CashDividend,
            CorporateActionType.BondInterestPayment
        };

        // Sự kiện quyền có chứng khoán chờ về
        public bool IsPendingStockAction()
        {
            if (Enum.TryParse(typeof(CorporateActionType), Catype, out var result))
            {
                return PendingStockActions.Contains((CorporateActionType)result);
            }
            return false;
        }

        // Sự kiện quyền có tiền cổ tức chờ về
        public bool IsPendingDividendAction()
        {
            if (Enum.TryParse(typeof(CorporateActionType), Catype, out var result))
            {
                return PendingDividendActions.Contains((CorporateActionType)result);
            }
            return false;
        }
        #endregion

        #endregion
    }
}