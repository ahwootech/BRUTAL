using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcUPlotHandle
    {
    }
    public unsafe readonly partial struct NcUPlotHandle
    {
        public void AddSample(ulong x, ulong y)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncuplot_add_sample(this, x, y);
            if (__r != 0) throw new NcResultException("ncuplot_add_sample", __r);
        }
        public void Destroy()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncuplot_destroy(this);
        public NcPlaneHandle Plane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncuplot_plane(this);
        public ulong Sample(ulong x)
        {
            ulong y = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncuplot_sample(this, x, new Ptr<ulong>(&y));
            if (__r != 0) throw new NcResultException("ncuplot_sample", __r);
            return y;
        }
        public void SetSample(ulong x, ulong y)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncuplot_set_sample(this, x, y);
            if (__r != 0) throw new NcResultException("ncuplot_set_sample", __r);
        }
    }
}
