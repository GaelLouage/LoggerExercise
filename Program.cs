using LoggingSystem.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

LoggingSystem.Helpers.Logger.Log("Info !", LoggingSystem.Enums.LogLevel.Info);
LoggingSystem.Helpers.Logger.Log("warning!", LoggingSystem.Enums.LogLevel.Warning);
LoggingSystem.Helpers.Logger.Log("Error!", LoggingSystem.Enums.LogLevel.Error);
app.MapGet("/", () => 
{
  return LoggingSystem.Helpers.Logger.GetLogs(LoggingSystem.Enums.LogLevel.Info);
});

app.Run();
