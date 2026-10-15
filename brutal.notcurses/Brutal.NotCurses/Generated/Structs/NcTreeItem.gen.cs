using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    /// each item has a curry, and zero or more subitems.
    public unsafe partial struct NcTreeItem
    {
        public Ptr Curry;
        public Ptr<NcTreeItem> Subs;
        public uint Subcount;
    }
}
