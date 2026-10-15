using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Brutal.FmodApi;

public static partial class InlineArray
{
    [InlineArray(8)]
    public struct Attributes3d8
    {
        public Attributes3d Value;
    }
}

[StructLayout(LayoutKind.Explicit, Size = 468)]
public unsafe partial struct DspParameter3dAttributesMulti
{
    [FieldOffset(0)]
    public int NumListeners;

    [FieldOffset(4)]
    public InlineArray.Attributes3d8 Relative;

    [FieldOffset(388)]
    public fixed float Weight[8];

    [FieldOffset(420)]
    public Attributes3d Absolute;
}
