using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using QRAdmit_Api.Extensions;
using QRAdmit_Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(),
"/nlog.config"));
// Add services to the container.

//builder.Logging.ClearProviders();
//builder.Logging.AddConsole();
//builder.Logging.AddDebug();

builder.Services.ConfigureCors();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureDbContext(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/users", (ILoggerManager _logger) =>
{
    _logger.LogInfo("START LOG");
    _logger.LogInfo("----------------------- Getting users here -----------------------");
    _logger.LogInfo("Here is info message from our values controller.");
    _logger.LogDebug("Here is debug message from our values controller.");
    _logger.LogWarn("Here is warn message from our values controller.");
    _logger.LogError("Here is an error message from our values controller.");
    _logger.LogInfo("END LOG");

    //    return (new[]
    //{   new {
    //        Name = "Joy Jacob",
    //        Age = 25
    //    },
    //    new {
    //        Name = "Mary Lucas",
    //        Age = 79
    //    },
    //    new {
    //        Name = "Bimpe Ladi",
    //        Age = 48
    //    } }
    return new string[] { "value1", "value2" };
    
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
