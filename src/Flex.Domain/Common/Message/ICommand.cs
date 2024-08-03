using Flex.Domain.Common.Shared;
using MassTransit;
using MediatR;

namespace Flex.Domain.Common.Message
{
    [ExcludeFromTopology]
    public interface ICommand : IRequest<Result>
    {
    }

    [ExcludeFromTopology]
    public interface ICommand<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
