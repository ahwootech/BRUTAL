using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcTabletHandle
    {
    }
    public unsafe readonly partial struct NcTabletHandle
    {
        public NcPlaneHandle Plane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctablet_plane(this);
        public Ptr UserPtr()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.nctablet_userptr(this);
    }
}
