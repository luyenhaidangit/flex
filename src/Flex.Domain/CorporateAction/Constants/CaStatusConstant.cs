namespace Flex.Domain.CorporateAction.Constants
{
    public static class CaStatusConstant
    {
        public const string WaitingForConfirmation = "A";
        public const string Confirmed = "S";
        public const string NoSecuritiesBalance = "B";
        public const string Completed = "C";
        public const string Deleted = "D";
        public const string Rejected = "E";
        public const string MoneyAllocated3342 = "G";
        public const string SecuritiesAllocated3341 = "H";
        public const string WaitingForExecution = "I";
        public const string AllocationCompleted = "J";
        public const string PartiallyExecuted = "K";
        public const string Executed3384 = "M";
        public const string Approved = "N";
        public const string TransferredToCloseAccount = "O";
        public const string WaitingForApproval = "P";
        public const string Cancelled = "R";
        public const string ConfirmedWithVSD = "V";
        public const string TransferredToTrading = "W";

        private static readonly Dictionary<string, string> Descriptions = new Dictionary<string, string>
        {
            { WaitingForConfirmation, "Chờ xác nhận" },
            { Confirmed, "Xác nhận" },
            { NoSecuritiesBalance, "Không có số dư chứng khoán" },
            { Completed, "Hoàn tất" },
            { Deleted, "Đã xóa" },
            { Rejected, "Từ chối" },
            { MoneyAllocated3342, "Đã thực hiện phân bổ tiền 3342" },
            { SecuritiesAllocated3341, "Đã thực hiện phân bổ chứng khoán 3341" },
            { WaitingForExecution, "Chờ thực hiện" },
            { AllocationCompleted, "Hoàn tất phân bổ" },
            { PartiallyExecuted, "Đã thực hiện một phần" },
            { Executed3384, "Đã thực hiện 3384" },
            { Approved, "Duyệt" },
            { TransferredToCloseAccount, "Đã chuyển khoản để đóng tài khoản" },
            { WaitingForApproval, "Chờ duyệt" },
            { Cancelled, "Hủy" },
            { ConfirmedWithVSD, "Đã xác nhận với VSD" },
            { TransferredToTrading, "Đã chuyển chứng khoán chờ giao dịch thành giao dịch" }
        };

        public static string GetDescription(string code)
        {
            return Descriptions.TryGetValue(code, out var description) ? description : "Unknown status";
        }
    }
}
