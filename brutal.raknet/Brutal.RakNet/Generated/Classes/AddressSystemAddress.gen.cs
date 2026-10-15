using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct AddressSystemAddress
    {
        [FieldOffset(0)]
        public SockaddrIn Addr4;
    }
}
