// The internal half of the callback marshalling (public half: Callbacks.cs): the exception latch,
// the rooting dictionaries and fields, and the [UnmanagedCallersOnly] trampolines. See the
// Callbacks.cs header for the pattern these all follow.

using System.Collections.Concurrent;

namespace Brutal.OpenAlApi;

// The process-wide latch for exceptions thrown by managed callback handlers. Capped so an
// undrained process cannot grow unboundedly: the first Capacity exceptions are kept, the rest
// only counted.
internal sealed class CallbackExceptionAggregator
{
    private const int Capacity = 16;
    private readonly List<Exception> _exceptions = [];
    private int _dropped;
    private readonly Lock _lock = new();

    public void Push(string message, Exception inner)
    {
        try
        {
            lock (_lock)
            {
                if (_exceptions.Count < Capacity)
                    _exceptions.Add(new Exception(message, inner));
                else
                    _dropped++;
            }
        }
        catch
        {
            // Never let the latch itself throw back into a native frame.
        }
    }

    public void ThrowIfAny()
    {
        Exception exception;
        lock (_lock)
        {
            if (_exceptions.Count == 0)
                return;
            if (_dropped > 0)
                _exceptions.Add(new Exception($"{_dropped} further callback exception(s) were dropped."));
            exception = _exceptions.Count == 1 ? _exceptions[0] : new AggregateException([.. _exceptions]);
            _exceptions.Clear();
            _dropped = 0;
        }
        throw exception;
    }
}

public static unsafe partial class Al
{
    internal static readonly CallbackExceptionAggregator CallbackExceptions = new();

    // AL events are per-context, but the native callback has no per-context registration - so
    // registration passes the current context's raw address as userParam, and this dictionary
    // roots the handler keyed by that same address. The key is a plain nint, never a managed
    // pointer. internal so Context teardown can prune entries via EvictContextRoots below (a
    // recycled context address must never resolve to a stale handler) and tests can observe it.
    internal static readonly ConcurrentDictionary<nint, AlEventCallback> EventCallbacks = new();

    // Called from Context teardown for every context address that stops being valid. AlDebug's
    // per-context callback dictionary joins here rather than adding a second Context hook.
    internal static void EvictContextRoots(nint contextPointer)
    {
        EventCallbacks.TryRemove(contextPointer, out _);
        AlDebug.EvictContextRoots(contextPointer);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static void AlEventTrampoline(
        int eventType,
        uint obj,
        uint param,
        int length,
        byte* message,
        void* userParam
    )
    {
        try
        {
            if (EventCallbacks.TryGetValue((nint)userParam, out var callback))
                callback((AlEventType)eventType, obj, param, new ReadOnlySpan<byte>(message, length));
        }
        catch (Exception ex)
        {
            CallbackExceptions.Push("Error in Al event callback.", ex);
            // the event is dropped
        }
    }
}

public static unsafe partial class Alc
{
    // ALC_SOFT_system_events is process-global, so a single static field is enough rooting.
    internal static AlcEventCallback? SystemEventCallback => _systemEventCallback;
    private static AlcEventCallback? _systemEventCallback;

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static void AlcEventTrampoline(
        int eventType,
        int deviceType,
        nint device,
        int length,
        byte* message,
        void* userParam
    )
    {
        try
        {
            _systemEventCallback?.Invoke(
                (AlcEventType)eventType,
                (AlcDeviceType)deviceType,
                (void*)device,
                new ReadOnlySpan<byte>(message, length)
            );
        }
        catch (Exception ex)
        {
            Al.CallbackExceptions.Push("Error in Alc event callback.", ex);
            // the event is dropped
        }
    }
}

public readonly unsafe partial struct AlBuffer
{
    // Rooting and identity: userptr round-trips a process-unique cookie (never a managed pointer,
    // and never the buffer name - see the Callbacks.cs header), and this dictionary keeps the
    // delegate alive while native code may call it. The owning device's address rides along
    // (recorded once registration is confirmed) so Device.Dispose can sweep the roots of buffers
    // destroyed with their device.
    private static readonly ConcurrentDictionary<nint, (AlBufferCallback Callback, nint Device)> BufferCallbacks =
        new();

    // Minted per registration via Interlocked.Increment; not derived from any AL object identity,
    // so it can never collide across devices or re-registrations.
    private static long _cookieCounter;

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static int BufferTrampoline(void* userptr, void* sampleData, int numBytes)
    {
        try
        {
            return BufferCallbacks.TryGetValue((nint)userptr, out var entry)
                ? entry.Callback(new Span<byte>(sampleData, numBytes))
                : 0;
        }
        catch (Exception ex)
        {
            Al.CallbackExceptions.Push("Error in AlBuffer callback.", ex);
            return 0; // the stream goes silent
        }
    }

    // Queries the cookie currently bound to this buffer name (alGetBufferPtrSOFT); 0 when no
    // callback is registered. SetCallback/ClearCallback read this before and after their native
    // call to decide which dictionary entry to evict: native registration and reset report
    // failure only on the error latch, so the bound cookie is the one reliable signal of whether
    // the call actually took.
    private static nint BoundCookie(uint name)
    {
        void* existing = null;
        Al.PInvoke.GetBufferPtrSOFT(name, Al.Constants.AL_BUFFER_CALLBACK_USER_PARAM_SOFT, &existing);
        return (nint)existing;
    }

    // Fast-path guard for the hot upload/delete paths: with no registration rooted anywhere there
    // is nothing to evict, and the extension query is skipped entirely - non-callback consumers
    // pay one dictionary emptiness check.
    private static nint PeekCookie(uint name) => BufferCallbacks.IsEmpty ? 0 : BoundCookie(name);

    // Deleting a buffer ends its native callback registration, so the managed root must go with
    // it - otherwise the delegate (and everything its closure captures) stays reachable for the
    // rest of the process. The generated Delete/DeleteBuffers route here. Cookies are read BEFORE
    // the native delete (a freed name cannot answer) and evicted AFTER, keyed on per-name
    // liveness: deletion reports failure only on the error latch, and a rejected delete (buffer
    // in use by a source) leaves the native callback registered, so its root must survive.
    internal static void DeleteAndEvictCallbackRoots(uint* names, int count)
    {
        if (BufferCallbacks.IsEmpty)
        {
            Al.PInvoke.DeleteBuffers(count, names);
            return;
        }

        // Deletes are not hot enough to justify pooling; the stackalloc covers every sane bulk.
        Span<nint> cookies = count <= 64 ? stackalloc nint[count] : new nint[count];
        for (var i = 0; i < count; i++)
            cookies[i] = BoundCookie(names[i]);

        Al.PInvoke.DeleteBuffers(count, names);

        for (var i = 0; i < count; i++)
        {
            if (cookies[i] != 0 && !Al.PInvoke.IsBuffer(names[i]))
                BufferCallbacks.TryRemove(cookies[i], out _);
        }
    }

    // Called from Device.Dispose: closing a device destroys its buffers without any per-buffer
    // delete running, so every root recorded under the device is swept wholesale. Removing by
    // (key, value) pair never evicts an entry re-registered under a recycled cookie (cookies are
    // never recycled, but the discipline matches Context.EvictDeviceEntries).
    internal static void EvictDeviceRoots(nint devicePointer)
    {
        foreach (var entry in BufferCallbacks)
        {
            if (entry.Value.Device == devicePointer)
                BufferCallbacks.TryRemove(entry);
        }
    }
}
