// The Alc class root: the `Dll` const shared by the generated Alc.PInvoke imports and the hand-written
// partials (Alc.Wrapper.cs, Errors.cs).

namespace Brutal.OpenAlApi;

/// <summary>
///     Wrappers over the OpenAL context layer (<c>alc.h</c>): device and context lifetime, and audio
///     capture.
/// </summary>
/// <remarks>
///     <para>
///         Lifetime is owned by <see cref="Device"/>, <see cref="Context"/>, and
///         <see cref="CaptureDevice"/>, returned by <see cref="OpenDevice"/>,
///         <see cref="Device.CreateContext"/>, and
///         <see cref="CaptureOpenDevice(string?, uint, AlFormat, int)"/>. The raw
///         <see cref="AlcDevice"/>, <see cref="AlcContext"/>, and <see cref="AlcCaptureDevice"/> structs
///         are non-owning handles used at the P/Invoke boundary; each wrapper class converts implicitly
///         to its raw handle.
///     </para>
///     <para>
///         Tear down in order: detach the current context (<see cref="Context.MakeCurrent(Context?)"/>
///         with <see langword="null"/>), dispose every context, then dispose the device. Closing or
///         destroying the same native object twice - including through copies of a raw handle - is
///         undefined behavior.
///     </para>
/// </remarks>
public static partial class Alc
{
    // Logical native library name; mapped to the platform file by NativeLoader's DllImportResolver.
    internal const string Dll = "openal";
}
