namespace Flex.Api.Bootstrap.Extensions
{
    public static class SwaggerExtension
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                // Swagger doc...

                c.EnableAnnotations();
            });

            services.AddSwaggerGenNewtonsoftSupport();

            //services.AddFluentValidationRulesToSwagger();
        }

    }
}
