using System.ComponentModel;

namespace Flex.Domain.CorporateAction.Enums
{
    public enum CorporateActionType
    {
        [Description("Tham dự đại hội cổ đông")]
        ShareholdersMeeting = 005,

        [Description("Lấy ý kiến cổ đông")]
        ShareholdersOpinion = 006,

        [Description("Chia cổ tức bằng tiền")]
        CashDividend = 010,

        [Description("Chia cổ tức bằng cổ phiếu")]
        StockDividend = 011,

        [Description("Quyền mua")]
        PurchaseRight = 014,

        [Description("Trả lãi trái phiếu")]
        BondInterestPayment = 015,

        [Description("Trả gốc và lãi trái phiếu")]
        BondPrincipalAndInterestPayment = 016,

        [Description("Chuyển đổi trái phiếu thành cổ phiếu")]
        BondToStockConversion = 017,

        [Description("Chuyển sàn")]
        ExchangeTransfer = 019,

        [Description("Chuyển đổi cổ phiếu thành cổ phiếu")]
        StockToStockConversion = 020,

        [Description("Cổ phiếu thưởng")]
        BonusStock = 021,

        [Description("Quyền bỏ phiếu")]
        VotingRight = 022,

        [Description("Chuyển đổi Trái phiếu– Chọn nhận CP hoặc Tiền")]
        BondConversionToStockOrCash = 023,

        [Description("Chuyển cổ phiếu chờ giao dịch thành giao dịch")]
        PendingStockToTradingStock = 026,

        [Description("Trả lãi trái phiếu OTC")]
        OTCBondInterestPayment = 027,

        [Description("Chi trả lợi tức chứng quyền")]
        WarrantDividendPayment = 028
    }
}
