using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    public unsafe partial struct NcTreeOptions
    {
        public Ptr<NcTreeItem> Items; // top-level nctree_item array
        public uint Count; // size of |items|
        public delegate* unmanaged[Cdecl]<NcPlaneHandle, Ptr, int, int> Nctreecb; // item callback function
        public int Indentcols; // columns to indent per level of hierarchy
        public ulong Flags; // bitfield of NCTREE_OPTION_*
    }
}
