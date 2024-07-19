using Flex.Application.Common.Shared;
using Flex.Application.Common.Message;
using Flex.Domain.CorporateAction.Interfaces;
using Flex.Contract.Abstractions.Shared;

namespace Flex.Application.CorporateAction.ManageCamast.GetCamast
{
    public sealed class GetCamastQueryHandler : IQueryHandler<GetCamastQuery, string>
    {
        private readonly ICamastRepository _camastRepository;

        public GetCamastQueryHandler(ICamastRepository camastRepository)
        {
            _camastRepository = camastRepository;
        }

        public Task<Result<string>> Handle(GetCamastQuery request, CancellationToken cancellationToken)
        {
            var result = Flex.Application.Common.Shared.Result.Success("Done");

            return Task.FromResult(result);
        }
    }
}