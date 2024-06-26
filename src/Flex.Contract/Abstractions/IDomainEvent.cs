using MassTransit;

namespace Flex.Contract.Abstractions
{
    [ExcludeFromTopology]
    public interface IDomainEvent
    {
        public Guid IdEvent { get; init; }
    }
}
