using System.Reflection;

namespace Brutal.SdlApi;

public static unsafe partial class Sdl
{
    public static unsafe partial class PInvoke
    {
        // The native SDL3 handle, resolved lazily by the DllImportResolver below and cached so the
        // library is loaded at most once regardless of how many entry points are resolved.
        private static nint _nativeHandle;

        // Serializes resolution. The .NET resolver can be invoked concurrently from multiple threads
        // resolving different entry points; without this two threads could both observe a zero handle
        // and race to load, leaking one of the two library handles.
        private static readonly Lock ResolveLock = new();

        // The resolver is registered in this static constructor rather than at Initialize time so
        // that it is in place before ANY P/Invoke is resolved. Accessing a member of the nested
        // PInvoke type triggers this constructor (and only this one — the enclosing Sdl type's
        // static constructor is not triggered by nested-member access), which guarantees the
        // resolver is installed even when a consumer calls Sdl.PInvoke.* (or an ergonomic wrapper)
        // before Sdl.Init.Initialize. CLR type-initialization semantics make this run exactly once
        // and are thread-safe, so no explicit locking or "registered?" flag is needed — and
        // SetDllImportResolver (which throws if called twice for one assembly) is therefore called
        // exactly once. This mirrors the Brutal.Slang pattern.
        static PInvoke()
        {
            NativeLibrary.SetDllImportResolver(typeof(Sdl).Assembly, Resolve);
        }

        // Normalizes the "SDL3" import name to the platform-specific shared library filename
        // (SDL3.dll on Windows, libSDL3.dylib on macOS, libSDL3.so.0 on Linux). SDL's Linux build
        // installs a versioned soname (libSDL3.so.0) that the default probing conventions do not
        // try, so the candidate list is spelled out explicitly, most-specific first, with the
        // default convention name as a fallback.
        private static nint Resolve(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            // Only ever asked to resolve SDL3; anything else is left to the default resolver.
            if (libraryName != Dll)
                return IntPtr.Zero;

            lock (ResolveLock)
            {
                if (_nativeHandle != IntPtr.Zero)
                    return _nativeHandle;

                var search = searchPath ?? DllImportSearchPath.AssemblyDirectory;

                // Try each candidate with Load (not TryLoad): TryLoad reports only pass/fail and
                // discards the OS diagnostic, so a candidate that *exists but fails to load* (a missing
                // transitive dependency, an ABI mismatch — the classic Linux "libSDL3.so.0 is present
                // but unusable" case) would vanish. Load throws with the real dlerror/LoadLibrary text,
                // which we aggregate so the final exception names every attempt and why it failed. (F7)
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
                    "Could not load the SDL3 native library. Attempts (most specific first): "
                        + string.Join("; ", failures)
                        + "."
                );
            }
        }

        private static string[] Candidates()
        {
            if (OperatingSystem.IsWindows())
                return ["SDL3.dll", "SDL3"];
            if (OperatingSystem.IsMacOS())
                return ["libSDL3.dylib", "SDL3"];
            // Linux and other Unix-likes.
            return ["libSDL3.so.0", "libSDL3.so", "SDL3"];
        }

        // SDL_LogMessage is variadic in C (const char *fmt, ...) and so was skipped by the raw
        // generator (LibraryImport cannot express varargs). Binding it here as a fixed-arity
        // format-only import is portable across the Windows x64 / Linux x64 / macOS arm64 targets:
        // no variadic argument is ever passed, so there is no register-vs-stack ABI mismatch (the
        // classic AAPCS64 variadic trap). The managed logging wrappers in Sdl.Log.cs pre-escape the
        // caller's message and pass it as the entire format string, so the "..." is always empty.
        [LibraryImport(
            Dll,
            EntryPoint = "SDL_LogMessage",
            StringMarshalling = StringMarshalling.Custom,
            StringMarshallingCustomType = typeof(CustomStringMarshaller)
        )]
        private static partial void _LogMessage(int category, SdlLogPriority priority, string fmt);

        /// <summary>
        /// Emits a single already-formatted message through <c>SDL_LogMessage</c>. The
        /// <paramref name="preformatted"/> text is passed as the format string itself (with no
        /// variadic arguments); callers are responsible for escaping any <c>%</c> characters.
        /// </summary>
        /// <param name="category">The SDL log category (an <c>SDL_LOG_CATEGORY_*</c> value).</param>
        /// <param name="priority">The message priority.</param>
        /// <param name="preformatted">The final message text, used verbatim as the format string.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void LogMessage(int category, SdlLogPriority priority, string preformatted)
        {
            ArgumentNullException.ThrowIfNull(preformatted);
            Sdl.TraceLog.Trace();
            _LogMessage(category, priority, preformatted);
        }
    }
}
