using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyFirstMCP; // Ensure Host is available

//var builder = Host.CreateApplicationBuilder(args);
var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddConsole(consoleLogOptions =>
{
    // Configure all logs to go to stderr
    consoleLogOptions.LogToStandardErrorThreshold = LogLevel.Trace;
});

builder.Services
    .AddMcpServer()
    //.WithStdioServerTransport()
    .WithHttpTransport()
    //.WithToolsFromAssembly();
    .WithTools<MonkeyTools>();

builder.Services.AddHttpClient();
builder.Services.AddSingleton<MonkeyService>();

var app = builder.Build();

app.MapMcp();

await app.RunAsync("http://localhost:5000");
//await builder.Build().RunAsync();