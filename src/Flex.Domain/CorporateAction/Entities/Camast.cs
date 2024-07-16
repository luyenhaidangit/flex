using Flex.Domain.CorporateAction.Enums;
using System.Linq;

namespace Flex.Domain.CorporateAction.Entities
{
    /// <summary>
    /// Thông tin về các đợt thực hiện quyền.
    /// </summary>
    public class Camast
    {
        #region Properties
        public string CamastId { get; set; }

        public string Catype { get; set; }

        public DateTime ReportDate { get; set; }
        #endregion

        #region Bussiness
        // Catype
        private static readonly HashSet<CorporateActionType> PendingStockActions = new HashSet<CorporateActionType>
        {
            CorporateActionType.PurchaseRight,
            CorporateActionType.StockDividend,
            CorporateActionType.BonusShares,
            CorporateActionType.StockToStockConversion
        };

        public bool IsPendingStockAction => PendingStockActions.Contains(this.Catype);
        #endregion
    }
}