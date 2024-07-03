using Serilog;
using Flex.Api.Bootstrap.Options;
using Flex.Api.Bootstrap.Extensions;
using Asp.Versioning;

var builder = WebApplication.CreateBuilder(args);

try
{
    // Logging
    builder.Host.UseSerilog(SeriLogger.Configure);

    // Add services to the container.
    // Swagger
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwagger();

    // Controller
    builder.Services.AddControllers();

    // Versioning
    builder.Services.AddApiVersioning(options =>
    {
        options.DefaultApiVersion = new ApiVersion(1, 0);
        options.AssumeDefaultVersionWhenUnspecified = true;
        options.ReportApiVersions = true;
    })
    .AddApiExplorer(options =>
    {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true;
    });

    // Auth
    builder.Services.AddJwtAuthentication(builder.Configuration);

    var app = builder.Build();

    Log.Information("Application starting up");

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
    string typeException = ex.GetType().Name;
    if (typeException.Equals("StopTheHostException", StringComparison.Ordinal))
    {
        throw;
    }

    Log.Fatal(ex, "Unhandled exception");
}
finally
{
    Log.Information("Shut down application complete");
    Log.CloseAndFlush();
}