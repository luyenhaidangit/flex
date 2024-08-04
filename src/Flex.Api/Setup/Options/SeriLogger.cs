using Serilog;

namespace Flex.Api.Setup.Options
{
    public class SeriLogger
    {
        public static Action<HostBuilderContext, LoggerConfiguration> Configure =>
        (context, configuration) =>
        {
            //var applicationName = context.HostingEnvironment.ApplicationName?.ToLower().Replace(".", "-");
            //var environmentName = context.HostingEnvironment.EnvironmentName ?? "Development";

            configuration
                .ReadFrom.Configuration(context.Configuration)
                .MinimumLevel.Debug()
                .Enrich.FromLogContext()
                //.Enrich.WithMachineName()
                //.Enrich.FromLogContext()
                //.Enrich.WithThreadId()
                //.Enrich.WithProperty("Environment", environmentName)
                //.Enrich.WithProperty("Application", applicationName)
                .WriteTo.Async(a => a.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}"))
                .WriteTo.Async(a => a.Debug(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}"));
            //.WriteTo.Async(a => a.File("logs/log-.txt", rollingInterval: RollingInterval.Day, outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}"))
        };
    }
}
