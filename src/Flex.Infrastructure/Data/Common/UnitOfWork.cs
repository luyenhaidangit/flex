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
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        async ValueTask IAsyncDisposable.DisposeAsync()
        {
            await _dbContext.DisposeAsync();
        }
    }
}
