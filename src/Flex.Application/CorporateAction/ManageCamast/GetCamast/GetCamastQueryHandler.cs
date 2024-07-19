using Flex.Application.Common.Shared;
using Flex.Application.Common.Message;
using Flex.Domain.CorporateAction.Interfaces;
using Flex.Domain.CorporateAction.Entities;

namespace Flex.Application.CorporateAction.ManageCamast.GetCamast
{
    public sealed class GetCamastQueryHandler : IQueryHandler<GetCamastQuery, IEnumerable<Camast>>
    {
        private readonly ICamastRepository _camastRepository;

        public GetCamastQueryHandler(ICamastRepository camastRepository)
        {
            _camastRepository = camastRepository;
        }

        public async Task<Result<IEnumerable<Camast>>> Handle(GetCamastQuery request, CancellationToken cancellationToken)
        {
            var camasts = await _camastRepository.GetAllAsync();

            var result = new Result<IEnumerable<Camast>>
            {
                Data = camasts,
                Success = true,
                Message = "ok"
            };

            return result;
        }
    }
}