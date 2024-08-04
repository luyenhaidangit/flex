using Flex.Domain.SystemManagement.User.Abstractions;
using Flex.Domain.SystemManagement.User.Entities;
using Flex.Infrastructure.Data.Common;

namespace Flex.Infrastructure.Data.Repositories
{
    public class TlProfilesRepository : RepositoryBase<TlProfiles>, ITlProfilesRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TlProfilesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}