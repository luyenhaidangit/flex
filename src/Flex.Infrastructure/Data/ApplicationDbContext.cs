using Flex.Domain.CorporateAction.Entities;
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

        public DbSet<Camast> Camasts { get; set; }
    }
}