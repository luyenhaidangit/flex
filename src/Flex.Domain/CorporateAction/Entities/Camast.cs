namespace Flex.Domain.CorporateAction.Entities
{
    /// <summary>
    /// Thông tin về các đợt thực hiện quyền.
    /// Thuộc tính:
    /// + CamastId: Khoá chính, Mã thực hiện quyền
    /// + Catype: Loại thực hiện quyền, nhận các giá trị <see cref="Flex.Domain.CorporateAction.Constants.CaTypeConstant"/>
    /// + CodeId: Mã chứng khoán
    /// + ToCodeId: Mã chứng khoán nhận, chuyển đổi, cổ tức,...
    /// + Status: Trạng thái thực hiện quyền, nhận các giá trị <see cref="Flex.Domain.CorporateAction.Constants.CaStatusConstant"/>
    /// </summary>
    public class Camast
    {
        #region Properties
        public string CamastId { get; set; }

        public string Catype { get; set; }

        public string CodeId { get; set; }

        public string ToCodeId { get; set; }

        public string Status { get; set; }

        //public DateOnly ReportDate { get; set; }

        //public DateOnly DueDate { get; set; }

        //public DateOnly ActionDate { get; set; }

        //public double ExPrice { get; set; }

        //public decimal? Price { get; set; }

        //public string ExRate { get; set; }

        //public string RightOffRate { get; set; }

        //public string DevidentRate { get; set; }

        //public string DevidentShares { get; set; }

        //public string SplitRate { get; set; }

        //public string InterestRate { get; set; }

        //public decimal InterestPeriod { get; set; }

        //public string Description { get; set; }

        //public string ExCodeId { get; set; }

        //public string PStatus { get; set; }

        //public decimal Rate { get; set; }

        //public string Deltd { get; set; }

        //public string TrfLimit { get; set; }

        //public decimal ParValue { get; set; }

        //public string RoundType { get; set; }

        //public string OptSymbol { get; set; }

        //public string OptCodeId { get; set; }

        //public DateTime? TradeDate { get; set; }

        //public DateTime? LastDate { get; set; }

        //public string RetailShare { get; set; }

        //public DateTime? RetailDate { get; set; }

        //public DateTime? FrDateRetail { get; set; }

        //public DateTime? ToDateRetail { get; set; }

        //public string FrTradePlace { get; set; }

        //public string ToTradePlace { get; set; }

        //public string TransferTimes { get; set; }

        //public DateTime? FrDateTransfer { get; set; }

        //public DateTime? ToDateTransfer { get; set; }

        //public string TaskCd { get; set; }

        //public DateTime? LastChange { get; set; }

        //public decimal PitRate { get; set; }

        //public string PitRateMethod { get; set; }

        //public string IsWft { get; set; }

        //public decimal PriceAccounting { get; set; }

        //public decimal? CaQty { get; set; }

        //public DateTime? BeginDate { get; set; }

        //public string PurposeDesc { get; set; }

        //public decimal? DevidentValue { get; set; }

        //public string AdvDesc { get; set; }

        //public string TypeRate { get; set; }

        //public decimal CirRoundType { get; set; }

        //public decimal PitRateSe { get; set; }

        //public DateTime? InActionDate { get; set; }

        //public string MakerId { get; set; }

        //public string ApprvId { get; set; }

        //public decimal ExeRate { get; set; }

        //public DateTime? CancelDate { get; set; }

        //public DateTime? ReceiveDate { get; set; }

        //public string CancelStatus { get; set; }

        //public string IsinCode { get; set; }

        //public decimal CashRound { get; set; }

        //public string IsAlloc { get; set; }

        //public string IsChangeWft { get; set; }

        //public DateTime? FDateOtc { get; set; }

        //public DateTime? TDateOtc { get; set; }

        //public decimal DayOfYear { get; set; }

        //public string RefCorpId { get; set; }

        //public DateTime? NRateNextDate { get; set; }

        //public DateTime? NDueDate { get; set; }

        //public DateTime? NoDate { get; set; }

        //public DateTime? ExFromDate { get; set; }

        //public DateTime? ExToDate { get; set; }

        //public DateTime? ExCancelDate { get; set; }

        //public DateTime? ExRecvDate { get; set; }

        //public string DomesticCd { get; set; }

        //public string VsdStatus { get; set; }

        //public string ExAddress { get; set; }

        //public string VsdId { get; set; }

        //public string ParName { get; set; }

        //public decimal AutoId { get; set; }
        #endregion
    }
}