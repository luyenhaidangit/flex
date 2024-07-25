namespace Flex.Api.Setup.Extensions
{
    public static class MapperExtension
    {
        public static IServiceCollection AddAutoMapperApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Flex.Application.AssemblyReference.Assembly);

            return services;
        }
    }
}