using MassTransit;

namespace Flex.Domain.Common.Message
{
    [ExcludeFromTopology]
    public interface IDomainEvent
    {
        public Guid IdEvent { get; init; }
    }
}
