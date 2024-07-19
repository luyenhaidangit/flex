using Microsoft.EntityFrameworkCore;
using Flex.Domain.Common.Data;

namespace Flex.Infrastructure.Data.Common
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public readonly ApplicationDbContext _dbContext;

        public RepositoryBase(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<(IEnumerable<T>, int)> SearchAndPaginateAsync(Dictionary<string, (string operation, object value)> searchs, int pageIndex, int pageSize, string sortBy, bool ascending)
        {
            IQueryable<T> query = _dbContext.Set<T>();

            // Apply search filters
            foreach (var search in searchs)
            {
                var property = typeof(T).GetProperty(search.Key);
                if (property == null)
                {
                    throw new ArgumentException($"Property '{search.Key}' does not exist on type '{typeof(T)}'");
                }

                switch (search.Value.operation.ToLower())
                {
                    case "=":
                        query = query.Where(e => EF.Property<object>(e, search.Key).Equals(search.Value.value));
                        break;
                    case "like":
                        query = query.Where(e => EF.Property<string>(e, search.Key).Contains((string)search.Value.value));
                        break;
                    // Add more operations as needed
                    default:
                        throw new ArgumentException($"Operation '{search.Value.operation}' is not supported");
                }
            }

            // Get total count
            var totalCount = await query.CountAsync();

            // Apply sorting
            if (!string.IsNullOrEmpty(sortBy))
            {
                var property = typeof(T).GetProperty(sortBy);
                if (property == null)
                {
                    throw new ArgumentException($"Property '{sortBy}' does not exist on type '{typeof(T)}'");
                }

                query = ascending ? query.OrderBy(e => EF.Property<object>(e, sortBy)) : query.OrderByDescending(e => EF.Property<object>(e, sortBy));
            }

            // Apply pagination
            query = query.Skip(pageIndex * pageSize).Take(pageSize);

            // Execute query
            var items = await query.ToListAsync();

            return (items, totalCount);
        }
    }
}