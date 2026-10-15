#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    public enum KtxSupercmpScheme : int
    {
        /// <summary>No supercompression.</summary>
        None = 0,

        /// <summary>Basis LZ supercompression.</summary>
        BasisLz = 1,

        /// <summary>ZStd supercompression.</summary>
        Zstd = 2,

        /// <summary>ZLIB supercompression.</summary>
        Zlib = 3,
        BeginRange = 0,
        EndRange = 3,
        BeginVendorRange = 65536,
        EndVendorRange = 131071,
        BeginReserved = 131072,
    }
}
#pragma warning restore 1591
