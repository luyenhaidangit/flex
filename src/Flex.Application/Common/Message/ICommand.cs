using Flex.Application.Common.Shared;
using MassTransit;
using MediatR;

namespace Flex.Application.Common.Message
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
