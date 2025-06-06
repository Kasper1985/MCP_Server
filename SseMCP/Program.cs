using SseMCP;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddMcpServer()
    .WithHttpTransport()
    .WithTools<TimeTool>();

var app = builder.Build();

app.MapMcp();

await app.RunAsync("http://localhost:5001");