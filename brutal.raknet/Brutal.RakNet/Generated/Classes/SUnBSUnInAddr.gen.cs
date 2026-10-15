using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct SUnBSUnInAddr
    {
        [FieldOffset(0)]
        public byte SB1;

        [FieldOffset(1)]
        public byte SB2;

        [FieldOffset(2)]
        public byte SB3;

        [FieldOffset(3)]
        public byte SB4;
    }
}
