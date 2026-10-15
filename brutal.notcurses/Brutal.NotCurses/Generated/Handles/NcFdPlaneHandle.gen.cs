using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcFdPlaneHandle
    {
    }
    public unsafe readonly partial struct NcFdPlaneHandle
    {
        public void Destroy()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncfdplane_destroy(this);
            if (__r != 0) throw new NcResultException("ncfdplane_destroy", __r);
        }
        public NcPlaneHandle Plane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncfdplane_plane(this);
    }
}
