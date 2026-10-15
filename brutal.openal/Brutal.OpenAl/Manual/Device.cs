// Sealed IDisposable wrapper over the raw AlcDevice handle: Alc.OpenDevice constructs it, Dispose
// closes it. No finalizer and no Destroy() alias - disposal is explicit. AlcDevice stays the raw,
// non-owning handle used at the [LibraryImport] boundary.

using System.Collections.ObjectModel;
using CommunityToolkit.HighPerformance.Buffers;

namespace Brutal.OpenAlApi;

/// <summary>A device's clock time paired with its output latency. Provided by <c>ALC_SOFT_device_clock</c>.</summary>
/// <param name="ClockTime">The device clock, in nanoseconds.</param>
/// <param name="Latency">The device's output latency, in nanoseconds.</param>
public readonly record struct AlcClockLatency(long ClockTime, long Latency);

/// <summary>
///     An OpenAL playback device, opened by <see cref="Alc.OpenDevice"/>.
/// </summary>
/// <remarks>
///     Owns the underlying native device: call <see cref="Dispose"/> after disposing every
///     <see cref="Context"/> created on it (see <see cref="Alc"/> for the full teardown order).
///     Converts implicitly to the raw, non-owning <see cref="AlcDevice"/> handle.
/// </remarks>
public sealed class Device : IDisposable, INullable
{
    private readonly bool _ownedByLoopback;

    /// <summary>The raw device handle.</summary>
    public AlcDevice Handle { get; private set; }

    internal Device(AlcDevice handle, bool ownedByLoopback = false)
    {
        Handle = handle;
        _ownedByLoopback = ownedByLoopback;
    }

    // The disposal guard shared by every member that touches native state or returns cached
    // native answers: a disposed device must never answer plausibly (a nulled handle reads as
    // Connected == false, MajorVersion == 1, ...). Handle itself, IsNull() and the implicit
    // conversion stay unguarded - they are the raw escape hatch, and a null handle there is an
    // honest answer. Efx shares the guard through ThrowIfDisposed and reads Handle itself.
    private AlcDevice CheckedHandle
    {
        get
        {
            ThrowIfDisposed();
            return Handle;
        }
    }

    internal void ThrowIfDisposed() => ObjectDisposedException.ThrowIf(IsNull(), this);

    private Efx? _efx;

    // Lifetime-constant query results, cached on first access. Reopen can change the device's
    // identity, so it drops the specifier caches; Reset and Reopen can both renegotiate the HRTF
    // set, so both drop that cache. Versions and the extension list are fixed by the loaded
    // implementation and never invalidated.
    private string? _specifier;
    private string? _allDevicesSpecifier;
    private ReadOnlyCollection<string>? _extensions;
    private ReadOnlyCollection<string>? _hrtfSpecifiers;
    private int? _majorVersion;
    private int? _minorVersion;

    /// <summary>
    ///     The EFX surface for this device. The pinned openal-soft always implements
    ///     <c>ALC_EXT_EFX</c>, so this needs no presence gate.
    /// </summary>
    public Efx Efx
    {
        get
        {
            ThrowIfDisposed();
            return _efx ??= new Efx(this);
        }
    }

    /// <summary>Returns <see langword="true"/> if this device has not been opened, or has already been disposed.</summary>
    public bool IsNull() => Handle.IsNull();

    /// <summary>
    ///     The device's name (<c>ALC_DEVICE_SPECIFIER</c>). Cached; <see cref="Reopen"/> drops the cache.
    /// </summary>
    public string? Specifier
    {
        get
        {
            // Guard before the cache, not just before the query: a cached answer on a disposed
            // device is still an answer a disposed device must not give. Same in every cached
            // getter below.
            ObjectDisposedException.ThrowIf(IsNull(), this);
            return _specifier ??= Alc.GetString(Handle, AlcGetString.DeviceSpecifier);
        }
    }

    /// <summary>
    ///     The device's full name from the extended enumeration (<c>ALC_ALL_DEVICES_SPECIFIER</c>).
    ///     Cached; <see cref="Reopen"/> drops the cache.
    /// </summary>
    public string? AllDevicesSpecifier
    {
        get
        {
            ObjectDisposedException.ThrowIf(IsNull(), this);
            return _allDevicesSpecifier ??= Alc.GetString(Handle, AlcGetString.AllDevicesSpecifier);
        }
    }

    /// <summary>
    ///     The device's ALC extension list (<c>ALC_EXTENSIONS</c>) as a read-only view over the
    ///     cached list. Queried once per device; no allocation per access.
    /// </summary>
    public IReadOnlyList<string> Extensions
    {
        get
        {
            ObjectDisposedException.ThrowIf(IsNull(), this);
            if (_extensions is null)
            {
                var s = Alc.GetString(Handle, AlcGetString.Extensions);
                _extensions = Array.AsReadOnly(
                    string.IsNullOrEmpty(s) ? [] : s.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                );
            }
            return _extensions;
        }
    }

    /// <summary>The major version of the device's ALC implementation (<c>ALC_MAJOR_VERSION</c>).</summary>
    public int MajorVersion
    {
        get
        {
            ObjectDisposedException.ThrowIf(IsNull(), this);
            return _majorVersion ??= Alc.GetInteger(Handle, AlcInteger.MajorVersion);
        }
    }

    /// <summary>The minor version of the device's ALC implementation (<c>ALC_MINOR_VERSION</c>).</summary>
    public int MinorVersion
    {
        get
        {
            ObjectDisposedException.ThrowIf(IsNull(), this);
            return _minorVersion ??= Alc.GetInteger(Handle, AlcInteger.MinorVersion);
        }
    }

    /// <summary>
    ///     The device's context attribute list (<c>ALC_ALL_ATTRIBUTES</c>) as attribute/value pairs.
    ///     Attribute keys not surfaced on <see cref="AlcContextAttribute"/> (extension tokens) appear
    ///     as their raw constant values cast to the enum.
    /// </summary>
    public unsafe (AlcContextAttribute Attribute, int Value)[] Attributes
    {
        get
        {
            // Two-call native protocol, encapsulated: ALC_ATTRIBUTES_SIZE reports the list length
            // (including its zero terminator), ALC_ALL_ATTRIBUTES fills the buffer. The terminator
            // is trimmed and the flat ints paired up.
            var size = Alc.GetInteger(CheckedHandle, AlcInteger.AttributesSize);
            if (size <= 0)
                return [];

            using var owner = SpanOwner<int>.Allocate(size);
            var flat = owner.Span;
            fixed (int* p = flat)
                Alc.PInvoke.GetIntegerv(Handle, (int)AlcInteger.AllAttributes, size, p);

            var count = flat[size - 1] == 0 ? size - 1 : size;
            var pairs = new (AlcContextAttribute, int)[count / 2];
            for (var i = 0; i < pairs.Length; i++)
                pairs[i] = ((AlcContextAttribute)flat[i * 2], flat[i * 2 + 1]);
            return pairs;
        }
    }

    /// <summary>Queries whether an ALC extension is present for this device (<c>alcIsExtensionPresent</c>).</summary>
    public bool IsExtensionPresent(string name) => Alc.IsExtensionPresent(CheckedHandle, name);

    /// <summary>
    ///     Resolves an extension entry point scoped to this device (<c>alcGetProcAddress</c>), or
    ///     throws <see cref="AlExtensionException"/> if it is unavailable.
    /// </summary>
    public unsafe void* GetProcAddress(string name) => Alc.GetProcAddress(CheckedHandle, name);

    /// <summary>
    ///     Reads and clears this device's ALC error (<c>alcGetError</c>), without throwing on a
    ///     latched error.
    /// </summary>
    public AlcError GetError()
    {
        ObjectDisposedException.ThrowIf(IsNull(), this);
        return Alc.GetError(Handle);
    }

    /// <summary>
    ///     Reads and clears this device's ALC error, throwing <see cref="AlcException"/> if one was
    ///     set. Never called automatically by wrapper methods, as with <see cref="Al.ThrowIfError"/>.
    /// </summary>
    public void ThrowIfError()
    {
        ObjectDisposedException.ThrowIf(IsNull(), this);
        Alc.ThrowIfError(Handle);
    }

    /// <summary>Creates a context on this device (<c>alcCreateContext</c>).</summary>
    public Context CreateContext(Context.CreateInfo info = default)
    {
        ObjectDisposedException.ThrowIf(IsNull(), this);
        return new(this, info);
    }

    /// <summary>Pauses device processing (<c>alcDevicePauseSOFT</c>). Provided by <c>ALC_SOFT_pause_device</c>.</summary>
    public void Pause() => Alc.PInvoke.DevicePauseSOFT(CheckedHandle);

    /// <summary>
    ///     Resumes device processing after <see cref="Pause"/> (<c>alcDeviceResumeSOFT</c>). Provided by
    ///     <c>ALC_SOFT_pause_device</c>.
    /// </summary>
    public void Resume() => Alc.PInvoke.DeviceResumeSOFT(CheckedHandle);

    /// <summary>
    ///     Whether the device is still connected (<c>ALC_CONNECTED</c>). Provided by
    ///     <c>ALC_EXT_disconnect</c>.
    /// </summary>
    public bool Connected => Alc.GetInteger(CheckedHandle, AlcInteger.Connected) != 0;

    /// <summary>
    ///     The device clock, in nanoseconds (<c>ALC_DEVICE_CLOCK_SOFT</c>). Provided by
    ///     <c>ALC_SOFT_device_clock</c>.
    /// </summary>
    public unsafe long ClockTime
    {
        get
        {
            long value = 0;
            Alc.PInvoke.GetInteger64vSOFT(CheckedHandle, Alc.Constants.ALC_DEVICE_CLOCK_SOFT, 1, &value);
            return value;
        }
    }

    /// <summary>
    ///     The device's output latency, in nanoseconds (<c>ALC_DEVICE_LATENCY_SOFT</c>). Provided by
    ///     <c>ALC_SOFT_device_clock</c>.
    /// </summary>
    public unsafe long Latency
    {
        get
        {
            long value = 0;
            Alc.PInvoke.GetInteger64vSOFT(CheckedHandle, Alc.Constants.ALC_DEVICE_LATENCY_SOFT, 1, &value);
            return value;
        }
    }

    /// <summary>
    ///     The device clock and output latency, read atomically (<c>ALC_DEVICE_CLOCK_LATENCY_SOFT</c>).
    ///     Provided by <c>ALC_SOFT_device_clock</c>.
    /// </summary>
    public unsafe AlcClockLatency ClockLatency
    {
        get
        {
            var pair = stackalloc long[2];
            Alc.PInvoke.GetInteger64vSOFT(CheckedHandle, Alc.Constants.ALC_DEVICE_CLOCK_LATENCY_SOFT, 2, pair);
            return new AlcClockLatency(pair[0], pair[1]);
        }
    }

    /// <summary>
    ///     Why HRTF is or is not in use on the device (<c>ALC_HRTF_STATUS_SOFT</c>). Provided by
    ///     <c>ALC_SOFT_HRTF</c>.
    /// </summary>
    public AlcHrtfStatus HrtfStatus => (AlcHrtfStatus)Alc.GetInteger(CheckedHandle, AlcInteger.HrtfStatus);

    /// <summary>
    ///     The available HRTF specifiers (<c>ALC_HRTF_SPECIFIER_SOFT</c>, indexed up to
    ///     <c>ALC_NUM_HRTF_SPECIFIERS_SOFT</c>) as a read-only view over the cached list. No
    ///     allocation per access. <see cref="Reset"/> and <see cref="Reopen"/> drop the cache, so
    ///     the result is a snapshot: a list held across either call keeps describing the device as
    ///     it was, and the next access re-queries. Provided by <c>ALC_SOFT_HRTF</c>.
    /// </summary>
    public IReadOnlyList<string> HrtfSpecifiers
    {
        get
        {
            ObjectDisposedException.ThrowIf(IsNull(), this);
            if (_hrtfSpecifiers is null)
            {
                var count = Alc.GetInteger(Handle, AlcInteger.NumHrtfSpecifiers);
                var names = new string[count];
                for (var i = 0; i < count; i++)
                {
                    unsafe
                    {
                        names[i] =
                            StringUtils.Utf8ToString(
                                Alc.PInvoke.GetStringiSOFT(Handle, Alc.Constants.ALC_HRTF_SPECIFIER_SOFT, i)
                            ) ?? string.Empty;
                    }
                }
                _hrtfSpecifiers = Array.AsReadOnly(names);
            }
            return _hrtfSpecifiers;
        }
    }

    /// <summary>
    ///     Resets the device with a new attribute list, without closing it (<c>alcResetDeviceSOFT</c>).
    ///     Provided by <c>ALC_SOFT_HRTF</c>.
    /// </summary>
    /// <param name="attributes">Attribute/value pairs; no trailing zero (appended internally).</param>
    public unsafe void Reset(ReadOnlySpan<(AlcContextAttribute Attribute, int Value)> attributes = default)
    {
        ObjectDisposedException.ThrowIf(IsNull(), this);
        using var owner = Alc.FlattenAttributes(attributes);
        fixed (int* p = owner.Span)
        {
            if (!Alc.PInvoke.ResetDeviceSOFT(Handle, p))
                throw new AlcException(Alc.GetError(Handle), "alcResetDeviceSOFT failed.");
        }

        // A reset renegotiates the attribute list: the HRTF set and the auxiliary-send count can
        // both change. The device's identity (specifiers) cannot.
        _hrtfSpecifiers = null;
        _efx?.InvalidateDeviceCaches();
    }

    /// <summary>
    ///     Reopens the device, optionally under a different name, with a new attribute list
    ///     (<c>alcReopenDeviceSOFT</c>). Provided by <c>ALC_SOFT_reopen_device</c>.
    /// </summary>
    /// <param name="deviceName">The device name, or <see langword="null"/> to keep the current device.</param>
    /// <param name="attributes">Attribute/value pairs; no trailing zero (appended internally).</param>
    public unsafe void Reopen(
        string? deviceName,
        ReadOnlySpan<(AlcContextAttribute Attribute, int Value)> attributes = default
    )
    {
        ObjectDisposedException.ThrowIf(IsNull(), this);
        using var owner = Alc.FlattenAttributes(attributes);
        using var utf8 = new Utf8Buffer(deviceName, stackalloc byte[Utf8Buffer.StackBufferSize]);
        fixed (int* attribs = owner.Span)
        fixed (byte* name = utf8.Span)
        {
            if (!Alc.PInvoke.ReopenDeviceSOFT(Handle, name, attribs))
                throw new AlcException(Alc.GetError(Handle), "alcReopenDeviceSOFT failed.");
        }

        // A reopen can change the underlying device (new specifiers) and renegotiates the
        // attribute list like Reset does. Versions and the extension list are properties of the
        // loaded implementation, not the device, and survive.
        _specifier = null;
        _allDevicesSpecifier = null;
        _hrtfSpecifiers = null;
        _efx?.InvalidateDeviceCaches();
    }

    /// <summary>
    ///     The device's channel output mode (<c>ALC_OUTPUT_MODE_SOFT</c>). Provided by
    ///     <c>ALC_SOFT_output_mode</c>.
    /// </summary>
    public AlcOutputMode OutputMode => (AlcOutputMode)Alc.GetInteger(CheckedHandle, AlcInteger.OutputMode);

    /// <summary>
    ///     Closes the device (<c>alcCloseDevice</c>), throwing <see cref="AlcException"/> if the
    ///     native close reports failure - the explicit-lifetime counterpart of
    ///     <see cref="Dispose"/>, which swallows it. Dispose every context created on this device
    ///     first; any still live are destroyed with the device and their wrappers invalidated. The
    ///     wrapper is disposed either way, so a later <see cref="Dispose"/> (a <see langword="using"/>
    ///     safety net) is a no-op.
    /// </summary>
    public void Close()
    {
        if (_ownedByLoopback)
            throw new InvalidOperationException("Close the owning LoopbackDevice instead.");
        ObjectDisposedException.ThrowIf(IsNull(), this);
        CloseUnchecked();
    }

    /// <summary>
    ///     Closes the device (<c>alcCloseDevice</c>). Dispose every context created on this device
    ///     first; any still live are destroyed with the device and their wrappers invalidated.
    ///     Never throws: a failed close leaves its reason on the global ALC error latch - call
    ///     <see cref="Close"/> instead when failure should surface. Idempotent but not safe to call
    ///     concurrently; no finalizer - an undisposed device leaks. On the plumbing
    ///     <see cref="Context.Device"/> of a <see cref="LoopbackDevice"/> context this is a no-op:
    ///     the loopback wrapper owns the handle.
    /// </summary>
    public void Dispose()
    {
        // Dispose must never throw (see below), so ownership misuse cannot surface here the way
        // Close() surfaces it. Nothing is owned, so there is nothing to do.
        if (_ownedByLoopback)
            return;
        DisposeUnchecked();
    }

    // Close() without the ownership and disposal guards. Also the entry point LoopbackDevice
    // uses on its plumbing Device, whose public Close() rejects direct use.
    internal void CloseUnchecked()
    {
        if (!CloseCore())
            throw new AlcException(Alc.GetError(), "alcCloseDevice failed (invalid or already-closed handle).");
    }

    // Dispose() without the ownership guard. Also the entry point LoopbackDevice uses on its
    // plumbing Device, whose public Dispose() is a no-op.
    internal void DisposeUnchecked()
    {
        if (IsNull())
            return;

        // Dispose must never throw: inside a `using` whose body already threw, an exception here
        // would REPLACE the original fault. A failed close leaves its reason on the global latch;
        // Close() is the path that surfaces it.
        CloseCore();
    }

    private bool CloseCore()
    {
        // Closing destroys any live contexts on this device without their Dispose running, so
        // their ledger entries are evicted first - a freed, recyclable address must never stay
        // mapped.
        var orphans = Context.EvictDeviceEntries(this);

        // Closing also destroys the device's buffers without any per-buffer delete running, so
        // the buffer-callback handler roots recorded under this device are swept with it.
        AlBuffer.EvictDeviceRoots(Handle.Pointer.Value);

        // A successful close frees the device, so it must not be queried afterwards; on failure
        // the global error holds the reason.
        var closed = Alc.PInvoke.CloseDevice(Handle);

        // Only once the close succeeded are the orphaned contexts definitely gone and their
        // wrappers safe to invalidate; on failure they are still alive natively (see
        // Context.MarkOrphaned).
        if (closed)
            Context.MarkOrphaned(orphans);

        // The wrapper dies either way: a failed close means an invalid or already-closed handle
        // (openal-soft destroys live contexts rather than refusing), and a deterministic dead
        // wrapper beats a half-alive one no caller will retry.
        Handle = AlcDevice.Null;
        return closed;
    }

    /// <summary>Implicitly converts to the raw <see cref="AlcDevice"/> handle.</summary>
    public static implicit operator AlcDevice(Device device) => device.Handle;
}
