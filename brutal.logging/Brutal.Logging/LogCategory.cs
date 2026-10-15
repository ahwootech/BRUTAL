using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Brutal.Logging.Internal;
using Microsoft.Extensions.Logging;

namespace Brutal.Logging;

/// <summary>
/// Represents an abstract logging category that provides methods for structured logging.
/// </summary>
/// <remarks>
/// A logging category is designed to group related logging messages and control the logging level.
/// This class provides various logging methods to handle message logging at different levels.
/// Implementations of this abstract class define specific behavior for each category.
/// </remarks>
public sealed class LogCategory
{
    #region Categories

    internal static readonly Dictionary<string, LogCategory> Categories = [];

    /// <summary>
    /// Gets a logging category by name.
    /// </summary>
    /// <exception cref="KeyNotFoundException">Thrown if the category does not exist.</exception>
    public static LogCategory Get(string categoryName)
    {
        return Categories[categoryName];
    }

    /// <summary>
    /// Tries to get a logging category by name.
    /// </summary>
    public static bool TryGet(string categoryName, [MaybeNullWhen(false)] out LogCategory category)
    {
        return Categories.TryGetValue(categoryName, out category);
    }

    /// <summary>
    /// Tries to get a logging category by name, or creates it if it does not exist.
    /// </summary>
    public static LogCategory Make(string categoryName)
    {
        if (Categories.TryGetValue(categoryName, out var category))
            return category;

        category = new LogCategory(categoryName) { Logger = LogSystem.Factory?.CreateLogger(categoryName) };

        Categories[categoryName] = category;
        return category;
    }

    #endregion

    /// <summary>
    /// Represents the name of the logging category.
    /// This property is used to uniquely identify a specific logging category, allowing
    /// for categorization and filtering of logged messages.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Represents whether this category is enabled and will display logs
    /// </summary>
    public bool IsCategoryEnabled = true;

    /// <summary>
    /// Represents whether the caller info (member name, file path, line number) should be displayed in the logs
    /// </summary>
    public bool AppendCallerInfo = false;

    public ILogger? Logger { get; internal set; }

    /// <summary>
    /// Represents a logging category that provides methods for structured and leveled logging.
    /// </summary>
    /// <remarks>
    /// A logging category is a logical grouping for log entries, enabling control over log level filtering and organization.
    /// The class serves as a base for defining specific logging behavior.
    /// </remarks>
    private LogCategory(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Logging will be skipped for this category if these conditions are not met
    /// </summary>
    private bool LoggingEnabled => LogSystem.IsEnabled && IsCategoryEnabled;

    /// <summary>
    /// Is logging enabled for this category at this level?
    /// </summary>
    public bool IsEnabled(LogLevel level) =>
        LogSystem.IsEnabled && IsCategoryEnabled && Logger?.IsEnabled(level) == true;

    /// <summary>
    /// Logs a message at the given level, with optional details about the source member, file, and line number.
    /// </summary>
    /// <param name="logLevel">The level to log on.</param>
    /// <param name="message">The message to log.</param>
    /// <param name="sourceMemberName">The name of the method that invokes this log call. Automatically populated by the CallerMemberName attribute if not specified.</param>
    /// <param name="sourceFilePath">The file path of the caller. Automatically populated by the CallerFilePath attribute if not specified.</param>
    /// <param name="sourceLineNumber">The line number in the source file where the log call originates. Automatically populated by the CallerLineNumber attribute if not specified.</param>
    /// <param name="appendCallerInfo">For internal use, to forcibly append caller information even if <see cref="AppendCallerInfo"/> is false.
    /// Defaults to null i.e. follow <see cref="AppendCallerInfo"/>.</param>
    private void Log<TLevel>(
        LogLevel logLevel,
        [InterpolatedStringHandlerArgument("")] LogString<TLevel> message = default,
        [CallerMemberName] string sourceMemberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0,
        bool? appendCallerInfo = null
    )
        where TLevel : unmanaged, ILogLevel
    {
        // Thread-safety paranoia: drain the handler first to avoid leaking the rented StringBuilder
        // in case a guard below mismatches due to a race condition
        // (level/logger state flipped on another thread between ctor and here).
        var messageString = message.ToStringAndClear();

        if (!LoggingEnabled)
            return;

        if (Logger is null)
            throw new LogNotInitializedException();

        if (!Logger.IsEnabled(logLevel))
            return;

        // A span pass-through materializes only now: unlike the rented SB drained above it holds
        // no pooled resource, so deferring past the guards keeps suppressed logs allocation-free.
        messageString ??= message.Span.ToString();

        if (appendCallerInfo ?? AppendCallerInfo)
        {
            Logger.Log(
                logLevel,
                "{Message} {SourceMemberName} (in {SourceFilePath}:{SourceLineNumber})",
                messageString,
                sourceMemberName,
                sourceFilePath,
                sourceLineNumber
            );
        }
        else
            Logger.Log(logLevel, messageString);
    }

    /// <inheritdoc cref="Log{TLevel}"/>
    public void Log(
        LogLevel logLevel,
        [InterpolatedStringHandlerArgument("", nameof(logLevel))] LogString<Dynamic> message = default,
        [CallerMemberName] string sourceMemberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Log<Dynamic>(logLevel, message, sourceMemberName, sourceFilePath, sourceLineNumber);
    }

    /// <inheritdoc cref="Log{TLevel}"/>
    public void Trace(
        [InterpolatedStringHandlerArgument("")] LogString<Trace> message = default,
        [CallerMemberName] string sourceMemberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Log(LogLevel.Trace, message, sourceMemberName, sourceFilePath, sourceLineNumber);
    }

    /// <inheritdoc cref="Log{TLevel}"/>
    public void Debug(
        [InterpolatedStringHandlerArgument("")] LogString<Debug> message = default,
        [CallerMemberName] string sourceMemberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Log(LogLevel.Debug, message, sourceMemberName, sourceFilePath, sourceLineNumber);
    }

    /// <inheritdoc cref="Log{TLevel}"/>
    public void Info(
        [InterpolatedStringHandlerArgument("")] LogString<Information> message = default,
        [CallerMemberName] string sourceMemberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Log(LogLevel.Information, message, sourceMemberName, sourceFilePath, sourceLineNumber);
    }

    /// <inheritdoc cref="Log{TLevel}"/>
    public void Warning(
        [InterpolatedStringHandlerArgument("")] LogString<Warning> message = default,
        [CallerMemberName] string sourceMemberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Log(LogLevel.Warning, message, sourceMemberName, sourceFilePath, sourceLineNumber);
    }

    /// <inheritdoc cref="Log{TLevel}"/>
    public void Error(
        [InterpolatedStringHandlerArgument("")] LogString<Error> message = default,
        [CallerMemberName] string sourceMemberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Log(LogLevel.Error, message, sourceMemberName, sourceFilePath, sourceLineNumber);
    }

    /// <inheritdoc cref="Log{TLevel}"/>
    public void Critical(
        [InterpolatedStringHandlerArgument("")] LogString<Critical> message = default,
        [CallerMemberName] string sourceMemberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Log(LogLevel.Critical, message, sourceMemberName, sourceFilePath, sourceLineNumber);
    }

#pragma warning disable CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
    /// <inheritdoc cref="Log{TLevel}"/>
    /// <param name="exception">The exception object containing details for the logged error message.</param>
    public void Error(
        Exception exception,
        [CallerMemberName] string sourceMemberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Log<Error>(
            LogLevel.Error,
            $"{exception}",
            sourceMemberName,
            sourceFilePath,
            sourceLineNumber,
            appendCallerInfo: true
        );
    }

    /// <inheritdoc cref="Log{TLevel}"/>
    /// <param name="exception">The exception object containing details for the logged critical message.</param>
    public void Critical(
        Exception exception,
        [CallerMemberName] string sourceMemberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Log<Critical>(
            LogLevel.Critical,
            $"{exception}",
            sourceMemberName,
            sourceFilePath,
            sourceLineNumber,
            appendCallerInfo: true
        );
    }
#pragma warning restore CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
}
