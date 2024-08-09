using MediatR;
using Flex.Domain.Common.Response;

namespace Flex.Domain.Common.Message
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}