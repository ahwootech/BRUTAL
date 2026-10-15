namespace Brutal.NotCursesApi;

/// <summary>
/// Thrown by generated wrappers when a notcurses C function returns a failure result.
/// </summary>
public class NcResultException : Exception
{
    public int Result { get; }
    public string FunctionName { get; }

    public NcResultException(string functionName, int result)
        : base($"{functionName} failed with result {result}.")
    {
        FunctionName = functionName;
        Result = result;
    }
}
