using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct SUnInAddr
    {
        [FieldOffset(0)]
        public SUnBSUnInAddr SUnB;

        [FieldOffset(0)]
        public SUnWSUnInAddr SUnW;

        [FieldOffset(0)]
        public uint SAddr;
    }
}
