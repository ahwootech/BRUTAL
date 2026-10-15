using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AddressOrGUID
    {
        public RakNetGUID RakNetGuid;
        public SystemAddress SystemAddress;
    }
}
