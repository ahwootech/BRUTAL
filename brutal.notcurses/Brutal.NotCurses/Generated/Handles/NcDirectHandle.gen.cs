using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcDirectHandle
    {
    }
    public unsafe readonly partial struct NcDirectHandle
    {
        public void AsciiBox(ulong ul, ulong ur, ulong ll, ulong lr, uint2 len, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_ascii_box(this, ul, ur, ll, lr, len.Y, len.X, ctlWord);
            if (__r != 0) throw new NcResultException("ncdirect_ascii_box", __r);
        }
        public Bool8 CanBraille()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_canbraille(this);
        public Bool8 CanChangeColor()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_canchangecolor(this);
        public Bool8 CanFade()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_canfade(this);
        public Bool8 CanGetCursor()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_canget_cursor(this);
        public Bool8 CanHalfBlock()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_canhalfblock(this);
        public Bool8 CanOctant()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_canoctant(this);
        public Bool8 CanOpenImages()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_canopen_images(this);
        public Bool8 CanOpenVideos()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_canopen_videos(this);
        public Bool8 CanQuadrant()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_canquadrant(this);
        public Bool8 CanSextant()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_cansextant(this);
        public Bool8 CanTrueColor()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_cantruecolor(this);
        public Bool8 CanUtf8()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_canutf8(this);
        public Ptr<NcCapabilities> Capabilities()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_capabilities(this);
        public int CheckPixelSupport()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_check_pixel_support(this);
        public void Clear()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_clear(this);
            if (__r != 0) throw new NcResultException("ncdirect_clear", __r);
        }
        public void CursorDisable()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_cursor_disable(this);
            if (__r != 0) throw new NcResultException("ncdirect_cursor_disable", __r);
        }
        public void CursorDown(int num)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_cursor_down(this, num);
            if (__r != 0) throw new NcResultException("ncdirect_cursor_down", __r);
        }
        public void CursorEnable()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_cursor_enable(this);
            if (__r != 0) throw new NcResultException("ncdirect_cursor_enable", __r);
        }
        public void CursorLeft(int num)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_cursor_left(this, num);
            if (__r != 0) throw new NcResultException("ncdirect_cursor_left", __r);
        }
        public void CursorMove(int2 xy)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_cursor_move_yx(this, xy.Y, xy.X);
            if (__r != 0) throw new NcResultException("ncdirect_cursor_move_yx", __r);
        }
        public void CursorPop()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_cursor_pop(this);
            if (__r != 0) throw new NcResultException("ncdirect_cursor_pop", __r);
        }
        public void CursorPush()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_cursor_push(this);
            if (__r != 0) throw new NcResultException("ncdirect_cursor_push", __r);
        }
        public void CursorRight(int num)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_cursor_right(this, num);
            if (__r != 0) throw new NcResultException("ncdirect_cursor_right", __r);
        }
        public void CursorUp(int num)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_cursor_up(this, num);
            if (__r != 0) throw new NcResultException("ncdirect_cursor_up", __r);
        }
        public void CursorYx(Ptr<uint> y, Ptr<uint> x)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_cursor_yx(this, y, x);
            if (__r != 0) throw new NcResultException("ncdirect_cursor_yx", __r);
        }
        public void Cursor(out uint2 xy)
        {
            uint xyY = default;
            uint xyX = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_cursor_yx(this, new Ptr<uint>(&xyY), new Ptr<uint>(&xyX));
            if (__r != 0) throw new NcResultException("ncdirect_cursor_yx", __r);
            xy = new uint2(xyX, xyY);
        }
        public string DetectedTerminal()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_detected_terminal(this);
        public uint DimX()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_dim_x(this);
        public uint DimY()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_dim_y(this);
        public void DoubleBox(ulong ul, ulong ur, ulong ll, ulong lr, uint2 len, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_double_box(this, ul, ur, ll, lr, len.Y, len.X, ctlWord);
            if (__r != 0) throw new NcResultException("ncdirect_double_box", __r);
        }
        public void Flush()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_flush(this);
            if (__r != 0) throw new NcResultException("ncdirect_flush", __r);
        }
        public uint Get(Ptr<TimeSpec> absdl, Ptr<NcInput> ni)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_get(this, absdl, ni);
        public uint Get(out TimeSpec absdl, out NcInput ni)
        {
            absdl = default;
            ni = default;
            fixed (TimeSpec* absdlPtr = &absdl)
            {
                fixed (NcInput* niPtr = &ni)
                {
                    return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_get(this, new Ptr<TimeSpec>(absdlPtr), new Ptr<NcInput>(niPtr));
                }
            }
        }
        public uint GetBlocking(Ptr<NcInput> ni)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_get_blocking(this, ni);
        public uint GetBlocking(out NcInput ni)
        {
            ni = default;
            fixed (NcInput* niPtr = &ni)
            {
                return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_get_blocking(this, new Ptr<NcInput>(niPtr));
            }
        }
        public uint GetNblock(Ptr<NcInput> ni)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_get_nblock(this, ni);
        public uint GetNblock(out NcInput ni)
        {
            ni = default;
            fixed (NcInput* niPtr = &ni)
            {
                return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_get_nblock(this, new Ptr<NcInput>(niPtr));
            }
        }
        public void HeavyBox(ulong ul, ulong ur, ulong ll, ulong lr, uint2 len, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_heavy_box(this, ul, ur, ll, lr, len.Y, len.X, ctlWord);
            if (__r != 0) throw new NcResultException("ncdirect_heavy_box", __r);
        }
        public void HlineInterp(Ptr<byte> egc, uint len, ulong h1, ulong h2)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_hline_interp(this, egc, len, h1, h2);
            if (__r != 0) throw new NcResultException("ncdirect_hline_interp", __r);
        }
        public void InputReadyFd()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_inputready_fd(this);
            if (__r != 0) throw new NcResultException("ncdirect_inputready_fd", __r);
        }
        public void LightBox(ulong ul, ulong ur, ulong ll, ulong lr, uint2 len, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_light_box(this, ul, ur, ll, lr, len.Y, len.X, ctlWord);
            if (__r != 0) throw new NcResultException("ncdirect_light_box", __r);
        }
        public void OffStyles(uint styleBits)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_off_styles(this, styleBits);
            if (__r != 0) throw new NcResultException("ncdirect_off_styles", __r);
        }
        public void OnStyles(uint styleBits)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_on_styles(this, styleBits);
            if (__r != 0) throw new NcResultException("ncdirect_on_styles", __r);
        }
        public uint PaletteSize()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_palette_size(this);
        public void PrintfAligned(int y, NcAlign align, RefString8 fmt)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_printf_aligned(this, y, align, fmt);
            if (__r != 0) throw new NcResultException("ncdirect_printf_aligned", __r);
        }
        public int PutEgc(ulong channels, RefString8 utf8, Ptr<int> sBytes)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_putegc(this, channels, utf8, sBytes);
            if (__r < 0) throw new NcResultException("ncdirect_putegc", __r);
            return __r;
        }
        public int PutEgc(ulong channels, RefString8 utf8, out int sBytes)
        {
            sBytes = default;
            fixed (int* sBytesPtr = &sBytes)
            {
                var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_putegc(this, channels, utf8, new Ptr<int>(sBytesPtr));
                if (__r < 0) throw new NcResultException("ncdirect_putegc", __r);
                return __r;
            }
        }
        public int PutStr(ulong channels, RefString8 utf8)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_putstr(this, channels, utf8);
            if (__r < 0) throw new NcResultException("ncdirect_putstr", __r);
            return __r;
        }
        public void RasterFrame(NcPlaneHandle ncdv, NcAlign align)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_raster_frame(this, ncdv, align);
            if (__r != 0) throw new NcResultException("ncdirect_raster_frame", __r);
        }
        public string ReadLine(RefString8 prompt)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_readline(this, prompt);
        public NcPlaneHandle RenderFrame(RefString8 filename, NcBlitter blitter, NcScale scale, int2 max)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_render_frame(this, filename, blitter, scale, max.Y, max.X);
        public void RenderImage(RefString8 filename, NcAlign align, NcBlitter blitter, NcScale scale)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_render_image(this, filename, align, blitter, scale);
            if (__r != 0) throw new NcResultException("ncdirect_render_image", __r);
        }
        public void RoundedBox(ulong ul, ulong ur, ulong ll, ulong lr, uint2 len, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_rounded_box(this, ul, ur, ll, lr, len.Y, len.X, ctlWord);
            if (__r != 0) throw new NcResultException("ncdirect_rounded_box", __r);
        }
        public void SetBgDefault()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_set_bg_default(this);
            if (__r != 0) throw new NcResultException("ncdirect_set_bg_default", __r);
        }
        public void SetBgPalindex(int pIdx)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_set_bg_palindex(this, pIdx);
            if (__r != 0) throw new NcResultException("ncdirect_set_bg_palindex", __r);
        }
        public void SetBgRgb(uint rgb)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_set_bg_rgb(this, rgb);
            if (__r != 0) throw new NcResultException("ncdirect_set_bg_rgb", __r);
        }
        public void SetBgRgb8(uint r, uint g, uint b)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_set_bg_rgb8(this, r, g, b);
            if (__r != 0) throw new NcResultException("ncdirect_set_bg_rgb8", __r);
        }
        public void SetFgDefault()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_set_fg_default(this);
            if (__r != 0) throw new NcResultException("ncdirect_set_fg_default", __r);
        }
        public void SetFgPalindex(int pIdx)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_set_fg_palindex(this, pIdx);
            if (__r != 0) throw new NcResultException("ncdirect_set_fg_palindex", __r);
        }
        public void SetFgRgb(uint rgb)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_set_fg_rgb(this, rgb);
            if (__r != 0) throw new NcResultException("ncdirect_set_fg_rgb", __r);
        }
        public void SetFgRgb8(uint r, uint g, uint b)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_set_fg_rgb8(this, r, g, b);
            if (__r != 0) throw new NcResultException("ncdirect_set_fg_rgb8", __r);
        }
        public void SetStyles(uint styleBits)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_set_styles(this, styleBits);
            if (__r != 0) throw new NcResultException("ncdirect_set_styles", __r);
        }
        public void Stop()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_stop(this);
            if (__r != 0) throw new NcResultException("ncdirect_stop", __r);
        }
        public void Stream(RefString8 filename, delegate* unmanaged[Cdecl]<NcVisualHandle, Ptr<NcVisualOptions>, Ptr<TimeSpec>, Ptr, int> streamer, Ptr<NcVisualOptions> vopts, Ptr currY)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_stream(this, filename, streamer, vopts, currY);
            if (__r != 0) throw new NcResultException("ncdirect_stream", __r);
        }
        public ushort Styles()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_styles(this);
        public ushort SupportedStyles()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_supported_styles(this);
        public void VlineInterp(Ptr<byte> egc, uint len, ulong h1, ulong h2)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncdirect_vline_interp(this, egc, len, h1, h2);
            if (__r != 0) throw new NcResultException("ncdirect_vline_interp", __r);
        }
    }
    public static unsafe partial class StringExtensions
    {
        public static void PrintfAligned(this NcDirectHandle self, int y, NcAlign align, string fmt)
        {
            using var fmtBuf = new ScratchBuffer(fmt, stackalloc byte[256]);
            self.PrintfAligned(y, align, fmtBuf.Bytes);
        }
        public static int PutEgc(this NcDirectHandle self, ulong channels, string utf8, Ptr<int> sBytes)
        {
            using var utf8Buf = new ScratchBuffer(utf8, stackalloc byte[256]);
            return self.PutEgc(channels, utf8Buf.Bytes, sBytes);
        }
        public static int PutStr(this NcDirectHandle self, ulong channels, string utf8)
        {
            using var utf8Buf = new ScratchBuffer(utf8, stackalloc byte[256]);
            return self.PutStr(channels, utf8Buf.Bytes);
        }
        public static string ReadLine(this NcDirectHandle self, string prompt)
        {
            using var promptBuf = new ScratchBuffer(prompt, stackalloc byte[256]);
            return self.ReadLine(promptBuf.Bytes);
        }
        public static NcPlaneHandle RenderFrame(this NcDirectHandle self, string filename, NcBlitter blitter, NcScale scale, int2 max)
        {
            using var filenameBuf = new ScratchBuffer(filename, stackalloc byte[256]);
            return self.RenderFrame(filenameBuf.Bytes, blitter, scale, max);
        }
        public static void RenderImage(this NcDirectHandle self, string filename, NcAlign align, NcBlitter blitter, NcScale scale)
        {
            using var filenameBuf = new ScratchBuffer(filename, stackalloc byte[256]);
            self.RenderImage(filenameBuf.Bytes, align, blitter, scale);
        }
        public static void Stream(this NcDirectHandle self, string filename, delegate* unmanaged[Cdecl]<NcVisualHandle, Ptr<NcVisualOptions>, Ptr<TimeSpec>, Ptr, int> streamer, Ptr<NcVisualOptions> vopts, Ptr currY)
        {
            using var filenameBuf = new ScratchBuffer(filename, stackalloc byte[256]);
            self.Stream(filenameBuf.Bytes, streamer, vopts, currY);
        }
    }
}
