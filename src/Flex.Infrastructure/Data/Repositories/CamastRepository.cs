using Flex.Domain.CorporateAction.Entities;
using Flex.Domain.CorporateAction.Interfaces;
using Flex.Infrastructure.Data.Common;

namespace Flex.Infrastructure.Data.Repositories
{
    public class CamastRepository : RepositoryBase<Camast>, ICamastRepository
    {
        public CamastRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}