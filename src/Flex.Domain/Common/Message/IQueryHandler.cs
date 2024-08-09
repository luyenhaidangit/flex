using Flex.Domain.Common.Response;
using MediatR;

namespace Flex.Domain.Common.Message
{
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>> where TQuery : IQuery<TResponse>
    {
    }
}
