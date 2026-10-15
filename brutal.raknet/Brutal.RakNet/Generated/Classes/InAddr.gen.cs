using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct InAddr
    {
        public SUnInAddr SUn;
    }
}
