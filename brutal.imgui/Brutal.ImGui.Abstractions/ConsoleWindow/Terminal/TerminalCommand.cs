namespace Brutal.ImGuiApi.Abstractions;

/// <summary>
///     Defines the arguments which a command takes
/// </summary>
public struct ArgDefinition
{
    /// <summary>
    ///     The name of the arg
    /// </summary>
    public string Name;

    /// <summary>
    ///     The type of the arg
    /// </summary>
    public Type Type;

    /// <summary>
    ///     Whether or not this arg has a default value
    /// </summary>
    public bool HasDefault;

    /// <summary>
    ///     ToString() helper
    /// </summary>
    public override string ToString()
    {
        return Name;
    }
}

/// <summary>
///     A struct which represents a command which can be called through the terminal interface
/// </summary>
public readonly struct Command
{
    private readonly List<ArgDefinition> _argDefinitions;
    private readonly Delegate _callback;

    /// <summary>
    ///     A description of the command
    /// </summary>
    public string Description { get; }

    /// <summary>
    ///     The parsing mode which should be used for this command
    /// </summary>
    public ArgParseMode ParsingMode { get; }

    /// <summary>
    ///     Constructor, which takes a callback function and uses its parameters to define argument definitions
    /// </summary>
    /// <param name="callback"></param>
    /// <param name="description"></param>
    /// <param name="parsingMode"></param>
    public Command(Delegate callback, string description, ArgParseMode parsingMode)
    {
        _argDefinitions = new List<ArgDefinition>();
        _callback = callback;
        Description = description;
        ParsingMode = parsingMode;
        CreateArgDefinitions();
    }

    /// <summary>
    ///     Call to issue this command
    /// </summary>
    /// <param name="args">The args to call the command with</param>
    public void Issue(string[]? args)
    {
        ParseArgs(args, out var parsedArgs);
        _callback.Method.Invoke(_callback.Target, parsedArgs);
    }

    /// <summary>
    ///     Returns a readonly list of the arg definitions for this command
    /// </summary>
    public IReadOnlyList<ArgDefinition> GetDefinitions => _argDefinitions;

    private void ParseArgs(string[]? args, out object[]? outParsedArgs)
    {
        if (args?.Length > _argDefinitions.Count)
            throw new TerminalInterfaceException(
                "Command parsing failed,"
                    + $" too many arguments for command: {_callback.Method.Name}."
                    + $" Expected: {_argDefinitions.Count}, got: {args.Length}."
            );

        if (_argDefinitions.Count == 0)
        {
            outParsedArgs = null;
            return;
        }

        outParsedArgs = new object[_argDefinitions.Count];

        // Iterate through our defined definitions and try to parse the args into the correct types
        for (var i = 0; i < _argDefinitions.Count; i++)
        {
            var definition = _argDefinitions[i];
            ref var outArg = ref outParsedArgs[i];

            if (args is null || args.Length <= i)
            {
                // If an arg is optional pass Type.Missing to use the function's defined default
                if (definition.HasDefault)
                {
                    outArg = Type.Missing;
                    continue;
                }

                throw new TerminalInterfaceException(
                    "Command parsing failed,"
                        + $" missing required argument: {definition.Name}"
                        + $" of type: {definition.Type.Name}"
                );
            }

            var arg = args[i];

            TryParse(arg, definition.Type, out outArg);
        }
    }

    private static void TryParse(string arg, Type type, out object value)
    {
        // TODO: Add specific cases that we want to handle with our own parsing logic - e.g. vectors

        try
        {
            value = Convert.ChangeType(arg, type);
        }
        catch
        {
            throw new TerminalInterfaceException($"Failed to parse command argument: {arg} to type: {type.Name}.");
        }
    }

    private void CreateArgDefinitions()
    {
        var parameters = _callback.Method.GetParameters();

        // Validation of single string parsing mode
        if (ParsingMode == ArgParseMode.Unparsed)
        {
            if (parameters.Length != 1)
                throw new TerminalInterfaceException(
                    "Failed to parse delegate parameters into argument types,"
                        + " single string parsing mode requires exactly one parameter"
                        + $" in callback: {_callback.Method.Name}"
                );

            if (parameters[0].ParameterType != typeof(string))
                throw new TerminalInterfaceException(
                    "Failed to parse delegate parameters into argument types,"
                        + " single string parsing mode requires a string parameter"
                        + $" in callback: {_callback.Method.Name}"
                );
        }

        foreach (var parameter in parameters)
        {
            if (!TypeIsSupported(parameter.ParameterType))
                throw new TerminalInterfaceException(
                    "Failed to parse delegate parameters into argument types,"
                        + $" unsupported argument type: {parameter.ParameterType.Name}"
                        + $" in callback: {_callback.Method.Name}"
                );

            var definition = new ArgDefinition
            {
                Name = parameter.Name ?? $"param_{parameter.Position}",
                Type = parameter.ParameterType,
                HasDefault = parameter.HasDefaultValue,
            };

            _argDefinitions.Add(definition);
        }
    }

    private static bool TypeIsSupported(Type type)
    {
        // Convert.ChangeType() supports primitives, strings, and DateTime
        if (type.IsPrimitive)
            return true;

        if (type == typeof(string))
            return true;

        if (type == typeof(DateTime))
            return true;

        // TODO: add any types for which we offer custom parsing logic

        return false;
    }
}
