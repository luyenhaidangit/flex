using Microsoft.EntityFrameworkCore;
using Flex.Domain.Entities.Account;

namespace Flex.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
        }

        public DbSet<Cfmast> Cfmasts { get; set; }
    }
}
