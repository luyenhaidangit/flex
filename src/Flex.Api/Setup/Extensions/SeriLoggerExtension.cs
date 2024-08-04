using Serilog;

namespace Flex.Api.Setup.Extensions
{
    /// <summary>
    /// Configures Serilog logger settings from appsettings.json.
    /// </summary>
    /// <reference href="https://github.com/luyenhaidangit/microservice/blob/master/src/BuildingBlocks/Common.Logging/Serilogger.cs">Serilog Settings Configuration Documentation Microservice Tedu</reference>
    public static class SeriLoggerExtension
    {
        public static void ConfigureLogger(IConfiguration configuration)
        {
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .MinimumLevel.Debug()
                .Enrich.FromLogContext()
                .WriteTo.Async(a => a.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}"))
                .WriteTo.Async(a => a.Debug(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}"))
                .CreateLogger();
        }
    }
}