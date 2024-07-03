namespace Flex.Api.Bootstrap.Extensions
{
    public static class MediaRExtension
    {
        public static IServiceCollection AddMediaR(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Flex.Application.AssemblyReference.Assembly);
            });
            //.RegisterServicesFromAssembly(Flex.Application.AssemblyReference.Assembly));
            //.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationDefaultBehavior<,>))
            //.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>))
            //.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformancePipelineBehavior<,>))
            //.AddTransient(typeof(IPipelineBehavior<,>), typeof(TransactionPipelineBehavior<,>))
            //.AddTransient(typeof(IPipelineBehavior<,>), typeof(TracingPipelineBehavior<,>))
            //.AddValidatorsFromAssembly(Contract.AssemblyReference.Assembly, includeInternalTypes: true);

            return services;
        }
    }
}
