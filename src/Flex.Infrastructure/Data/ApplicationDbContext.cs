using Flex.Domain.Customer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Flex.Infrastructure.Data
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

        public virtual DbSet<Cfmast> Banners { get; set; } = null!;
    }
}
