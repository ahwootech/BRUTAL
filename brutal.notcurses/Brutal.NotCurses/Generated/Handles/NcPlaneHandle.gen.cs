using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    [InteropHandle]
    public unsafe readonly partial struct NcPlaneHandle
    {
    }
    public unsafe readonly partial struct NcPlaneHandle
    {
        public NcPlaneHandle Above()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_above(this);
        public void AbsX()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_abs_x(this);
            if (__r != 0) throw new NcResultException("ncplane_abs_x", __r);
        }
        public void AbsY()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_abs_y(this);
            if (__r != 0) throw new NcResultException("ncplane_abs_y", __r);
        }
        public void AbsYx(Ptr<int> y, Ptr<int> x)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_abs_yx(this, y, x);
        public void Abs(out int2 xy)
        {
            int xyY = default;
            int xyX = default;
            global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_abs_yx(this, new Ptr<int>(&xyY), new Ptr<int>(&xyX));
            xy = new int2(xyX, xyY);
        }
        public Ptr<uint> AsRgba(NcBlitter blit, int2 beg, uint2 len, Ptr<uint> pxDimY, Ptr<uint> pxDimX)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_as_rgba(this, blit, beg.Y, beg.X, len.Y, len.X, pxDimY, pxDimX);
        public Ptr<uint> AsRgba(NcBlitter blit, int begY, int begX, uint lenY, uint lenX, out uint2 pxDim)
        {
            uint pxDimY = default;
            uint pxDimX = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_as_rgba(this, blit, begY, begX, lenY, lenX, new Ptr<uint>(&pxDimY), new Ptr<uint>(&pxDimX));
            pxDim = new uint2(pxDimX, pxDimY);
            return __r;
        }
        public void AsciiBox(ushort styles, ulong channels, uint2 len, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_ascii_box(this, styles, channels, len.Y, len.X, ctlWord);
            if (__r != 0) throw new NcResultException("ncplane_ascii_box", __r);
        }
        public string AtCursor(Ptr<ushort> stylemask, Ptr<ulong> channels)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_at_cursor(this, stylemask, channels);
        public string AtCursor(out ushort stylemask, out ulong channels)
        {
            stylemask = default;
            channels = default;
            fixed (ushort* stylemaskPtr = &stylemask)
            {
                fixed (ulong* channelsPtr = &channels)
                {
                    return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_at_cursor(this, new Ptr<ushort>(stylemaskPtr), new Ptr<ulong>(channelsPtr));
                }
            }
        }
        public NcCell AtCursorCell()
        {
            NcCell c = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_at_cursor_cell(this, new Ptr<NcCell>(&c));
            if (__r != 0) throw new NcResultException("ncplane_at_cursor_cell", __r);
            return c;
        }
        public string At(int2 xy, Ptr<ushort> stylemask, Ptr<ulong> channels)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_at_yx(this, xy.Y, xy.X, stylemask, channels);
        public string AtYx(int y, int x, out ushort stylemask, out ulong channels)
        {
            stylemask = default;
            channels = default;
            fixed (ushort* stylemaskPtr = &stylemask)
            {
                fixed (ulong* channelsPtr = &channels)
                {
                    return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_at_yx(this, y, x, new Ptr<ushort>(stylemaskPtr), new Ptr<ulong>(channelsPtr));
                }
            }
        }
        public NcCell AtYxCell(int2 xy)
        {
            NcCell c = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_at_yx_cell(this, xy.Y, xy.X, new Ptr<NcCell>(&c));
            if (__r != 0) throw new NcResultException("ncplane_at_yx_cell", __r);
            return c;
        }
        public Bool8 AutogrowP()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_autogrow_p(this);
        public NcCell Base()
        {
            NcCell c = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_base(this, new Ptr<NcCell>(&c));
            if (__r != 0) throw new NcResultException("ncplane_base", __r);
            return c;
        }
        public uint BChannel()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_bchannel(this);
        public NcPlaneHandle Below()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_below(this);
        public uint BgAlpha()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_bg_alpha(this);
        public Bool8 BgDefaultP()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_bg_default_p(this);
        public uint BgRgb()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_bg_rgb(this);
        public uint BgRgb8(Ptr<uint> r, Ptr<uint> g, Ptr<uint> b)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_bg_rgb8(this, r, g, b);
        public uint BgRgb8(out uint r, out uint g, out uint b)
        {
            r = default;
            g = default;
            b = default;
            fixed (uint* rPtr = &r)
            {
                fixed (uint* gPtr = &g)
                {
                    fixed (uint* bPtr = &b)
                    {
                        return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_bg_rgb8(this, new Ptr<uint>(rPtr), new Ptr<uint>(gPtr), new Ptr<uint>(bPtr));
                    }
                }
            }
        }
        public void Box(Ptr<NcCell> ul, Ptr<NcCell> ur, Ptr<NcCell> ll, Ptr<NcCell> lr, Ptr<NcCell> hline, Ptr<NcCell> vline, uint2 stop, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_box(this, ul, ur, ll, lr, hline, vline, stop.Y, stop.X, ctlWord);
            if (__r != 0) throw new NcResultException("ncplane_box", __r);
        }
        public void BoxSized(Ptr<NcCell> ul, Ptr<NcCell> ur, Ptr<NcCell> ll, Ptr<NcCell> lr, Ptr<NcCell> hline, Ptr<NcCell> vline, uint2 stop, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_box_sized(this, ul, ur, ll, lr, hline, vline, stop.Y, stop.X, ctlWord);
            if (__r != 0) throw new NcResultException("ncplane_box_sized", __r);
        }
        public void CenterAbs(Ptr<int> y, Ptr<int> x)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_center_abs(this, y, x);
        public void CenterAbs(out int2 xy)
        {
            int xyY = default;
            int xyX = default;
            global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_center_abs(this, new Ptr<int>(&xyY), new Ptr<int>(&xyX));
            xy = new int2(xyX, xyY);
        }
        public ulong Channels()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_channels(this);
        public string Contents(int2 beg, uint2 len)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_contents(this, beg.Y, beg.X, len.Y, len.X);
        public NcPlaneHandle Create(Ptr<NcPlaneOptions> nopts)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_create(this, nopts);
        public NcPlaneHandle Create(out NcPlaneOptions nopts)
        {
            nopts = default;
            fixed (NcPlaneOptions* noptsPtr = &nopts)
            {
                return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_create(this, new Ptr<NcPlaneOptions>(noptsPtr));
            }
        }
        public void CursorMoveRel(int2 xy)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_cursor_move_rel(this, xy.Y, xy.X);
            if (__r != 0) throw new NcResultException("ncplane_cursor_move_rel", __r);
        }
        public void CursorMove(int2 xy)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_cursor_move_yx(this, xy.Y, xy.X);
            if (__r != 0) throw new NcResultException("ncplane_cursor_move_yx", __r);
        }
        public uint CursorX()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_cursor_x(this);
        public uint CursorY()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_cursor_y(this);
        public void CursorYx(Ptr<uint> y, Ptr<uint> x)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_cursor_yx(this, y, x);
        public void Cursor(out uint2 xy)
        {
            uint xyY = default;
            uint xyX = default;
            global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_cursor_yx(this, new Ptr<uint>(&xyY), new Ptr<uint>(&xyX));
            xy = new uint2(xyX, xyY);
        }
        public void DescendantP(NcPlaneHandle ancestor)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_descendant_p(this, ancestor);
            if (__r != 0) throw new NcResultException("ncplane_descendant_p", __r);
        }
        public void Destroy()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_destroy(this);
            if (__r != 0) throw new NcResultException("ncplane_destroy", __r);
        }
        public uint DimX()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_dim_x(this);
        public uint DimY()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_dim_y(this);
        public void DimYx(Ptr<uint> y, Ptr<uint> x)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_dim_yx(this, y, x);
        public void Dim(out uint2 xy)
        {
            uint xyY = default;
            uint xyX = default;
            global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_dim_yx(this, new Ptr<uint>(&xyY), new Ptr<uint>(&xyX));
            xy = new uint2(xyX, xyY);
        }
        public void DoubleBox(ushort styles, ulong channels, uint2 len, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_double_box(this, styles, channels, len.Y, len.X, ctlWord);
            if (__r != 0) throw new NcResultException("ncplane_double_box", __r);
        }
        public void DoubleBoxSized(ushort styles, ulong channels, uint2 len, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_double_box_sized(this, styles, channels, len.Y, len.X, ctlWord);
            if (__r != 0) throw new NcResultException("ncplane_double_box_sized", __r);
        }
        public NcPlaneHandle Dup(Ptr opaque)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_dup(this, opaque);
        public void Erase()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_erase(this);
        public void EraseRegion(int2 start, int2 len)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_erase_region(this, start.Y, start.X, len.Y, len.X);
            if (__r != 0) throw new NcResultException("ncplane_erase_region", __r);
        }
        public void FadeIn(Ptr<TimeSpec> ts, delegate* unmanaged[Cdecl]<NotCursesHandle, NcPlaneHandle, Ptr<TimeSpec>, Ptr, int> fader, Ptr currY)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_fadein(this, ts, fader, currY);
            if (__r != 0) throw new NcResultException("ncplane_fadein", __r);
        }
        public void FadeInIteration(NcFadectxHandle nctX, int iter, delegate* unmanaged[Cdecl]<NotCursesHandle, NcPlaneHandle, Ptr<TimeSpec>, Ptr, int> fader, Ptr currY)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_fadein_iteration(this, nctX, iter, fader, currY);
            if (__r != 0) throw new NcResultException("ncplane_fadein_iteration", __r);
        }
        public void FadeOut(Ptr<TimeSpec> ts, delegate* unmanaged[Cdecl]<NotCursesHandle, NcPlaneHandle, Ptr<TimeSpec>, Ptr, int> fader, Ptr currY)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_fadeout(this, ts, fader, currY);
            if (__r != 0) throw new NcResultException("ncplane_fadeout", __r);
        }
        public void FadeOutIteration(NcFadectxHandle nctX, int iter, delegate* unmanaged[Cdecl]<NotCursesHandle, NcPlaneHandle, Ptr<TimeSpec>, Ptr, int> fader, Ptr currY)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_fadeout_iteration(this, nctX, iter, fader, currY);
            if (__r != 0) throw new NcResultException("ncplane_fadeout_iteration", __r);
        }
        public void FamilyDestroy()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_family_destroy(this);
            if (__r != 0) throw new NcResultException("ncplane_family_destroy", __r);
        }
        public uint FChannel()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_fchannel(this);
        public uint FgAlpha()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_fg_alpha(this);
        public Bool8 FgDefaultP()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_fg_default_p(this);
        public uint FgRgb()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_fg_rgb(this);
        public uint FgRgb8(Ptr<uint> r, Ptr<uint> g, Ptr<uint> b)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_fg_rgb8(this, r, g, b);
        public uint FgRgb8(out uint r, out uint g, out uint b)
        {
            r = default;
            g = default;
            b = default;
            fixed (uint* rPtr = &r)
            {
                fixed (uint* gPtr = &g)
                {
                    fixed (uint* bPtr = &b)
                    {
                        return global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_fg_rgb8(this, new Ptr<uint>(rPtr), new Ptr<uint>(gPtr), new Ptr<uint>(bPtr));
                    }
                }
            }
        }
        public void Format(int2 xy, uint2 len, ushort stylemask)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_format(this, xy.Y, xy.X, len.Y, len.X, stylemask);
            if (__r != 0) throw new NcResultException("ncplane_format", __r);
        }
        public void Gradient(int2 xy, uint2 len, RefString8 egc, ushort styles, ulong ul, ulong ur, ulong ll, ulong lr)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_gradient(this, xy.Y, xy.X, len.Y, len.X, egc, styles, ul, ur, ll, lr);
            if (__r != 0) throw new NcResultException("ncplane_gradient", __r);
        }
        public void Gradient2x1(int2 xy, uint2 len, uint ul, uint ur, uint ll, uint lr)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_gradient2x1(this, xy.Y, xy.X, len.Y, len.X, ul, ur, ll, lr);
            if (__r != 0) throw new NcResultException("ncplane_gradient2x1", __r);
        }
        public void Greyscale()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_greyscale(this);
        public void HAlign(NcAlign align, int c)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_halign(this, align, c);
            if (__r != 0) throw new NcResultException("ncplane_halign", __r);
        }
        public void Hline(Ptr<NcCell> c, uint len)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_hline(this, c, len);
            if (__r != 0) throw new NcResultException("ncplane_hline", __r);
        }
        public void HlineInterp(Ptr<NcCell> c, uint len, ulong c1, ulong c2)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_hline_interp(this, c, len, c1, c2);
            if (__r != 0) throw new NcResultException("ncplane_hline_interp", __r);
        }
        public void Home()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_home(this);
        public void MergeDown(NcPlaneHandle dst, int2 begSrc, uint2 len, int2 dstXy)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_mergedown(this, dst, begSrc.Y, begSrc.X, len.Y, len.X, dstXy.Y, dstXy.X);
            if (__r != 0) throw new NcResultException("ncplane_mergedown", __r);
        }
        public void MergeDownSimple(NcPlaneHandle dst)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_mergedown_simple(this, dst);
            if (__r != 0) throw new NcResultException("ncplane_mergedown_simple", __r);
        }
        public void MoveAbove(NcPlaneHandle above)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_move_above(this, above);
            if (__r != 0) throw new NcResultException("ncplane_move_above", __r);
        }
        public void MoveBelow(NcPlaneHandle below)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_move_below(this, below);
            if (__r != 0) throw new NcResultException("ncplane_move_below", __r);
        }
        public void MoveBottom()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_move_bottom(this);
        public void MoveFamilyAbove(NcPlaneHandle targ)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_move_family_above(this, targ);
            if (__r != 0) throw new NcResultException("ncplane_move_family_above", __r);
        }
        public void MoveFamilyBelow(NcPlaneHandle targ)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_move_family_below(this, targ);
            if (__r != 0) throw new NcResultException("ncplane_move_family_below", __r);
        }
        public void MoveFamilyBottom()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_move_family_bottom(this);
        public void MoveFamilyTop()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_move_family_top(this);
        public void MoveRel(int2 xy)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_move_rel(this, xy.Y, xy.X);
            if (__r != 0) throw new NcResultException("ncplane_move_rel", __r);
        }
        public void MoveTop()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_move_top(this);
        public void Move(int2 xy)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_move_yx(this, xy.Y, xy.X);
            if (__r != 0) throw new NcResultException("ncplane_move_yx", __r);
        }
        public string Name()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_name(this);
        public NotCursesHandle NotCurses()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_notcurses(this);
        public NotCursesHandle NotCursesConst()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_notcurses_const(this);
        public void OffStyles(uint styleBits)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_off_styles(this, styleBits);
        public void OnStyles(uint styleBits)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_on_styles(this, styleBits);
        public NcPlaneHandle Parent()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_parent(this);
        public NcPlaneHandle ParentConst()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_parent_const(this);
        public void Perimeter(Ptr<NcCell> ul, Ptr<NcCell> ur, Ptr<NcCell> ll, Ptr<NcCell> lr, Ptr<NcCell> hline, Ptr<NcCell> vline, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_perimeter(this, ul, ur, ll, lr, hline, vline, ctlWord);
            if (__r != 0) throw new NcResultException("ncplane_perimeter", __r);
        }
        public void PerimeterDouble(ushort stylemask, ulong channels, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_perimeter_double(this, stylemask, channels, ctlWord);
            if (__r != 0) throw new NcResultException("ncplane_perimeter_double", __r);
        }
        public void PerimeterRounded(ushort stylemask, ulong channels, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_perimeter_rounded(this, stylemask, channels, ctlWord);
            if (__r != 0) throw new NcResultException("ncplane_perimeter_rounded", __r);
        }
        public void PixelGeom(Ptr<uint> pxY, Ptr<uint> pxX, Ptr<uint> cellDimY, Ptr<uint> cellDimX, Ptr<uint> maxBmapY, Ptr<uint> maxBmapX)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_pixel_geom(this, pxY, pxX, cellDimY, cellDimX, maxBmapY, maxBmapX);
        public void PixelGeom(out uint2 px, out uint2 cellDim, out uint2 maxBmap)
        {
            uint pxY = default;
            uint pxX = default;
            uint cellDimY = default;
            uint cellDimX = default;
            uint maxBmapY = default;
            uint maxBmapX = default;
            global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_pixel_geom(this, new Ptr<uint>(&pxY), new Ptr<uint>(&pxX), new Ptr<uint>(&cellDimY), new Ptr<uint>(&cellDimX), new Ptr<uint>(&maxBmapY), new Ptr<uint>(&maxBmapX));
            px = new uint2(pxX, pxY);
            cellDim = new uint2(cellDimX, cellDimY);
            maxBmap = new uint2(maxBmapX, maxBmapY);
        }
        public NcCell Polyfill(int2 xy)
        {
            NcCell c = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_polyfill_yx(this, xy.Y, xy.X, new Ptr<NcCell>(&c));
            if (__r != 0) throw new NcResultException("ncplane_polyfill_yx", __r);
            return c;
        }
        public void Printf(RefString8 format)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_printf(this, format);
            if (__r != 0) throw new NcResultException("ncplane_printf", __r);
        }
        public void PrintfAligned(int y, NcAlign align, RefString8 format)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_printf_aligned(this, y, align, format);
            if (__r != 0) throw new NcResultException("ncplane_printf_aligned", __r);
        }
        public void PrintfStained(RefString8 format)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_printf_stained(this, format);
            if (__r != 0) throw new NcResultException("ncplane_printf_stained", __r);
        }
        public void Printf(int2 xy, RefString8 format)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_printf_yx(this, xy.Y, xy.X, format);
            if (__r != 0) throw new NcResultException("ncplane_printf_yx", __r);
        }
        public void Pulse(Ptr<TimeSpec> ts, delegate* unmanaged[Cdecl]<NotCursesHandle, NcPlaneHandle, Ptr<TimeSpec>, Ptr, int> fader, Ptr currY)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_pulse(this, ts, fader, currY);
            if (__r != 0) throw new NcResultException("ncplane_pulse", __r);
        }
        public int Putc(Ptr<NcCell> c)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putc(this, c);
            if (__r < 0) throw new NcResultException("ncplane_putc", __r);
            return __r;
        }
        public int Putc(out NcCell c)
        {
            c = default;
            fixed (NcCell* cPtr = &c)
            {
                var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putc(this, new Ptr<NcCell>(cPtr));
                if (__r < 0) throw new NcResultException("ncplane_putc", __r);
                return __r;
            }
        }
        public int Putc(int2 xy, Ptr<NcCell> c)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putc_yx(this, xy.Y, xy.X, c);
            if (__r < 0) throw new NcResultException("ncplane_putc_yx", __r);
            return __r;
        }
        public int PutcYx(int y, int x, out NcCell c)
        {
            c = default;
            fixed (NcCell* cPtr = &c)
            {
                var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putc_yx(this, y, x, new Ptr<NcCell>(cPtr));
                if (__r < 0) throw new NcResultException("ncplane_putc_yx", __r);
                return __r;
            }
        }
        public int PutChar(byte c)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putchar(this, c);
            if (__r < 0) throw new NcResultException("ncplane_putchar", __r);
            return __r;
        }
        public int PutCharStained(byte c)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putchar_stained(this, c);
            if (__r < 0) throw new NcResultException("ncplane_putchar_stained", __r);
            return __r;
        }
        public int PutChar(int2 xy, byte c)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putchar_yx(this, xy.Y, xy.X, c);
            if (__r < 0) throw new NcResultException("ncplane_putchar_yx", __r);
            return __r;
        }
        public int PutEgc(RefString8 gclust, Ptr<ByteSize64> sBytes)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putegc(this, gclust, sBytes);
            if (__r < 0) throw new NcResultException("ncplane_putegc", __r);
            return __r;
        }
        public int PutEgc(RefString8 gclust, out ByteSize64 sBytes)
        {
            sBytes = default;
            fixed (ByteSize64* sBytesPtr = &sBytes)
            {
                var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putegc(this, gclust, new Ptr<ByteSize64>(sBytesPtr));
                if (__r < 0) throw new NcResultException("ncplane_putegc", __r);
                return __r;
            }
        }
        public int PutEgcStained(RefString8 gclust, Ptr<ByteSize64> sBytes)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putegc_stained(this, gclust, sBytes);
            if (__r < 0) throw new NcResultException("ncplane_putegc_stained", __r);
            return __r;
        }
        public int PutEgcStained(RefString8 gclust, out ByteSize64 sBytes)
        {
            sBytes = default;
            fixed (ByteSize64* sBytesPtr = &sBytes)
            {
                var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putegc_stained(this, gclust, new Ptr<ByteSize64>(sBytesPtr));
                if (__r < 0) throw new NcResultException("ncplane_putegc_stained", __r);
                return __r;
            }
        }
        public int PutEgc(int2 xy, RefString8 gclust, Ptr<ByteSize64> sBytes)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putegc_yx(this, xy.Y, xy.X, gclust, sBytes);
            if (__r < 0) throw new NcResultException("ncplane_putegc_yx", __r);
            return __r;
        }
        public int PutEgcYx(int y, int x, RefString8 gclust, out ByteSize64 sBytes)
        {
            sBytes = default;
            fixed (ByteSize64* sBytesPtr = &sBytes)
            {
                var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putegc_yx(this, y, x, gclust, new Ptr<ByteSize64>(sBytesPtr));
                if (__r < 0) throw new NcResultException("ncplane_putegc_yx", __r);
                return __r;
            }
        }
        public int PutNStr(ByteSize64 s, RefString8 gclustarr)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putnstr(this, s, gclustarr);
            if (__r < 0) throw new NcResultException("ncplane_putnstr", __r);
            return __r;
        }
        public int PutNStrAligned(int y, NcAlign align, ByteSize64 s, RefString8 str)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putnstr_aligned(this, y, align, s, str);
            if (__r < 0) throw new NcResultException("ncplane_putnstr_aligned", __r);
            return __r;
        }
        public int PutNStr(int2 xy, ByteSize64 s, RefString8 gclusters)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putnstr_yx(this, xy.Y, xy.X, s, gclusters);
            if (__r < 0) throw new NcResultException("ncplane_putnstr_yx", __r);
            return __r;
        }
        public int PutStr(RefString8 gclustarr)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putstr(this, gclustarr);
            if (__r < 0) throw new NcResultException("ncplane_putstr", __r);
            return __r;
        }
        public int PutStrAligned(int y, NcAlign align, RefString8 s)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putstr_aligned(this, y, align, s);
            if (__r < 0) throw new NcResultException("ncplane_putstr_aligned", __r);
            return __r;
        }
        public int PutStrStained(RefString8 gclusters)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putstr_stained(this, gclusters);
            if (__r < 0) throw new NcResultException("ncplane_putstr_stained", __r);
            return __r;
        }
        public int PutStr(int2 xy, RefString8 gclusters)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_putstr_yx(this, xy.Y, xy.X, gclusters);
            if (__r < 0) throw new NcResultException("ncplane_putstr_yx", __r);
            return __r;
        }
        public int PutText(int y, NcAlign align, RefString8 text, Ptr<ByteSize64> bytes)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_puttext(this, y, align, text, bytes);
            if (__r < 0) throw new NcResultException("ncplane_puttext", __r);
            return __r;
        }
        public int PutText(int y, NcAlign align, RefString8 text, out ByteSize64 bytes)
        {
            bytes = default;
            fixed (ByteSize64* bytesPtr = &bytes)
            {
                var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_puttext(this, y, align, text, new Ptr<ByteSize64>(bytesPtr));
                if (__r < 0) throw new NcResultException("ncplane_puttext", __r);
                return __r;
            }
        }
        public int PutUtf32(int2 xy, uint u)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_pututf32_yx(this, xy.Y, xy.X, u);
            if (__r < 0) throw new NcResultException("ncplane_pututf32_yx", __r);
            return __r;
        }
        public void QrCode(Ptr<uint> yMaX, Ptr<uint> xMaX, Ptr data, ByteSize64 len)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_qrcode(this, yMaX, xMaX, data, len);
            if (__r != 0) throw new NcResultException("ncplane_qrcode", __r);
        }
        public NcPlaneHandle Reparent(NcPlaneHandle newparent)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_reparent(this, newparent);
        public NcPlaneHandle ReparentFamily(NcPlaneHandle newparent)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_reparent_family(this, newparent);
        public void Resize(int2 keep, uint2 keepLen, int2 off, uint2 len)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_resize(this, keep.Y, keep.X, keepLen.Y, keepLen.X, off.Y, off.X, len.Y, len.X);
            if (__r != 0) throw new NcResultException("ncplane_resize", __r);
        }
        public void ResizeMarginalized()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_resize_marginalized(this);
            if (__r != 0) throw new NcResultException("ncplane_resize_marginalized", __r);
        }
        public void ResizeMaximize()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_resize_maximize(this);
            if (__r != 0) throw new NcResultException("ncplane_resize_maximize", __r);
        }
        public void ResizePlacewithin()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_resize_placewithin(this);
            if (__r != 0) throw new NcResultException("ncplane_resize_placewithin", __r);
        }
        public void ResizeRealign()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_resize_realign(this);
            if (__r != 0) throw new NcResultException("ncplane_resize_realign", __r);
        }
        public void ResizeSimple(uint2 len)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_resize_simple(this, len.Y, len.X);
            if (__r != 0) throw new NcResultException("ncplane_resize_simple", __r);
        }
        public delegate* unmanaged[Cdecl]<NcPlaneHandle, NcPlaneHandle, int> ResizeCb(NcPlaneHandle n)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_resizecb(this, n);
        public void RotateCcw()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_rotate_ccw(this);
            if (__r != 0) throw new NcResultException("ncplane_rotate_ccw", __r);
        }
        public void RotateCw()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_rotate_cw(this);
            if (__r != 0) throw new NcResultException("ncplane_rotate_cw", __r);
        }
        public void RoundedBox(ushort styles, ulong channels, uint2 stop, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_rounded_box(this, styles, channels, stop.Y, stop.X, ctlWord);
            if (__r != 0) throw new NcResultException("ncplane_rounded_box", __r);
        }
        public void RoundedBoxSized(ushort styles, ulong channels, uint2 len, uint ctlWord)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_rounded_box_sized(this, styles, channels, len.Y, len.X, ctlWord);
            if (__r != 0) throw new NcResultException("ncplane_rounded_box_sized", __r);
        }
        public Bool8 ScrollingP()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_scrolling_p(this);
        public void ScrollUp(int r)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_scrollup(this, r);
            if (__r != 0) throw new NcResultException("ncplane_scrollup", __r);
        }
        public void ScrollUpChild(NcPlaneHandle child)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_scrollup_child(this, child);
            if (__r != 0) throw new NcResultException("ncplane_scrollup_child", __r);
        }
        public Bool8 SetAutogrow(uint growP)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_autogrow(this, growP);
        public void SetBase(RefString8 egc, ushort stylemask, ulong channels)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_base(this, egc, stylemask, channels);
            if (__r != 0) throw new NcResultException("ncplane_set_base", __r);
        }
        public NcCell SetBaseCell()
        {
            NcCell c = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_base_cell(this, new Ptr<NcCell>(&c));
            if (__r != 0) throw new NcResultException("ncplane_set_base_cell", __r);
            return c;
        }
        public ulong SetBChannel(uint channel)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_bchannel(this, channel);
        public void SetBgAlpha(int alpha)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_bg_alpha(this, alpha);
            if (__r != 0) throw new NcResultException("ncplane_set_bg_alpha", __r);
        }
        public void SetBgDefault()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_bg_default(this);
        public void SetBgPalindex(uint idx)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_bg_palindex(this, idx);
            if (__r != 0) throw new NcResultException("ncplane_set_bg_palindex", __r);
        }
        public void SetBgRgb(uint channel)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_bg_rgb(this, channel);
            if (__r != 0) throw new NcResultException("ncplane_set_bg_rgb", __r);
        }
        public void SetBgRgb8(uint r, uint g, uint b)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_bg_rgb8(this, r, g, b);
            if (__r != 0) throw new NcResultException("ncplane_set_bg_rgb8", __r);
        }
        public void SetBgRgb8Clipped(int r, int g, int b)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_bg_rgb8_clipped(this, r, g, b);
        public void SetChannels(ulong channels)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_channels(this, channels);
        public ulong SetFChannel(uint channel)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_fchannel(this, channel);
        public void SetFgAlpha(int alpha)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_fg_alpha(this, alpha);
            if (__r != 0) throw new NcResultException("ncplane_set_fg_alpha", __r);
        }
        public void SetFgDefault()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_fg_default(this);
        public void SetFgPalindex(uint idx)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_fg_palindex(this, idx);
            if (__r != 0) throw new NcResultException("ncplane_set_fg_palindex", __r);
        }
        public void SetFgRgb(uint channel)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_fg_rgb(this, channel);
            if (__r != 0) throw new NcResultException("ncplane_set_fg_rgb", __r);
        }
        public void SetFgRgb8(uint r, uint g, uint b)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_fg_rgb8(this, r, g, b);
            if (__r != 0) throw new NcResultException("ncplane_set_fg_rgb8", __r);
        }
        public void SetFgRgb8Clipped(int r, int g, int b)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_fg_rgb8_clipped(this, r, g, b);
        public void SetName(RefString8 name)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_name(this, name);
            if (__r != 0) throw new NcResultException("ncplane_set_name", __r);
        }
        public void SetResizeCb(delegate* unmanaged[Cdecl]<NcPlaneHandle, int> resizeCb)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_resizecb(this, resizeCb);
        public Bool8 SetScrolling(uint scrollP)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_scrolling(this, scrollP);
        public void SetStyles(uint styleBits)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_styles(this, styleBits);
        public Ptr SetUserPtr(Ptr opaque)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_set_userptr(this, opaque);
        public void Stain(int2 xy, uint2 len, ulong ul, ulong ur, ulong ll, ulong lr)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_stain(this, xy.Y, xy.X, len.Y, len.X, ul, ur, ll, lr);
            if (__r != 0) throw new NcResultException("ncplane_stain", __r);
        }
        public ushort Styles()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_styles(this);
        public void Translate(NcPlaneHandle dst, Ptr<int> y, Ptr<int> x)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_translate(this, dst, y, x);
        public void Translate(NcPlaneHandle dst, out int2 xy)
        {
            int xyY = default;
            int xyX = default;
            global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_translate(this, dst, new Ptr<int>(&xyY), new Ptr<int>(&xyX));
            xy = new int2(xyX, xyY);
        }
        public Bool8 TranslateAbs(Ptr<int> y, Ptr<int> x)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_translate_abs(this, y, x);
        public Bool8 TranslateAbs(out int2 xy)
        {
            int xyY = default;
            int xyX = default;
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_translate_abs(this, new Ptr<int>(&xyY), new Ptr<int>(&xyX));
            xy = new int2(xyX, xyY);
            return __r;
        }
        public Ptr UserPtr()
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_userptr(this);
        public void VAlign(NcAlign align, int r)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_valign(this, align, r);
            if (__r != 0) throw new NcResultException("ncplane_valign", __r);
        }
        public void Vline(Ptr<NcCell> c, uint len)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_vline(this, c, len);
            if (__r != 0) throw new NcResultException("ncplane_vline", __r);
        }
        public void VlineInterp(Ptr<NcCell> c, uint len, ulong c1, ulong c2)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_vline_interp(this, c, len, c1, c2);
            if (__r != 0) throw new NcResultException("ncplane_vline_interp", __r);
        }
        public void VPrintf(RefString8 format, RefString8 ap)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_vprintf(this, format, ap);
            if (__r != 0) throw new NcResultException("ncplane_vprintf", __r);
        }
        public void VPrintfAligned(int y, NcAlign align, RefString8 format, RefString8 ap)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_vprintf_aligned(this, y, align, format, ap);
            if (__r != 0) throw new NcResultException("ncplane_vprintf_aligned", __r);
        }
        public void VPrintfStained(RefString8 format, RefString8 ap)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_vprintf_stained(this, format, ap);
            if (__r != 0) throw new NcResultException("ncplane_vprintf_stained", __r);
        }
        public void VPrintf(int2 xy, RefString8 format, RefString8 ap)
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_vprintf_yx(this, xy.Y, xy.X, format, ap);
            if (__r != 0) throw new NcResultException("ncplane_vprintf_yx", __r);
        }
        public void X()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_x(this);
            if (__r != 0) throw new NcResultException("ncplane_x", __r);
        }
        public void Y()
        {
            var __r = global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_y(this);
            if (__r != 0) throw new NcResultException("ncplane_y", __r);
        }
        public void Yx(Ptr<int> y, Ptr<int> x)
         => global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_yx(this, y, x);
        public void Yx(out int2 xy)
        {
            int xyY = default;
            int xyX = default;
            global::Brutal.NotCursesApi.NotCurses.PInvoke.ncplane_yx(this, new Ptr<int>(&xyY), new Ptr<int>(&xyX));
            xy = new int2(xyX, xyY);
        }
    }
    public static unsafe partial class StringExtensions
    {
        public static void Gradient(this NcPlaneHandle self, int2 xy, uint2 len, string egc, ushort styles, ulong ul, ulong ur, ulong ll, ulong lr)
        {
            using var egcBuf = new ScratchBuffer(egc, stackalloc byte[256]);
            self.Gradient(xy, len, egcBuf.Bytes, styles, ul, ur, ll, lr);
        }
        public static void Printf(this NcPlaneHandle self, string format)
        {
            using var formatBuf = new ScratchBuffer(format, stackalloc byte[256]);
            self.Printf(formatBuf.Bytes);
        }
        public static void PrintfAligned(this NcPlaneHandle self, int y, NcAlign align, string format)
        {
            using var formatBuf = new ScratchBuffer(format, stackalloc byte[256]);
            self.PrintfAligned(y, align, formatBuf.Bytes);
        }
        public static void PrintfStained(this NcPlaneHandle self, string format)
        {
            using var formatBuf = new ScratchBuffer(format, stackalloc byte[256]);
            self.PrintfStained(formatBuf.Bytes);
        }
        public static void Printf(this NcPlaneHandle self, int2 xy, string format)
        {
            using var formatBuf = new ScratchBuffer(format, stackalloc byte[256]);
            self.Printf(xy, formatBuf.Bytes);
        }
        public static int PutEgc(this NcPlaneHandle self, string gclust, Ptr<ByteSize64> sBytes)
        {
            using var gclustBuf = new ScratchBuffer(gclust, stackalloc byte[256]);
            return self.PutEgc(gclustBuf.Bytes, sBytes);
        }
        public static int PutEgcStained(this NcPlaneHandle self, string gclust, Ptr<ByteSize64> sBytes)
        {
            using var gclustBuf = new ScratchBuffer(gclust, stackalloc byte[256]);
            return self.PutEgcStained(gclustBuf.Bytes, sBytes);
        }
        public static int PutEgc(this NcPlaneHandle self, int2 xy, string gclust, Ptr<ByteSize64> sBytes)
        {
            using var gclustBuf = new ScratchBuffer(gclust, stackalloc byte[256]);
            return self.PutEgc(xy, gclustBuf.Bytes, sBytes);
        }
        public static int PutNStr(this NcPlaneHandle self, ByteSize64 s, string gclustarr)
        {
            using var gclustarrBuf = new ScratchBuffer(gclustarr, stackalloc byte[256]);
            return self.PutNStr(s, gclustarrBuf.Bytes);
        }
        public static int PutNStrAligned(this NcPlaneHandle self, int y, NcAlign align, ByteSize64 s, string str)
        {
            using var strBuf = new ScratchBuffer(str, stackalloc byte[256]);
            return self.PutNStrAligned(y, align, s, strBuf.Bytes);
        }
        public static int PutNStr(this NcPlaneHandle self, int2 xy, ByteSize64 s, string gclusters)
        {
            using var gclustersBuf = new ScratchBuffer(gclusters, stackalloc byte[256]);
            return self.PutNStr(xy, s, gclustersBuf.Bytes);
        }
        public static int PutStr(this NcPlaneHandle self, string gclustarr)
        {
            using var gclustarrBuf = new ScratchBuffer(gclustarr, stackalloc byte[256]);
            return self.PutStr(gclustarrBuf.Bytes);
        }
        public static int PutStrAligned(this NcPlaneHandle self, int y, NcAlign align, string s)
        {
            using var sBuf = new ScratchBuffer(s, stackalloc byte[256]);
            return self.PutStrAligned(y, align, sBuf.Bytes);
        }
        public static int PutStrStained(this NcPlaneHandle self, string gclusters)
        {
            using var gclustersBuf = new ScratchBuffer(gclusters, stackalloc byte[256]);
            return self.PutStrStained(gclustersBuf.Bytes);
        }
        public static int PutStr(this NcPlaneHandle self, int2 xy, string gclusters)
        {
            using var gclustersBuf = new ScratchBuffer(gclusters, stackalloc byte[256]);
            return self.PutStr(xy, gclustersBuf.Bytes);
        }
        public static int PutText(this NcPlaneHandle self, int y, NcAlign align, string text, Ptr<ByteSize64> bytes)
        {
            using var textBuf = new ScratchBuffer(text, stackalloc byte[256]);
            return self.PutText(y, align, textBuf.Bytes, bytes);
        }
        public static void SetBase(this NcPlaneHandle self, string egc, ushort stylemask, ulong channels)
        {
            using var egcBuf = new ScratchBuffer(egc, stackalloc byte[256]);
            self.SetBase(egcBuf.Bytes, stylemask, channels);
        }
        public static void SetName(this NcPlaneHandle self, string name)
        {
            using var nameBuf = new ScratchBuffer(name, stackalloc byte[256]);
            self.SetName(nameBuf.Bytes);
        }
        public static void VPrintf(this NcPlaneHandle self, string format, string ap)
        {
            using var formatBuf = new ScratchBuffer(format, stackalloc byte[256]);
            using var apBuf = new ScratchBuffer(ap, stackalloc byte[256]);
            self.VPrintf(formatBuf.Bytes, apBuf.Bytes);
        }
        public static void VPrintfAligned(this NcPlaneHandle self, int y, NcAlign align, string format, string ap)
        {
            using var formatBuf = new ScratchBuffer(format, stackalloc byte[256]);
            using var apBuf = new ScratchBuffer(ap, stackalloc byte[256]);
            self.VPrintfAligned(y, align, formatBuf.Bytes, apBuf.Bytes);
        }
        public static void VPrintfStained(this NcPlaneHandle self, string format, string ap)
        {
            using var formatBuf = new ScratchBuffer(format, stackalloc byte[256]);
            using var apBuf = new ScratchBuffer(ap, stackalloc byte[256]);
            self.VPrintfStained(formatBuf.Bytes, apBuf.Bytes);
        }
        public static void VPrintf(this NcPlaneHandle self, int2 xy, string format, string ap)
        {
            using var formatBuf = new ScratchBuffer(format, stackalloc byte[256]);
            using var apBuf = new ScratchBuffer(ap, stackalloc byte[256]);
            self.VPrintf(xy, formatBuf.Bytes, apBuf.Bytes);
        }
    }
}
