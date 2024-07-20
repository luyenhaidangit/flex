using Flex.Application.Common.Message;
using Flex.Contract.Abstractions.Shared;
using Flex.Domain.CorporateAction.Entities;

namespace Flex.Application.CorporateAction.ManageCamast.GetCamast
{
    //public sealed record GetCamastQuery(GetCamastRequest request) : IQuery<PagingResult<GetCamastResponse>>;

    public sealed record GetCamastQuery(GetCamastRequest request) : IQuery<PagedResult<Camast>>;
}