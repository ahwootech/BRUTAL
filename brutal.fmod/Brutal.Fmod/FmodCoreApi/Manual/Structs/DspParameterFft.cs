using System.Runtime.InteropServices;

namespace Brutal.FmodApi;

[StructLayout(LayoutKind.Explicit, Size = 264)]
public unsafe partial struct DspParameterFft
{
    [FieldOffset(0)]
    public int Length;

    [FieldOffset(4)]
    public int NumChannels;

    [FieldOffset(8)]
    public fixed ulong Spectrum[32];
}
