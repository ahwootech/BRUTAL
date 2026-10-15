using Brutal.Logging;

namespace Brutal.SdlApi;

/// <summary>
/// The exception type an SDL callback (event watch/filter, log output function, …) failed with,
/// captured at the native boundary and rethrown from managed code at the next event pump. Derives
/// from <see cref="SdlException"/> so callers can catch the whole SDL failure family uniformly; the
/// original callback exception is preserved as <see cref="Exception.InnerException"/>.
/// </summary>
public sealed class SdlCallbackException : SdlException
{
    /// <summary>Initializes a new <see cref="SdlCallbackException"/> with the given message.</summary>
    /// <param name="message">A description of the callback in which the exception occurred.</param>
    public SdlCallbackException(string message)
        : base(message) { }

    /// <summary>Initializes a new <see cref="SdlCallbackException"/> with a message and inner exception.</summary>
    /// <param name="message">A description of the callback in which the exception occurred.</param>
    /// <param name="innerException">The original exception thrown inside the callback.</param>
    public SdlCallbackException(string message, Exception innerException)
        : base(message, innerException) { }
}

/// <summary>
/// Collects exceptions thrown inside SDL callbacks and rethrows them from managed code.
/// </summary>
/// <remarks>
/// SDL invokes managed callbacks (event watches, event filters, log output functions, …) from
/// native code. An exception thrown out of such a callback cannot legally unwind across the native
/// stack frame that called it — doing so is undefined behaviour. Instead, the callback wrappers in
/// this binding catch every exception and hand it to this aggregator with <see cref="Push"/>, which
/// also logs it immediately so it is never silently lost. The pending exceptions are rethrown from
/// managed code at the next pump point (<see cref="Sdl.Events.PollEvent(out SdlEvent)"/>,
/// <see cref="Sdl.Events.PumpEvents"/>, <see cref="Sdl.Events.WaitEvent(SdlEvent*)"/>, …) via
/// <see cref="CheckExceptions"/>. To bound memory when a pump point is never reached, only the first
/// <see cref="MaxRetained"/> exceptions are kept; further ones are counted and reported but not
/// stored.
/// </remarks>
internal sealed class ExceptionAggregator
{
    /// <summary>The maximum number of pending exceptions retained; beyond this only a count is kept.</summary>
    public const int MaxRetained = 16;

    private readonly List<Exception> _exceptions = [];
    private int _dropped;
    private readonly Lock _lock = new();

    /// <summary>
    /// Records an exception raised inside a native-to-managed callback so it can be rethrown from
    /// managed code at the next <see cref="CheckExceptions"/>. The exception is logged immediately at
    /// error level (so it is visible even if no pump point ever drains the aggregator) and retained
    /// up to <see cref="MaxRetained"/> entries; further exceptions increment a dropped counter.
    /// </summary>
    /// <param name="message">A description of the callback in which the exception occurred.</param>
    /// <param name="innerException">The exception that was caught, preserved as the inner exception.</param>
    public void Push(string message, Exception? innerException = null)
    {
        var wrapped = innerException is null
            ? new SdlCallbackException(message)
            : new SdlCallbackException(message, innerException);

        // Store FIRST (under the lock) so the parked exception is durably retained before anything that
        // can fail runs — a faulting logger must never be able to drop it. This is the "never lost"
        // guarantee.
        lock (_lock)
        {
            if (_exceptions.Count < MaxRetained)
                _exceptions.Add(wrapped);
            else
                _dropped++;
        }

        // Then log for promptness (the exception may sit pending until a pump point). Wrapped in its own
        // catch so a logging failure can never re-escape across the native callback boundary (SDL calls
        // these wrappers from native code); the payload is already retained above, so swallowing a
        // logging fault loses nothing.
        try
        {
            Sdl.TraceLog.Error(wrapped);
        }
        catch
        {
            // Intentionally swallowed: the exception is already parked; a logging fault must not cross
            // the native boundary.
        }
    }

    /// <summary>
    /// Rethrows any exceptions captured since the last check, then clears the pending set. Does
    /// nothing when nothing is pending. A single pending exception (with none dropped) is rethrown
    /// directly; otherwise the pending exceptions are wrapped in an <see cref="AggregateException"/>
    /// whose message notes how many further exceptions were dropped.
    /// </summary>
    /// <exception cref="SdlCallbackException">Exactly one callback exception was pending.</exception>
    /// <exception cref="AggregateException">More than one callback exception was pending, or some were dropped.</exception>
    public void CheckExceptions()
    {
        Exception exception;
        lock (_lock)
        {
            if (_exceptions.Count == 0)
                return;

            var dropped = _dropped;
            if (_exceptions.Count == 1 && dropped == 0)
            {
                exception = _exceptions[0];
            }
            else
            {
                var message =
                    $"{_exceptions.Count} SDL callback exception(s) occurred."
                    + (
                        dropped > 0
                            ? $" A further {dropped} were dropped (only the first {MaxRetained} are retained)."
                            : ""
                    );
                exception = new AggregateException(message, _exceptions.ToArray());
            }

            _exceptions.Clear();
            _dropped = 0;
        }

        throw exception;
    }

    /// <summary>
    /// Discards all pending exceptions without throwing. Used during <see cref="Sdl.Init.Quit"/>
    /// teardown, where the parked exceptions refer to a session that is ending.
    /// </summary>
    public void Clear()
    {
        lock (_lock)
        {
            _exceptions.Clear();
            _dropped = 0;
        }
    }
}

/// <summary>
/// Provides access to the SDL3 library.
/// </summary>
public static unsafe partial class Sdl
{
    /// <summary>
    /// The name the generated P/Invoke surface imports against. The <see cref="PInvoke"/> static
    /// constructor registers a <see cref="NativeLibrary.SetDllImportResolver"/> that normalizes
    /// this name to the platform-specific SDL3 shared library.
    /// </summary>
    internal const string Dll = "SDL3";

    /// <summary>
    /// The logging category for the per-call trace logs the generated P/Invoke surface emits. It is
    /// an internal implementation detail: the public <see cref="Log"/> nested class hosts the
    /// consumer-facing logging helpers, and reclaiming the <c>Log</c> name for that class is why this
    /// category is spelled <c>TraceLog</c> rather than <c>Log</c>.
    /// </summary>
    internal static readonly LogCategory TraceLog = LogCategory.Make("Sdl");

    /// <summary>
    /// Captures exceptions thrown inside SDL callbacks (event watches/filters, log output) so they
    /// can be rethrown safely from managed code at the next event pump instead of unwinding across
    /// the native boundary.
    /// </summary>
    internal static readonly ExceptionAggregator ExceptionAggregator = new();
}
