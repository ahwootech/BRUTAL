#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    [StructLayout(LayoutKind.Explicit, Pack = 8)]
    public unsafe partial struct KtxTextureProtected
    {
        [FieldOffset(24)]
        public readonly KtxFormatSize FormatSize;
    }
}
#pragma warning restore 1591
