// Sealed IDisposable wrapper over a loopback device handle (ALC_SOFT_loopback). The loopback
// handle IS an ALCdevice*, so this class wraps an internal Device around the same handle and
// delegates CreateContext/Dispose to it. Device's playback-only members (Pause, ClockTime, HRTF,
// ...) are deliberately not re-exposed: they mean nothing on a device with no real output.

namespace Brutal.OpenAlApi;

/// <summary>
///     A loopback device, opened by <see cref="Open"/>. Provided by <c>ALC_SOFT_loopback</c>.
/// </summary>
/// <remarks>
///     A loopback device has no real audio hardware behind it and no background mixing thread: it
///     renders into an app-owned buffer only when one of the <see cref="Render(Span{byte}, int)"/>
///     overloads is called. Create a context on it with the render format specified via
///     <see cref="Context.CreateInfo.Attributes"/> (<c>Frequency</c>, <c>FormatChannels</c>,
///     <c>FormatType</c>), make it current, then drive playback and rendering explicitly. Owns the
///     underlying native device: call <see cref="Dispose"/> after disposing every context created
///     on it. Converts implicitly to the raw, non-owning <see cref="AlcDevice"/> handle.
///     <para>
///         The created context's <see cref="Context.Device"/> is an internal plumbing
///         <see cref="Device"/> wrapper around the same handle: its playback-only members are
///         meaningless here and surface native errors. Its <see cref="Device.Close"/> rejects
///         direct use and its <see cref="Device.Dispose"/> is a no-op; close or dispose the owning
///         <see cref="LoopbackDevice"/> instead.
///     </para>
/// </remarks>
public sealed class LoopbackDevice : IDisposable, INullable
{
    private readonly Device _device;

    // Bytes per sample frame of the device's render format, captured on each CreateContext; 0
    // until the first context establishes a format. Render's span bound - see CheckBufferLength.
    private int _bytesPerFrame;

    private LoopbackDevice(AlcDevice handle) => _device = new Device(handle, ownedByLoopback: true);

    /// <summary>
    ///     Opens a loopback device (<c>alcLoopbackOpenDeviceSOFT</c>); a <see langword="null"/> name
    ///     means the default device.
    /// </summary>
    public static unsafe LoopbackDevice Open(string? deviceName = null)
    {
        // No trustworthy open device yet, so a null return is diagnosed via the global error - same
        // protocol as Alc.OpenDevice. A null name pins as a null native pointer (the default).
        using var utf8 = new Utf8Buffer(deviceName, stackalloc byte[Utf8Buffer.StackBufferSize]);
        AlcDevice handle;
        fixed (byte* p = utf8.Span)
            handle = Alc.PInvoke.LoopbackOpenDeviceSOFT(p);
        if (handle.IsNull())
            throw new AlcException(Alc.GetError(), "alcLoopbackOpenDeviceSOFT failed.");
        return new LoopbackDevice(handle);
    }

    /// <summary>The raw device handle.</summary>
    public AlcDevice Handle => _device.Handle;

    /// <summary>Returns <see langword="true"/> if this device has not been opened, or has already been disposed.</summary>
    public bool IsNull() => _device.IsNull();

    // Disposal guard reporting the LoopbackDevice itself, not the internal plumbing Device, as
    // the disposed object. Handle, IsNull() and the implicit conversion stay unguarded as the raw
    // escape hatch, matching Device.
    private AlcDevice CheckedHandle
    {
        get
        {
            ObjectDisposedException.ThrowIf(IsNull(), this);
            return Handle;
        }
    }

    /// <summary>Queries whether a render format is supported (<c>alcIsRenderFormatSupportedSOFT</c>).</summary>
    public bool IsRenderFormatSupported(int frequency, AlcChannelLayout channels, AlcSampleType sampleType) =>
        Alc.PInvoke.IsRenderFormatSupportedSOFT(CheckedHandle, frequency, (int)channels, (int)sampleType);

    /// <summary>
    ///     Creates a context on this device (<c>alcCreateContext</c>). Specify the render format via
    ///     <see cref="Context.CreateInfo.Attributes"/> - see the class remarks.
    /// </summary>
    public Context CreateContext(Context.CreateInfo info = default)
    {
        ObjectDisposedException.ThrowIf(IsNull(), this);
        var context = _device.CreateContext(info);
        _bytesPerFrame = QueryBytesPerFrame();
        return context;
    }

    // The render format lives on the DEVICE (context creation configures it), so query it back
    // rather than parsing info.Attributes: the query reports what the native side actually chose,
    // and repeat context creations that change the format update it. Unknown future enum values
    // yield 0, which Render refuses rather than guessing a frame size.
    private unsafe int QueryBytesPerFrame()
    {
        var channelCount = (AlcChannelLayout)Query(Alc.Constants.ALC_FORMAT_CHANNELS_SOFT) switch
        {
            AlcChannelLayout.Mono => 1,
            AlcChannelLayout.Stereo => 2,
            AlcChannelLayout.Quad => 4,
            AlcChannelLayout.Surround51 => 6,
            AlcChannelLayout.Surround61 => 7,
            AlcChannelLayout.Surround71 => 8,
            // B-Format with ambisonic order N carries (N + 1)^2 channels.
            AlcChannelLayout.Bformat3d => AmbisonicChannels(Query(Alc.Constants.ALC_AMBISONIC_ORDER_SOFT)),
            _ => 0,
        };
        var sampleSize = (AlcSampleType)Query(Alc.Constants.ALC_FORMAT_TYPE_SOFT) switch
        {
            AlcSampleType.Byte or AlcSampleType.UnsignedByte => 1,
            AlcSampleType.Short or AlcSampleType.UnsignedShort => 2,
            AlcSampleType.Int or AlcSampleType.UnsignedInt or AlcSampleType.Float => 4,
            _ => 0,
        };
        return channelCount * sampleSize;

        static int AmbisonicChannels(int order) => (order + 1) * (order + 1);

        int Query(int param)
        {
            var value = 0;
            Alc.PInvoke.GetIntegerv(Handle, param, 1, &value);
            return value;
        }
    }

    /// <summary>
    ///     Renders <paramref name="sampleFrames"/> frames into <paramref name="buffer"/>
    ///     (<c>alcRenderSamplesSOFT</c>). <paramref name="sampleFrames"/> counts sample FRAMES, not
    ///     samples or bytes: the buffer must hold at least <c>sampleFrames * channels *
    ///     sizeof(sample)</c> bytes, per the render format the last context created on this device
    ///     established, and is validated against it - a too-small buffer throws
    ///     <see cref="ArgumentException"/> rather than letting the native render write out of
    ///     bounds.
    /// </summary>
    /// <remarks>
    ///     Drains <see cref="Al.ThrowCallbackExceptions"/> after rendering, so a throwing
    ///     <see cref="AlBufferCallback"/> surfaces here. The drain is process-wide: exceptions
    ///     queued by any other callback handler since the last drain also rethrow here.
    /// </remarks>
    public unsafe void Render(Span<byte> buffer, int sampleFrames)
    {
        // The disposal guard outranks the no-render-format guard below: disposed wins.
        ObjectDisposedException.ThrowIf(IsNull(), this);

        // alcRenderSamplesSOFT writes frames * bytes-per-frame with no size parameter at all
        // (upstream is deliberately real-time lean and cannot validate), so an unbounded call here
        // is a silent managed-heap corruption - same hazard CaptureDevice.Samples guards against.
        if (_bytesPerFrame == 0)
        {
            throw new InvalidOperationException(
                "No render format is established. Create a context on this device (with Frequency/"
                    + "FormatChannels/FormatType attributes) before rendering."
            );
        }
        CheckBufferLength(_bytesPerFrame, sampleFrames, buffer.Length);

        fixed (byte* p = buffer)
            Alc.PInvoke.RenderSamplesSOFT(Handle, p, sampleFrames);

        Al.ThrowCallbackExceptions();
    }

    // Mirrors CaptureDevice.CheckBufferLength. Widens to long before multiplying: sampleFrames *
    // bytesPerFrame can overflow 32 bits, which would wrap and silently defeat the guard.
    private static void CheckBufferLength(int bytesPerFrame, int sampleFrames, int bufferLength)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(sampleFrames);

        if (bufferLength < (long)sampleFrames * bytesPerFrame)
        {
            throw new ArgumentException(
                $"buffer must hold at least {sampleFrames} frames * {bytesPerFrame} bytes = {(long)sampleFrames * bytesPerFrame} bytes, but was {bufferLength}.",
                "buffer"
            );
        }
    }

    /// <inheritdoc cref="Render(Span{byte}, int)"/>
    public void Render(Span<short> buffer, int sampleFrames) => Render(MemoryMarshal.AsBytes(buffer), sampleFrames);

    /// <inheritdoc cref="Render(Span{byte}, int)"/>
    public void Render(Span<float> buffer, int sampleFrames) => Render(MemoryMarshal.AsBytes(buffer), sampleFrames);

    /// <inheritdoc cref="Device.Close"/>
    public void Close()
    {
        // Guarded here so the exception reports the LoopbackDevice, not the plumbing Device.
        ObjectDisposedException.ThrowIf(IsNull(), this);
        _device.CloseUnchecked();
    }

    /// <inheritdoc cref="Device.Dispose"/>
    public void Dispose() => _device.DisposeUnchecked();

    /// <summary>Implicitly converts to the raw <see cref="AlcDevice"/> handle.</summary>
    public static implicit operator AlcDevice(LoopbackDevice device) => device.Handle;
}
