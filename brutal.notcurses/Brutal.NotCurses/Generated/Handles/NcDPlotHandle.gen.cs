using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcDPlotHandle
    {
    }
    public unsafe readonly partial struct NcDPlotHandle
    {
        public void AddSample(ulong x, double y)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdplot_add_sample(this, x, y);
            if (__r != 0) throw new NcResultException("ncdplot_add_sample", __r);
        }
        public void Destroy()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdplot_destroy(this);
        public NcPlaneHandle Plane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdplot_plane(this);
        public double Sample(ulong x)
        {
            double y = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdplot_sample(this, x, new Ptr<double>(&y));
            if (__r != 0) throw new NcResultException("ncdplot_sample", __r);
            return y;
        }
        public void SetSample(ulong x, double y)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdplot_set_sample(this, x, y);
            if (__r != 0) throw new NcResultException("ncdplot_set_sample", __r);
        }
    }
}
