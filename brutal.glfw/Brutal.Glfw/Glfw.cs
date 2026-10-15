using Brutal.Logging;

namespace Brutal.GlfwApi;

/// <summary>
/// Handles exceptions that occur during GLFW event processing.
/// </summary>
public class ExceptionAggregator
{
    private readonly List<Exception> _exceptions = [];
    private readonly Lock _lock = new();

    /// <summary>
    /// Push an exception to the aggregator.
    /// </summary>
    /// <param name="message"></param>
    /// <param name="innerException"></param>
    public void Push(string message, Exception? innerException = null)
    {
        lock (_lock)
        {
            _exceptions.Add(new Exception(message, innerException));
        }
    }

    /// <summary>
    /// Checks if there are any exceptions that have been thrown during event processing.
    /// </summary>
    /// <exception cref="Exception"></exception>
    /// <exception cref="AggregateException"></exception>
    public void CheckExceptions()
    {
        Exception exception;
        lock (_lock)
        {
            if (_exceptions.Count == 0)
                return;

            exception = _exceptions.Count == 1 ? _exceptions[0] : new AggregateException(_exceptions.ToArray());
            _exceptions.Clear();
        }

        throw exception;
    }
}

/// <summary>
/// Provides access to the GLFW library.
/// </summary>
public static partial class Glfw
{
    private const string Dll = "glfw";

    /// <summary>
    /// The logging category for all GLFW-related logs.
    /// </summary>
    public static readonly LogCategory Log = LogCategory.Make("Glfw");

    internal static readonly ExceptionAggregator ExceptionAggregator = new();
}
