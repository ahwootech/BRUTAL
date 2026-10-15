// The opt-in keyed parameter layer: the escape hatch for code that has "which parameter" as a
// runtime value (automation curves, inspectors, snapshot/restore). Importing Brutal.OpenAlApi.Params
// adds the keyed Set/Get overloads as extension members on the handle types, with overload
// resolution enforcing the right value shape per key enum. Setting a get-only key is a native
// error.
//
// SourceParams/BufferParams/ListenerParams are generated; DeviceParams stays manual - an ALC
// string-query one-off with no key-enum table to derive from.

namespace Brutal.OpenAlApi.Params;

/// <summary>
///     Keyed ALC string and integer query access (<c>alcGetString</c>/<c>alcGetIntegerv</c>) as
///     extension members on the raw device handles, for extension parameters not named by
///     <see cref="AlcGetString"/>/<see cref="AlcInteger"/> (for example,
///     <c>ALC_HRTF_SPECIFIER_SOFT</c> or <c>ALC_CONNECTED</c>, cast into the enums). Typical code
///     uses the named properties on <see cref="Device"/>/<see cref="CaptureDevice"/> and the
///     <see cref="Alc"/> enumeration statics instead.
/// </summary>
public static class DeviceParams
{
    extension(AlcDevice device)
    {
        /// <summary>
        ///     Gets a device-scoped ALC string (<c>alcGetString</c>) as a zero-copy UTF-8 view of
        ///     library-owned memory. The view is valid only until the next ALC string query (an
        ///     openal-soft lifetime guarantee) - copy the bytes out to keep them, or use
        ///     <c>Encoding.UTF8.GetString</c> to materialize a managed string. An empty span is either a
        ///     genuinely empty value or OpenAL's NULL absence sentinel.
        /// </summary>
        public ReadOnlySpan<byte> GetString(AlcGetString param) => Alc.GetStringUtf8(device, param);

        /// <summary>Gets a single device-scoped ALC integer (<c>alcGetIntegerv</c>).</summary>
        public int Get(AlcInteger param) => Alc.GetInteger(device, param);
    }

    extension(AlcCaptureDevice capture)
    {
        /// <summary>
        ///     Gets a capture-device-scoped ALC string (<c>alcGetString</c>) as a zero-copy UTF-8
        ///     view of library-owned memory, with the same validity rules as the
        ///     <see cref="AlcDevice"/> overload.
        /// </summary>
        public ReadOnlySpan<byte> GetString(AlcGetString param) => Alc.GetStringUtf8(capture, param);

        /// <summary>Gets a single capture-device-scoped ALC integer (<c>alcGetIntegerv</c>).</summary>
        public int Get(AlcInteger param) => Alc.GetInteger(capture, param);
    }
}
