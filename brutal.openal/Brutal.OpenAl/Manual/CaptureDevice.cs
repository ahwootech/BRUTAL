// Sealed IDisposable wrapper over the raw AlcCaptureDevice handle: Alc.CaptureOpenDevice
// constructs it, Dispose closes it. No finalizer and no Destroy() alias - disposal is explicit.
// Capture and playback devices are both a native ALCdevice*, but are closed with different native
// calls; the distinct handle type makes passing one to the wrong close op a compile error.
//
// Public half of the type; the format/buffer-size helpers live in CaptureDevice.Internal.cs.

namespace Brutal.OpenAlApi;

/// <summary>
///     An OpenAL capture device, opened by
///     <see cref="Alc.CaptureOpenDevice(string?, uint, AlFormat, int)"/>.
/// </summary>
/// <remarks>
///     Owns the underlying native capture device: call <see cref="Dispose"/> when done. Converts
///     implicitly to the raw, non-owning <see cref="AlcCaptureDevice"/> handle.
/// </remarks>
public sealed partial class CaptureDevice : IDisposable, INullable
{
    /// <summary>The raw capture-device handle.</summary>
    public AlcCaptureDevice Handle { get; private set; }

    // The frame size (bytes per sample-frame) for the format this device was opened with. Always
    // known: Alc.CaptureOpenDevice derives it for the four standard AlFormat values and rejects any
    // other format unless the caller states the size explicitly. Samples() below relies on it.
    private readonly int _bytesPerFrame;

    // Lifetime-constant query result, cached on first access instead of re-querying native (and
    // re-allocating) every time. A capture device has no reopen path, so this is never invalidated.
    private string? _specifier;

    internal CaptureDevice(AlcCaptureDevice handle, int bytesPerFrame)
    {
        Handle = handle;
        _bytesPerFrame = bytesPerFrame;
    }

    // Disposal guard shared by every member that touches native state or returns cached native
    // answers - a disposed capture device must never answer plausibly. Handle, IsNull() and the
    // implicit conversion stay unguarded (the raw escape hatch), matching Device.
    private AlcCaptureDevice CheckedHandle
    {
        get
        {
            ObjectDisposedException.ThrowIf(IsNull(), this);
            return Handle;
        }
    }

    /// <summary>Returns <see langword="true"/> if this capture device has already been disposed.</summary>
    public bool IsNull() => Handle.IsNull();

    /// <summary>The capture device's name (<c>ALC_CAPTURE_DEVICE_SPECIFIER</c>). Cached.</summary>
    public string? Specifier
    {
        get
        {
            // Guard before the cache, not just before the query - as in Device's cached getters.
            ObjectDisposedException.ThrowIf(IsNull(), this);
            return _specifier ??= Alc.GetString(Handle, AlcGetString.CaptureDeviceSpecifier);
        }
    }

    /// <summary>
    ///     The number of captured sample-frames available to read (<c>ALC_CAPTURE_SAMPLES</c>).
    ///     Poll this between <see cref="Start"/> and <see cref="Samples"/> to size the read.
    /// </summary>
    public int AvailableSamples => Alc.GetInteger(CheckedHandle, AlcInteger.CaptureSamples);

    /// <summary>
    ///     Reads and clears this capture device's ALC error (<c>alcGetError</c>), without throwing
    ///     on a latched error.
    /// </summary>
    public AlcError GetError()
    {
        ObjectDisposedException.ThrowIf(IsNull(), this);
        return Alc.GetError(Handle);
    }

    /// <summary>
    ///     Reads and clears this capture device's ALC error, throwing <see cref="AlcException"/> if
    ///     one was set. Never called automatically by wrapper methods, as with
    ///     <see cref="Al.ThrowIfError"/>.
    /// </summary>
    public void ThrowIfError()
    {
        ObjectDisposedException.ThrowIf(IsNull(), this);
        Alc.ThrowIfError(Handle);
    }

    /// <inheritdoc cref="Alc.PInvoke.CaptureStart"/>
    public void Start() => Alc.PInvoke.CaptureStart(CheckedHandle);

    /// <inheritdoc cref="Alc.PInvoke.CaptureStop"/>
    public void Stop() => Alc.PInvoke.CaptureStop(CheckedHandle);

    /// <summary>
    ///     Reads captured samples out of the device's internal buffer (<c>alcCaptureSamples</c>).
    ///     Native code writes <paramref name="samples"/> frames regardless of the buffer's length,
    ///     so the length is validated against the frame size the device was opened with (throws
    ///     <see cref="ArgumentException"/> on a too-small buffer).
    /// </summary>
    public void Samples(Span<byte> buffer, int samples)
    {
        ObjectDisposedException.ThrowIf(IsNull(), this);
        CheckBufferLength(_bytesPerFrame, samples, buffer.Length);

        unsafe
        {
            fixed (byte* p = buffer)
                Alc.PInvoke.CaptureSamples(Handle, p, samples);
        }
    }

    /// <summary>
    ///     Closes the capture device (<c>alcCaptureCloseDevice</c>), throwing
    ///     <see cref="AlcException"/> if the native close reports failure - the explicit-lifetime
    ///     counterpart of <see cref="Dispose"/>, which swallows it. The wrapper is disposed either
    ///     way, so a later <see cref="Dispose"/> (a <see langword="using"/> safety net) is a no-op.
    /// </summary>
    public void Close()
    {
        ObjectDisposedException.ThrowIf(IsNull(), this);
        if (!CloseCore())
            throw new AlcException(Alc.GetError(), "alcCaptureCloseDevice failed.");
    }

    /// <summary>
    ///     Closes the capture device (<c>alcCaptureCloseDevice</c>). Never throws: a failed close
    ///     leaves its reason on the global ALC error latch - call <see cref="Close"/> instead when
    ///     failure should surface. Idempotent but not safe to call concurrently; no finalizer - an
    ///     undisposed capture device leaks.
    /// </summary>
    public void Dispose()
    {
        if (IsNull())
            return;

        // Same rationale as Device.Dispose: never replace a using-body exception; the reason
        // stays on the global latch.
        CloseCore();
    }

    private bool CloseCore()
    {
        // The wrapper dies either way - see Device.CloseCore.
        var closed = Alc.PInvoke.CaptureCloseDevice(Handle);
        Handle = AlcCaptureDevice.Null;
        return closed;
    }

    /// <summary>Implicitly converts to the raw <see cref="AlcCaptureDevice"/> handle.</summary>
    public static implicit operator AlcCaptureDevice(CaptureDevice capture) => capture.Handle;
}
