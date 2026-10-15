using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    public unsafe partial struct NcReelOptions
    {
        public uint Bordermask; // bitfield; 1s will not be drawn (see bordermaskbits)
        public ulong Borderchan; // attributes used for ncreel border
        public uint Tabletmask; // bitfield; same as bordermask but for tablet borders
        public ulong Tabletchan; // tablet border styling channel
        public ulong Focusedchan; // focused tablet border styling channel
        public NcReelOption Flags; // bitfield over NCREEL_OPTION_*
    }
}
