using Flex.Application.Common.Message;
using Flex.Application.Common.Shared;

namespace Flex.Application.Customer.ManageSemast.GetSemast
{
    public sealed record GetSemastQuery(GetSemastRequest request) : IQuery<PagingResult<GetSemastResponse>>;
}