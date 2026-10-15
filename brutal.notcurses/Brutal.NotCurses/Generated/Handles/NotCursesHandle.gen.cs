using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NotCursesHandle
    {
    }
    public unsafe readonly partial struct NotCursesHandle
    {
        public string At(uint2 off, Ptr<ushort> stylemask, Ptr<ulong> channels)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_at_yx(this, off.Y, off.X, stylemask, channels);
        public string AtYx(uint yOff, uint xOff, out ushort stylemask, out ulong channels)
        {
            stylemask = default;
            channels = default;
            fixed (ushort* stylemaskPtr = &stylemask)
            {
                fixed (ulong* channelsPtr = &channels)
                {
                    return global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_at_yx(this, yOff, xOff, new Ptr<ushort>(stylemaskPtr), new Ptr<ulong>(channelsPtr));
                }
            }
        }
        public NcPlaneHandle Bottom()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_bottom(this);
        public Bool8 CanBraille()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_canbraille(this);
        public Bool8 CanChangeColor()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_canchangecolor(this);
        public Bool8 CanFade()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_canfade(this);
        public Bool8 CanHalfBlock()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_canhalfblock(this);
        public Bool8 CanOctant()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_canoctant(this);
        public Bool8 CanOpenImages()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_canopen_images(this);
        public Bool8 CanOpenVideos()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_canopen_videos(this);
        public Bool8 CanPixel()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_canpixel(this);
        public Bool8 CanQuadrant()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_canquadrant(this);
        public Bool8 CanSextant()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_cansextant(this);
        public Bool8 CanTrueColor()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_cantruecolor(this);
        public Bool8 CanUtf8()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_canutf8(this);
        public Ptr<NcCapabilities> Capabilities()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_capabilities(this);
        public NcPixelImpl CheckPixelSupport()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_check_pixel_support(this);
        public void CursorDisable()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_cursor_disable(this);
            if (__r != 0) throw new NcResultException("notcurses_cursor_disable", __r);
        }
        public void CursorEnable(int2 xy)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_cursor_enable(this, xy.Y, xy.X);
            if (__r != 0) throw new NcResultException("notcurses_cursor_enable", __r);
        }
        public void CursorYx(Ptr<int> y, Ptr<int> x)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_cursor_yx(this, y, x);
            if (__r != 0) throw new NcResultException("notcurses_cursor_yx", __r);
        }
        public void Cursor(out int2 xy)
        {
            int xyY = default;
            int xyX = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_cursor_yx(this, new Ptr<int>(&xyY), new Ptr<int>(&xyX));
            if (__r != 0) throw new NcResultException("notcurses_cursor_yx", __r);
            xy = new int2(xyX, xyY);
        }
        public void Debug(Ptr debugfp)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_debug(this, debugfp);
        public uint DefaultBackground()
        {
            uint bg = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_default_background(this, new Ptr<uint>(&bg));
            if (__r != 0) throw new NcResultException("notcurses_default_background", __r);
            return bg;
        }
        public uint DefaultForeground()
        {
            uint fg = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_default_foreground(this, new Ptr<uint>(&fg));
            if (__r != 0) throw new NcResultException("notcurses_default_foreground", __r);
            return fg;
        }
        public string DetectedTerminal()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_detected_terminal(this);
        public void DropPlanes()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_drop_planes(this);
        public void EnterAlternateScreen()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_enter_alternate_screen(this);
            if (__r != 0) throw new NcResultException("notcurses_enter_alternate_screen", __r);
        }
        public uint Get(Ptr<TimeSpec> ts, Ptr<NcInput> ni)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_get(this, ts, ni);
        public uint Get(out TimeSpec ts, out NcInput ni)
        {
            ts = default;
            ni = default;
            fixed (TimeSpec* tsPtr = &ts)
            {
                fixed (NcInput* niPtr = &ni)
                {
                    return global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_get(this, new Ptr<TimeSpec>(tsPtr), new Ptr<NcInput>(niPtr));
                }
            }
        }
        public uint GetBlocking(Ptr<NcInput> ni)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_get_blocking(this, ni);
        public uint GetBlocking(out NcInput ni)
        {
            ni = default;
            fixed (NcInput* niPtr = &ni)
            {
                return global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_get_blocking(this, new Ptr<NcInput>(niPtr));
            }
        }
        public uint GetNblock(Ptr<NcInput> ni)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_get_nblock(this, ni);
        public uint GetNblock(out NcInput ni)
        {
            ni = default;
            fixed (NcInput* niPtr = &ni)
            {
                return global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_get_nblock(this, new Ptr<NcInput>(niPtr));
            }
        }
        public void GetVec(Ptr<TimeSpec> ts, Ptr<NcInput> ni, int vCount)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_getvec(this, ts, ni, vCount);
            if (__r != 0) throw new NcResultException("notcurses_getvec", __r);
        }
        public void InputReadyFd()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_inputready_fd(this);
            if (__r != 0) throw new NcResultException("notcurses_inputready_fd", __r);
        }
        public void LeaveAlternateScreen()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_leave_alternate_screen(this);
            if (__r != 0) throw new NcResultException("notcurses_leave_alternate_screen", __r);
        }
        public void LineSigsDisable()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_linesigs_disable(this);
            if (__r != 0) throw new NcResultException("notcurses_linesigs_disable", __r);
        }
        public void LineSigsEnable()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_linesigs_enable(this);
            if (__r != 0) throw new NcResultException("notcurses_linesigs_enable", __r);
        }
        public void MiceDisable()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_mice_disable(this);
            if (__r != 0) throw new NcResultException("notcurses_mice_disable", __r);
        }
        public void MiceEnable(uint eventMask)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_mice_enable(this, eventMask);
            if (__r != 0) throw new NcResultException("notcurses_mice_enable", __r);
        }
        public uint PaletteSize()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_palette_size(this);
        public void Refresh(Ptr<uint> y, Ptr<uint> x)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_refresh(this, y, x);
            if (__r != 0) throw new NcResultException("notcurses_refresh", __r);
        }
        public void Refresh(out uint2 xy)
        {
            uint xyY = default;
            uint xyX = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_refresh(this, new Ptr<uint>(&xyY), new Ptr<uint>(&xyX));
            if (__r != 0) throw new NcResultException("notcurses_refresh", __r);
            xy = new uint2(xyX, xyY);
        }
        public void Render()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_render(this);
            if (__r != 0) throw new NcResultException("notcurses_render", __r);
        }
        public void Stats(Ptr<NcStats> stats)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_stats(this, stats);
        public void Stats(out NcStats stats)
        {
            stats = default;
            fixed (NcStats* statsPtr = &stats)
            {
                global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_stats(this, new Ptr<NcStats>(statsPtr));
            }
        }
        public Ptr<NcStats> StatsAlloc()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_stats_alloc(this);
        public void StatsReset(Ptr<NcStats> stats)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_stats_reset(this, stats);
        public void StatsReset(out NcStats stats)
        {
            stats = default;
            fixed (NcStats* statsPtr = &stats)
            {
                global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_stats_reset(this, new Ptr<NcStats>(statsPtr));
            }
        }
        public NcPlaneHandle StdDimYx(Ptr<uint> y, Ptr<uint> x)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_stddim_yx(this, y, x);
        public NcPlaneHandle StdDim(out uint2 xy)
        {
            uint xyY = default;
            uint xyX = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_stddim_yx(this, new Ptr<uint>(&xyY), new Ptr<uint>(&xyX));
            xy = new uint2(xyX, xyY);
            return __r;
        }
        public NcPlaneHandle StdDimYxConst(Ptr<uint> y, Ptr<uint> x)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_stddim_yx_const(this, y, x);
        public NcPlaneHandle StdDimYxConst(out uint2 xy)
        {
            uint xyY = default;
            uint xyX = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_stddim_yx_const(this, new Ptr<uint>(&xyY), new Ptr<uint>(&xyX));
            xy = new uint2(xyX, xyY);
            return __r;
        }
        public NcPlaneHandle StdPlane()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_stdplane(this);
        public NcPlaneHandle StdPlaneConst()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_stdplane_const(this);
        public void Stop()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_stop(this);
            if (__r != 0) throw new NcResultException("notcurses_stop", __r);
        }
        public ushort SupportedStyles()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_supported_styles(this);
        public void TermDimYx(Ptr<uint> rows, Ptr<uint> cols)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_term_dim_yx(this, rows, cols);
        public void TermDimYx(out uint rows, out uint cols)
        {
            rows = default;
            cols = default;
            fixed (uint* rowsPtr = &rows)
            {
                fixed (uint* colsPtr = &cols)
                {
                    global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_term_dim_yx(this, new Ptr<uint>(rowsPtr), new Ptr<uint>(colsPtr));
                }
            }
        }
        public NcPlaneHandle Top()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.notcurses_top(this);
    }
}
