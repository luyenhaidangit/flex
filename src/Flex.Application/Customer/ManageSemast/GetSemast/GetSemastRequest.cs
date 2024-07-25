using Flex.Application.Common.Shared;

namespace Flex.Application.Customer.ManageSemast.GetSemast
{
    public class GetSemastRequest : PagingRequest
    {
        public string? SemastId { get; set; }

        public string? AfAccTno  { get; set; }

        public string? CustodyCd { get; set; }

        public string? SymBol { get; set; }

        public string? Status { get; set; }
    }
}