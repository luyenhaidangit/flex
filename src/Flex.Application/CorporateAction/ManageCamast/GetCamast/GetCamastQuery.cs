using Flex.Application.Common.Message;
using Flex.Application.Common.Shared;

namespace Flex.Application.CorporateAction.ManageCamast.GetCamast
{
    //public sealed record GetCamastQuery(GetCamastRequest request) : IQuery<PagingResult<GetCamastResponse>>;

    public sealed record GetCamastQuery(GetCamastRequest request) : IQuery<string>;
}