using Flex.Domain.CorporateAction.Enums;

namespace Flex.Domain.CorporateAction.Entities
{
    /// <summary>
    /// Thông tin về các đợt thực hiện quyền.
    /// </summary>
    public class Camast
    {
        #region Properties
        // Mã thực hiện quyền
        public string CamastId { get; set; }

        // Mã code chứng khoán
        public string CodeId { get; set; }

        /// <summary>
        /// Mệnh giá chứng khoán.
        /// Xác định giá trị, tính toán lãi suất, cổ tức...
        /// </summary>
        public string Parvalue { get; set; }

        /// <summary>
        /// Loại thực hiện quyền
        /// Nhận các giá trị <see cref="CorporateActionType"/>.
        /// </summary>
        public string Catype { get; set; }

        // Ngày đăng ký cuối cùng
        public DateTime ReportDate { get; set; }

        // Trạng thái xoá thực hiện quyền
        public string Deltd { get; set; }
        #endregion

        #region Define

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
        public bool IsPendingStockAction
        {
            get
            {
                if (Enum.TryParse(typeof(CorporateActionType), Catype, out var result))
                {
                    return PendingStockActions.Contains((CorporateActionType)result);
                }
                return false;
            }
        }

        // Sự kiện quyền có tiền cổ tức chờ về
        public bool IsPendingDividendAction
        {
            get
            {
                if (Enum.TryParse(typeof(CorporateActionType), Catype, out var result))
                {
                    return PendingDividendActions.Contains((CorporateActionType)result);
                }
                return false;
            }
        }
        #endregion

        #endregion
    }
}