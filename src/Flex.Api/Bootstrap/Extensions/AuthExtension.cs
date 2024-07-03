using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Flex.Api.Bootstrap.Options;

namespace Flex.Api.Bootstrap.Extensions
{
    public static class AuthExtension
    {
        public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(o =>
            {
                var jwtToken = configuration.GetSection(nameof(JwtToken)).Get<JwtToken>();

                /**
                 * Storing the JWT in the AuthenticationProperties allows you to retrieve it from elsewhere within your application.
                 * public async Task<IActionResult> SomeAction()
                    {
                        // using Microsoft.AspNetCore.Authentication;
                        var accessToken = await HttpContext.GetTokenAsync("access_token");
                        // ...
                    }
                 */
                o.SaveToken = true; // Save token into AuthenticationProperties

                var Key = Encoding.UTF8.GetBytes(jwtToken.SecretKey);
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true, // on production make it true
                    ValidateAudience = true, // on production make it true
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtToken.Issuer,
                    ValidAudience = jwtToken.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Key),
                    ClockSkew = TimeSpan.Zero
                };

                o.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            context.Response.Headers.Add("IS-TOKEN-EXPIRED", "true");
                        }
                        return Task.CompletedTask;
                    }
                };

                //o.EventsType = typeof(CustomJwtBearerEvents);
            });

            return services;
        }
    }
}
