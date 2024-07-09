using Flex.Domain.Customer.Interfaces;

namespace Flex.Infrastructure.Data.Repositories
{
    public class CfmastRepository : ICfmastRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CfmastRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
