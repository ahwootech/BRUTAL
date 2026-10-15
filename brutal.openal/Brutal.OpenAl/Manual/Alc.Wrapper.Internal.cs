// The internal half of the handle-less ALC surface (public half: Alc.Wrapper.cs): the shared
// query/marshalling helpers the wrapper classes, the keyed Params.DeviceParams layer, and the
// public statics are written against.

using Brutal.Strings;
using CommunityToolkit.HighPerformance.Buffers;

namespace Brutal.OpenAlApi;

public static unsafe partial class Alc
{
    // --- Strings -----------------------------------------------------------------------------------------
    //
    // The string-returning helpers copy the returned pointer into managed memory before checking
    // errors, in case the error query invalidates the library-owned buffer; the GetStringUtf8 pair
    // instead returns a zero-copy view, safe because no ALC call happens before the return on the
    // success path.

    // A null result is either the NULL sentinel or an error; the device error is checked only on
    // that path to disambiguate.
    internal static string? GetString(AlcDevice device, AlcGetString param)
    {
        var p = PInvoke.GetString(device, (int)param);
        var s = StringUtils.Utf8ToString(p);
        if (s is null)
            ThrowIfError(device);
        return s;
    }

    internal static string? GetString(AlcCaptureDevice capture, AlcGetString param)
    {
        var p = PInvoke.GetString(AsQueryDevice(capture), (int)param);
        var s = StringUtils.Utf8ToString(p);
        if (s is null)
            ThrowIfError(capture);
        return s;
    }

    // Zero-copy siblings for the keyed Params.DeviceParams layer. Same error protocol as above,
    // but the return views the library-owned buffer, so it is only valid until the next ALC string
    // query. The NULL sentinel becomes an empty span.
    internal static ReadOnlySpan<byte> GetStringUtf8(AlcDevice device, AlcGetString param)
    {
        var p = PInvoke.GetString(device, (int)param);
        if (p is null)
        {
            ThrowIfError(device);
            return default;
        }
        return Utf8.GetNullTerminatedSpan(p);
    }

    internal static ReadOnlySpan<byte> GetStringUtf8(AlcCaptureDevice capture, AlcGetString param)
    {
        var p = PInvoke.GetString(AsQueryDevice(capture), (int)param);
        if (p is null)
        {
            ThrowIfError(capture);
            return default;
        }
        return Utf8.GetNullTerminatedSpan(p);
    }

    // Backs Alc.GetDefaultDeviceSpecifier and friends: a null pointer means inspect the global
    // error - throw if set, else the query is legitimately empty.
    private static string? GetNullDeviceString(AlcGetString param)
    {
        var p = PInvoke.GetString(AlcDevice.Null, (int)param);
        if (p is null)
        {
            var err = GetError();
            if (err != AlcError.NoError)
                throw new AlcException(err, $"alcGetString(NULL, {param}) failed.");
            return null;
        }
        return StringUtils.Utf8ToString(p);
    }

    // Backs Alc.GetDeviceSpecifiers and friends; same null-pointer protocol as GetNullDeviceString.
    private static string[] EnumerateDevices(AlcGetString param)
    {
        var p = PInvoke.GetString(AlcDevice.Null, (int)param);
        if (p is null)
        {
            var err = GetError();
            if (err != AlcError.NoError)
                throw new AlcException(err, "alcGetString(NULL, ...) device enumeration failed.");
            return [];
        }
        return StringUtils.Utf8ListToStrings(p);
    }

    // --- Integers ----------------------------------------------------------------------------------------
    //
    // alcGetIntegerv fills a caller buffer; these flatten the single-value case to a return value.
    // No automatic error poll, matching the explicit error model. The one vector query,
    // ALC_ALL_ATTRIBUTES, is encapsulated by Device.Attributes.

    internal static int GetInteger(AlcDevice device, AlcInteger param)
    {
        int value;
        PInvoke.GetIntegerv(device, (int)param, 1, &value);
        return value;
    }

    internal static int GetInteger(AlcCaptureDevice capture, AlcInteger param) =>
        GetInteger(AsQueryDevice(capture), param);

    // --- Device handle crossing ------------------------------------------------------------------------

    // The native string/integer queries take ALCdevice* for playback AND capture devices; the
    // split handle types exist to make the mismatched close ops unrepresentable, not to forbid
    // shared queries. This one internal reinterpret is the sanctioned crossing.
    private static AlcDevice AsQueryDevice(AlcCaptureDevice capture) => (void*)capture.Pointer.Value;

    // --- Attribute lists -----------------------------------------------------------------------------

    // Flattens an attribute/value list into a rented, zero-terminated buffer (element-wise copy:
    // ValueTuple layout is not blittable-guaranteed). An empty input returns SpanOwner<int>.Empty,
    // and fixing an empty span yields a null pointer - the native "no attribute list" - for free.
    internal static SpanOwner<int> FlattenAttributes(
        ReadOnlySpan<(AlcContextAttribute Attribute, int Value)> attributes
    )
    {
        if (attributes.IsEmpty)
            return SpanOwner<int>.Empty;

        var owner = SpanOwner<int>.Allocate(attributes.Length * 2 + 1);
        var terminated = owner.Span;
        for (var i = 0; i < attributes.Length; i++)
        {
            terminated[i * 2] = (int)attributes[i].Attribute;
            terminated[i * 2 + 1] = attributes[i].Value;
        }
        terminated[attributes.Length * 2] = 0;
        return owner;
    }
}
