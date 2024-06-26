using MassTransit;

namespace Flex.Contract.Abstractions.Message
{
    [ExcludeFromTopology]
    public interface IDomainEvent
    {
        public Guid IdEvent { get; init; }
    }
}
