using System.ComponentModel;
using Microsoft.VisualBasic;
using ModelContextProtocol.Server;

namespace SseMCP;

[McpServerToolType]
public class TimeTool
{
    [McpServerTool, Description("Get the current time for a city")]
    public static string GetCurrentTime(string city) =>
        $"It is {DateTime.Now.Hour:00}:{DateTime.Now.Minute:00} in {city}.";
}