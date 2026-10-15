// AL_EXT_debug: a KHR_debug-style message log, debug groups, and object labels. Public half of
// AlDebug; the callback rooting, trampoline, and shared text arena live in AlDebug.Internal.cs;
// the typed ObjectLabel/GetObjectLabel overloads (one trio per object-name handle type) are
// generated - see Generated/Al/AlDebug.ObjectLabels.gen.cs.
//
// The callback roots per-context the same way as Al.SetEventCallback (see Callbacks.cs) and is
// pruned through the same Al.EvictContextRoots hook. The string-taking push side (MessageInsert/
// PushGroup/ObjectLabel) may allocate - outbound dev-tool calls, never on the delivery path. The
// pull side (GetMessageLog/GetObjectLabel) never allocates: results land in the shared arena.
//
// Verified against openal-soft's al/debug.cpp:
// - The message log writes each entry's length INCLUDING the trailing NUL; alGetObjectLabelEXT
//   writes it EXCLUDING the NUL. GetMessageLog and GetObjectLabel below slice accordingly.
// - The callback runs synchronously on the calling thread (unlike AL_SOFT_events' event thread).
// - alDebugMessageInsertEXT accepts only the Application/ThirdParty sources, and message/group
//   delivery requires a context created with ALC_CONTEXT_DEBUG_BIT_EXT - see the class doc.

using unsafe DebugTrampolineFn = delegate* unmanaged[Cdecl]<int, int, uint, int, int, byte*, void*, void>;

namespace Brutal.OpenAlApi;

/// <summary>Reports a debug message from the AL implementation, a debug group push/pop, or an application-inserted message.</summary>
/// <remarks>
///     Called synchronously on whichever thread triggers the message (unlike the AL_SOFT_events
///     callback, which runs on openal-soft's event thread). Must not throw (a thrown exception is
///     caught, queued on <see cref="Al.ThrowCallbackExceptions"/>, and the message dropped) and
///     must not block. The message span is valid only for the duration of the call. See
///     <see cref="AlDebug.SetCallback"/>.
/// </remarks>
public delegate void AlDebugCallback(
    AlDebugSource source,
    AlDebugType type,
    uint id,
    AlDebugSeverity severity,
    ReadOnlySpan<byte> message
);

/// <summary>A logged debug message, as drained by <see cref="AlDebug.GetMessageLog"/>.</summary>
public readonly record struct AlDebugMessageInfo(
    AlDebugSource Source,
    AlDebugType Type,
    uint Id,
    AlDebugSeverity Severity,
    int Offset,
    int Length
)
{
    /// <summary>
    ///     The UTF-8 message text (no trailing NUL). A view into <see cref="AlDebug"/>'s shared
    ///     text arena: valid only until the next <see cref="AlDebug.GetMessageLog"/> or
    ///     <c>AlDebug.GetObjectLabel</c> call.
    /// </summary>
    public ReadOnlySpan<byte> Message => AlDebug.ArenaView.Slice(Offset, Length);
}

/// <summary>
///     A <see langword="using"/>-able scope pairing
///     <see cref="AlDebug.PushGroup(AlDebugSource, uint, string)"/> with
///     <see cref="AlDebug.PopGroup"/>: the group pushed to obtain this scope is popped when it is
///     disposed.
/// </summary>
public readonly ref struct DebugGroupScope
{
    /// <summary>Pops the debug group (<c>alPopDebugGroupEXT</c>).</summary>
    public void Dispose() => AlDebug.PopGroup();
}

/// <summary>
///     The AL_EXT_debug surface: a KHR_debug-style message log, debug groups, object labels, and a
///     debug message callback.
/// </summary>
/// <remarks>
///     Message/group delivery (the log and the callback) requires a DEBUG context - create one by
///     passing <c>ALC_CONTEXT_DEBUG_BIT_EXT</c> among the context flags, then call
///     <see cref="Enable"/>:
///     <code>
///     using var context = device.CreateContext(
///         new Context.CreateInfo
///         {
///             Attributes = [(AlcContextAttribute.ContextFlags, Alc.Constants.ALC_CONTEXT_DEBUG_BIT_EXT)],
///         }
///     );
///     context.MakeCurrent();
///     AlDebug.Enable();
///     </code>
///     Object labels (<see cref="ObjectLabel(AlObjectLabelIdentifier,uint,string)"/> /
///     <see cref="GetObjectLabel(AlObjectLabelIdentifier, uint)"/>) work on any context; they carry
///     no message-delivery requirement. Provided by <c>AL_EXT_debug</c>.
/// </remarks>
public static unsafe partial class AlDebug
{
    /// <summary>Enables debug message/group delivery (<c>alEnable(AL_DEBUG_OUTPUT_EXT)</c>).</summary>
    public static void Enable() => Al.PInvoke.Enable(Al.Constants.AL_DEBUG_OUTPUT_EXT);

    /// <summary>Disables debug message/group delivery (<c>alDisable(AL_DEBUG_OUTPUT_EXT)</c>).</summary>
    public static void Disable() => Al.PInvoke.Disable(Al.Constants.AL_DEBUG_OUTPUT_EXT);

    /// <summary>
    ///     Registers (or, with <see langword="null"/>, deregisters) the debug callback for the
    ///     context current on this thread (<c>alDebugMessageCallbackEXT</c>).
    /// </summary>
    /// <remarks>
    ///     Binds to whichever context is current AT THE CALL - the same currency and disposal model
    ///     as <see cref="Al.SetEventCallback"/> (see its remarks). While a callback is registered,
    ///     messages are delivered to it instead of accumulating in the log, so
    ///     <see cref="GetMessageLog"/> then always returns empty.
    /// </remarks>
    public static void SetCallback(AlDebugCallback? callback)
    {
        // With nothing current the registration simply keys on address 0 - same stance as
        // Al.SetEventCallback: never pre-validate state the native call would itself diagnose.
        var context = Alc.PInvoke.GetCurrentContext().Pointer.Value;
        if (callback is null)
        {
            Al.PInvoke.DebugMessageCallbackEXT(null, null);
            DebugCallbacks.TryRemove(context, out _);
            return;
        }

        // Stored before the native call, restored if it throws - see the Callbacks.cs header.
        var hadPrevious = DebugCallbacks.TryGetValue(context, out var previous);
        DebugCallbacks[context] = callback;
        try
        {
            // (&DebugTrampoline) is parenthesized because `(AliasName)&expr` parses as a binary AND, not a cast.
            Al.PInvoke.DebugMessageCallbackEXT((void*)(DebugTrampolineFn)(&DebugTrampoline), (void*)context);
        }
        catch
        {
            if (hadPrevious)
                DebugCallbacks[context] = previous!;
            else
                DebugCallbacks.TryRemove(context, out _);
            throw;
        }
    }

    /// <summary>
    ///     Inserts an application message into the debug log/callback
    ///     (<c>alDebugMessageInsertEXT</c>). Only <see cref="AlDebugSource.Application"/> and
    ///     <see cref="AlDebugSource.ThirdParty"/> are valid for <paramref name="source"/>.
    /// </summary>
    public static void MessageInsert(
        AlDebugSource source,
        AlDebugType type,
        uint id,
        AlDebugSeverity severity,
        string message
    )
    {
        ArgumentNullException.ThrowIfNull(message);
        using var utf8 = new Utf8Buffer(message, stackalloc byte[Utf8Buffer.StackBufferSize]);
        fixed (byte* p = utf8.Span)
            Al.PInvoke.DebugMessageInsertEXT((int)source, (int)type, id, (int)severity, utf8.Length, p);
    }

    /// <inheritdoc cref="MessageInsert(AlDebugSource, AlDebugType, uint, AlDebugSeverity, string)"/>
    /// <remarks>UTF-8 byte variant: no transcode, no allocation.</remarks>
    public static void MessageInsert(
        AlDebugSource source,
        AlDebugType type,
        uint id,
        AlDebugSeverity severity,
        ReadOnlySpan<byte> message
    )
    {
        fixed (byte* p = message)
        {
            // `fixed` pins an empty span as null, and openal-soft rejects a null message pointer
            // even at length 0 (al/debug.cpp) - substitute a real empty string.
            byte nul = 0;
            Al.PInvoke.DebugMessageInsertEXT(
                (int)source,
                (int)type,
                id,
                (int)severity,
                message.Length,
                p != null ? p : &nul
            );
        }
    }

    /// <summary>
    ///     Enables or disables delivery of debug messages matching a filter
    ///     (<c>alDebugMessageControlEXT</c>). <c>DontCare</c> enum values act as wildcards. A
    ///     non-empty <paramref name="ids"/> filters on specific message IDs instead, and then
    ///     REQUIRES a concrete <paramref name="source"/> and <paramref name="type"/> and a
    ///     <c>DontCare</c> <paramref name="severity"/> - openal-soft rejects any other combination
    ///     with <see cref="AlError.InvalidOperation"/>.
    /// </summary>
    public static void MessageControl(
        AlDebugSource source,
        AlDebugType type,
        AlDebugSeverity severity,
        ReadOnlySpan<uint> ids,
        bool enable
    )
    {
        fixed (uint* p = ids)
            Al.PInvoke.DebugMessageControlEXT((int)source, (int)type, (int)severity, ids.Length, p, enable);
    }

    /// <summary>
    ///     Pushes a named debug group (<c>alPushDebugGroupEXT</c>); pair with <see cref="PopGroup"/>,
    ///     or use <see cref="GroupScope(AlDebugSource, uint, string)"/> for a
    ///     <see langword="using"/>-able pairing.
    /// </summary>
    public static void PushGroup(AlDebugSource source, uint id, string message)
    {
        ArgumentNullException.ThrowIfNull(message);
        using var utf8 = new Utf8Buffer(message, stackalloc byte[Utf8Buffer.StackBufferSize]);
        fixed (byte* p = utf8.Span)
            Al.PInvoke.PushDebugGroupEXT((int)source, id, utf8.Length, p);
    }

    /// <inheritdoc cref="PushGroup(AlDebugSource, uint, string)"/>
    /// <remarks>UTF-8 byte variant: no transcode, no allocation.</remarks>
    public static void PushGroup(AlDebugSource source, uint id, ReadOnlySpan<byte> message)
    {
        fixed (byte* p = message)
        {
            // Same null-substitution rationale as the span MessageInsert above.
            byte nul = 0;
            Al.PInvoke.PushDebugGroupEXT((int)source, id, message.Length, p != null ? p : &nul);
        }
    }

    /// <summary>Pops the innermost debug group (<c>alPopDebugGroupEXT</c>).</summary>
    public static void PopGroup() => Al.PInvoke.PopDebugGroupEXT();

    /// <summary>
    ///     Pushes a named debug group and returns a scope whose <see cref="DebugGroupScope.Dispose"/>
    ///     pops it (pairs <see cref="PushGroup(AlDebugSource, uint, string)"/> with
    ///     <see cref="PopGroup"/> for a <see langword="using"/> block).
    /// </summary>
    public static DebugGroupScope GroupScope(AlDebugSource source, uint id, string message)
    {
        PushGroup(source, id, message);
        return new DebugGroupScope();
    }

    /// <inheritdoc cref="GroupScope(AlDebugSource, uint, string)"/>
    public static DebugGroupScope GroupScope(AlDebugSource source, uint id, ReadOnlySpan<byte> message)
    {
        PushGroup(source, id, message);
        return new DebugGroupScope();
    }

    /// <summary>
    ///     Pulls up to <c>messages.Length</c> entries (at most 64 per call - drain in a loop) from
    ///     the debug message log (<c>alGetDebugMessageLogEXT</c>), removing them, and returns how
    ///     many were pulled. Never allocates: message text lands in a shared internal arena that
    ///     each <see cref="AlDebugMessageInfo.Message"/> views, so drained entries stay valid only
    ///     until the next <see cref="GetMessageLog"/> or <c>GetObjectLabel</c> call, and pulls must
    ///     not run concurrently. With a callback registered (<see cref="SetCallback"/>) the log
    ///     stays empty and this returns 0.
    /// </summary>
    public static int GetMessageLog(Span<AlDebugMessageInfo> messages)
    {
        if (messages.IsEmpty)
            return 0;

        var arena = EnsureArena();
        var chunk = Math.Min(messages.Length, LogChunk);
        Span<int> sources = stackalloc int[chunk];
        Span<int> types = stackalloc int[chunk];
        Span<uint> ids = stackalloc uint[chunk];
        Span<int> severities = stackalloc int[chunk];
        Span<int> lengths = stackalloc int[chunk];

        uint count;
        fixed (int* sourcesPtr = sources)
        fixed (int* typesPtr = types)
        fixed (uint* idsPtr = ids)
        fixed (int* severitiesPtr = severities)
        fixed (int* lengthsPtr = lengths)
        fixed (byte* textPtr = arena)
        {
            count = Al.PInvoke.GetDebugMessageLogEXT(
                (uint)chunk,
                arena.Length,
                sourcesPtr,
                typesPtr,
                idsPtr,
                severitiesPtr,
                lengthsPtr,
                textPtr
            );
        }

        var offset = 0;
        for (var i = 0; i < count; i++)
        {
            // lengths[i] INCLUDES the trailing NUL terminator (openal-soft's al/debug.cpp writes
            // `msg.size() + 1` per entry) - the text itself is lengths[i] - 1 bytes.
            messages[i] = new AlDebugMessageInfo(
                (AlDebugSource)sources[i],
                (AlDebugType)types[i],
                ids[i],
                (AlDebugSeverity)severities[i],
                offset,
                lengths[i] - 1
            );
            offset += lengths[i];
        }
        return (int)count;
    }

    /// <summary>
    ///     Labels an AL object for diagnostics (<c>alObjectLabelEXT</c>); a <see langword="null"/>
    ///     label clears it.
    /// </summary>
    public static void ObjectLabel(AlObjectLabelIdentifier identifier, uint name, string? label)
    {
        // A null label pins as a null pointer with length 0, which the native call treats as "clear".
        using var utf8 = new Utf8Buffer(label, stackalloc byte[Utf8Buffer.StackBufferSize]);
        fixed (byte* p = utf8.Span)
            Al.PInvoke.ObjectLabelEXT((int)identifier, name, utf8.Length, p);
    }

    /// <inheritdoc cref="ObjectLabel(AlObjectLabelIdentifier, uint, string)"/>
    /// <remarks>UTF-8 byte variant: no transcode, no allocation; an empty label clears it.</remarks>
    public static void ObjectLabel(AlObjectLabelIdentifier identifier, uint name, ReadOnlySpan<byte> label)
    {
        fixed (byte* p = label)
        {
            // An empty span pins as null with length 0, which the native call accepts as "clear" -
            // no substitution needed here, unlike the message calls.
            Al.PInvoke.ObjectLabelEXT((int)identifier, name, label.Length, p);
        }
    }

    /// <summary>
    ///     Gets an AL object's diagnostic label (<c>alGetObjectLabelEXT</c>) as UTF-8 bytes, or an
    ///     empty span if none was set. Never allocates: the returned span views the shared internal
    ///     arena and stays valid only until the next <see cref="GetMessageLog"/> or
    ///     <see cref="GetObjectLabel(AlObjectLabelIdentifier, uint)"/> call.
    /// </summary>
    public static ReadOnlySpan<byte> GetObjectLabel(AlObjectLabelIdentifier identifier, uint name)
    {
        var arena = EnsureArena();
        // Explicitly zeroed: with no context current the native call is a no-op that never
        // writes length, and an empty arena pins as a NULL pointer, which openal-soft answers by
        // reporting the full label length without copying anything - so also clamp the slice, so
        // a native/managed size disagreement can never throw out of a getter.
        var length = 0;
        fixed (byte* p = arena)
            Al.PInvoke.GetObjectLabelEXT((int)identifier, name, arena.Length, &length, p);
        return arena.AsSpan(0, Math.Clamp(length, 0, arena.Length));
    }
}
