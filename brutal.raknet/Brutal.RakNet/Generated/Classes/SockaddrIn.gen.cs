using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SockaddrIn
    {
        [FieldOffset(0)]
        private ushort SinFamilyNonBsd;

        [FieldOffset(2)]
        public ushort SinPort;

        [FieldOffset(4)]
        public InAddr SinAddr;

        [FieldOffset(8)]
        public fixed byte SinZero[8];
    }
}
