using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcProgBarHandle
    {
    }
    public unsafe readonly partial struct NcProgBarHandle
    {
        public void Destroy()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncprogbar_destroy(this);
        public NcPlaneHandle Plane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncprogbar_plane(this);
        public double Progress()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncprogbar_progress(this);
        public void SetProgress(double p)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncprogbar_set_progress(this, p);
            if (__r != 0) throw new NcResultException("ncprogbar_set_progress", __r);
        }
    }
}
