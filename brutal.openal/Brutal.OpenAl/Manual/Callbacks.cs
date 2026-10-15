// Callback marshalling for the alext.h callback extensions. Public half: the delegate types and
// the register/deregister/control surface; the exception latch, handler dictionaries, and
// trampolines live in Callbacks.Internal.cs.
//
// The pattern throughout: [UnmanagedCallersOnly] static trampolines (no GCHandles needed), managed
// handlers rooted by strong references, and userParam never carrying a managed pointer. Exceptions
// never cross into native frames - every trampoline catches, pushes onto Al.CallbackExceptions,
// and returns a neutral value. No callback path allocates managed memory.
//
// Registration stores the handler BEFORE the native call, not after: openal-soft can deliver an
// event from its own thread as soon as the native call returns, and a handler stored afterwards
// would miss it. The native call only throws when the extension entry point is missing, so each
// register hook puts the previous handler back in that case instead of leaving a dead one stored.
//
// AlBuffer callbacks are keyed by a process-unique cookie, NOT the buffer name: names are
// per-device in openal-soft, so two open devices can each hand out buffer 1 and a name-keyed
// dictionary would resolve to the wrong device's handler.

using unsafe AlcEventTrampolineFn = delegate* unmanaged[Cdecl]<int, int, nint, int, byte*, void*, void>;
using unsafe AlEventTrampolineFn = delegate* unmanaged[Cdecl]<int, uint, uint, int, byte*, void*, void>;
using unsafe BufferTrampolineFn = delegate* unmanaged[Cdecl]<void*, void*, int, int>;

namespace Brutal.OpenAlApi;

/// <summary>
///     Fills a callback buffer with sample data; returns the number of BYTES written. Return less
///     than <c>destination.Length</c> to signal the end of the stream. Provided by
///     <c>AL_SOFT_callback_buffer</c>.
/// </summary>
/// <remarks>
///     Called from openal-soft's mixer thread. Must not throw (a thrown exception is caught, queued
///     on <see cref="Al.ThrowCallbackExceptions"/>, and the stream goes silent) and must not block.
/// </remarks>
public delegate int AlBufferCallback(Span<byte> destination);

/// <summary>
///     Reports an AL event (buffer completion, source state change, or disconnect). Provided by
///     <c>AL_SOFT_events</c>; see <see cref="Al.SetEventCallback"/>.
/// </summary>
/// <remarks>
///     Called on openal-soft's internal event thread, not necessarily the thread that registered
///     the callback. Must not throw (a thrown exception is caught, queued on
///     <see cref="Al.ThrowCallbackExceptions"/>, and the event is dropped) and must not block. The
///     message span is valid only for the duration of the call.
/// </remarks>
public delegate void AlEventCallback(AlEventType eventType, uint @object, uint parameter, ReadOnlySpan<byte> message);

/// <summary>
///     Reports an ALC system event (default device change, device added, or device removed).
///     Provided by <c>ALC_SOFT_system_events</c>; see <see cref="Alc.SetEventCallback"/>.
/// </summary>
/// <remarks>
///     Called synchronously on whichever backend thread noticed the change, under openal-soft's
///     global event lock - re-entering <see cref="Alc.SetEventCallback"/> or
///     <see cref="Alc.EventControl"/> from the handler can deadlock. Must not throw (a thrown
///     exception is caught, queued on <see cref="Al.ThrowCallbackExceptions"/>, and the event is
///     dropped) and must not block. The message span is valid only for the duration of the call.
/// </remarks>
public delegate void AlcEventCallback(
    AlcEventType eventType,
    AlcDeviceType deviceType,
    AlcDevice device,
    ReadOnlySpan<byte> message
);

public static unsafe partial class Al
{
    /// <summary>
    ///     Rethrows (and clears) any exceptions thrown by callback handlers since the last call.
    ///     Callbacks run on openal-soft's internal threads, where an exception cannot propagate;
    ///     each trampoline catches, queues here, and degrades (a buffer callback renders silence,
    ///     a notification is dropped). Call this from your update loop when using callbacks.
    ///     <see cref="LoopbackDevice.Render(Span{byte}, int)"/> drains automatically after each render.
    /// </summary>
    public static void ThrowCallbackExceptions() => CallbackExceptions.ThrowIfAny();

    /// <summary>
    ///     Enables or disables delivery of the given AL event types to the callback registered with
    ///     <see cref="SetEventCallback"/> (<c>alEventControlSOFT</c>). Provided by
    ///     <c>AL_SOFT_events</c>.
    /// </summary>
    public static void EventControl(ReadOnlySpan<AlEventType> types, bool enable)
    {
        var raw = MemoryMarshal.Cast<AlEventType, int>(types);
        fixed (int* p = raw)
            PInvoke.EventControlSOFT(raw.Length, p, enable);
    }

    /// <summary>
    ///     Registers (or, with <see langword="null"/>, deregisters) the AL event callback for the
    ///     context current on this thread (<c>alEventCallbackSOFT</c>). Provided by
    ///     <c>AL_SOFT_events</c>.
    /// </summary>
    /// <remarks>
    ///     Registration AND deregistration bind to whichever context is current AT THE CALL: each
    ///     context has its own independent registration, and passing <see langword="null"/> with a
    ///     different context current deregisters nothing on the original one. Disposing a context
    ///     releases its own rooted handler automatically.
    /// </remarks>
    public static void SetEventCallback(AlEventCallback? callback)
    {
        // With nothing current the registration/removal simply keys on address 0 - this codebase
        // never pre-validates state the native call would itself diagnose (see the Errors.cs
        // header).
        var context = Alc.PInvoke.GetCurrentContext().Pointer.Value;
        if (callback is null)
        {
            PInvoke.EventCallbackSOFT(null, null);
            EventCallbacks.TryRemove(context, out _);
            return;
        }

        // Stored before the native call, restored if it throws - see the file header.
        var hadPrevious = EventCallbacks.TryGetValue(context, out var previous);
        EventCallbacks[context] = callback;
        try
        {
            // (&Trampoline) is parenthesized because `(AliasName)&expr` parses as a binary AND, not a cast.
            PInvoke.EventCallbackSOFT((void*)(AlEventTrampolineFn)(&AlEventTrampoline), (void*)context);
        }
        catch
        {
            if (hadPrevious)
                EventCallbacks[context] = previous!;
            else
                EventCallbacks.TryRemove(context, out _);
            throw;
        }
    }
}

public static unsafe partial class Alc
{
    /// <summary>
    ///     Whether the given ALC system event type is supported for the given device kind
    ///     (<c>alcEventIsSupportedSOFT</c>). Provided by <c>ALC_SOFT_system_events</c>.
    /// </summary>
    public static bool IsEventSupported(AlcEventType eventType, AlcDeviceType deviceType) =>
        PInvoke.EventIsSupportedSOFT((int)eventType, (int)deviceType) == Constants.ALC_EVENT_SUPPORTED_SOFT;

    /// <summary>
    ///     Enables or disables delivery of the given ALC system event types to the callback
    ///     registered with <see cref="SetEventCallback"/> (<c>alcEventControlSOFT</c>). Provided by
    ///     <c>ALC_SOFT_system_events</c>.
    /// </summary>
    public static bool EventControl(ReadOnlySpan<AlcEventType> events, bool enable)
    {
        var raw = MemoryMarshal.Cast<AlcEventType, int>(events);
        fixed (int* p = raw)
            return PInvoke.EventControlSOFT(raw.Length, p, enable);
    }

    /// <summary>
    ///     Registers (or, with <see langword="null"/>, deregisters) the ALC system event callback
    ///     (<c>alcEventCallbackSOFT</c>). Unlike <see cref="Al.SetEventCallback"/>, there is exactly
    ///     one registration for the whole process. Provided by <c>ALC_SOFT_system_events</c>.
    /// </summary>
    public static void SetEventCallback(AlcEventCallback? callback)
    {
        if (callback is null)
        {
            PInvoke.EventCallbackSOFT(null, null);
            _systemEventCallback = null;
            return;
        }

        // Stored before the native call, restored if it throws - see the file header.
        var previous = _systemEventCallback;
        _systemEventCallback = callback;
        try
        {
            PInvoke.EventCallbackSOFT((AlcEventTrampolineFn)(&AlcEventTrampoline), null);
        }
        catch
        {
            _systemEventCallback = previous;
            throw;
        }
    }
}

public readonly unsafe partial struct AlBuffer
{
    /// <summary>
    ///     Makes this a callback buffer: openal-soft pulls sample data from
    ///     <paramref name="callback"/> on its mixer thread instead of storing data
    ///     (<c>alBufferCallbackSOFT</c>). Provided by <c>AL_SOFT_callback_buffer</c>.
    /// </summary>
    /// <remarks>
    ///     On success the handler stays referenced until the registration ends:
    ///     <see cref="ClearCallback"/>, re-registration, a data upload
    ///     (<see cref="SetData(AlFormat, ReadOnlySpan{byte}, int)"/>), a successful delete, and
    ///     disposal of the owning <see cref="Device"/> all release it. Registration is
    ///     rejected while the buffer is attached to a source (<c>AL_INVALID_OPERATION</c>, silently
    ///     unless you check <see cref="Al.GetError"/>); a rejected registration releases the new
    ///     handler and leaves any existing callback fully in place.
    /// </remarks>
    public void SetCallback(AlFormat format, int frequency, AlBufferCallback callback)
    {
        ArgumentNullException.ThrowIfNull(callback);
        var previous = BoundCookie(Name);
        var cookie = (nint)Interlocked.Increment(ref _cookieCounter);
        // Root before registering - see the file header pattern. The owning device is not known to
        // be resolvable yet (registration may be a context-less no-op), so it is recorded below,
        // once the read-back proves the registration took.
        BufferCallbacks[cookie] = (callback, 0);
        Al.PInvoke.BufferCallbackSOFT(
            Name,
            (int)format,
            frequency,
            (BufferTrampolineFn)(&BufferTrampoline),
            (void*)cookie
        );

        // Registration reports failure only on the error latch (AL_INVALID_OPERATION while the
        // buffer is attached to a source), so read back which cookie the buffer actually holds:
        // on success evict the handler this call replaced, on failure unroot the new handler and
        // leave the existing registration untouched.
        if (BoundCookie(Name) == cookie)
        {
            // Registration took, so a context is necessarily current: record the buffer's owning
            // device so Device.Dispose can sweep this root if the buffer is destroyed with the
            // device rather than deleted individually.
            var device = Alc.PInvoke.GetContextsDevice(Alc.PInvoke.GetCurrentContext());
            BufferCallbacks[cookie] = (callback, device.Pointer.Value);
            if (previous != 0)
                BufferCallbacks.TryRemove(previous, out _);
        }
        else
        {
            BufferCallbacks.TryRemove(cookie, out _);
        }
    }

    /// <summary>
    ///     Detaches the callback (the buffer reverts to an empty non-callback buffer) and releases
    ///     the handler reference. Detach the buffer from any source first - the underlying reset
    ///     rejects an attached buffer with <c>AL_INVALID_OPERATION</c>, silently unless you check
    ///     <see cref="Al.GetError"/>, and a rejected reset leaves the callback registered and its
    ///     handler referenced.
    /// </summary>
    public void ClearCallback()
    {
        // The spec's sanctioned detach is re-specifying the buffer's data; openal-soft rejects a
        // NULL callback pointer with AL_INVALID_VALUE (verified in CallbackTests), so an empty
        // BufferData reset is used instead. The format is irrelevant at zero length. As in
        // SetCallback, the reset fails only on the error latch - release the handler only once
        // the buffer no longer holds its cookie.
        var previous = BoundCookie(Name);
        Al.PInvoke.BufferData(Name, (int)AlFormat.Mono16, null, 0, 1);
        if (previous != 0 && BoundCookie(Name) == 0)
            BufferCallbacks.TryRemove(previous, out _);
    }
}
