using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;

namespace Flex.Api.Setup.Extensions
{
    public static class SwaggerExtension
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Flex",
                    Description = "Flex Api",
                    //TermsOfService = new Uri("https://luyenhaidangit.id.vn"),
                    //Contact = new OpenApiContact
                    //{
                    //    Name = "Luyen Hai Dang",
                    //    Email = "luyenhaidangit@gmail.com",
                    //    Url = new Uri("https://luyenhaidangit.id.vn")
                    //},
                    //License = new OpenApiLicense
                    //{
                    //    Name = "Luyen Hai Dang",
                    //    Url = new Uri("https://luyenhaidangit.id.vn")
                    //}
                });

                c.EnableAnnotations();
            });

            services.AddSwaggerGenNewtonsoftSupport();

            services.AddFluentValidationRulesToSwagger();

            return services;
        }
    }
}