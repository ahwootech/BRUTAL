using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcSubProcHandle
    {
    }
    public unsafe readonly partial struct NcSubProcHandle
    {
        public void Destroy()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncsubproc_destroy(this);
            if (__r != 0) throw new NcResultException("ncsubproc_destroy", __r);
        }
        public NcPlaneHandle Plane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncsubproc_plane(this);
    }
}
