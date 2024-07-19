namespace Flex.Domain.Common.Data
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        /// <summary>
        /// Saves all changes made in all repositories within the unit of work.
        /// </summary>
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}