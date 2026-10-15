namespace Brutal.ImGuiApi.Abstractions;

/// <summary>
///     Defines how a terminal action should be parsed
/// </summary>
public enum ArgParseMode
{
    /// <summary>
    ///     Parse the command string args into individual tokens, considering whitespace and quotes
    /// </summary>
    Default,

    /// <summary>
    ///     Output the raw unparsed command arg string
    /// </summary>
    Unparsed,
}

/// <summary>
///     An attribute which is used to define methods that can be registered as callback through a TerminalInterface
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public class TerminalActionAttribute : Attribute
{
    /// <param name="commandName">The command name</param>
    /// <param name="description">A description of the command</param>
    /// <param name="parsingMode">The type of parsing which should be used on the command</param>
    public TerminalActionAttribute(
        string commandName,
        string description = "",
        ArgParseMode parsingMode = ArgParseMode.Default
    )
    {
        CommandName = commandName.ToLower();
        Description = description;
        ParsingMode = parsingMode;
    }

    /// <summary>
    ///     The name of the command
    /// </summary>
    public string CommandName { get; }

    /// <summary>
    ///     A description of the command
    /// </summary>
    public string Description { get; }

    /// <summary>
    ///     The parsing mode of the command
    /// </summary>
    public ArgParseMode ParsingMode { get; }
}
