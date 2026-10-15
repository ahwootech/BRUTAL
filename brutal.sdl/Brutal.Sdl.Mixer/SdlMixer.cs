using System.Reflection;
using Brutal.Logging;

namespace Brutal.SdlApi.Mixer;

/// <summary>
/// Provides access to the SDL_mixer library.
/// </summary>
public static unsafe partial class SdlMixer
{
    /// <summary>
    /// The name the generated P/Invoke surface imports against. The <see cref="PInvoke"/> static
    /// constructor registers a <see cref="NativeLibrary.SetDllImportResolver"/> that normalizes
    /// this name to the platform-specific SDL3_mixer shared library.
    /// </summary>
    internal const string Dll = "SDL3_mixer";

    /// <summary>
    /// The logging category for the per-call trace logs the generated P/Invoke surface emits. An
    /// internal implementation detail mirroring core's <c>Sdl.TraceLog</c>; the generated
    /// <c>SdlMixer.PInvoke</c> wrappers call <c>SdlMixer.TraceLog.Trace()</c> on every invocation.
    /// </summary>
    internal static readonly LogCategory TraceLog = LogCategory.Make("SdlMixer");

    /// <summary>
    /// Captures exceptions thrown inside SDL_mixer callbacks (track-stopped, per-track/group/mixer mix
    /// hooks) so they can be rethrown safely from managed code instead of unwinding across the native
    /// boundary. Unlike core's aggregator — which fires on the single event-pump thread — SDL_mixer
    /// invokes these callbacks on its own audio device thread(s), so this aggregator is drained from
    /// every ergonomic method that touches a mixer/track/group (the generated
    /// <c>ExceptionAggregator.CheckExceptions()</c> prelude) and from the public
    /// <see cref="ThrowPendingCallbackExceptions"/> for long device-driven playback that makes no other
    /// API calls. The aggregator itself is thread-safe (see <see cref="ExceptionAggregator"/>).
    /// </summary>
    internal static readonly ExceptionAggregator ExceptionAggregator = new();

    /// <summary>
    /// Rethrows any exception captured inside an SDL_mixer callback since the last drain, then clears
    /// the pending set. Callbacks fire on SDL_mixer's audio thread(s), where a managed exception cannot
    /// legally unwind; each is caught, logged, and parked on the shared aggregator instead. Every
    /// ergonomic method that touches a mixer, track or group drains automatically, but during long
    /// device-driven playback that makes no such calls, invoke this periodically (e.g. once per frame)
    /// to surface a failing callback promptly.
    /// </summary>
    /// <exception cref="SdlCallbackException">Exactly one callback exception was pending.</exception>
    /// <exception cref="AggregateException">More than one callback exception was pending, or some were dropped.</exception>
    public static void ThrowPendingCallbackExceptions() => ExceptionAggregator.CheckExceptions();

    /// <summary>
    /// Hosts the raw generated P/Invoke surface (filled in by a later task) and, for now, the
    /// native library resolver that makes loading <c>SDL3_mixer</c> work.
    /// </summary>
    public static unsafe partial class PInvoke
    {
        // The native SDL3_mixer handle, resolved lazily by the DllImportResolver below and cached
        // so the library is loaded at most once regardless of how many entry points are resolved.
        private static nint _nativeHandle;

        // Serializes resolution — see Brutal.Sdl's Sdl.PInvoke for the full rationale (two threads
        // resolving different entry points concurrently must not race to load two handles).
        private static readonly Lock ResolveLock = new();

        // The resolver is registered in this static constructor rather than at first use so it is
        // in place before ANY P/Invoke against this assembly is resolved. Accessing a member of the
        // nested PInvoke type triggers this constructor (mirrors Brutal.Sdl's Sdl.PInvoke pattern).
        static PInvoke()
        {
            // GUARANTEE: SDL3 must actually be loaded into the process before SDL3_mixer's own
            // resolve runs below — SDL3_mixer's dylib/so/dll has a dynamic-link dependency on
            // libSDL3 (@rpath/libSDL3.0.dylib on macOS, libSDL3.so.0 on Linux, SDL3.dll on
            // Windows) that a nupkg-deployed app's probe layout cannot always be relied on to
            // satisfy via rpath/loader-path alone (the CMake wrapper's INSTALL_RPATH is a second,
            // belt-and-braces line of defense, not the primary guarantee).
            //
            // Merely running Sdl's or Sdl.PInvoke's static constructor is NOT sufficient: those
            // constructors only *register* Brutal.Sdl's DllImportResolver
            // (NativeLibrary.SetDllImportResolver) — the resolver is not invoked, and libSDL3 is
            // not actually loaded, until the CLR resolves a real P/Invoke against it. So instead of
            // RunClassConstructor, we make one real, side-effect-free P/Invoke call into core:
            // Sdl.PInvoke.GetVersion() just reads SDL's compiled-in version number, requires no
            // SDL_Init and has no observable side effects, but its LibraryImport binding is exactly
            // what triggers Brutal.Sdl's resolver to actually NativeLibrary.Load libSDL3. By the
            // time this call returns, libSDL3 is resident in the process, so SDL3_mixer's own
            // dynamic-link dependency on it is satisfiable regardless of rpath/loader-path probing.
            _ = Sdl.PInvoke.GetVersion();

            NativeLibrary.SetDllImportResolver(typeof(SdlMixer).Assembly, Resolve);
        }

        // Normalizes the "SDL3_mixer" import name to the platform-specific shared library filename
        // (SDL3_mixer.dll on Windows, libSDL3_mixer.dylib on macOS, libSDL3_mixer.so.0 on Linux).
        // SDL_mixer's Linux build installs a versioned soname (libSDL3_mixer.so.0), same convention
        // as core's SDL3, so the candidate list is spelled out explicitly, most-specific first, with
        // the default probing convention name as a fallback.
        private static nint Resolve(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            // Only ever asked to resolve SDL3_mixer; anything else is left to the default resolver.
            if (libraryName != Dll)
                return IntPtr.Zero;

            lock (ResolveLock)
            {
                if (_nativeHandle != IntPtr.Zero)
                    return _nativeHandle;

                var search = searchPath ?? DllImportSearchPath.AssemblyDirectory;

                // Try each candidate with Load (not TryLoad): TryLoad reports only pass/fail and
                // discards the OS diagnostic, so a candidate that *exists but fails to load* (a
                // missing transitive dependency, an ABI mismatch) would vanish silently. Load throws
                // with the real dlerror/LoadLibrary text, which we aggregate so the final exception
                // names every attempt and why it failed.
                var failures = new List<string>();
                foreach (var candidate in Candidates())
                {
                    try
                    {
                        _nativeHandle = NativeLibrary.Load(candidate, assembly, search);
                        return _nativeHandle;
                    }
                    catch (Exception ex)
                    {
                        failures.Add($"'{candidate}': {ex.Message}");
                    }
                }

                throw new DllNotFoundException(
                    "Could not load the SDL3_mixer native library. Attempts (most specific first): "
                        + string.Join("; ", failures)
                        + "."
                );
            }
        }

        private static string[] Candidates()
        {
            if (OperatingSystem.IsWindows())
                return ["SDL3_mixer.dll", "SDL3_mixer"];
            if (OperatingSystem.IsMacOS())
                return ["libSDL3_mixer.dylib", "SDL3_mixer"];
            // Linux and other Unix-likes.
            return ["libSDL3_mixer.so.0", "libSDL3_mixer.so", "SDL3_mixer"];
        }
    }
}
