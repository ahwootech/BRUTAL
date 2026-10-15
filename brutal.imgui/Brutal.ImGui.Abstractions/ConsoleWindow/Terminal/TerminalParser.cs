using System.CommandLine.Parsing;

namespace Brutal.ImGuiApi.Abstractions;

/// <summary>
///     A parsing utility class for the terminal interface
/// </summary>
internal static class Parser
{
    private const char CommandDelimiter = ';';

    /// <summary>
    ///     Splits an input string into individual command strings
    /// </summary>
    /// <param name="inInput">The raw string from terminal input</param>
    /// <returns>A list of individual command strings</returns>
    public static List<string> SplitToCommands(string inInput)
    {
        var commands = new List<string>();
        var withinQuotes = false;
        var startIndex = 0;

        void TryAddCommand(string command)
        {
            var trimmedCommand = command.Trim();
            if (trimmedCommand.Length > 0)
                commands.Add(trimmedCommand);
        }

        // Ignore our delimiter if it's part of a quoted string
        for (var i = 0; i < inInput.Length; i++)
            if (inInput[i] == '\"')
            {
                withinQuotes = !withinQuotes;
            }
            else if (inInput[i] == CommandDelimiter && !withinQuotes)
            {
                // Split input into individual commands by delimiter
                TryAddCommand(inInput.Substring(startIndex, i - startIndex));
                startIndex = i + 1;
            }

        // Add the last command if there is one
        if (startIndex < inInput.Length)
            TryAddCommand(inInput.Substring(startIndex).Trim());

        return commands;
    }

    /// <summary>
    ///     Splits a command string into a command name and args string
    /// </summary>
    /// <param name="inCommandString">The command string to split</param>
    /// <param name="inCommandName">The command name part of the input string</param>
    /// <param name="inArgsString">The args part of the input string</param>
    public static void SplitCommand(string inCommandString, out string inCommandName, out string inArgsString)
    {
        const StringSplitOptions flags = StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries;

        // Split at first whitespace
        var split = inCommandString.Split(Array.Empty<char>(), 2, flags);

        if (split.Length == 0)
            throw new TerminalInterfaceException("Command parsing failed, command string was empty.");

        inCommandName = split[0].ToLower();
        inArgsString = split.Length > 1 ? split[1] : "";
    }

    /// <summary>
    ///     Splits an arg string into individual args according to the parsing mode
    /// </summary>
    /// <param name="inArgsString">The string to split</param>
    /// <param name="inArgParseMode">The parsing mode to use</param>
    /// <returns>An array of arg strings, or null if the args string was empty</returns>
    public static string[]? SplitToArgs(string inArgsString, ArgParseMode inArgParseMode)
    {
        // If we're using single string parsing mode, return the args as a single string
        if (inArgParseMode == ArgParseMode.Unparsed)
            // Remove outer whitespace and quotes if they exist
            return new[] { inArgsString };

        // If there are no args, return null
        if (string.IsNullOrEmpty(inArgsString))
            return null;

        // If we're using default parsing mode, split the args into individual strings
        return CommandLineParser.SplitCommandLine(inArgsString).ToArray();
    }
}
