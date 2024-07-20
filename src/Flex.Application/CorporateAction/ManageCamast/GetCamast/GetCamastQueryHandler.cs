using Flex.Application.Common.Shared;
using Flex.Application.Common.Message;
using Flex.Domain.CorporateAction.Interfaces;
using Flex.Domain.CorporateAction.Entities;
using Flex.Contract.Abstractions.Shared;

namespace Flex.Application.CorporateAction.ManageCamast.GetCamast
{
    public sealed class GetCamastQueryHandler : IQueryHandler<GetCamastQuery, PagedResult<Camast>>
    {
        private readonly ICamastRepository _camastRepository;

        public GetCamastQueryHandler(ICamastRepository camastRepository)
        {
            _camastRepository = camastRepository;
        }

        public async Task<Result<PagedResult<Camast>>> Handle(GetCamastQuery request, CancellationToken cancellationToken)
        {
            var searchs = new Dictionary<string, (string operation, object value)>
            {
                //{ "Name", ("like", "Sample") },
                //{ "Price", ("=", 10.0m) }
            };

            int pageIndex = 0;
            int pageSize = 10;
            string sortBy = "CAMASTID";
            bool ascending = true;

            var (products, totalCount) = await _camastRepository.SearchAndPaginateAsync(searchs, pageIndex, pageSize, sortBy, ascending);

            var result1 = new PagedResult<Camast>(products, 1, 10, totalCount);

            //var camasts = await _camastRepository.GetAllAsync();

            var result = new Result<PagedResult<Camast>>
            {
                Data = result1,
                Success = true,
                Message = "ok"
            };

            return result;
        }
    }
}