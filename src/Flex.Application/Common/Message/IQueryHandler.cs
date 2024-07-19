using Flex.Application.Common.Shared;
using MediatR;

namespace Flex.Application.Common.Message
{
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>> where TQuery : IQuery<TResponse>
    {
    }
}
