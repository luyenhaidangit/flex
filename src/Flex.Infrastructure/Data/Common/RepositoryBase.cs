using Flex.Domain.Common.Data;

namespace Flex.Infrastructure.Data.Common
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly ApplicationDbContext _context;

        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<(IEnumerable<T>, int)> SearchAndPaginateAsync(Dictionary<string, (string operation, object value)> searchs, int pageIndex, int pageSize, string sortBy, bool ascending)
        {
            throw new NotImplementedException();
        }
    }
}
