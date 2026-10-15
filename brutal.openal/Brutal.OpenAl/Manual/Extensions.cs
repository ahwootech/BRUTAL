// The extension-function loader. Core and EFX entry points bind statically via [LibraryImport]:
// the pinned openal-soft exports every EFX symbol, so Device.Efx needs no presence gate. The
// alext.h surface (ExtPointers, generated) instead dispatches through proc addresses cached from
// alcGetProcAddress, because openal-soft does not export those symbols reliably; ThrowMissing
// below is what a generated alext.h method throws when its cached pointer is null. GetProcAddress
// remains for extensions this package has not bound.

namespace Brutal.OpenAlApi
{
    /// <summary>Thrown when a requested OpenAL extension entry point cannot be resolved.</summary>
    public sealed class AlExtensionException : Exception
    {
        /// <summary>Creates the exception for a named, unavailable entry point.</summary>
        public AlExtensionException(string fn)
            : base($"OpenAL extension entry point '{fn}' is not available.") { }

        /// <summary>Creates the exception for an entry point missing from the loaded binary.</summary>
        public AlExtensionException(string fn, string extension)
            : base($"OpenAL extension entry point '{fn}' ({extension}) is not available in the loaded library.") { }

        /// <summary>Throws for an alext.h entry point whose cached proc address resolved to null.</summary>
        [System.Diagnostics.CodeAnalysis.DoesNotReturn]
        internal static void ThrowMissing(string fn, string extension) => throw new AlExtensionException(fn, extension);
    }

    public static unsafe partial class Al
    {
        /// <summary>Queries whether an AL extension is present (<c>alIsExtensionPresent</c>).</summary>
        public static bool IsExtensionPresent(string name)
        {
            ArgumentNullException.ThrowIfNull(name);
            using var utf8 = new Utf8Buffer(name, stackalloc byte[Utf8Buffer.StackBufferSize]);
            fixed (byte* p = utf8.Span)
                return PInvoke.IsExtensionPresent(p);
        }

        /// <summary>
        ///     Resolves an AL-scoped extension entry point (<c>alGetProcAddress</c>), or throws
        ///     <see cref="AlExtensionException"/> if it is unavailable.
        /// </summary>
        public static void* GetProcAddress(string name)
        {
            ArgumentNullException.ThrowIfNull(name);
            using var utf8 = new Utf8Buffer(name, stackalloc byte[Utf8Buffer.StackBufferSize]);
            void* fn;
            fixed (byte* p = utf8.Span)
                fn = PInvoke.GetProcAddress(p);

            if (fn is null)
                throw new AlExtensionException(name);
            return fn;
        }
    }

    public static unsafe partial class Alc
    {
        /// <summary>
        ///     Queries whether an ALC extension is present globally, independent of any device
        ///     (<c>alcIsExtensionPresent(NULL, ...)</c>). For device-scoped extensions, use
        ///     <see cref="Device.IsExtensionPresent"/>.
        /// </summary>
        public static bool IsExtensionPresent(string name) => IsExtensionPresent(AlcDevice.Null, name);

        /// <summary>
        ///     Resolves a global (device-independent) ALC extension entry point
        ///     (<c>alcGetProcAddress(NULL, ...)</c>), or throws <see cref="AlExtensionException"/>
        ///     if it is unavailable. For device-scoped entry points, use
        ///     <see cref="Device.GetProcAddress"/>.
        /// </summary>
        public static void* GetProcAddress(string name) => GetProcAddress(AlcDevice.Null, name);

        // Shared plumbing for the null-device statics above and the device-scoped members on
        // Device.
        internal static bool IsExtensionPresent(AlcDevice device, string name)
        {
            ArgumentNullException.ThrowIfNull(name);
            using var utf8 = new Utf8Buffer(name, stackalloc byte[Utf8Buffer.StackBufferSize]);
            fixed (byte* p = utf8.Span)
                return PInvoke.IsExtensionPresent(device, p);
        }

        internal static void* GetProcAddress(AlcDevice device, string name)
        {
            ArgumentNullException.ThrowIfNull(name);
            using var utf8 = new Utf8Buffer(name, stackalloc byte[Utf8Buffer.StackBufferSize]);
            void* fn;
            fixed (byte* p = utf8.Span)
                fn = PInvoke.GetProcAddress(device, p);

            if (fn is null)
                throw new AlExtensionException(name);
            return fn;
        }

        // Resolve plumbing for the generated ExtPointers field initializers. The span must have a
        // NUL terminator in memory immediately after it - true for u8 literals, not checked here.
        // Returns null for a missing symbol instead of throwing: a null ExtPointers field is how
        // the generated methods detect an unavailable extension.
        internal static void* GetProcAddressUtf8(AlcDevice device, ReadOnlySpan<byte> nulTerminatedName)
        {
            fixed (byte* p = nulTerminatedName)
                return PInvoke.GetProcAddress(device, p);
        }
    }
}
