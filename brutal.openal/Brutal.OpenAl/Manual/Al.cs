// The Al class root: the `Dll` const shared by the generated Al.PInvoke imports and the hand-written
// partials (Al.Wrapper.cs, Al.Listener.cs, Errors.cs).

namespace Brutal.OpenAlApi;

/// <summary>
///     Wrappers over core OpenAL (<c>al.h</c>): buffers, sources, the listener, and playback state.
/// </summary>
/// <remarks>
///     <para>
///         Most AL calls do not return errors. OpenAL records the first error per context/thread and
///         holds it until it is read with <c>alGetError</c>, which also clears it.
///         <see cref="ThrowIfError"/> reads the error and throws <see cref="AlException"/> if one was
///         set; <see cref="GetError"/> reads it without throwing. Methods here never check for errors
///         automatically - call <see cref="ThrowIfError"/> yourself, for example after initialization,
///         after loading a resource, and per-frame in debug builds.
///     </para>
///     <para>
///         Because only the first error is recorded, an unchecked error is attributed to whichever call
///         checks next - check promptly if you need to know which call failed. AL calls act on the
///         context current on the calling thread; with no current context, <see cref="ThrowIfError"/>
///         throws (openal-soft reports <c>AL_INVALID_OPERATION</c>).
///     </para>
/// </remarks>
public static partial class Al
{
    // Logical native library name; mapped to the platform file by NativeLoader's DllImportResolver.
    internal const string Dll = "openal";
}
