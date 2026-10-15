using System;
using System.Runtime.InteropServices;

namespace Brutal.RakNetApi
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct RakNetGUID
    {
        /// <summary>uint32_t g[6];</summary>
        public ulong G;

        /// <summary>Used internally for fast lookup. Optional (use -1 to do regular lookup). Don't transmit this.</summary>
        public ushort SystemIndex;
    }
}
