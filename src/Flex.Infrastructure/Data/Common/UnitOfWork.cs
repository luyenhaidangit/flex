using Flex.Domain.Common.Data;

namespace Flex.Infrastructure.Data.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync();
        }

        async ValueTask IAsyncDisposable.DisposeAsync()
        => await _dbContext.DisposeAsync();

        //private void ConvertDomainEventsToOutboxMessages()
        //{
        //    var outboxMessages = _dbContext.ChangeTracker
        //        .Entries<AggregateRoot<Guid>>()
        //        .Select(x => x.Entity)
        //        .SelectMany(aggregateRoot =>
        //        {
        //            var domainEvents = aggregateRoot.GetDomainEvents();

        //            aggregateRoot.ClearDomainEvents();

        //            return domainEvents;
        //        })
        //        .Select(domainEvent => new OutboxMessage
        //        {
        //            Id = Guid.NewGuid(),
        //            OccurredOnUtc = DateTime.UtcNow,
        //            Type = domainEvent.GetType().Name,
        //            Content = JsonConvert.SerializeObject(
        //                domainEvent,
        //                new JsonSerializerSettings
        //                {
        //                    TypeNameHandling = TypeNameHandling.All
        //                })
        //        })
        //        .ToList();

        //    _dbContext.Set<OutboxMessage>().AddRange(outboxMessages);
        //}

        //private void UpdateAuditableEntities()
        //{
        //    IEnumerable<EntityEntry<IAuditableEntity>> entries =
        //        _dbContext
        //            .ChangeTracker
        //            .Entries<IAuditableEntity>();

        //    foreach (EntityEntry<IAuditableEntity> entityEntry in entries)
        //    {
        //        if (entityEntry.State == EntityState.Added)
        //        {
        //            entityEntry.Property(a => a.CreatedOnUtc).CurrentValue = DateTime.UtcNow;
        //        }

        //        if (entityEntry.State == EntityState.Modified)
        //        {
        //            entityEntry.Property(a => a.ModifiedOnUtc).CurrentValue = DateTime.UtcNow;
        //        }
        //    }
        //}
    }
}
