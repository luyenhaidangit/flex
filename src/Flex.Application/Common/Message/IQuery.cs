using MediatR;
using Flex.Application.Common.Shared;

namespace Flex.Application.Common.Message
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}