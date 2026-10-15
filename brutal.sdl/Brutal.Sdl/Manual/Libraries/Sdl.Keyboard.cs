using System.Text;

namespace Brutal.SdlApi;

public static unsafe partial class Sdl
{
    public static unsafe partial class Keyboard
    {
        // SDL_SetScancodeName stores the pointer we pass verbatim — `SDL_scancode_names[scancode] =
        // name;` in SDL_keymap.c, with no copy — and reads it back later from SDL_GetScancodeName.
        // The default string marshaller would free the temporary UTF-8 buffer as soon as the call
        // returned, leaving SDL holding a dangling pointer. So this is hand-written (the generator
        // auto-skips it because the LibraryImport below declares its EntryPoint): we allocate a
        // NUL-terminated UTF-8 copy in unmanaged memory that we own, hand SDL that, and keep it alive
        // in a per-scancode registry, freeing the previous copy when a scancode is renamed. (F1)
        private static readonly Dictionary<SdlScancode, nint> ScancodeNames = new();
        private static readonly Lock ScancodeNameLock = new();

        [LibraryImport(Dll, EntryPoint = "SDL_SetScancodeName")]
        private static partial byte _SetScancodeName(SdlScancode scancode, byte* name);

        /// <summary>
        /// Sets a human-readable name for a scancode (<c>SDL_SetScancodeName</c>).
        /// </summary>
        /// <remarks>
        /// SDL retains the name pointer rather than copying it, so this binding keeps an unmanaged
        /// copy alive for the lifetime of the registration. Setting a new name for the same scancode
        /// releases the previous copy.
        /// </remarks>
        /// <param name="scancode">The scancode to name.</param>
        /// <param name="name">The name to assign.</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is <c>null</c>.</exception>
        /// <exception cref="SdlException">SDL rejected the scancode or name.</exception>
        public static void SetScancodeName(SdlScancode scancode, string name)
        {
            ArgumentNullException.ThrowIfNull(name);

            // Copy `name` into unmanaged memory we own: a NUL-terminated UTF-8 buffer.
            var byteCount = Encoding.UTF8.GetByteCount(name);
            var buffer = (byte*)NativeMemory.Alloc((nuint)(byteCount + 1));
            var span = new Span<byte>(buffer, byteCount + 1);
            Encoding.UTF8.GetBytes(name, span);
            span[byteCount] = 0;

            lock (ScancodeNameLock)
            {
                if (_SetScancodeName(scancode, buffer) == 0)
                {
                    // SDL did not take the pointer; free our copy and surface the error.
                    NativeMemory.Free(buffer);
                    throw SdlException.FromError("SDL_SetScancodeName failed");
                }

                // SDL now holds `buffer`. Any previous copy WE allocated for this scancode is no
                // longer referenced by SDL, so free it. (Default SDL names are static literals and
                // are never in this registry, so they are never freed.)
                if (ScancodeNames.TryGetValue(scancode, out var previous))
                    NativeMemory.Free((void*)previous);
                ScancodeNames[scancode] = (nint)buffer;
            }
        }
    }
}
