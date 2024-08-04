using Flex.Domain.Common.Authentication;
using Flex.Infrastructure.Authentication;

namespace Flex.Api.Setup.Extensions
{
    public static class AuthenticationExtension
    {
        public static IServiceCollection AddAuthenticationContainer(this IServiceCollection services)
        {
            services.AddScoped<IPasswordHasher, PasswordHasher>();

            return services;
        }
    }
}
