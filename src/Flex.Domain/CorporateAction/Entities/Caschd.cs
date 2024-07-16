namespace Flex.Domain.CorporateAction.Entities
{
    /// <summary>
    /// Lịch thực hiện quyền cho từng tài khoản chứng khoán.
    /// </summary>
    public class Caschd
    {
        // Mã thực hiện quyền
        public string CamastId { get; set; }

        // Trạng thái xoá thực hiện quyền
        public string Deltd { get; set; }
    }
}
