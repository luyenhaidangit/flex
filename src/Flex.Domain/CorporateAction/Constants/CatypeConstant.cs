namespace Flex.Domain.CorporateAction.Constants
{
    public class CaTypeConstant
    {
        public const string AttendingShareholderMeeting = "005";
        public const string CollectingShareholderOpinions = "006";
        public const string PayingCashDividends = "010";
        public const string PayingStockDividends = "011";
        public const string PurchaseRights = "014";
        public const string PayingBondInterest = "015";
        public const string PayingBondPrincipalAndInterest = "016";
        public const string ConvertingBondsToShares = "017";
        public const string SwitchingStockExchanges = "019";
        public const string ConvertingSharesToShares = "020";
        public const string BonusShares = "021";
        public const string VotingRights = "022";
        public const string ConvertingBondsChoiceSharesOrCash = "023";
        public const string SwitchingPendingSharesToTradingShares = "026";
        public const string PayingOTCBondInterest = "027";
        public const string WarrantReturns = "028";

        private static readonly Dictionary<string, string> Descriptions = new Dictionary<string, string>
        {
            { AttendingShareholderMeeting, "Tham dự đại hội cổ đông" },
            { CollectingShareholderOpinions, "Lấy ý kiến cổ đông" },
            { PayingCashDividends, "Chia cổ tức bằng tiền" },
            { PayingStockDividends, "Chia cổ tức bằng cổ phiếu" },
            { PurchaseRights, "Quyền mua" },
            { PayingBondInterest, "Trả lãi trái phiếu" },
            { PayingBondPrincipalAndInterest, "Trả gốc và lãi trái phiếu" },
            { ConvertingBondsToShares, "Chuyển đổi trái phiếu thành cổ phiếu" },
            { SwitchingStockExchanges, "Chuyển sàn" },
            { ConvertingSharesToShares, "Chuyển đổi cổ phiếu thành cổ phiếu" },
            { BonusShares, "Cổ phiếu thưởng" },
            { VotingRights, "Quyền bỏ phiếu" },
            { ConvertingBondsChoiceSharesOrCash, "Chuyển đổi Trái phiếu– Chọn nhận CP hoặc Tiền" },
            { SwitchingPendingSharesToTradingShares, "Chuyển cổ phiếu chờ giao dịch thành giao dịch" },
            { PayingOTCBondInterest, "Trả lãi trái phiếu OTC" },
            { WarrantReturns, "Chi trả lợi tức chứng quyền" }
        };

        public static string GetDescription(string code)
        {
            return Descriptions.TryGetValue(code, out var description) ? description : "Unknown code";
        }
    }
}
