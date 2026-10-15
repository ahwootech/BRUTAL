using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SystemAddress
    {
        public AddressSystemAddress Address;

        /// <summary>This is not used internally, but holds a copy of the port held in the address union, so for debugging it's easier to check what port is being held</summary>
        public ushort DebugPort;
        public ushort SystemIndex;
    }
}
