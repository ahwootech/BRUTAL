using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    /// multiselection widget -- a selector supporting multiple selections.
    /// 
    /// Unlike the selector widget, zero to all of the items can be selected, but
    /// also the widget does not support adding or removing items at runtime.
    public unsafe partial struct NcMultiSelectorOptions
    {
        public Ptr<byte> Title; // title may be NULL, inhibiting riser, saving two rows.
        public Ptr<byte> Secondary; // secondary may be NULL
        public Ptr<byte> Footer; // footer may be NULL
        public Ptr<NcMSelectorItem> Items; // initial items, descriptions, and statuses
        /// maximum number of options to display at once, 0 to use all available space
        public uint Maxdisplay;
        public ulong Opchannels; // option channels
        public ulong Descchannels; // description channels
        public ulong Titlechannels; // title channels
        public ulong Footchannels; // secondary and footer channels
        public ulong Boxchannels; // border channels
        public ulong Flags; // bitfield of NCMULTISELECTOR_OPTION_*, currently unused
    }
}
