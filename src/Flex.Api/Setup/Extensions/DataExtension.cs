using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using Flex.Infrastructure.Data;
using Flex.Domain.CorporateAction.Interfaces;
using Flex.Domain.Common.Data;
using Flex.Domain.SystemManagement.User.Abstractions;
using Flex.Infrastructure.Data.Repositories;
using Flex.Infrastructure.Data.Common;

namespace Flex.Api.Setup.Extensions
{
    public static class DataExtension
    {
        public static IServiceCollection AddEntityFrameworkCore(this IServiceCollection services, IConfiguration configuration)
        {
            OracleConfiguration.SqlNetAllowedLogonVersionClient = OracleAllowedLogonVersionClient.Version11;

            services.AddDbContext<Flex.Infrastructure.Data.ApplicationDbContext>(options =>
            options.UseOracle(configuration.GetConnectionString("OracleConnection")));

            return services;
        }

        public static IServiceCollection AddDapper(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<ISqlConnectionFactory>(serviceProvider => new SqlConnectionFactory(configuration.GetConnectionString("OracleConnection")));

            return services;
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<ICamastRepository, CamastRepository>();
            services.AddScoped<ITlProfilesRepository, TlProfilesRepository>();

            return services;
        }
    }
}