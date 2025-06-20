using System.ComponentModel;
using ModelContextProtocol.Server;

namespace ConsoleMCP;

[McpServerToolType]
public class EchoTools
{
    [McpServerTool, Description("Echoes the message back to the client.")]
    public static string Echo(string message) => $"Hello from C#: {message}";

    [McpServerTool, Description("Echoes in reverse the message sent by the client.")]
    public static string ReverseEcho(string message) => new([.. message.Reverse()]);
}
