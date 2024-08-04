using Serilog;
using Flex.Api.Bootstrap.Extensions;
using Flex.Api.Setup.Extensions;
using Flex.Infrastructure.Setup.Extensions;

var builder = WebApplication.CreateBuilder(args);

SeriLoggerExtension.ConfigureLogger(builder.Configuration);

Log.Information("Application starting up.");

try
{
    // Logging
    builder.Host.UseSerilog();

    // Add services to the container.
    // Swagger
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwagger();

    // Controller
    builder.Services.AddControllers();

    // Data
    builder.Services.AddEntityFrameworkCore(builder.Configuration);
    builder.Services.AddDapper(builder.Configuration);
    builder.Services.RegisterRepositories();

    // Lib
    builder.Services.AddMediaR();

    // Auth
    builder.Services.AddJwtAuthentication(builder.Configuration);

    // Quartz
    builder.Services.AddQuartzApplication();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "The application encountered a fatal error and will terminate.");
}
finally
{
    Log.Information("Application is shutting down.");
    Log.CloseAndFlush();
}