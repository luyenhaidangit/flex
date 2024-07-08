namespace Flex.Domain.Common.Abstractions.Entities
{
    public interface IAuditableEntity
    {
        DateTimeOffset CreatedOnUtc { get; set; }

        DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
