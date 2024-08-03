using MediatR;
using Flex.Domain.Common.Shared;

namespace Flex.Domain.Common.Message
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}