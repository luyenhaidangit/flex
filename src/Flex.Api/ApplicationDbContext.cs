using Microsoft.EntityFrameworkCore;

namespace Flex.Api
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Cấu hình các thực thể khác nếu cần
        }
    }
}
