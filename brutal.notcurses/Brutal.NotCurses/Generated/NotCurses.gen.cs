using System.Runtime.InteropServices;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
using Brutal.Strings;
namespace Brutal.NotCursesApi
{
    public static partial class NotCurses
    {
        public static unsafe partial class PInvoke
        {
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nckey_synthesized_p(uint w);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nckey_pua_p(uint w);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nckey_supppuaa_p(uint w);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nckey_supppuab_p(uint w);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string notcurses_version();
            [LibraryImport("notcurses-core")]
            public static partial void notcurses_version_components(Ptr<int> major, Ptr<int> minor, Ptr<int> patch, Ptr<int> tweak);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannel_alpha(uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncchannel_set_alpha(Ptr<uint> channel, uint alpha);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncchannel_default_p(uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannel_set_default(Ptr<uint> channel);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncchannel_palindex_p(uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannel_palindex(uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncchannel_set_palindex(Ptr<uint> channel, uint idx);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncchannel_rgb_p(uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannel_r(uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannel_g(uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannel_b(uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannel_rgb(uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannel_rgb8(uint channel, Ptr<uint> r, Ptr<uint> g, Ptr<uint> b);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncchannel_set_rgb8(Ptr<uint> channel, uint r, uint g, uint b);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncchannel_set(Ptr<uint> channel, uint rgb);
            [LibraryImport("notcurses-ffi")]
            public static partial void ncchannel_set_rgb8_clipped(Ptr<uint> channel, int r, int g, int b);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannels_bchannel(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannels_fchannel(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong ncchannels_channels(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncchannels_bg_rgb_p(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncchannels_fg_rgb_p(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannels_bg_alpha(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong ncchannels_set_bchannel(Ptr<ulong> channels, uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong ncchannels_set_fchannel(Ptr<ulong> channels, uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong ncchannels_set_channels(Ptr<ulong> dst, ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncchannels_set_bg_alpha(Ptr<ulong> channels, uint alpha);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannels_fg_alpha(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncchannels_set_fg_alpha(Ptr<ulong> channels, uint alpha);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong ncchannels_reverse(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong ncchannels_combine(uint fchan, uint bchan);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannels_fg_palindex(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannels_bg_palindex(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannels_fg_rgb(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannels_bg_rgb(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannels_fg_rgb8(ulong channels, Ptr<uint> r, Ptr<uint> g, Ptr<uint> b);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncchannels_bg_rgb8(ulong channels, Ptr<uint> r, Ptr<uint> g, Ptr<uint> b);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncchannels_set_fg_rgb8(Ptr<ulong> channels, uint r, uint g, uint b);
            [LibraryImport("notcurses-ffi")]
            public static partial void ncchannels_set_fg_rgb8_clipped(Ptr<ulong> channels, int r, int g, int b);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncchannels_set_fg_palindex(Ptr<ulong> channels, uint idx);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncchannels_set_fg_rgb(Ptr<ulong> channels, uint rgb);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncchannels_set_bg_rgb8(Ptr<ulong> channels, uint r, uint g, uint b);
            [LibraryImport("notcurses-ffi")]
            public static partial void ncchannels_set_bg_rgb8_clipped(Ptr<ulong> channels, int r, int g, int b);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncchannels_set_bg_palindex(Ptr<ulong> channels, uint idx);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncchannels_set_bg_rgb(Ptr<ulong> channels, uint rgb);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncchannels_fg_default_p(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncchannels_fg_palindex_p(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncchannels_bg_default_p(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncchannels_bg_palindex_p(ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong ncchannels_set_fg_default(Ptr<ulong> channels);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong ncchannels_set_bg_default(Ptr<ulong> channels);
            [LibraryImport("notcurses-core")]
            public static partial int ncstrwidth(RefString8 egcs, Ptr<int> validbytes, Ptr<int> validwidth);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_ucs32_to_utf8(Ptr<uint> ucs32, uint ucs32count, RefString8 resultbuf, ByteSize64 buflen);
            [LibraryImport("notcurses-ffi")]
            public static partial void nccell_init(Ptr<NcCell> c);
            [LibraryImport("notcurses-core")]
            public static partial int nccell_load(NcPlaneHandle n, Ptr<NcCell> c, RefString8 gcluster);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccell_prime(NcPlaneHandle n, Ptr<NcCell> c, RefString8 gcluster, ushort stylemask, ulong channels);
            [LibraryImport("notcurses-core")]
            public static partial int nccell_duplicate(NcPlaneHandle n, Ptr<NcCell> targ, Ptr<NcCell> c);
            [LibraryImport("notcurses-core")]
            public static partial void nccell_release(NcPlaneHandle n, Ptr<NcCell> c);
            [LibraryImport("notcurses-ffi")]
            public static partial void nccell_set_styles(Ptr<NcCell> c, uint styleBits);
            [LibraryImport("notcurses-ffi")]
            public static partial ushort nccell_styles(Ptr<NcCell> c);
            [LibraryImport("notcurses-ffi")]
            public static partial void nccell_on_styles(Ptr<NcCell> c, uint styleBits);
            [LibraryImport("notcurses-ffi")]
            public static partial void nccell_off_styles(Ptr<NcCell> c, uint styleBits);
            [LibraryImport("notcurses-ffi")]
            public static partial void nccell_set_fg_default(Ptr<NcCell> c);
            [LibraryImport("notcurses-ffi")]
            public static partial void nccell_set_bg_default(Ptr<NcCell> c);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccell_set_fg_alpha(Ptr<NcCell> c, uint alpha);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccell_set_bg_alpha(Ptr<NcCell> c, uint alpha);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong nccell_set_bchannel(Ptr<NcCell> c, uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong nccell_set_fchannel(Ptr<NcCell> c, uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong nccell_set_channels(Ptr<NcCell> c, ulong channels);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nccell_double_wide_p(Ptr<NcCell> c);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nccell_wide_right_p(Ptr<NcCell> c);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nccell_wide_left_p(Ptr<NcCell> c);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string nccell_extended_gcluster(NcPlaneHandle n, Ptr<NcCell> c);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong nccell_channels(Ptr<NcCell> c);
            [LibraryImport("notcurses-ffi")]
            public static partial uint nccell_bchannel(Ptr<NcCell> cl);
            [LibraryImport("notcurses-ffi")]
            public static partial uint nccell_fchannel(Ptr<NcCell> cl);
            [LibraryImport("notcurses-ffi")]
            public static partial uint nccell_cols(Ptr<NcCell> c);
            [LibraryImport("notcurses-ffi", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string nccell_strdup(NcPlaneHandle n, Ptr<NcCell> c);
            [LibraryImport("notcurses-ffi", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string nccell_extract(NcPlaneHandle n, Ptr<NcCell> c, Ptr<ushort> stylemask, Ptr<ulong> channels);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nccellcmp(NcPlaneHandle n1, Ptr<NcCell> c1, NcPlaneHandle n2, Ptr<NcCell> c2);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccell_load_char(NcPlaneHandle n, Ptr<NcCell> c, byte ch);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccell_load_egc32(NcPlaneHandle n, Ptr<NcCell> c, uint egc);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccell_load_ucs32(NcPlaneHandle n, Ptr<NcCell> c, uint u);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_lex_margins(RefString8 op, Ptr<NotCursesOptions> opts);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_lex_blitter(RefString8 op, Ptr<NcBlitter> blitter);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string notcurses_str_blitter(NcBlitter blitter);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_lex_scalemode(RefString8 op, Ptr<NcScale> scalemode);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string notcurses_str_scalemode(NcScale scalemode);
            [LibraryImport("notcurses-core")]
            public static partial NotCursesHandle notcurses_core_init(Ptr<NotCursesOptions> opts, Ptr fp);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_stop(NotCursesHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_enter_alternate_screen(NotCursesHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_leave_alternate_screen(NotCursesHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle notcurses_stdplane(NotCursesHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle notcurses_stdplane_const(NotCursesHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncpile_top(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncpile_bottom(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial NcPlaneHandle notcurses_top(NotCursesHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial NcPlaneHandle notcurses_bottom(NotCursesHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncpile_render(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncpile_rasterize(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial int notcurses_render(NotCursesHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial int ncpile_render_to_buffer(NcPlaneHandle p, Ptr<Ptr<byte>> buf, Ptr<ByteSize64> buflen);
            [LibraryImport("notcurses-core")]
            public static partial int ncpile_render_to_file(NcPlaneHandle p, Ptr fp);
            [LibraryImport("notcurses-core")]
            public static partial void notcurses_drop_planes(NotCursesHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nckey_mouse_p(uint r);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncinput_shift_p(Ptr<NcInput> n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncinput_ctrl_p(Ptr<NcInput> n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncinput_alt_p(Ptr<NcInput> n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncinput_meta_p(Ptr<NcInput> n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncinput_super_p(Ptr<NcInput> n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncinput_hyper_p(Ptr<NcInput> n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncinput_capslock_p(Ptr<NcInput> n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncinput_numlock_p(Ptr<NcInput> n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncinput_equal_p(Ptr<NcInput> n1, Ptr<NcInput> n2);
            [LibraryImport("notcurses-core")]
            public static partial uint notcurses_get(NotCursesHandle n, Ptr<TimeSpec> ts, Ptr<NcInput> ni);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_getvec(NotCursesHandle n, Ptr<TimeSpec> ts, Ptr<NcInput> ni, int vCount);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_inputready_fd(NotCursesHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial uint notcurses_get_nblock(NotCursesHandle n, Ptr<NcInput> ni);
            [LibraryImport("notcurses-ffi")]
            public static partial uint notcurses_get_blocking(NotCursesHandle n, Ptr<NcInput> ni);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncinput_nomod_p(Ptr<NcInput> ni);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_mice_enable(NotCursesHandle n, uint eventMask);
            [LibraryImport("notcurses-ffi")]
            public static partial int notcurses_mice_disable(NotCursesHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_linesigs_disable(NotCursesHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_linesigs_enable(NotCursesHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_refresh(NotCursesHandle n, Ptr<uint> y, Ptr<uint> x);
            [LibraryImport("notcurses-core")]
            public static partial NotCursesHandle ncplane_notcurses(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NotCursesHandle ncplane_notcurses_const(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_dim_yx(NcPlaneHandle n, Ptr<uint> y, Ptr<uint> x);
            [LibraryImport("notcurses-ffi")]
            public static partial NcPlaneHandle notcurses_stddim_yx(NotCursesHandle nc, Ptr<uint> y, Ptr<uint> x);
            [LibraryImport("notcurses-ffi")]
            public static partial NcPlaneHandle notcurses_stddim_yx_const(NotCursesHandle nc, Ptr<uint> y, Ptr<uint> x);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncplane_dim_y(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncplane_dim_x(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_pixel_geom(NcPlaneHandle n, Ptr<uint> pxY, Ptr<uint> pxX, Ptr<uint> cellDimY, Ptr<uint> cellDimX, Ptr<uint> maxBmapY, Ptr<uint> maxBmapX);
            [LibraryImport("notcurses-ffi")]
            public static partial void notcurses_term_dim_yx(NotCursesHandle n, Ptr<uint> rows, Ptr<uint> cols);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string notcurses_at_yx(NotCursesHandle nc, uint yOff, uint xOff, Ptr<ushort> stylemask, Ptr<ulong> channels);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncplane_create(NcPlaneHandle n, Ptr<NcPlaneOptions> nopts);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncpile_create(NotCursesHandle nc, Ptr<NcPlaneOptions> nopts);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_resize_maximize(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_resize_marginalized(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_resize_realign(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_resize_placewithin(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_set_resizecb(NcPlaneHandle n, delegate* unmanaged[Cdecl]<NcPlaneHandle, int> resizeCb);
            [LibraryImport("notcurses-core")]
            public static partial delegate* unmanaged[Cdecl]<NcPlaneHandle, NcPlaneHandle, int> ncplane_resizecb(NcPlaneHandle arg0, NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_set_name(NcPlaneHandle n, RefString8 name);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncplane_name(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncplane_reparent(NcPlaneHandle n, NcPlaneHandle newparent);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncplane_reparent_family(NcPlaneHandle n, NcPlaneHandle newparent);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncplane_dup(NcPlaneHandle n, Ptr opaque);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_translate(NcPlaneHandle src, NcPlaneHandle dst, Ptr<int> y, Ptr<int> x);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 ncplane_translate_abs(NcPlaneHandle n, Ptr<int> y, Ptr<int> x);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 ncplane_set_scrolling(NcPlaneHandle n, uint scrollP);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 ncplane_scrolling_p(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 ncplane_set_autogrow(NcPlaneHandle n, uint growP);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 ncplane_autogrow_p(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial Ptr<NcPalette> ncpalette_new(NotCursesHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial int ncpalette_use(NotCursesHandle nc, Ptr<NcPalette> p);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncpalette_set_rgb8(Ptr<NcPalette> p, int idx, uint r, uint g, uint b);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncpalette_set(Ptr<NcPalette> p, int idx, uint rgb);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncpalette_get(Ptr<NcPalette> p, int idx, Ptr<uint> palent);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncpalette_get_rgb8(Ptr<NcPalette> p, int idx, Ptr<uint> r, Ptr<uint> g, Ptr<uint> b);
            [LibraryImport("notcurses-core")]
            public static partial void ncpalette_free(Ptr<NcPalette> p);
            [LibraryImport("notcurses-core")]
            public static partial ushort notcurses_supported_styles(NotCursesHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial uint notcurses_palette_size(NotCursesHandle nc);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string notcurses_detected_terminal(NotCursesHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial Ptr<NcCapabilities> notcurses_capabilities(NotCursesHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcPixelImpl notcurses_check_pixel_support(NotCursesHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nccapability_canchangecolor(Ptr<NcCapabilities> caps);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 notcurses_cantruecolor(NotCursesHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 notcurses_canchangecolor(NotCursesHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 notcurses_canfade(NotCursesHandle n);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 notcurses_canopen_images(NotCursesHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 notcurses_canopen_videos(NotCursesHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 notcurses_canutf8(NotCursesHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 notcurses_canhalfblock(NotCursesHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 notcurses_canquadrant(NotCursesHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 notcurses_cansextant(NotCursesHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 notcurses_canoctant(NotCursesHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 notcurses_canbraille(NotCursesHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 notcurses_canpixel(NotCursesHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial Ptr<NcStats> notcurses_stats_alloc(NotCursesHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial void notcurses_stats(NotCursesHandle nc, Ptr<NcStats> stats);
            [LibraryImport("notcurses-core")]
            public static partial void notcurses_stats_reset(NotCursesHandle nc, Ptr<NcStats> stats);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_resize(NcPlaneHandle n, int keepY, int keepX, uint keepLenY, uint keepLenX, int yOff, int xOff, uint yLen, uint xLen);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_resize_simple(NcPlaneHandle n, uint yLen, uint xLen);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_destroy(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_set_base_cell(NcPlaneHandle n, Ptr<NcCell> c);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_set_base(NcPlaneHandle n, RefString8 egc, ushort stylemask, ulong channels);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_base(NcPlaneHandle n, Ptr<NcCell> c);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_yx(NcPlaneHandle n, Ptr<int> y, Ptr<int> x);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_y(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_x(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_move_yx(NcPlaneHandle n, int y, int x);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_move_rel(NcPlaneHandle n, int y, int x);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_abs_yx(NcPlaneHandle n, Ptr<int> y, Ptr<int> x);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_abs_y(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_abs_x(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncplane_parent(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncplane_parent_const(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_descendant_p(NcPlaneHandle n, NcPlaneHandle ancestor);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_move_above(NcPlaneHandle n, NcPlaneHandle above);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_move_below(NcPlaneHandle n, NcPlaneHandle below);
            [LibraryImport("notcurses-ffi")]
            public static partial void ncplane_move_top(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial void ncplane_move_bottom(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_move_family_above(NcPlaneHandle n, NcPlaneHandle targ);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_move_family_below(NcPlaneHandle n, NcPlaneHandle targ);
            [LibraryImport("notcurses-ffi")]
            public static partial void ncplane_move_family_top(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial void ncplane_move_family_bottom(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_family_destroy(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncplane_below(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncplane_above(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_scrollup(NcPlaneHandle n, int r);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_scrollup_child(NcPlaneHandle n, NcPlaneHandle child);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_rotate_cw(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_rotate_ccw(NcPlaneHandle n);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncplane_at_cursor(NcPlaneHandle n, Ptr<ushort> stylemask, Ptr<ulong> channels);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_at_cursor_cell(NcPlaneHandle n, Ptr<NcCell> c);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncplane_at_yx(NcPlaneHandle n, int y, int x, Ptr<ushort> stylemask, Ptr<ulong> channels);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_at_yx_cell(NcPlaneHandle n, int y, int x, Ptr<NcCell> c);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncplane_contents(NcPlaneHandle n, int begY, int begX, uint lenY, uint lenX);
            [LibraryImport("notcurses-core")]
            public static partial Ptr ncplane_set_userptr(NcPlaneHandle n, Ptr opaque);
            [LibraryImport("notcurses-core")]
            public static partial Ptr ncplane_userptr(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_center_abs(NcPlaneHandle n, Ptr<int> y, Ptr<int> x);
            [LibraryImport("notcurses-core")]
            public static partial Ptr<uint> ncplane_as_rgba(NcPlaneHandle n, NcBlitter blit, int begY, int begX, uint lenY, uint lenX, Ptr<uint> pxDimY, Ptr<uint> pxDimX);
            [LibraryImport("notcurses-ffi")]
            public static partial int notcurses_align(int availu, NcAlign align, int u);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_halign(NcPlaneHandle n, NcAlign align, int c);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_valign(NcPlaneHandle n, NcAlign align, int r);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_cursor_move_yx(NcPlaneHandle n, int y, int x);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_cursor_move_rel(NcPlaneHandle n, int y, int x);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_home(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_cursor_yx(NcPlaneHandle n, Ptr<uint> y, Ptr<uint> x);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncplane_cursor_y(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncplane_cursor_x(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial ulong ncplane_channels(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial ushort ncplane_styles(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_putc_yx(NcPlaneHandle n, int y, int x, Ptr<NcCell> c);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_putc(NcPlaneHandle n, Ptr<NcCell> c);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_putchar_yx(NcPlaneHandle n, int y, int x, byte c);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_putchar(NcPlaneHandle n, byte c);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_putchar_stained(NcPlaneHandle n, byte c);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_putegc_yx(NcPlaneHandle n, int y, int x, RefString8 gclust, Ptr<ByteSize64> sBytes);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_putegc(NcPlaneHandle n, RefString8 gclust, Ptr<ByteSize64> sBytes);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_putegc_stained(NcPlaneHandle n, RefString8 gclust, Ptr<ByteSize64> sBytes);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_putstr_yx(NcPlaneHandle n, int y, int x, RefString8 gclusters);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_putstr(NcPlaneHandle n, RefString8 gclustarr);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_putstr_aligned(NcPlaneHandle n, int y, NcAlign align, RefString8 s);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_putstr_stained(NcPlaneHandle n, RefString8 gclusters);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_putnstr_aligned(NcPlaneHandle n, int y, NcAlign align, ByteSize64 s, RefString8 str);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_putnstr_yx(NcPlaneHandle n, int y, int x, ByteSize64 s, RefString8 gclusters);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_putnstr(NcPlaneHandle n, ByteSize64 s, RefString8 gclustarr);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_pututf32_yx(NcPlaneHandle n, int y, int x, uint u);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_vprintf_aligned(NcPlaneHandle n, int y, NcAlign align, RefString8 format, RefString8 ap);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_vprintf_yx(NcPlaneHandle n, int y, int x, RefString8 format, RefString8 ap);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_vprintf(NcPlaneHandle n, RefString8 format, RefString8 ap);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_vprintf_stained(NcPlaneHandle n, RefString8 format, RefString8 ap);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_printf(NcPlaneHandle n, RefString8 format);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_printf_yx(NcPlaneHandle n, int y, int x, RefString8 format);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_printf_aligned(NcPlaneHandle n, int y, NcAlign align, RefString8 format);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_printf_stained(NcPlaneHandle n, RefString8 format);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_puttext(NcPlaneHandle n, int y, NcAlign align, RefString8 text, Ptr<ByteSize64> bytes);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_hline_interp(NcPlaneHandle n, Ptr<NcCell> c, uint len, ulong c1, ulong c2);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_hline(NcPlaneHandle n, Ptr<NcCell> c, uint len);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_vline_interp(NcPlaneHandle n, Ptr<NcCell> c, uint len, ulong c1, ulong c2);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_vline(NcPlaneHandle n, Ptr<NcCell> c, uint len);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_box(NcPlaneHandle n, Ptr<NcCell> ul, Ptr<NcCell> ur, Ptr<NcCell> ll, Ptr<NcCell> lr, Ptr<NcCell> hline, Ptr<NcCell> vline, uint yStop, uint xStop, uint ctlWord);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_box_sized(NcPlaneHandle n, Ptr<NcCell> ul, Ptr<NcCell> ur, Ptr<NcCell> ll, Ptr<NcCell> lr, Ptr<NcCell> hline, Ptr<NcCell> vline, uint yStop, uint xStop, uint ctlWord);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_perimeter(NcPlaneHandle n, Ptr<NcCell> ul, Ptr<NcCell> ur, Ptr<NcCell> ll, Ptr<NcCell> lr, Ptr<NcCell> hline, Ptr<NcCell> vline, uint ctlWord);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_polyfill_yx(NcPlaneHandle n, int y, int x, Ptr<NcCell> c);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_gradient(NcPlaneHandle n, int y, int x, uint yLen, uint xLen, RefString8 egc, ushort styles, ulong ul, ulong ur, ulong ll, ulong lr);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_gradient2x1(NcPlaneHandle n, int y, int x, uint yLen, uint xLen, uint ul, uint ur, uint ll, uint lr);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_format(NcPlaneHandle n, int y, int x, uint yLen, uint xLen, ushort stylemask);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_stain(NcPlaneHandle n, int y, int x, uint yLen, uint xLen, ulong ul, ulong ur, ulong ll, ulong lr);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_mergedown_simple(NcPlaneHandle src, NcPlaneHandle dst);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_mergedown(NcPlaneHandle src, NcPlaneHandle dst, int begSrcY, int begSrcX, uint lenY, uint lenX, int dstY, int dstX);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_erase(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_erase_region(NcPlaneHandle n, int yStart, int xStart, int yLen, int xLen);
            [LibraryImport("notcurses-ffi")]
            public static partial uint nccell_fg_rgb(Ptr<NcCell> cl);
            [LibraryImport("notcurses-ffi")]
            public static partial uint nccell_bg_rgb(Ptr<NcCell> cl);
            [LibraryImport("notcurses-ffi")]
            public static partial uint nccell_fg_alpha(Ptr<NcCell> cl);
            [LibraryImport("notcurses-ffi")]
            public static partial uint nccell_bg_alpha(Ptr<NcCell> cl);
            [LibraryImport("notcurses-ffi")]
            public static partial uint nccell_fg_rgb8(Ptr<NcCell> cl, Ptr<uint> r, Ptr<uint> g, Ptr<uint> b);
            [LibraryImport("notcurses-ffi")]
            public static partial uint nccell_bg_rgb8(Ptr<NcCell> cl, Ptr<uint> r, Ptr<uint> g, Ptr<uint> b);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccell_set_fg_rgb8(Ptr<NcCell> cl, uint r, uint g, uint b);
            [LibraryImport("notcurses-ffi")]
            public static partial void nccell_set_fg_rgb8_clipped(Ptr<NcCell> cl, int r, int g, int b);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccell_set_fg_rgb(Ptr<NcCell> c, uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccell_set_fg_palindex(Ptr<NcCell> cl, uint idx);
            [LibraryImport("notcurses-ffi")]
            public static partial uint nccell_fg_palindex(Ptr<NcCell> cl);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccell_set_bg_rgb8(Ptr<NcCell> cl, uint r, uint g, uint b);
            [LibraryImport("notcurses-ffi")]
            public static partial void nccell_set_bg_rgb8_clipped(Ptr<NcCell> cl, int r, int g, int b);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccell_set_bg_rgb(Ptr<NcCell> c, uint channel);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccell_set_bg_palindex(Ptr<NcCell> cl, uint idx);
            [LibraryImport("notcurses-ffi")]
            public static partial uint nccell_bg_palindex(Ptr<NcCell> cl);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nccell_fg_default_p(Ptr<NcCell> cl);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nccell_fg_palindex_p(Ptr<NcCell> cl);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nccell_bg_default_p(Ptr<NcCell> cl);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 nccell_bg_palindex_p(Ptr<NcCell> cl);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncplane_bchannel(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncplane_fchannel(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_set_channels(NcPlaneHandle n, ulong channels);
            [LibraryImport("notcurses-core")]
            public static partial ulong ncplane_set_bchannel(NcPlaneHandle n, uint channel);
            [LibraryImport("notcurses-core")]
            public static partial ulong ncplane_set_fchannel(NcPlaneHandle n, uint channel);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_set_styles(NcPlaneHandle n, uint styleBits);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_on_styles(NcPlaneHandle n, uint styleBits);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_off_styles(NcPlaneHandle n, uint styleBits);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncplane_fg_rgb(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncplane_bg_rgb(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncplane_fg_alpha(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncplane_fg_default_p(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncplane_bg_alpha(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncplane_bg_default_p(NcPlaneHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncplane_fg_rgb8(NcPlaneHandle n, Ptr<uint> r, Ptr<uint> g, Ptr<uint> b);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncplane_bg_rgb8(NcPlaneHandle n, Ptr<uint> r, Ptr<uint> g, Ptr<uint> b);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_set_fg_rgb8(NcPlaneHandle n, uint r, uint g, uint b);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_set_bg_rgb8(NcPlaneHandle n, uint r, uint g, uint b);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_set_bg_rgb8_clipped(NcPlaneHandle n, int r, int g, int b);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_set_fg_rgb8_clipped(NcPlaneHandle n, int r, int g, int b);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_set_fg_rgb(NcPlaneHandle n, uint channel);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_set_bg_rgb(NcPlaneHandle n, uint channel);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_set_fg_default(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_set_bg_default(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_set_fg_palindex(NcPlaneHandle n, uint idx);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_set_bg_palindex(NcPlaneHandle n, uint idx);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_set_fg_alpha(NcPlaneHandle n, int alpha);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_set_bg_alpha(NcPlaneHandle n, int alpha);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_fadeout(NcPlaneHandle n, Ptr<TimeSpec> ts, delegate* unmanaged[Cdecl]<NotCursesHandle, NcPlaneHandle, Ptr<TimeSpec>, Ptr, int> fader, Ptr currY);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_fadein(NcPlaneHandle n, Ptr<TimeSpec> ts, delegate* unmanaged[Cdecl]<NotCursesHandle, NcPlaneHandle, Ptr<TimeSpec>, Ptr, int> fader, Ptr currY);
            [LibraryImport("notcurses-core")]
            public static partial NcFadectxHandle ncfadectx_setup(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncfadectx_iterations(NcFadectxHandle nctX);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_fadeout_iteration(NcPlaneHandle n, NcFadectxHandle nctX, int iter, delegate* unmanaged[Cdecl]<NotCursesHandle, NcPlaneHandle, Ptr<TimeSpec>, Ptr, int> fader, Ptr currY);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_fadein_iteration(NcPlaneHandle n, NcFadectxHandle nctX, int iter, delegate* unmanaged[Cdecl]<NotCursesHandle, NcPlaneHandle, Ptr<TimeSpec>, Ptr, int> fader, Ptr currY);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_pulse(NcPlaneHandle n, Ptr<TimeSpec> ts, delegate* unmanaged[Cdecl]<NotCursesHandle, NcPlaneHandle, Ptr<TimeSpec>, Ptr, int> fader, Ptr currY);
            [LibraryImport("notcurses-core")]
            public static partial void ncfadectx_free(NcFadectxHandle nctX);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccells_load_box(NcPlaneHandle n, ushort styles, ulong channels, Ptr<NcCell> ul, Ptr<NcCell> ur, Ptr<NcCell> ll, Ptr<NcCell> lr, Ptr<NcCell> hl, Ptr<NcCell> vl, RefString8 gclusters);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccells_ascii_box(NcPlaneHandle n, ushort attr, ulong channels, Ptr<NcCell> ul, Ptr<NcCell> ur, Ptr<NcCell> ll, Ptr<NcCell> lr, Ptr<NcCell> hl, Ptr<NcCell> vl);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccells_double_box(NcPlaneHandle n, ushort attr, ulong channels, Ptr<NcCell> ul, Ptr<NcCell> ur, Ptr<NcCell> ll, Ptr<NcCell> lr, Ptr<NcCell> hl, Ptr<NcCell> vl);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccells_rounded_box(NcPlaneHandle n, ushort attr, ulong channels, Ptr<NcCell> ul, Ptr<NcCell> ur, Ptr<NcCell> ll, Ptr<NcCell> lr, Ptr<NcCell> hl, Ptr<NcCell> vl);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccells_light_box(NcPlaneHandle n, ushort attr, ulong channels, Ptr<NcCell> ul, Ptr<NcCell> ur, Ptr<NcCell> ll, Ptr<NcCell> lr, Ptr<NcCell> hl, Ptr<NcCell> vl);
            [LibraryImport("notcurses-ffi")]
            public static partial int nccells_heavy_box(NcPlaneHandle n, ushort attr, ulong channels, Ptr<NcCell> ul, Ptr<NcCell> ur, Ptr<NcCell> ll, Ptr<NcCell> lr, Ptr<NcCell> hl, Ptr<NcCell> vl);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_rounded_box(NcPlaneHandle n, ushort styles, ulong channels, uint yStop, uint xStop, uint ctlWord);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_perimeter_rounded(NcPlaneHandle n, ushort stylemask, ulong channels, uint ctlWord);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_rounded_box_sized(NcPlaneHandle n, ushort styles, ulong channels, uint yLen, uint xLen, uint ctlWord);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_double_box(NcPlaneHandle n, ushort styles, ulong channels, uint yLen, uint xLen, uint ctlWord);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_ascii_box(NcPlaneHandle n, ushort styles, ulong channels, uint yLen, uint xLen, uint ctlWord);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_perimeter_double(NcPlaneHandle n, ushort stylemask, ulong channels, uint ctlWord);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncplane_double_box_sized(NcPlaneHandle n, ushort styles, ulong channels, uint yLen, uint xLen, uint ctlWord);
            [LibraryImport("notcurses-core")]
            public static partial NcVisualHandle ncvisual_from_file(RefString8 file);
            [LibraryImport("notcurses-core")]
            public static partial NcVisualHandle ncvisual_from_rgba(Ptr rgba, int rows, int rowstride, int cols);
            [LibraryImport("notcurses-core")]
            public static partial NcVisualHandle ncvisual_from_rgb_packed(Ptr rgba, int rows, int rowstride, int cols, int alpha);
            [LibraryImport("notcurses-core")]
            public static partial NcVisualHandle ncvisual_from_rgb_loose(Ptr rgba, int rows, int rowstride, int cols, int alpha);
            [LibraryImport("notcurses-core")]
            public static partial NcVisualHandle ncvisual_from_bgra(Ptr bgra, int rows, int rowstride, int cols);
            [LibraryImport("notcurses-core")]
            public static partial NcVisualHandle ncvisual_from_palidx(Ptr data, int rows, int rowstride, int cols, int palsize, int pstride, Ptr<uint> palette);
            [LibraryImport("notcurses-core")]
            public static partial NcVisualHandle ncvisual_from_plane(NcPlaneHandle n, NcBlitter blit, int begY, int begX, uint lenY, uint lenX);
            [LibraryImport("notcurses-core")]
            public static partial NcVisualHandle ncvisual_from_sixel(RefString8 s, uint lenY, uint lenX);
            [LibraryImport("notcurses-core")]
            public static partial int ncvisual_geom(NotCursesHandle nc, NcVisualHandle n, Ptr<NcVisualOptions> vopts, Ptr<NcVGeom> geom);
            [LibraryImport("notcurses-core")]
            public static partial void ncvisual_destroy(NcVisualHandle ncv);
            [LibraryImport("notcurses-core")]
            public static partial int ncvisual_decode(NcVisualHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial int ncvisual_decode_loop(NcVisualHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial int ncvisual_rotate(NcVisualHandle n, double rads);
            [LibraryImport("notcurses-core")]
            public static partial int ncvisual_resize(NcVisualHandle n, int rows, int cols);
            [LibraryImport("notcurses-core")]
            public static partial int ncvisual_resize_noninterpolative(NcVisualHandle n, int rows, int cols);
            [LibraryImport("notcurses-core")]
            public static partial int ncvisual_polyfill_yx(NcVisualHandle n, uint y, uint x, uint rgba);
            [LibraryImport("notcurses-core")]
            public static partial int ncvisual_at_yx(NcVisualHandle n, uint y, uint x, Ptr<uint> pixel);
            [LibraryImport("notcurses-core")]
            public static partial int ncvisual_set_yx(NcVisualHandle n, uint y, uint x, uint pixel);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncvisual_blit(NotCursesHandle nc, NcVisualHandle ncv, Ptr<NcVisualOptions> vopts);
            [LibraryImport("notcurses-ffi")]
            public static partial NcPlaneHandle ncvisualplane_create(NotCursesHandle nc, Ptr<NcPlaneOptions> opts, NcVisualHandle ncv, Ptr<NcVisualOptions> vopts);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncvisual_subtitle_plane(NcPlaneHandle parent, NcVisualHandle ncv);
            [LibraryImport("notcurses-core")]
            public static partial NcBlitter ncvisual_media_defblitter(NotCursesHandle nc, NcScale scale);
            [LibraryImport("notcurses-core")]
            public static partial int ncvisual_simple_streamer(NcVisualHandle ncv, Ptr<NcVisualOptions> vopts, Ptr<TimeSpec> tspec, Ptr currY);
            [LibraryImport("notcurses-core")]
            public static partial int ncvisual_stream(NotCursesHandle nc, NcVisualHandle ncv, float timescale, delegate* unmanaged[Cdecl]<NcVisualHandle, Ptr<NcVisualOptions>, Ptr<TimeSpec>, Ptr, int> streamer, Ptr<NcVisualOptions> vopts, Ptr currY);
            [LibraryImport("notcurses-core")]
            public static partial int ncblit_rgba(Ptr data, int linesize, Ptr<NcVisualOptions> vopts);
            [LibraryImport("notcurses-core")]
            public static partial int ncblit_bgrx(Ptr data, int linesize, Ptr<NcVisualOptions> vopts);
            [LibraryImport("notcurses-core")]
            public static partial int ncblit_rgb_packed(Ptr data, int linesize, Ptr<NcVisualOptions> vopts, int alpha);
            [LibraryImport("notcurses-core")]
            public static partial int ncblit_rgb_loose(Ptr data, int linesize, Ptr<NcVisualOptions> vopts, int alpha);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncpixel_a(uint pixel);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncpixel_r(uint pixel);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncpixel_g(uint pixel);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncpixel_b(uint pixel);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncpixel_set_a(Ptr<uint> pixel, uint a);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncpixel_set_r(Ptr<uint> pixel, uint r);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncpixel_set_g(Ptr<uint> pixel, uint g);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncpixel_set_b(Ptr<uint> pixel, uint b);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncpixel(uint r, uint g, uint b);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncpixel_set_rgb8(Ptr<uint> pixel, uint r, uint g, uint b);
            [LibraryImport("notcurses-core")]
            public static partial NcReelHandle ncreel_create(NcPlaneHandle n, Ptr<NcReelOptions> popts);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncreel_plane(NcReelHandle nr);
            [LibraryImport("notcurses-core")]
            public static partial NcTabletHandle ncreel_add(NcReelHandle nr, NcTabletHandle after, NcTabletHandle before, delegate* unmanaged[Cdecl]<NcTabletHandle, Bool8, int> cb, Ptr opaque);
            [LibraryImport("notcurses-core")]
            public static partial int ncreel_tabletcount(NcReelHandle nr);
            [LibraryImport("notcurses-core")]
            public static partial int ncreel_del(NcReelHandle nr, NcTabletHandle t);
            [LibraryImport("notcurses-core")]
            public static partial int ncreel_redraw(NcReelHandle nr);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 ncreel_offer_input(NcReelHandle nr, Ptr<NcInput> ni);
            [LibraryImport("notcurses-core")]
            public static partial NcTabletHandle ncreel_focused(NcReelHandle nr);
            [LibraryImport("notcurses-core")]
            public static partial NcTabletHandle ncreel_next(NcReelHandle nr);
            [LibraryImport("notcurses-core")]
            public static partial NcTabletHandle ncreel_prev(NcReelHandle nr);
            [LibraryImport("notcurses-core")]
            public static partial void ncreel_destroy(NcReelHandle nr);
            [LibraryImport("notcurses-core")]
            public static partial Ptr nctablet_userptr(NcTabletHandle t);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle nctablet_plane(NcTabletHandle t);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncnmetric(ulong val, ByteSize64 s, ulong @decimal, RefString8 buf, int omitdec, ulong mult, int uprefiX);
            [LibraryImport("notcurses-ffi", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncqprefix(ulong val, ulong @decimal, RefString8 buf, int omitdec);
            [LibraryImport("notcurses-ffi", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string nciprefix(ulong val, ulong @decimal, RefString8 buf, int omitdec);
            [LibraryImport("notcurses-ffi", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncbprefix(ulong val, ulong @decimal, RefString8 buf, int omitdec);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_default_foreground(NotCursesHandle nc, Ptr<uint> fg);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_default_background(NotCursesHandle nc, Ptr<uint> bg);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_cursor_enable(NotCursesHandle nc, int y, int x);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_cursor_disable(NotCursesHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial int notcurses_cursor_yx(NotCursesHandle nc, Ptr<int> y, Ptr<int> x);
            [LibraryImport("notcurses-core")]
            public static partial void ncplane_greyscale(NcPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcSelectorHandle ncselector_create(NcPlaneHandle n, Ptr<NcSelectorOptions> opts);
            [LibraryImport("notcurses-core")]
            public static partial int ncselector_additem(NcSelectorHandle n, Ptr<NcSelectorItem> item);
            [LibraryImport("notcurses-core")]
            public static partial int ncselector_delitem(NcSelectorHandle n, RefString8 item);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncselector_selected(NcSelectorHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncselector_plane(NcSelectorHandle n);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncselector_previtem(NcSelectorHandle n);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncselector_nextitem(NcSelectorHandle n);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 ncselector_offer_input(NcSelectorHandle n, Ptr<NcInput> nc);
            [LibraryImport("notcurses-core")]
            public static partial void ncselector_destroy(NcSelectorHandle n, Ptr<Ptr<byte>> item);
            [LibraryImport("notcurses-core")]
            public static partial NcMultiSelectorHandle ncmultiselector_create(NcPlaneHandle n, Ptr<NcMultiSelectorOptions> opts);
            [LibraryImport("notcurses-core")]
            public static partial int ncmultiselector_selected(NcMultiSelectorHandle n, Ptr<Bool8> selected, uint count);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncmultiselector_plane(NcMultiSelectorHandle n);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 ncmultiselector_offer_input(NcMultiSelectorHandle n, Ptr<NcInput> nc);
            [LibraryImport("notcurses-core")]
            public static partial void ncmultiselector_destroy(NcMultiSelectorHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcTreeHandle nctree_create(NcPlaneHandle n, Ptr<NcTreeOptions> opts);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle nctree_plane(NcTreeHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int nctree_redraw(NcTreeHandle n);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 nctree_offer_input(NcTreeHandle n, Ptr<NcInput> ni);
            [LibraryImport("notcurses-core")]
            public static partial Ptr nctree_focused(NcTreeHandle n);
            [LibraryImport("notcurses-core")]
            public static partial Ptr nctree_next(NcTreeHandle n);
            [LibraryImport("notcurses-core")]
            public static partial Ptr nctree_prev(NcTreeHandle n);
            [LibraryImport("notcurses-core")]
            public static partial Ptr nctree_goto(NcTreeHandle n, Ptr<uint> spec, Ptr<int> failSpec);
            [LibraryImport("notcurses-core")]
            public static partial int nctree_add(NcTreeHandle n, Ptr<uint> spec, Ptr<NcTreeItem> add);
            [LibraryImport("notcurses-core")]
            public static partial int nctree_del(NcTreeHandle n, Ptr<uint> spec);
            [LibraryImport("notcurses-core")]
            public static partial void nctree_destroy(NcTreeHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcMenuHandle ncmenu_create(NcPlaneHandle n, Ptr<NcMenuOptions> opts);
            [LibraryImport("notcurses-core")]
            public static partial int ncmenu_unroll(NcMenuHandle n, int sectionIdx);
            [LibraryImport("notcurses-core")]
            public static partial int ncmenu_rollup(NcMenuHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncmenu_nextsection(NcMenuHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncmenu_prevsection(NcMenuHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncmenu_nextitem(NcMenuHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncmenu_previtem(NcMenuHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncmenu_item_set_status(NcMenuHandle n, RefString8 section, RefString8 item, Bool8 enabled);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncmenu_selected(NcMenuHandle n, Ptr<NcInput> ni);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncmenu_mouse_selected(NcMenuHandle n, Ptr<NcInput> click, Ptr<NcInput> ni);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncmenu_plane(NcMenuHandle n);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 ncmenu_offer_input(NcMenuHandle n, Ptr<NcInput> nc);
            [LibraryImport("notcurses-core")]
            public static partial void ncmenu_destroy(NcMenuHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcProgBarHandle ncprogbar_create(NcPlaneHandle n, Ptr<NcProgBarOptions> opts);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncprogbar_plane(NcProgBarHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncprogbar_set_progress(NcProgBarHandle n, double p);
            [LibraryImport("notcurses-core")]
            public static partial double ncprogbar_progress(NcProgBarHandle n);
            [LibraryImport("notcurses-core")]
            public static partial void ncprogbar_destroy(NcProgBarHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcTabbedHandle nctabbed_create(NcPlaneHandle n, Ptr<NcTabbedOptions> opts);
            [LibraryImport("notcurses-core")]
            public static partial void nctabbed_destroy(NcTabbedHandle nt);
            [LibraryImport("notcurses-core")]
            public static partial void nctabbed_redraw(NcTabbedHandle nt);
            [LibraryImport("notcurses-core")]
            public static partial void nctabbed_ensure_selected_header_visible(NcTabbedHandle nt);
            [LibraryImport("notcurses-core")]
            public static partial NcTabHandle nctabbed_selected(NcTabbedHandle nt);
            [LibraryImport("notcurses-core")]
            public static partial NcTabHandle nctabbed_leftmost(NcTabbedHandle nt);
            [LibraryImport("notcurses-core")]
            public static partial int nctabbed_tabcount(NcTabbedHandle nt);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle nctabbed_plane(NcTabbedHandle nt);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle nctabbed_content_plane(NcTabbedHandle nt);
            [LibraryImport("notcurses-core")]
            public static partial delegate* unmanaged[Cdecl]<NcTabHandle, NcPlaneHandle, Ptr, void> nctab_cb(NcTabHandle t);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string nctab_name(NcTabHandle t);
            [LibraryImport("notcurses-core")]
            public static partial int nctab_name_width(NcTabHandle t);
            [LibraryImport("notcurses-core")]
            public static partial Ptr nctab_userptr(NcTabHandle t);
            [LibraryImport("notcurses-core")]
            public static partial NcTabHandle nctab_next(NcTabHandle t);
            [LibraryImport("notcurses-core")]
            public static partial NcTabHandle nctab_prev(NcTabHandle t);
            [LibraryImport("notcurses-core")]
            public static partial NcTabHandle nctabbed_add(NcTabbedHandle nt, NcTabHandle after, NcTabHandle before, delegate* unmanaged[Cdecl]<NcTabHandle, NcPlaneHandle, Ptr, void> tcb, RefString8 name, Ptr opaque);
            [LibraryImport("notcurses-core")]
            public static partial int nctabbed_del(NcTabbedHandle nt, NcTabHandle t);
            [LibraryImport("notcurses-core")]
            public static partial int nctab_move(NcTabbedHandle nt, NcTabHandle t, NcTabHandle after, NcTabHandle before);
            [LibraryImport("notcurses-core")]
            public static partial void nctab_move_right(NcTabbedHandle nt, NcTabHandle t);
            [LibraryImport("notcurses-core")]
            public static partial void nctab_move_left(NcTabbedHandle nt, NcTabHandle t);
            [LibraryImport("notcurses-core")]
            public static partial void nctabbed_rotate(NcTabbedHandle nt, int amt);
            [LibraryImport("notcurses-core")]
            public static partial NcTabHandle nctabbed_next(NcTabbedHandle nt);
            [LibraryImport("notcurses-core")]
            public static partial NcTabHandle nctabbed_prev(NcTabbedHandle nt);
            [LibraryImport("notcurses-core")]
            public static partial NcTabHandle nctabbed_select(NcTabbedHandle nt, NcTabHandle t);
            [LibraryImport("notcurses-core")]
            public static partial void nctabbed_channels(NcTabbedHandle nt, Ptr<ulong> hdrChan, Ptr<ulong> selChan, Ptr<ulong> sepChan);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong nctabbed_hdrchan(NcTabbedHandle nt);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong nctabbed_selchan(NcTabbedHandle nt);
            [LibraryImport("notcurses-ffi")]
            public static partial ulong nctabbed_sepchan(NcTabbedHandle nt);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string nctabbed_separator(NcTabbedHandle nt);
            [LibraryImport("notcurses-core")]
            public static partial int nctabbed_separator_width(NcTabbedHandle nt);
            [LibraryImport("notcurses-core")]
            public static partial void nctabbed_set_hdrchan(NcTabbedHandle nt, ulong chan);
            [LibraryImport("notcurses-core")]
            public static partial void nctabbed_set_selchan(NcTabbedHandle nt, ulong chan);
            [LibraryImport("notcurses-core")]
            public static partial void nctabbed_set_sepchan(NcTabbedHandle nt, ulong chan);
            [LibraryImport("notcurses-core")]
            public static partial delegate* unmanaged[Cdecl]<NcTabHandle, NcPlaneHandle, Ptr, void> nctab_set_cb(NcTabHandle t, delegate* unmanaged[Cdecl]<NcTabHandle, NcPlaneHandle, Ptr, void> newcb);
            [LibraryImport("notcurses-core")]
            public static partial int nctab_set_name(NcTabHandle t, RefString8 newname);
            [LibraryImport("notcurses-core")]
            public static partial Ptr nctab_set_userptr(NcTabHandle t, Ptr newopaque);
            [LibraryImport("notcurses-core")]
            public static partial int nctabbed_set_separator(NcTabbedHandle nt, RefString8 separator);
            [LibraryImport("notcurses-core")]
            public static partial NcUPlotHandle ncuplot_create(NcPlaneHandle n, Ptr<NcPlotOptions> opts, ulong minY, ulong maxY);
            [LibraryImport("notcurses-core")]
            public static partial NcDPlotHandle ncdplot_create(NcPlaneHandle n, Ptr<NcPlotOptions> opts, double minY, double maxY);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncuplot_plane(NcUPlotHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncdplot_plane(NcDPlotHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncuplot_add_sample(NcUPlotHandle n, ulong x, ulong y);
            [LibraryImport("notcurses-core")]
            public static partial int ncdplot_add_sample(NcDPlotHandle n, ulong x, double y);
            [LibraryImport("notcurses-core")]
            public static partial int ncuplot_set_sample(NcUPlotHandle n, ulong x, ulong y);
            [LibraryImport("notcurses-core")]
            public static partial int ncdplot_set_sample(NcDPlotHandle n, ulong x, double y);
            [LibraryImport("notcurses-core")]
            public static partial int ncuplot_sample(NcUPlotHandle n, ulong x, Ptr<ulong> y);
            [LibraryImport("notcurses-core")]
            public static partial int ncdplot_sample(NcDPlotHandle n, ulong x, Ptr<double> y);
            [LibraryImport("notcurses-core")]
            public static partial void ncuplot_destroy(NcUPlotHandle n);
            [LibraryImport("notcurses-core")]
            public static partial void ncdplot_destroy(NcDPlotHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcFdPlaneHandle ncfdplane_create(NcPlaneHandle n, Ptr<NcFdPlaneOptions> opts, int fd, delegate* unmanaged[Cdecl]<NcFdPlaneHandle, Ptr, ByteSize64, Ptr, int> cbfxn, delegate* unmanaged[Cdecl]<NcFdPlaneHandle, int, Ptr, int> donecbfxn);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncfdplane_plane(NcFdPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncfdplane_destroy(NcFdPlaneHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcSubProcHandle ncsubproc_createv(NcPlaneHandle n, Ptr<NcSubProcOptions> opts, RefString8 bin, Ptr<Ptr<byte>> arg, delegate* unmanaged[Cdecl]<NcFdPlaneHandle, Ptr, ByteSize64, Ptr, int> cbfxn, delegate* unmanaged[Cdecl]<NcFdPlaneHandle, int, Ptr, int> donecbfxn);
            [LibraryImport("notcurses-core")]
            public static partial NcSubProcHandle ncsubproc_createvp(NcPlaneHandle n, Ptr<NcSubProcOptions> opts, RefString8 bin, Ptr<Ptr<byte>> arg, delegate* unmanaged[Cdecl]<NcFdPlaneHandle, Ptr, ByteSize64, Ptr, int> cbfxn, delegate* unmanaged[Cdecl]<NcFdPlaneHandle, int, Ptr, int> donecbfxn);
            [LibraryImport("notcurses-core")]
            public static partial NcSubProcHandle ncsubproc_createvpe(NcPlaneHandle n, Ptr<NcSubProcOptions> opts, RefString8 bin, Ptr<Ptr<byte>> arg, Ptr<Ptr<byte>> env, delegate* unmanaged[Cdecl]<NcFdPlaneHandle, Ptr, ByteSize64, Ptr, int> cbfxn, delegate* unmanaged[Cdecl]<NcFdPlaneHandle, int, Ptr, int> donecbfxn);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncsubproc_plane(NcSubProcHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncsubproc_destroy(NcSubProcHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncplane_qrcode(NcPlaneHandle n, Ptr<uint> yMaX, Ptr<uint> xMaX, Ptr data, ByteSize64 len);
            [LibraryImport("notcurses-core")]
            public static partial NcReaderHandle ncreader_create(NcPlaneHandle n, Ptr<NcReaderOptions> opts);
            [LibraryImport("notcurses-core")]
            public static partial int ncreader_clear(NcReaderHandle n);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncreader_plane(NcReaderHandle n);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 ncreader_offer_input(NcReaderHandle n, Ptr<NcInput> ni);
            [LibraryImport("notcurses-core")]
            public static partial int ncreader_move_left(NcReaderHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncreader_move_right(NcReaderHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncreader_move_up(NcReaderHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncreader_move_down(NcReaderHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncreader_write_egc(NcReaderHandle n, RefString8 egc);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncreader_contents(NcReaderHandle n);
            [LibraryImport("notcurses-core")]
            public static partial void ncreader_destroy(NcReaderHandle n, Ptr<Ptr<byte>> contents);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string notcurses_accountname();
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string notcurses_hostname();
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string notcurses_osversion();
            [LibraryImport("notcurses-core")]
            public static partial void notcurses_debug(NotCursesHandle nc, Ptr debugfp);
            [LibraryImport("notcurses-core")]
            public static partial NcDirectHandle ncdirect_core_init(RefString8 termtype, Ptr fp, NcDirectOption flags);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncdirect_readline(NcDirectHandle nc, RefString8 prompt);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_set_fg_rgb(NcDirectHandle nc, uint rgb);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_set_bg_rgb(NcDirectHandle nc, uint rgb);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_set_fg_palindex(NcDirectHandle nc, int pIdx);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_set_bg_palindex(NcDirectHandle nc, int pIdx);
            [LibraryImport("notcurses-core")]
            public static partial uint ncdirect_palette_size(NcDirectHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_putstr(NcDirectHandle nc, ulong channels, RefString8 utf8);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_putegc(NcDirectHandle nc, ulong channels, RefString8 utf8, Ptr<int> sBytes);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_printf_aligned(NcDirectHandle n, int y, NcAlign align, RefString8 fmt);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_flush(NcDirectHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncdirect_set_bg_rgb8(NcDirectHandle nc, uint r, uint g, uint b);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncdirect_set_fg_rgb8(NcDirectHandle nc, uint r, uint g, uint b);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_set_fg_default(NcDirectHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_set_bg_default(NcDirectHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial uint ncdirect_dim_x(NcDirectHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial uint ncdirect_dim_y(NcDirectHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial ushort ncdirect_supported_styles(NcDirectHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_set_styles(NcDirectHandle n, uint styleBits);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_on_styles(NcDirectHandle n, uint styleBits);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_off_styles(NcDirectHandle n, uint styleBits);
            [LibraryImport("notcurses-core")]
            public static partial ushort ncdirect_styles(NcDirectHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_cursor_move_yx(NcDirectHandle n, int y, int x);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_cursor_enable(NcDirectHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_cursor_disable(NcDirectHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_cursor_up(NcDirectHandle nc, int num);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_cursor_left(NcDirectHandle nc, int num);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_cursor_right(NcDirectHandle nc, int num);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_cursor_down(NcDirectHandle nc, int num);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_cursor_yx(NcDirectHandle n, Ptr<uint> y, Ptr<uint> x);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_cursor_push(NcDirectHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_cursor_pop(NcDirectHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_clear(NcDirectHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial Ptr<NcCapabilities> ncdirect_capabilities(NcDirectHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_hline_interp(NcDirectHandle n, Ptr<byte> egc, uint len, ulong h1, ulong h2);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_vline_interp(NcDirectHandle n, Ptr<byte> egc, uint len, ulong h1, ulong h2);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncdirect_light_box(NcDirectHandle n, ulong ul, ulong ur, ulong ll, ulong lr, uint yLen, uint xLen, uint ctlWord);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncdirect_heavy_box(NcDirectHandle n, ulong ul, ulong ur, ulong ll, ulong lr, uint yLen, uint xLen, uint ctlWord);
            [LibraryImport("notcurses-ffi")]
            public static partial int ncdirect_ascii_box(NcDirectHandle n, ulong ul, ulong ur, ulong ll, ulong lr, uint yLen, uint xLen, uint ctlWord);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_rounded_box(NcDirectHandle n, ulong ul, ulong ur, ulong ll, ulong lr, uint yLen, uint xLen, uint ctlWord);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_double_box(NcDirectHandle n, ulong ul, ulong ur, ulong ll, ulong lr, uint yLen, uint xLen, uint ctlWord);
            [LibraryImport("notcurses-core")]
            public static partial uint ncdirect_get(NcDirectHandle n, Ptr<TimeSpec> absdl, Ptr<NcInput> ni);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_inputready_fd(NcDirectHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncdirect_get_nblock(NcDirectHandle n, Ptr<NcInput> ni);
            [LibraryImport("notcurses-ffi")]
            public static partial uint ncdirect_get_blocking(NcDirectHandle n, Ptr<NcInput> ni);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_stop(NcDirectHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_render_image(NcDirectHandle n, RefString8 filename, NcAlign align, NcBlitter blitter, NcScale scale);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncdirect_render_frame(NcDirectHandle n, RefString8 filename, NcBlitter blitter, NcScale scale, int maxY, int maxX);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_raster_frame(NcDirectHandle n, NcPlaneHandle ncdv, NcAlign align);
            [LibraryImport("notcurses-core")]
            public static partial NcVisualHandle ncdirectf_from_file(NcDirectHandle n, RefString8 filename);
            [LibraryImport("notcurses-core")]
            public static partial void ncdirectf_free(NcVisualHandle frame);
            [LibraryImport("notcurses-core")]
            public static partial NcPlaneHandle ncdirectf_render(NcDirectHandle n, NcVisualHandle frame, Ptr<NcVisualOptions> vopts);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirectf_geom(NcDirectHandle n, NcVisualHandle frame, Ptr<NcVisualOptions> vopts, Ptr<NcVGeom> geom);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_stream(NcDirectHandle n, RefString8 filename, delegate* unmanaged[Cdecl]<NcVisualHandle, Ptr<NcVisualOptions>, Ptr<TimeSpec>, Ptr, int> streamer, Ptr<NcVisualOptions> vopts, Ptr currY);
            [LibraryImport("notcurses-core", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(InteropStringMarshaller))]
            public static partial string ncdirect_detected_terminal(NcDirectHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncdirect_cantruecolor(NcDirectHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncdirect_canchangecolor(NcDirectHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncdirect_canfade(NcDirectHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncdirect_canopen_images(NcDirectHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncdirect_canopen_videos(NcDirectHandle n);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 ncdirect_canutf8(NcDirectHandle n);
            [LibraryImport("notcurses-core")]
            public static partial int ncdirect_check_pixel_support(NcDirectHandle n);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncdirect_canhalfblock(NcDirectHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncdirect_canquadrant(NcDirectHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncdirect_cansextant(NcDirectHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncdirect_canoctant(NcDirectHandle nc);
            [LibraryImport("notcurses-ffi")]
            public static partial Bool8 ncdirect_canbraille(NcDirectHandle nc);
            [LibraryImport("notcurses-core")]
            public static partial Bool8 ncdirect_canget_cursor(NcDirectHandle nc);
        }
    }
}
