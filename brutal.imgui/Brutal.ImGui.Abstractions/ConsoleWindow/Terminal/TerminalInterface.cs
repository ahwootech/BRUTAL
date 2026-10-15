using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Brutal.Logging;

namespace Brutal.ImGuiApi.Abstractions;

/// <summary>
///     The type of message the terminal interface is outputting
/// </summary>
public enum TerminalInterfaceOutputType
{
    /// <summary>
    ///     An informative message
    /// </summary>
    Message,

    /// <summary>
    ///     An error with the processing of a command
    /// </summary>
    Error,
}

/// <summary>
///     Provides an interface which can be used to register terminal commands and handle terminal input.
/// </summary>
public class TerminalInterface
{
    public static LogCategory Log = LogCategory.Make("TerminalInterface");

    private readonly Dictionary<object, Dictionary<string, Command>> CommandLibrary = new();
    private readonly Dictionary<string, Command> StaticCommandLibrary = new();
    private readonly ConsoleWindow _consoleWindow;

    /// <summary>
    ///     Invoked with a message when the terminal interface wants to output something
    /// </summary>
    public event Action<string, TerminalInterfaceOutputType>? OnOutput;

    /// <summary>
    ///     Constructor
    /// </summary>
    public TerminalInterface(ConsoleWindow consoleWindow)
    {
        _consoleWindow = consoleWindow;
        RegisterCommand(ListCommands);
        RegisterCommand(ClearConsole);
    }

    /// <summary>
    ///     Executes a batch of terminal input commands.
    /// </summary>
    /// <param name="inInput">A collection of terminal input strings.</param>
    public void Execute(params ReadOnlySpan<string> inInput)
    {
        foreach (var commandLine in inInput)
            Execute(commandLine);
    }

    /// <summary>
    ///     Parses terminal input and processes it as commands.
    /// </summary>
    /// <param name="inInput">The input string from the terminal</param>
    public bool Execute(string inInput)
    {
        // Split full input into individual command statements
        foreach (var commandString in Parser.SplitToCommands(inInput))
            try
            {
                ProcessCommand(commandString);
            }
            catch (TerminalInterfaceException e)
            {
                OutputProcessCommandError(commandString, e.Message);
                return false;
            }

        return true;
    }

    private static Type? GetDelegateTypeForMethod(MethodBase inMethodInfo)
    {
        var parameterTypes = Array.ConvertAll(inMethodInfo.GetParameters(), p => p.ParameterType);
        // Direct lookup of the right Action arity. Returns false when no Action can represent the
        // signature: more than 16 parameters, or ByRef/pointer parameter types.
        return Expression.TryGetActionType(parameterTypes, out var delegateType) ? delegateType : null;
    }

    /// <summary>
    ///     Register an object with TerminalAction methods
    /// </summary>
    /// <param name="inObject">The object we want to register commands from</param>
    /// <exception cref="TerminalInterfaceException"></exception>
    public void RegisterObject(object inObject)
    {
        var methods = GetMethodInfos(inObject);

        foreach (var method in methods)
        {
            var delegateType = GetDelegateTypeForMethod(method);

            if (delegateType != null)
            {
                if (method.IsStatic)
                    RegisterCommand(Delegate.CreateDelegate(delegateType, method), inObject);
                else
                    RegisterCommand(Delegate.CreateDelegate(delegateType, inObject, method), inObject);
            }
            else
            {
                throw new TerminalInterfaceException(
                    $"Error registering command: callback {method.Name} has an unsupported signature"
                );
            }
        }
    }

    private IEnumerable<MethodInfo> GetMethodInfos(object inObject)
    {
        const BindingFlags flags =
            BindingFlags.Instance
            | BindingFlags.Public
            | BindingFlags.NonPublic
            | BindingFlags.FlattenHierarchy
            | BindingFlags.Static;

        var objectType = inObject.GetType();
        var allMethods = objectType.GetMethods(flags);
        return allMethods.Where(m => m.GetCustomAttribute<TerminalActionAttribute>() != null);
    }

    public void UnregisterObject(object inObject)
    {
        if (CommandLibrary.ContainsKey(inObject))
            CommandLibrary.Remove(inObject);
    }

    /// <summary>
    ///     Registers commands which can be called from the terminal.
    /// </summary>
    /// <param name="inCallback">The function which the command will call</param>
    /// <param name="inObject">Object to which the command delegate is bound to. Null for  methods</param>
    public void RegisterCommand(Delegate inCallback, object? inObject = null)
    {
        var attribute = inCallback.Method.GetCustomAttribute<TerminalActionAttribute>();

        if (attribute is null)
            throw new TerminalInterfaceException(
                $"Error registering command:" + $" callback {inCallback.Method.Name} has no TerminalActionAttribute"
            );

        if (inObject is not null)
        {
            if (!CommandLibrary.ContainsKey(inObject))
                CommandLibrary[inObject] = new Dictionary<string, Command>();

            CommandLibrary[inObject][attribute.CommandName] = new Command(
                inCallback,
                attribute.Description,
                attribute.ParsingMode
            );
        }
        else
        {
            StaticCommandLibrary[attribute.CommandName] = new Command(
                inCallback,
                attribute.Description,
                attribute.ParsingMode
            );
        }
    }

    private void ProcessCommand(string inCommandString)
    {
        // Split command into command name and arguments
        Parser.SplitCommand(inCommandString, out var commandName, out var argsString);

        if (StaticCommandLibrary.ContainsKey(commandName))
        {
            var args = Parser.SplitToArgs(argsString, StaticCommandLibrary[commandName].ParsingMode);

            // Issue the command
            StaticCommandLibrary[commandName].Issue(args);
            return;
        }

        foreach (var (_, commands) in CommandLibrary)
        {
            if (commands.ContainsKey(commandName))
            {
                var args = Parser.SplitToArgs(argsString, commands[commandName].ParsingMode);

                // Issue the command
                commands[commandName].Issue(args);
                return;
            }
        }
        Log.Error($"unknown command {commandName}, use 'help' for a list of commands");
    }

    [TerminalAction("clear", "Clears the console output")]
    private void ClearConsole() => _consoleWindow.ClearConsole();

    [TerminalAction("help", "Lists all registered commands and their descriptions")]
    private void ListCommands()
    {
        var commandCount = 0;
        var tableString = new TableString();

        var cmds = new Dictionary<string, Command>();

        //  commands
        foreach (var (command, args) in StaticCommandLibrary)
            cmds.Add(command, args);

        // instanced commands
        foreach (var (_, commands) in CommandLibrary)
        foreach (var (command, args) in commands)
            cmds.Add(command, args);

        foreach (var cmd in cmds)
            PrintHelpLine(cmd.Key, cmd.Value);

        _consoleWindow.Print($"listing {commandCount} commands");
        _consoleWindow.Print(
            "Multiple commands can be called in a single statement by separating them with a ';' semicolon"
        );
        tableString.Sort();
        tableString.ToConsole(_consoleWindow);
        OnOutput?.Invoke(string.Empty, TerminalInterfaceOutputType.Message);
        return;

        void PrintHelpLine(string command, Command args)
        {
            commandCount++;

            var definitions = args.GetDefinitions;
            if (definitions.Count == 0)
            {
                tableString.AddRow(command, args.Description);
                return;
            }

            var argSb = new StringBuilder();
            for (var i = 0; i < definitions.Count; i++)
            {
                if (i > 0)
                    argSb.Append(", ");
                var definition = args.GetDefinitions[i];
                argSb.Append('<');
                var type = definition.Type.ToString();
                // remove "System." from the type name
                if (type.StartsWith("System."))
                    type = type[7..];
                type = type.ToLowerInvariant();
                argSb.Append(type);
                argSb.Append('>');
                if (definition.HasDefault)
                    argSb.Append('?');
                argSb.Append(' ');
                argSb.Append(definition.Name);
            }
            tableString.AddRow(command, args.Description, argSb.ToString());
        }
    }

    private void OutputProcessCommandError(string inCommand, string inErrorMessage)
    {
        var message = $"Terminal interface failed to process command: {inCommand}, error: {inErrorMessage}";
        OnOutput?.Invoke(message, TerminalInterfaceOutputType.Error);
    }
}
