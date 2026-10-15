using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    public unsafe partial struct NcTabbedOptions
    {
        public ulong SelChan; // channel for the selected tab header
        public ulong HdrChan; // channel for unselected tab headers
        public ulong SepChan; // channel for the tab separator
        public Ptr<byte> Separator; // separator string (copied by nctabbed_create())
        public NcTabbedOption Flags; // bitmask of NCTABBED_OPTION_*
    }
}
