namespace Brutal.SdlApi.Mixer;

/// <summary>
/// Collects exceptions thrown inside SDL_mixer callbacks and rethrows them from managed code.
/// </summary>
/// <remarks>
/// This is the SDL_mixer analogue of core's <c>Brutal.SdlApi.ExceptionAggregator</c>, replicated here
/// (rather than shared) because core's type is <c>internal</c> to <c>Brutal.Sdl</c> and because the
/// two aggregators serve threads with fundamentally different concurrency: core's callbacks fire on
/// the single event-pump thread, whereas SDL_mixer invokes its track-stopped / mix hooks on its own
/// audio device thread(s). A callback exception cannot legally unwind across the native stack frame
/// that called it, so the trampolines catch every exception and hand it here via <see cref="Push"/>,
/// which also logs it immediately so it is never silently lost. Pending exceptions are rethrown from
/// managed code either at the next mixer/track/group-touching ergonomic method (each drains via
/// <see cref="CheckExceptions"/>) or explicitly via
/// <see cref="SdlMixer.ThrowPendingCallbackExceptions"/>. The reused public
/// <see cref="SdlCallbackException"/> type (from <c>Brutal.Sdl</c>) carries each wrapped failure.
/// <para>
/// <b>Thread safety:</b> every mutating and draining operation takes <see cref="_lock"/>, so an
/// audio thread calling <see cref="Push"/> and the game thread calling <see cref="CheckExceptions"/>
/// (or two audio threads pushing concurrently) never race on the pending list. To bound memory when
/// no drain point is reached for a while, only the first <see cref="MaxRetained"/> exceptions are
/// kept; further ones are counted and reported but not stored.
/// </para>
/// </remarks>
internal sealed class ExceptionAggregator
{
    /// <summary>The maximum number of pending exceptions retained; beyond this only a count is kept.</summary>
    public const int MaxRetained = 16;

    private readonly List<Exception> _exceptions = [];
    private int _dropped;
    private readonly Lock _lock = new();

    /// <summary>
    /// Records an exception raised inside a native-to-managed SDL_mixer callback so it can be rethrown
    /// from managed code at the next <see cref="CheckExceptions"/>. The exception is logged immediately
    /// at error level (so it is visible even if no drain point is ever reached) and retained up to
    /// <see cref="MaxRetained"/> entries; further exceptions increment a dropped counter. Safe to call
    /// concurrently from any audio thread.
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

        // Then log for promptness (the exception may sit pending until a drain point). This runs on the
        // SDL_mixer audio device thread, so it is wrapped in its own catch: a logging failure here must
        // never re-escape into native code (a managed exception unwinding into the audio thread is the
        // exact UB / hard crash this whole trampoline design exists to prevent) — and the payload is
        // already retained above, so swallowing the logging fault loses nothing. This is the one place
        // an empty catch is correct: it is a native-boundary firewall on a real-time thread.
        try
        {
            SdlMixer.TraceLog.Error(wrapped);
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
                    $"{_exceptions.Count} SDL_mixer callback exception(s) occurred."
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
    /// Discards all pending exceptions without throwing. Used during <see cref="SdlMixer.Quit"/>
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
