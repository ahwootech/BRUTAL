// Handle-less ALC operations: opening devices (playback and capture) and the null-device string
// queries. Opens check the returned handle and throw via the global error latch. All other ALC
// surface lives on the owning wrapper classes (Device/Context/CaptureDevice).
//
// Public half of the partial class; the shared query/marshalling helpers live in
// Alc.Wrapper.Internal.cs.

namespace Brutal.OpenAlApi;

public static unsafe partial class Alc
{
    // --- Device lifetime -------------------------------------------------------------------------------

    /// <summary>
    ///     Opens a playback device (<c>alcOpenDevice</c>); a <see langword="null"/> name means the
    ///     default device.
    /// </summary>
    public static Device OpenDevice(string? name = null)
    {
        // A null name pins as a null native pointer: the default-device case.
        using var utf8 = new Utf8Buffer(name, stackalloc byte[Utf8Buffer.StackBufferSize]);
        AlcDevice device;
        fixed (byte* p = utf8.Span)
            device = PInvoke.OpenDevice(p);

        // No trustworthy open device yet, so a null return is diagnosed via the global error.
        if (device.IsNull())
            throw new AlcException(GetError(), "alcOpenDevice failed.");
        return new Device(device);
    }

    // --- Capture ---------------------------------------------------------------------------------------

    /// <summary>
    ///     Opens a capture device (<c>alcCaptureOpenDevice</c>); a <see langword="null"/> name means
    ///     the default capture device. <paramref name="format"/> must be one of the four standard
    ///     <see cref="AlFormat"/> values; for an extension format, use the overload taking
    ///     <c>bytesPerFrame</c>. The buffer size is the internal ring-buffer size, in samples.
    /// </summary>
    public static CaptureDevice CaptureOpenDevice(string? name, uint frequency, AlFormat format, int bufferSize)
    {
        // Without a known frame size, CaptureDevice.Samples cannot bound its destination buffer
        // (alcCaptureSamples writes however many frames it is asked for). Extension formats go
        // through the overload below, which takes the frame size explicitly.
        if (CaptureDevice.FrameSize(format) is not { } bytesPerFrame)
        {
            throw new ArgumentOutOfRangeException(
                nameof(format),
                format,
                "Not one of the four standard AlFormat values, so its frame size is unknown. Use the "
                    + "CaptureOpenDevice overload taking bytesPerFrame for an extension format."
            );
        }

        return CaptureOpenDevice(name, frequency, format, bufferSize, bytesPerFrame);
    }

    /// <summary>
    ///     Opens a capture device using a format this binding has no fixed frame size for - an
    ///     extension format cast into <see cref="AlFormat"/>. <paramref name="bytesPerFrame"/> is
    ///     the size of one sample-frame in <paramref name="format"/>, in bytes:
    ///     <see cref="CaptureDevice.Samples"/> validates its destination buffer against it, so an
    ///     incorrect value reintroduces the out-of-bounds native write the check exists to prevent.
    /// </summary>
    public static CaptureDevice CaptureOpenDevice(
        string? name,
        uint frequency,
        AlFormat format,
        int bufferSize,
        int bytesPerFrame
    )
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(bytesPerFrame);

        // A null name pins as a null native pointer: the default capture device case.
        using var utf8 = new Utf8Buffer(name, stackalloc byte[Utf8Buffer.StackBufferSize]);
        AlcCaptureDevice handle;
        fixed (byte* p = utf8.Span)
            handle = PInvoke.CaptureOpenDevice(p, frequency, (int)format, bufferSize);

        if (handle.IsNull())
            throw new AlcException(GetError(), "alcCaptureOpenDevice failed.");

        return new CaptureDevice(handle, bytesPerFrame);
    }

    // --- Strings (null-device enumeration and defaults) ---------------------------------------------------

    /// <summary>Enumerates the available playback devices (<c>ALC_DEVICE_SPECIFIER</c>).</summary>
    public static string[] GetDeviceSpecifiers() => EnumerateDevices(AlcGetString.DeviceSpecifier);

    /// <summary>Enumerates all playback devices (<c>ALC_ALL_DEVICES_SPECIFIER</c>).</summary>
    public static string[] GetAllDeviceSpecifiers() => EnumerateDevices(AlcGetString.AllDevicesSpecifier);

    /// <summary>Enumerates the available capture devices (<c>ALC_CAPTURE_DEVICE_SPECIFIER</c>).</summary>
    public static string[] GetCaptureDeviceSpecifiers() => EnumerateDevices(AlcGetString.CaptureDeviceSpecifier);

    /// <summary>Gets the default playback device name (<c>ALC_DEFAULT_DEVICE_SPECIFIER</c>).</summary>
    public static string? GetDefaultDeviceSpecifier() => GetNullDeviceString(AlcGetString.DefaultDeviceSpecifier);

    /// <summary>
    ///     Gets the default playback device name from the full device list
    ///     (<c>ALC_DEFAULT_ALL_DEVICES_SPECIFIER</c>).
    /// </summary>
    public static string? GetDefaultAllDevicesSpecifier() =>
        GetNullDeviceString(AlcGetString.DefaultAllDevicesSpecifier);

    /// <summary>Gets the default capture device name (<c>ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER</c>).</summary>
    public static string? GetCaptureDefaultDeviceSpecifier() =>
        GetNullDeviceString(AlcGetString.CaptureDefaultDeviceSpecifier);
}
