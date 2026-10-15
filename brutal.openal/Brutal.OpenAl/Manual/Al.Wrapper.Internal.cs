// The internal half of the handle-less AL surface (public half: Al.Wrapper.cs): the vector-shaped
// marshalling helpers covering the shapes the generated scalar getters don't.

namespace Brutal.OpenAlApi;

public static unsafe partial class Al
{
    // --- EFX fv helpers ------------------------------------------------------------------------------

    // The EAX reverb pan vectors are the only fv-shaped EFX parameters, so the fv entry points
    // surface as float3 helpers (no filter has an fv key).

    internal static float3 GetEffectfv3(uint name, int param)
    {
        var v = stackalloc float[3];
        PInvoke.GetEffectfv(name, param, v);
        return new float3(v[0], v[1], v[2]);
    }

    internal static void SetEffectfv3(uint name, int param, float3 value)
    {
        var v = stackalloc float[3] { value.X, value.Y, value.Z };
        PInvoke.Effectfv(name, param, v);
    }

    // --- alext.h pair/scalar helpers -------------------------------------------------------------------

    // Two-element vector forms for the extension pair parameters. The core fv/iv entry points fill
    // caller memory; float2/int2 are sequential two-field structs, so their address is the buffer.
    internal static float2 GetSourcefv2(uint name, int param)
    {
        var value = default(float2);
        PInvoke.GetSourcefv(name, param, (float*)&value);
        return value;
    }

    internal static void SetSourcefv2(uint name, int param, float2 value) =>
        PInvoke.Sourcefv(name, param, (float*)&value);

    internal static int2 GetBufferiv2(uint name, int param)
    {
        var value = default(int2);
        PInvoke.GetBufferiv(name, param, (int*)&value);
        return value;
    }

    internal static void SetBufferiv2(uint name, int param, int2 value) => PInvoke.Bufferiv(name, param, (int*)&value);

    // Extension double/int64 scalar and pair getters (AL_SOFT_source_latency / ALC_SOFT_device_clock
    // source halves), over the fnptr-dispatched raw layer.
    internal static double GetSourcedSOFT(uint name, int param)
    {
        var value = 0.0;
        PInvoke.GetSourcedSOFT(name, param, &value);
        return value;
    }

    internal static long GetSourcei64SOFT(uint name, int param)
    {
        var value = 0L;
        PInvoke.GetSourcei64SOFT(name, param, &value);
        return value;
    }

    // Tuples, not double2/long2: the two slots hold different quantities (see the AlSource.Ext.cs
    // header); the callers name the halves via record structs.
    internal static (double A, double B) GetSourcedv2SOFT(uint name, int param)
    {
        var pair = stackalloc double[2];
        PInvoke.GetSourcedvSOFT(name, param, pair);
        return (pair[0], pair[1]);
    }

    internal static (long A, long B) GetSourcei64v2SOFT(uint name, int param)
    {
        var pair = stackalloc long[2];
        PInvoke.GetSourcei64vSOFT(name, param, pair);
        return (pair[0], pair[1]);
    }
}
