using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    /// An input event. Cell coordinates are currently defined only for mouse
    /// events. It is not guaranteed that we can set the modifiers for a given
    /// ncinput. We encompass single Unicode codepoints, not complete EGCs.
    /// FIXME for abi4, combine the bools into |modifiers|
    public unsafe partial struct NcInput
    {
        public uint Id; // Unicode codepoint or synthesized NCKEY event
        public int Y; // y/x cell coordinate of event, -1 for undefined
        public int X; // y/x cell coordinate of event, -1 for undefined
        public fixed byte Utf8[5]; // utf8 representation, if one exists
        public Bool8 Alt; // was alt held?
        public Bool8 Shift; // was shift held?
        public Bool8 Ctrl; // was ctrl held?
        /// END DEPRECATION
        public NcInType Evtype;
        public uint Modifiers; // bitmask over NCKEY_MOD_*
        public int Ypx; // pixel offsets within cell, -1 for undefined
        public int Xpx; // pixel offsets within cell, -1 for undefined
        public fixed uint EffText[4]; // Effective 
    }
}
