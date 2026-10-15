// The internal half of AlDebug (public half: AlDebug.cs): the per-context callback rooting and its
// trampoline, plus the shared text arena the pull side writes into. ArenaView is internal rather
// than private only so AlDebugMessageInfo.Message can slice the arena.

using System.Collections.Concurrent;

namespace Brutal.OpenAlApi;

public static unsafe partial class AlDebug
{
    // Per-context rooting, identical in shape to Al.EventCallbacks (Callbacks.Internal.cs): the
    // current context's raw address round-trips as userParam and keys the handler here, never a
    // managed pointer. internal so Al.EvictContextRoots can prune entries on context teardown and
    // tests can observe it.
    internal static readonly ConcurrentDictionary<nint, AlDebugCallback> DebugCallbacks = new();

    // The shared text arena the pull side writes into. Allocated lazily on the first pull (only
    // debug-tooling apps pay for it), sized to drain a full log chunk or hold the largest possible
    // label. Every pull overwrites it from offset 0 - that is what makes returned spans "valid
    // until the next pull" - and one arena means the pull side is single-threaded by design.
    private static byte[]? _arena;

    // Messages drained per native call. openal-soft's log holds at most 64 (al/debug.h), so one
    // chunk empties it; larger caller spans are served by the drain loop callers write anyway.
    // Also bounds the per-call stackalloc side-arrays.
    private const int LogChunk = 64;

    /// <summary>The current arena, or empty if nothing has been pulled yet.</summary>
    internal static ReadOnlySpan<byte> ArenaView => _arena;

    private static byte[] EnsureArena()
    {
        if (_arena is null)
        {
            var messageLength = Al.PInvoke.GetInteger(Al.Constants.AL_MAX_DEBUG_MESSAGE_LENGTH_EXT);
            var labelLength = Al.PInvoke.GetInteger(Al.Constants.AL_MAX_LABEL_LENGTH_EXT);
            var size = Math.Max(LogChunk * messageLength, labelLength);

            // With no context current (or no AL_EXT_debug) both queries answer 0. Do NOT cache
            // that: a zero-length arena cached here would poison every pull for the rest of the
            // process. Serve this call with an empty arena and let the next call re-query.
            if (size <= 0)
                return [];

            _arena = new byte[size];
        }
        return _arena;
    }

    // Called from Al.EvictContextRoots for every context address that stops being valid.
    internal static void EvictContextRoots(nint contextPointer) => DebugCallbacks.TryRemove(contextPointer, out _);

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static void DebugTrampoline(
        int source,
        int type,
        uint id,
        int severity,
        int length,
        byte* message,
        void* userParam
    )
    {
        try
        {
            if (DebugCallbacks.TryGetValue((nint)userParam, out var callback))
            {
                callback(
                    (AlDebugSource)source,
                    (AlDebugType)type,
                    id,
                    (AlDebugSeverity)severity,
                    new ReadOnlySpan<byte>(message, length)
                );
            }
        }
        catch (Exception ex)
        {
            Al.CallbackExceptions.Push("Error in AlDebug callback.", ex);
            // the message is dropped
        }
    }
}
