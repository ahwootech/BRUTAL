// Monitor reference
// https://www.glfw.org/docs/latest/group__monitor.html

// Hand-written members of the Monitor library: the GlfwMonitor handle struct scaffolding + its
// marshaller, the monitor-configuration callback delegate/event, GetMonitors (span - deferred),
// and the instance members not yet covered by a generator transform: Position/PhysicalSize/
// ContentScale (out-params -> vector), GetMonitorWorkArea (4 outs -> 2 vectors), Size (computed),
// VideoModes (span), VideoMode (pointer deref), and GammaRamp (GlfwGammaRampView get/set). The
// basic members - PrimaryMonitor, Name, UserPointer, SetGamma - are generated into
// Generated/Libraries/Glfw.Monitor.gen.cs and merge into these same partial declarations.

using System.Runtime.InteropServices.Marshalling;

namespace Brutal.GlfwApi;

/// <summary>The function pointer type for monitor configuration callbacks.</summary>
/// <param name="monitor">The monitor that was connected or disconnected.</param>
/// <param name="eventType">
///     One of <see cref="GlfwMonitorEvent.Connected" /> or
///     <see cref="GlfwMonitorEvent.Disconnected" />.
/// </param>
/// <seealso cref="Glfw.MonitorCallback" />
/// <seealso href="https://www.glfw.org/docs/latest/monitor_guide.html#monitor_event">Monitor configuration changes</seealso>
public delegate void GlfwMonitorCallback(GlfwMonitor monitor, GlfwMonitorEvent eventType);

public static unsafe partial class Glfw
{
    /// <summary>Sets the monitor configuration function.</summary>
    /// <remarks>
    ///     This function sets the monitor configuration callback, or removes the currently set callback. This is called when a
    ///     monitor is connected to or disconnected from the system.
    /// </remarks>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/monitor_guide.html#monitor_event">Monitor configuration changes</seealso>
    public static event GlfwMonitorCallback? MonitorCallback;
}

/// <summary>
///     Wrapper around a <see cref="GlfwMonitorHandle" />*
/// </summary>
[NativeMarshalling(typeof(GlfwMonitorMarshaller))]
public readonly unsafe partial struct GlfwMonitor : INullable
{
    public static readonly GlfwMonitor Null = new(null);

    internal GlfwMonitor(GlfwMonitorHandle* inPointer)
    {
        Pointer = inPointer;
    }

    internal GlfwMonitorHandle* Pointer { get; }

    /// <summary>
    ///     Gets the native Glfw handle for this monitor
    /// </summary>
    public nint NativeHandle => (nint)Pointer;

    public bool IsNull()
    {
        return Pointer == null;
    }

    /// <summary>Retrieves the work area of the monitor.</summary>
    /// <remarks>
    ///     This function returns the position, in screen coordinates, of the upper-left corner of the work area of the
    ///     monitor along with the work area size in screen coordinates. The work area is defined as the area
    ///     of the monitor not occluded by the operating system task bar where present. If no task bar exists then the
    ///     work area is the monitor resolution in screen coordinates.
    ///     <para />
    ///     If an error occurs, all values are set to zero.
    /// </remarks>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/monitor_guide.html#monitor_workarea">Work area</seealso>
    public void GetMonitorWorkArea(out int2 pos, out int2 size)
    {
        Glfw.PInvoke.GetMonitorWorkArea(this, out var x, out var y, out var w, out var h);
        pos = new int2(x, y);
        size = new int2(w, h);
    }

    public int2 Size
    {
        get
        {
            var videoMode = VideoMode;
            return new int2(videoMode.Width, videoMode.Height);
        }
    }

    /// <summary>Returns the current mode of the monitor.</summary>
    /// <remarks>
    ///     This function returns the current video mode of the monitor. If you have created a full screen window for
    ///     that monitor, the return value will depend on whether that window is iconified.
    /// </remarks>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso cref="VideoModes">VideoModes</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/monitor_guide.html#monitor_modes">Video modes</seealso>
    public GlfwVidMode VideoMode
    {
        get
        {
            var videoMode = Glfw.PInvoke.GetVideoMode(this);
            return videoMode != null ? *videoMode : default;
        }
    }

    /// <summary>Gets/Sets the current gamma ramp for the monitor.</summary>
    /// <remarks>
    ///     The getter returns the current gamma ramp of the monitor, or an empty view if an error occurred. The view
    ///     is valid until the monitor is disconnected, the gamma ramp is read again for that monitor or the library
    ///     is terminated.
    ///     <para />
    ///     The setter sets the current gamma ramp for the monitor. The original gamma ramp for that monitor is
    ///     saved by GLFW the first time the ramp is set and is restored by glfwTerminate. The specified gamma ramp
    ///     is copied before the setter returns.
    ///     <para />
    ///     The software controlled gamma ramp is applied in addition to the hardware gamma correction, which today is usually
    ///     an approximation of sRGB gamma. This means that setting a perfectly linear ramp, or gamma 1.0, will produce the
    ///     default (usually sRGB-like) behavior.
    ///     <para />
    ///     For gamma correct rendering with OpenGL or OpenGL ES, see the GLFW_SRGB_CAPABLE hint.
    /// </remarks>
    /// <exception cref="ArgumentException">The setter was given an empty ramp.</exception>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/monitor_guide.html#monitor_gamma">Gamma ramp</seealso>
    public GlfwGammaRampView GammaRamp
    {
        get
        {
            var ramp = Glfw.PInvoke.GetGammaRamp(this);
            if (ramp == null)
                return default;

            var size = (int)ramp->Size;
            return new GlfwGammaRampView(
                new ReadOnlySpan<ushort>(ramp->Red, size),
                new ReadOnlySpan<ushort>(ramp->Green, size),
                new ReadOnlySpan<ushort>(ramp->Blue, size)
            );
        }
        set
        {
            if (value.IsEmpty)
                throw new ArgumentException("Cannot set an empty gamma ramp.", nameof(value));

            fixed (ushort* red = value.Red)
            fixed (ushort* green = value.Green)
            fixed (ushort* blue = value.Blue)
            {
                var ramp = new GlfwGammaRamp
                {
                    Red = red,
                    Green = green,
                    Blue = blue,
                    Size = (uint)value.Size,
                };
                Glfw.PInvoke.SetGammaRamp(this, &ramp);
            }
        }
    }
}

/// <summary>Describes the gamma ramp for a monitor.</summary>
/// <remarks>
///     Views returned by <see cref="GlfwMonitor.GammaRamp" /> borrow memory owned by GLFW; see that
///     property for the lifetime rules.
/// </remarks>
/// <seealso cref="GlfwMonitor.GammaRamp" />
/// <seealso href="https://www.glfw.org/docs/latest/monitor_guide.html#monitor_gamma">Gamma ramp</seealso>
public readonly ref struct GlfwGammaRampView
{
    /// <summary>Creates a gamma ramp view over three equal-length channel buffers.</summary>
    /// <param name="red">The response of the red channel.</param>
    /// <param name="green">The response of the green channel.</param>
    /// <param name="blue">The response of the blue channel.</param>
    /// <exception cref="ArgumentException">The channels are not all the same length.</exception>
    public GlfwGammaRampView(ReadOnlySpan<ushort> red, ReadOnlySpan<ushort> green, ReadOnlySpan<ushort> blue)
    {
        if (red.Length != green.Length || red.Length != blue.Length)
            throw new ArgumentException("Gamma ramp channels must all be the same length.");

        Red = red;
        Green = green;
        Blue = blue;
    }

    /// <summary>The response of the red channel.</summary>
    public ReadOnlySpan<ushort> Red { get; }

    /// <summary>The response of the green channel.</summary>
    public ReadOnlySpan<ushort> Green { get; }

    /// <summary>The response of the blue channel.</summary>
    public ReadOnlySpan<ushort> Blue { get; }

    /// <summary>The number of elements in each channel.</summary>
    public int Size => Red.Length;

    /// <summary>Whether the view holds no data.</summary>
    public bool IsEmpty => Red.IsEmpty;
}

[CustomMarshaller(
    managedType: typeof(GlfwMonitor),
    marshalMode: MarshalMode.Default,
    marshallerType: typeof(GlfwMonitorMarshaller)
)]
internal static unsafe class GlfwMonitorMarshaller
{
    internal static GlfwMonitorHandle* ConvertToUnmanaged(GlfwMonitor managed) => managed.Pointer;

    internal static GlfwMonitor ConvertToManaged(GlfwMonitorHandle* unmanaged) => new(unmanaged);
}
