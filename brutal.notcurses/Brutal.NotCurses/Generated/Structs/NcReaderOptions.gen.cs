using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    public unsafe partial struct NcReaderOptions
    {
        public ulong Tchannels; // channels used for input
        public uint Tattrword; // attributes used for input
        public NcReaderOption Flags; // bitfield of NCREADER_OPTION_*
    }
}
