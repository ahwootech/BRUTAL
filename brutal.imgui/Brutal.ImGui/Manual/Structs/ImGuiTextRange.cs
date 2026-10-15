using System.Runtime.InteropServices;

namespace Brutal.ImGuiApi;

public partial struct ImGuiTextFilter
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct ImGuiTextRange
    {
        [FieldOffset(0)]
        public byte* B;

        [FieldOffset(8)]
        public byte* E;

        public ImGuiTextRange(ReadOnlySpan<byte> range)
        {
            B = range.AsPointer();
            E = B + range.Length;
        }
    }
}
