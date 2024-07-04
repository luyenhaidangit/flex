using Microsoft.EntityFrameworkCore;

namespace Flex.Api.Bootstrap.Extensions
{
    public static class EntityFrameworkCoreExtension
    {
        public static IServiceCollection AddEntityFrameworkCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseOracle(configuration.GetConnectionString("OracleConnection")));

            return services;
        }
    }
}
