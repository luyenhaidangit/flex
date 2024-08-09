using Flex.Domain.Common.Authentication;
using Flex.Domain.Common.Section;
using Flex.Infrastructure.Authentication;

namespace Flex.Api.Setup.Extensions
{
    public static class AuthenticationExtension
    {
        public static IServiceCollection AddAuthenticationApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtOption>(configuration.GetSection(SectionKeyConstant.JwtToken));
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}