using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;

namespace Flex.Api.Bootstrap.Extensions
{
    public static class EntityFrameworkCoreExtension
    {
        public static IServiceCollection AddEntityFrameworkCore(this IServiceCollection services, IConfiguration configuration)
        {
            OracleConfiguration.SqlNetAllowedLogonVersionClient = OracleAllowedLogonVersionClient.Version11;

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseOracle(configuration.GetConnectionString("OracleConnection")));

            return services;
        }
    }
}
