namespace Flex.Domain.Common.Data
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        /// <summary>
        /// Call save change from db context
        /// </summary>
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}