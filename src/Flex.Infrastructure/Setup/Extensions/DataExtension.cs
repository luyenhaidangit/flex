using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oracle.ManagedDataAccess.Client;
using Flex.Infrastructure.Data;
using Flex.Domain.CorporateAction.Interfaces;
using Flex.Infrastructure.Data.Repositories;

namespace Flex.Infrastructure.Setup.Extensions
{
    public static class DataExtension
    {
        public static IServiceCollection AddEntityFrameworkCore(this IServiceCollection services, IConfiguration configuration)
        {
            OracleConfiguration.SqlNetAllowedLogonVersionClient = OracleAllowedLogonVersionClient.Version11;

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseOracle(configuration.GetConnectionString("OracleConnection")));

            return services;
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICamastRepository, CamastRepository>();

            return services;
        }
    }
}