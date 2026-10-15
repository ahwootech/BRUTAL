namespace Brutal.ImGuiApi.Abstractions;

/// <summary>
///     An exception which is thrown when a terminal command fails to issue
/// </summary>
public class TerminalInterfaceException : Exception
{
    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="message"></param>
    public TerminalInterfaceException(string message)
        : base(message) { }
}
