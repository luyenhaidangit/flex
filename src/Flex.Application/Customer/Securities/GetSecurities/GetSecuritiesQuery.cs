using Flex.Application.Common.Message;
using Flex.Application.Common.Shared;

namespace Flex.Application.Customer.Securities.GetSecurities
{
    public sealed record GetSecuritiesQuery(GetSecuritiesRequest request) : IQuery<PagingResult<GetSecuritiesRequest>>;
}