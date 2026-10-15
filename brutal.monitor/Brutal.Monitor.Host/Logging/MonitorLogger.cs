using Brutal.Monitor.Common;
using Microsoft.Extensions.Logging;

namespace Brutal.Monitor.Logging;

/// <summary>
/// Provides the MonitorLogger. Messages are queued for the background writer and mirrored
/// into the crash-tail ring, so a log call only ever touches memory.
/// </summary>
public class MonitorLoggerProvider : ILoggerProvider
{
    private readonly BackgroundLogWriter _writer = new();
    private CrashTailRing? _tailRing;
    private volatile bool _disposed;

    // Backed by an int so the hot-path read is a plain load rather than a property call on an enum field
    private volatile int _minimumLevel = (int)LogLevel.Trace;

    public MonitorLoggerProvider() { }

    public MonitorLoggerProvider(LogLevel minimumLevel)
    {
        MinimumLevel = minimumLevel;
    }

    /// <summary>
    /// Messages below this level are dropped before anything is formatted, so trace spam
    /// costs a compare instead of a string, a ring write and a queue slot. Defaults to Trace.
    /// </summary>
    public LogLevel MinimumLevel
    {
        get => (LogLevel)_minimumLevel;
        set => _minimumLevel = (int)value;
    }

    /// <summary>True when this level is worth building a message for.</summary>
    public bool IsEnabled(LogLevel level)
    {
        return level != LogLevel.None && (int)level >= _minimumLevel;
    }

    /// <summary>
    /// Optional formatter for log file lines, given the level, category and message. Runs on
    /// the background writer thread, so its strings never cost a game thread, and the
    /// crash-tail ring always gets the plain message. Set it before logging starts.
    /// </summary>
    public Func<LogLevel, string, string, string>? LogFormatter
    {
        get => _writer.LogFormatter;
        set => _writer.LogFormatter = value;
    }

    /// <summary>Crash-tail ring path, once file logging is configured.</summary>
    public string? CrashTailPath => _tailRing?.FilePath;

    /// <summary>This run's log file path, once file logging is configured.</summary>
    public string? LogFilePath => _writer.LogFilePath;

    /// <summary>Counters for the logging pipeline, cheap enough to poll every frame.</summary>
    public MonitorLoggingStats GetStats()
    {
        return new MonitorLoggingStats
        {
            QueueDepth = _writer.QueueDepth,
            QueueCapacity = _writer.Capacity,
            LinesWritten = _writer.LinesWritten,
            BytesWritten = _writer.BytesWritten,
            LinesDropped = _writer.LinesDropped,
            LinesDiscarded = _writer.LinesDiscarded,
            WriterFailed = _writer.WriterFailed,
            RingSequence = _tailRing?.Sequence ?? 0,
            RingSlotCount = _tailRing?.SlotCount ?? 0,
            RingSlotSize = _tailRing?.SlotSize ?? 0,
        };
    }

    /// <summary>
    /// Open the log file and start the background writer, flushing anything already queued.
    /// Call once, during startup.
    /// </summary>
    public void Configure(LoggerOptions options, string name)
    {
        _writer.Open(options, name);

        // The ring carries the log file's name, so the subprocess can match the two
        var logFilePath = _writer.LogFilePath;
        if (logFilePath is null)
            return;

        try
        {
            _tailRing = new CrashTailRing(logFilePath + ".ring");
        }
        catch (Exception)
        {
            // Any unusable path or mapping loses the crash tail; none of it may fail startup
            _tailRing = null;
        }

        // A host that exits without disposing must still retire the ring, or a clean exit reads as a crash next run
        if (_tailRing is not null)
        {
            AppDomain.CurrentDomain.ProcessExit += OnProcessExit;

            // A crash unwinds through Dispose even without last-chance dumps, so the ring is preserved here too
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
        }
    }

    private void OnProcessExit(object? sender, EventArgs e)
    {
        Dispose();
    }

    // The subscription cannot be exercised in-process without dying, so tests call this directly
    internal void OnUnhandledException(object? sender, UnhandledExceptionEventArgs e)
    {
        PreserveCrashTail();
    }

    /// <summary>Keep this run's crash tail for the next run; a dying host unwinds through this disposal.</summary>
    internal void PreserveCrashTail()
    {
        _tailRing?.Preserve();
    }

    public ILogger CreateLogger(string categoryName)
    {
        return new MonitorLogger(categoryName, this);
    }

    public void AddMessage(string message)
    {
        AddMessage(LogLevel.None, null, message);
    }

    /// <summary>
    /// Queue a log message. The ring gets the plain message; formatting happens at the writer.
    /// </summary>
    public void AddMessage(LogLevel level, string? category, string message)
    {
        if (_disposed)
            return;

        // Raw lines (null category) are markers and recovery notes, so they are never filtered
        if (category is not null && !IsEnabled(level))
            return;

        // Threads can still be logging while another disposes, and ILogger.Log must not throw
        try
        {
            _tailRing?.Write(message);
            if (category is null)
                _writer.Add(message);
            else
                _writer.Add(level, category, message);
        }
        catch (ObjectDisposedException) { }
    }

    public void Dispose()
    {
        _disposed = true;
        AppDomain.CurrentDomain.ProcessExit -= OnProcessExit;
        AppDomain.CurrentDomain.UnhandledException -= OnUnhandledException;
        _writer.Dispose();
        _tailRing?.Dispose();
    }
}

/// <summary>Counters describing the logging pipeline's current state.</summary>
public struct MonitorLoggingStats
{
    public int QueueDepth;
    public int QueueCapacity;
    public long LinesWritten;
    public long BytesWritten;
    public long LinesDropped;

    // Lines drained with no usable log file, and whether the file was lost to a write failure
    public long LinesDiscarded;
    public bool WriterFailed;

    public long RingSequence;
    public int RingSlotCount;
    public int RingSlotSize;

    public MonitorLoggingStats() { }
}

/// <summary>
/// This logger queues messages for the background writer and crash-tail ring
/// </summary>
internal sealed class MonitorLogger : ILogger
{
    private readonly string _categoryName;
    private readonly MonitorLoggerProvider _provider;

    public MonitorLogger(string categoryName, MonitorLoggerProvider provider)
    {
        _provider = provider;
        _categoryName = categoryName;
    }

    public void Dispose() { }

    public void Log<TState>(
        LogLevel logLevel,
        EventId eventId,
        TState state,
        Exception? exception,
        Func<TState, Exception?, string> formatter
    )
    {
        // Gated before the formatter runs, so a filtered-out call allocates nothing at all
        if (!_provider.IsEnabled(logLevel))
            return;

        // A throwing ToString in the state or exception costs its line, never the game thread
        try
        {
            var message = formatter(state, exception);

            // The default formatter leaves the exception out, and a crash log without the stack is useless
            if (exception is not null)
                message = $"{message}{Environment.NewLine}{exception}";

            _provider.AddMessage(logLevel, _categoryName, message);
        }
        catch (Exception) { }
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return _provider.IsEnabled(logLevel);
    }

    public IDisposable? BeginScope<TState>(TState state)
        where TState : notnull
    {
        return null;
    }
}
