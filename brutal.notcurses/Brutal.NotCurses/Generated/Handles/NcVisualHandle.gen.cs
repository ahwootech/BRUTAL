using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcVisualHandle
    {
    }
    public unsafe readonly partial struct NcVisualHandle
    {
        public void Free()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirectf_free(this);
        public uint At(uint2 xy)
        {
            uint pixel = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncvisual_at_yx(this, xy.Y, xy.X, new Ptr<uint>(&pixel));
            if (__r != 0) throw new NcResultException("ncvisual_at_yx", __r);
            return pixel;
        }
        public void Decode()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncvisual_decode(this);
            if (__r != 0) throw new NcResultException("ncvisual_decode", __r);
        }
        public void DecodeLoop()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncvisual_decode_loop(this);
            if (__r != 0) throw new NcResultException("ncvisual_decode_loop", __r);
        }
        public void Destroy()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncvisual_destroy(this);
        public void Polyfill(uint2 xy, uint rgba)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncvisual_polyfill_yx(this, xy.Y, xy.X, rgba);
            if (__r != 0) throw new NcResultException("ncvisual_polyfill_yx", __r);
        }
        public void Resize(int rows, int cols)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncvisual_resize(this, rows, cols);
            if (__r != 0) throw new NcResultException("ncvisual_resize", __r);
        }
        public void ResizeNoninterpolative(int rows, int cols)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncvisual_resize_noninterpolative(this, rows, cols);
            if (__r != 0) throw new NcResultException("ncvisual_resize_noninterpolative", __r);
        }
        public void Rotate(double rads)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncvisual_rotate(this, rads);
            if (__r != 0) throw new NcResultException("ncvisual_rotate", __r);
        }
        public void Set(uint2 xy, uint pixel)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncvisual_set_yx(this, xy.Y, xy.X, pixel);
            if (__r != 0) throw new NcResultException("ncvisual_set_yx", __r);
        }
        public void SimpleStreamer(Ptr<NcVisualOptions> vopts, Ptr<TimeSpec> tspec, Ptr currY)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncvisual_simple_streamer(this, vopts, tspec, currY);
            if (__r != 0) throw new NcResultException("ncvisual_simple_streamer", __r);
        }
    }
}
