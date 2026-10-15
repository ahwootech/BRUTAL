using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    public unsafe partial struct NcMenuOptions
    {
        public Ptr<NcMenuSection> Sections; // array of 'sectioncount' menu_sections
        public int Sectioncount; // must be positive
        public ulong Headerchannels; // styling for header
        public ulong Sectionchannels; // styling for sections
        public NcMenuOption Flags; // flag word of NCMENU_OPTION_*
    }
}
