using MassTransit;

namespace Flex.Application.Common.Message
{
    [ExcludeFromTopology]
    public interface IDomainEvent
    {
        public Guid IdEvent { get; init; }
    }
}
