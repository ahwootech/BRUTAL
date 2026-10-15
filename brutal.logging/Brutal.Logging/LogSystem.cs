using Microsoft.Extensions.Logging;

namespace Brutal.Logging;

/// <summary>
/// Base class for all logging exceptions
/// </summary>
public class LogException(string message) : Exception(message);

/// <summary>
/// Exception thrown when the logging system is used before being initialized
/// </summary>
public class LogNotInitializedException()
    : LogException("Log not initialized. Call Log.Initialize before using the logging system.");

/// <summary>
/// Static class for handling logging functionality across the framework.
/// Provides methods for initializing, printing, and managing log messages
/// with different log levels, as well as interacting with external configurations.
/// </summary>
public static class LogSystem
{
    internal static ILoggerFactory? Factory;

    /// <summary>
    /// Enable or Disable all logging completely
    /// </summary>
    public static bool IsEnabled = false;

    /// <summary>
    /// Initialize and enable the log system
    /// </summary>
    public static void Initialize(Action<ILoggingBuilder> builder)
    {
        IsEnabled = true;
        Factory = LoggerFactory.Create(builder);
        foreach (var (categoryName, category) in LogCategory.Categories)
            category.Logger = Factory.CreateLogger(categoryName);
    }
}
