using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct RakNetSocket2
    {
        [FieldOffset(8)]
        public RNS2EventHandler* EventHandler;

        [FieldOffset(16)]
        public RNS2Type SocketType;

        [FieldOffset(20)]
        public SystemAddress BoundAddress;

        [FieldOffset(40)]
        public uint UserConnectionSocketIndex;
    }
}
