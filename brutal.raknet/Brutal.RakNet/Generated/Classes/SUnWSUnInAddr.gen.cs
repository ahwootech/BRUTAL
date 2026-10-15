using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct SUnWSUnInAddr
    {
        [FieldOffset(0)]
        public ushort SW1;

        [FieldOffset(2)]
        public ushort SW2;
    }
}
