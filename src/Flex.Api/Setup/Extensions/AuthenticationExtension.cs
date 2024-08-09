using Flex.Domain.Common.Authentication;
using Flex.Infrastructure.Authentication;
using System.Configuration;

namespace Flex.Api.Setup.Extensions
{
    public static class AuthenticationExtension
    {
        public static IServiceCollection AddAuthenticationApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtOption>(configuration.GetSection("JwtToken"));
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}