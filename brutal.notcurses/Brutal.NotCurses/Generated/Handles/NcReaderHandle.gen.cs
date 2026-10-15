using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcReaderHandle
    {
    }
    public unsafe readonly partial struct NcReaderHandle
    {
        public void Clear()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreader_clear(this);
            if (__r != 0) throw new NcResultException("ncreader_clear", __r);
        }
        public string Contents()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreader_contents(this);
        public void Destroy(Ptr<Ptr<byte>> contents)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreader_destroy(this, contents);
        public void MoveDown()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreader_move_down(this);
            if (__r != 0) throw new NcResultException("ncreader_move_down", __r);
        }
        public void MoveLeft()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreader_move_left(this);
            if (__r != 0) throw new NcResultException("ncreader_move_left", __r);
        }
        public void MoveRight()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreader_move_right(this);
            if (__r != 0) throw new NcResultException("ncreader_move_right", __r);
        }
        public void MoveUp()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreader_move_up(this);
            if (__r != 0) throw new NcResultException("ncreader_move_up", __r);
        }
        public Bool8 OfferInput(Ptr<NcInput> ni)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreader_offer_input(this, ni);
        public Bool8 OfferInput(out NcInput ni)
        {
            ni = default;
            fixed (NcInput* niPtr = &ni)
            {
                return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreader_offer_input(this, new Ptr<NcInput>(niPtr));
            }
        }
        public NcPlaneHandle Plane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreader_plane(this);
        public void WriteEgc(RefString8 egc)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncreader_write_egc(this, egc);
            if (__r != 0) throw new NcResultException("ncreader_write_egc", __r);
        }
    }
    public static unsafe partial class StringExtensions
    {
        public static void WriteEgc(this NcReaderHandle self, string egc)
        {
            using var egcBuf = new ScratchBuffer(egc, stackalloc byte[256]);
            self.WriteEgc(egcBuf.Bytes);
        }
    }
}
