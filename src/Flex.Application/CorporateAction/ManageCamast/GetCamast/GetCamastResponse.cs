namespace Flex.Application.CorporateAction.ManageCamast.GetCamast
{
    public class GetCamastResponse
    {
        public string? IsinCode { get; set; }            // ISINCODE
        public string? CamastId { get; set; }            // CAMASTID
        public string? CaType { get; set; }              // CATYPE
        public string? ToSymbol { get; set; }            // TOSYMBOL
        public string? Symbol { get; set; }              // SYMBOL
        public string? Status { get; set; }              // STATUS
        public DateTime? KhqDate { get; set; }           // KHQDATE
        public DateTime? ReportDate { get; set; }        // REPORTDATE
        public DateTime? ActionDate { get; set; }        // ACTIONDATE
        public DateTime? InActionDate { get; set; }      // INACTIONDATE
        public DateTime? BeginDate { get; set; }         // BEGINDATE
        public DateTime? DueDate { get; set; }           // DUEDATE
        public DateTime? TradeDate { get; set; }         // TRADEDATE
        public DateTime? FrDateTransfer { get; set; }    // FRDATETRANSFER
        public DateTime? ToDateTransfer { get; set; }    // TODATETRANSFER
        public string? Description { get; set; }         // DESCRIPTION
        public decimal? PitRateSe { get; set; }          // PITRATESE
        public decimal? PitRate { get; set; }            // PITRATE
        public string? PitRateMethod { get; set; }       // PITRATEMETHOD
        public decimal? Qtty { get; set; }                   // QTTY
        public decimal? Amt { get; set; }                // AMT
        public string? MakerId { get; set; }             // MAKERID
        public string? ApprvId { get; set; }             // APPRVID
        public string? AprAllow { get; set; }            // APRALLOW
    }
}
