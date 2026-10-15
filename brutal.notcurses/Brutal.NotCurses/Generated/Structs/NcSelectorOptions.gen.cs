using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    public unsafe partial struct NcSelectorOptions
    {
        public Ptr<byte> Title; // title may be NULL, inhibiting riser, saving two rows.
        public Ptr<byte> Secondary; // secondary may be NULL
        public Ptr<byte> Footer; // footer may be NULL
        public Ptr<NcSelectorItem> Items; // initial items and descriptions
        /// default item (selected at start), must be < itemcount unless itemcount is
        /// 0, in which case 'defidx' must also be 0
        public uint Defidx;
        /// maximum number of options to display at once, 0 to use all available space
        public uint Maxdisplay;
        public ulong Opchannels; // option channels
        public ulong Descchannels; // description channels
        public ulong Titlechannels; // title channels
        public ulong Footchannels; // secondary and footer channels
        public ulong Boxchannels; // border channels
        public ulong Flags; // bitfield of NCSELECTOR_OPTION_*, currently unused
    }
}
