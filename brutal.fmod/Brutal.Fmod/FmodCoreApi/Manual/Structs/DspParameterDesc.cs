using System.Runtime.InteropServices;

namespace Brutal.FmodApi;

[StructLayout(LayoutKind.Explicit, Size = 96)]
public unsafe partial struct DspParameterDesc
{
    [FieldOffset(0)]
    public DspParameterType Type;

    [FieldOffset(4)]
    public fixed byte Name[16];

    [FieldOffset(20)]
    public fixed byte Label[16];

    [FieldOffset(40)]
    public byte* Description;

    [FieldOffset(48)]
    public DspParameterDescFloat FloatDesc;

    [FieldOffset(48)]
    public DspParameterDescInt IntDesc;

    [FieldOffset(48)]
    public DspParameterDescBool BoolDesc;

    [FieldOffset(48)]
    public DspParameterDescData DataDesc;
}
