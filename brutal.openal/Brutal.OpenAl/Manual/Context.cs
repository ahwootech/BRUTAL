// Sealed IDisposable wrapper over the raw AlcContext handle: Device.CreateContext constructs it,
// Dispose destroys it. No finalizer and no Destroy() alias - disposal is explicit.
//
// Currency (which context is current) is native process state; this type never mirrors it. The
// LiveContexts ledger (Context.Internal.cs) only maps native addresses back to the wrappers this
// layer created, so Current can return the owning object. The ledger is weak (it must never keep
// an abandoned wrapper alive); do not extend the pattern to per-object types like AlSource.

namespace Brutal.OpenAlApi;

/// <summary>
///     An OpenAL context, created on a <see cref="OpenAlApi.Device"/> by <see cref="OpenAlApi.Device.CreateContext"/>.
/// </summary>
/// <remarks>
///     Owns the underlying native context: call <see cref="Dispose"/> exactly once. Disposing it
///     while current detaches it globally and on the calling thread. A thread-local context made
///     current on another thread must be detached on that thread first.
/// </remarks>
public sealed partial class Context : IDisposable, INullable
{
    /// <summary>
    ///     Options for <see cref="OpenAlApi.Device.CreateContext"/>.
    /// </summary>
    public ref struct CreateInfo()
    {
        /// <summary>
        ///     Attribute/value pairs; no trailing zero (appended internally). Extension keys not on
        ///     <see cref="AlcContextAttribute"/> are passed by casting the constant.
        /// </summary>
        public ReadOnlySpan<(AlcContextAttribute Attribute, int Value)> Attributes = [];
    }

    /// <summary>The device this context was created on.</summary>
    /// <remarks>
    ///     Not necessarily the owning wrapper. For a context created on a
    ///     <see cref="LoopbackDevice"/> this is an internal plumbing <see cref="OpenAlApi.Device"/>
    ///     around the same handle: its <see cref="OpenAlApi.Device.Dispose"/> is a no-op and its
    ///     <see cref="OpenAlApi.Device.Close"/> throws - dispose the owning
    ///     <see cref="LoopbackDevice"/> instead.
    /// </remarks>
    public Device Device { get; }

    /// <summary>The raw context handle.</summary>
    public AlcContext Handle { get; private set; }

    /// <summary>
    ///     The context current in the process, or <see langword="null"/> if none is current.
    /// </summary>
    /// <remarks>
    ///     Reads the native state (<c>alcGetCurrentContext</c>) on every access, then resolves the
    ///     handle to the wrapper that created it. <see langword="null"/> therefore does not prove
    ///     nothing is current natively: a context made current via raw interop, or whose wrapper was
    ///     garbage-collected undisposed, also reads as <see langword="null"/> - code mixing in raw
    ///     interop should query <see cref="Alc.PInvoke"/> directly.
    /// </remarks>
    public static Context? Current
    {
        get
        {
            var current = Alc.PInvoke.GetCurrentContext();
            if (current.IsNull())
                return null;
            return LiveContexts.TryGetValue(current.Pointer, out var weak) && weak.TryGetTarget(out var context)
                ? context
                : null;
        }
    }

    /// <summary>
    ///     Whether this context is current in the process (compares against
    ///     <c>alcGetCurrentContext</c>). A disposed context is never current.
    /// </summary>
    public bool IsCurrent => !IsNull() && Handle.Pointer == Alc.PInvoke.GetCurrentContext().Pointer;

    internal unsafe Context(Device device, CreateInfo info)
    {
        Device = device;

        // An empty attribute list flattens to a null pointer - see Alc.FlattenAttributes.
        using var owner = Alc.FlattenAttributes(info.Attributes);
        fixed (int* p = owner.Span)
            Handle = Alc.PInvoke.CreateContext(device, p);

        // Failure detail is recorded on the input device, not globally.
        if (Handle.IsNull())
            throw new AlcException(Alc.GetError(device), "alcCreateContext failed.");

        // Prune ledger entries whose wrapper was collected without Dispose (a leaked context).
        // Removing by (key, value) pair never evicts an entry another thread re-registered under a
        // recycled address between the read and the remove.
        foreach (var entry in LiveContexts)
        {
            if (!entry.Value.TryGetTarget(out _))
                LiveContexts.TryRemove(entry);
        }
        LiveContexts[Handle.Pointer] = new WeakReference<Context>(this);
    }

    /// <summary>Returns <see langword="true"/> if this context has already been disposed.</summary>
    public bool IsNull() => Handle.IsNull();

    /// <summary>
    ///     Makes a context current in the process, or detaches the current context when
    ///     <paramref name="context"/> is <see langword="null"/> (<c>alcMakeContextCurrent</c>; a null
    ///     context is the native detach idiom). Throws <see cref="AlcException"/> on a disposed
    ///     context rather than silently detaching.
    /// </summary>
    public static void MakeCurrent(Context? context)
    {
        if (context is null)
        {
            if (!Alc.PInvoke.MakeContextCurrent(AlcContext.Null))
                throw new AlcException(Alc.GetError(), "alcMakeContextCurrent(NULL) failed.");
            return;
        }

        // A disposed context's null handle is not passed through: alcMakeContextCurrent(NULL)
        // SUCCEEDS by detaching, so a disposed Context would silently detach instead of failing.
        if (context.IsNull())
            throw new AlcException(AlcError.InvalidContext, "The context has been disposed.");

        // Failure detail is recorded on the context's device.
        if (!Alc.PInvoke.MakeContextCurrent(context.Handle))
            throw new AlcException(Alc.GetError(context.Device), "alcMakeContextCurrent failed.");
    }

    /// <summary>
    ///     Tries to make a context current (or detach with <see langword="null"/>), without throwing.
    /// </summary>
    public static bool TryMakeCurrent(Context? context)
    {
        if (context is null)
            return Alc.PInvoke.MakeContextCurrent(AlcContext.Null);
        return !context.IsNull() && Alc.PInvoke.MakeContextCurrent(context.Handle);
    }

    /// <summary>Makes this context current in the process (<c>alcMakeContextCurrent</c>).</summary>
    public void MakeCurrent() => MakeCurrent(this);

    /// <summary>Tries to make this context current, without throwing (<c>alcMakeContextCurrent</c>).</summary>
    public bool TryMakeCurrent() => TryMakeCurrent(this);

    /// <summary>
    ///     The context current on the calling thread, or <see langword="null"/> if no thread-local
    ///     context is set. Provided by <c>ALC_EXT_thread_local_context</c>.
    /// </summary>
    /// <remarks>
    ///     Reads <c>alcGetThreadContext</c> and resolves the wrapper as <see cref="Current"/> does;
    ///     the same caveats apply. With no thread-local override, the thread follows the
    ///     process-wide context (<see cref="Current"/>) - which this still reports as
    ///     <see langword="null"/>.
    /// </remarks>
    public static Context? CurrentThread
    {
        get
        {
            var current = Alc.PInvoke.GetThreadContext();
            if (current.IsNull())
                return null;
            return LiveContexts.TryGetValue(current.Pointer, out var weak) && weak.TryGetTarget(out var context)
                ? context
                : null;
        }
    }

    /// <summary>
    ///     Makes a context current on the calling thread only, overriding process-wide currency for
    ///     this thread, or clears the override when <paramref name="context"/> is
    ///     <see langword="null"/> (<c>alcSetThreadContext</c>). Throws <see cref="AlcException"/> on
    ///     a disposed context rather than silently detaching. Provided by
    ///     <c>ALC_EXT_thread_local_context</c>.
    /// </summary>
    public static void MakeThreadCurrent(Context? context)
    {
        if (context is null)
        {
            if (!Alc.PInvoke.SetThreadContext(AlcContext.Null))
                throw new AlcException(Alc.GetError(), "alcSetThreadContext(NULL) failed.");
            return;
        }

        // As in MakeCurrent: a disposed context's null handle is not passed through, since
        // alcSetThreadContext(NULL) SUCCEEDS by detaching rather than failing.
        if (context.IsNull())
            throw new AlcException(AlcError.InvalidContext, "The context has been disposed.");

        // Failure detail is recorded on the context's device.
        if (!Alc.PInvoke.SetThreadContext(context.Handle))
            throw new AlcException(Alc.GetError(context.Device), "alcSetThreadContext failed.");
    }

    /// <summary>
    ///     Tries to make a context current on the calling thread (or clear the override with
    ///     <see langword="null"/>), without throwing. Provided by <c>ALC_EXT_thread_local_context</c>.
    /// </summary>
    public static bool TryMakeThreadCurrent(Context? context)
    {
        if (context is null)
            return Alc.PInvoke.SetThreadContext(AlcContext.Null);
        return !context.IsNull() && Alc.PInvoke.SetThreadContext(context.Handle);
    }

    /// <summary>
    ///     Makes this context current on the calling thread (<c>alcSetThreadContext</c>). Provided
    ///     by <c>ALC_EXT_thread_local_context</c>.
    /// </summary>
    public void MakeThreadCurrent() => MakeThreadCurrent(this);

    /// <summary>
    ///     Tries to make this context current on the calling thread, without throwing
    ///     (<c>alcSetThreadContext</c>). Provided by <c>ALC_EXT_thread_local_context</c>.
    /// </summary>
    public bool TryMakeThreadCurrent() => TryMakeThreadCurrent(this);

    // Disposal guard for the handle-bearing instance members (a disposed context must not pass
    // its nulled handle to native, where it reads as "no context"). MakeCurrent keeps its own
    // documented AlcException contract; Handle, IsNull() and the implicit conversion stay
    // unguarded as the raw escape hatch, matching Device.
    private AlcContext CheckedHandle
    {
        get
        {
            ObjectDisposedException.ThrowIf(IsNull(), this);
            return Handle;
        }
    }

    /// <inheritdoc cref="Alc.PInvoke.ProcessContext"/>
    public void Process() => Alc.PInvoke.ProcessContext(CheckedHandle);

    /// <inheritdoc cref="Alc.PInvoke.SuspendContext"/>
    public void Suspend() => Alc.PInvoke.SuspendContext(CheckedHandle);

    /// <summary>
    ///     Destroys the context (<c>alcDestroyContext</c>). If it is current, the bundled
    ///     openal-soft detaches it globally and on the calling thread. A context made current on
    ///     another thread via <see cref="MakeThreadCurrent(Context?)"/> must be detached there first.
    ///     Idempotent but not safe to call concurrently; no finalizer - an undisposed context leaks.
    /// </summary>
    public void Dispose()
    {
        if (IsNull())
            return;

        // While this context is alive the native object still occupies its address, so the entry
        // under this key is necessarily our own.
        LiveContexts.TryRemove(Handle.Pointer, out _);

        // Release any callback handlers rooted under this address (Al events, AlDebug) so a
        // recycled context address can never resolve to a stale handler.
        Al.EvictContextRoots(Handle.Pointer.Value);

        // alcDestroyContext returns nothing; an invalid context sets the global error - check
        // Alc.GetError() explicitly if you need to know.
        Alc.PInvoke.DestroyContext(Handle);
        Handle = AlcContext.Null;
    }

    /// <summary>Implicitly converts to the raw <see cref="AlcContext"/> handle.</summary>
    public static implicit operator AlcContext(Context context) => context.Handle;
}
