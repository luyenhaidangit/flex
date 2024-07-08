namespace Flex.Domain.Common.Abstractions.Data
{
    public interface IUnitOfWorkDbContext<TContext> : IAsyncDisposable
    {
        /// <summary>
        /// Call save change from db context
        /// </summary>
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}