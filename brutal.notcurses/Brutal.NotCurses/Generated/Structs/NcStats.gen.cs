using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    /// whenever a new field is added here, ensure we add the proper rule to
    /// notcurses_stats_reset(), so that values are preserved in the stash stats.
    public unsafe partial struct NcStats
    {
        public ulong Renders; // successful ncpile_render() runs
        public ulong Writeouts; // successful ncpile_rasterize() runs
        public ulong FailedRenders; // aborted renders, should be 0
        public ulong FailedWriteouts; // aborted writes
        public ulong RasterBytes; // bytes emitted to ttyfp
        public long RasterMaxBytes; // max bytes emitted for a frame
        public long RasterMinBytes; // min bytes emitted for a frame
        public ulong RenderNs; // nanoseconds spent rendering
        public long RenderMaxNs; // max ns spent in render for a frame
        public long RenderMinNs; // min ns spent in render for a frame
        public ulong RasterNs; // nanoseconds spent rasterizing
        public long RasterMaxNs; // max ns spent in raster for a frame
        public long RasterMinNs; // min ns spent in raster for a frame
        public ulong WriteoutNs; // nanoseconds spent writing frames to terminal
        public long WriteoutMaxNs; // max ns spent writing out a frame
        public long WriteoutMinNs; // min ns spent writing out a frame
        public ulong Cellelisions; // cells we elided entirely thanks to damage maps
        public ulong Cellemissions; // total number of cells emitted to terminal
        public ulong Fgelisions; // RGB fg elision count
        public ulong Fgemissions; // RGB fg emissions
        public ulong Bgelisions; // RGB bg elision count
        public ulong Bgemissions; // RGB bg emissions
        public ulong Defaultelisions; // default color was emitted
        public ulong Defaultemissions; // default color was elided
        public ulong Refreshes; // refresh requests (non-optimized redraw)
        public ulong Sprixelemissions; // sprixel draw count
        public ulong Sprixelelisions; // sprixel elision count
        public ulong Sprixelbytes; // sprixel bytes emitted
        public ulong AppsyncUpdates; // how many application-synchronized updates?
        public ulong InputErrors; // errors processing control sequences/utf8
        public ulong InputEvents; // characters returned to userspace
        public ulong HpaGratuitous; // unnecessary hpas issued
        public ulong CellGeoChanges; // cell geometry changes (resizes)
        public ulong PixelGeoChanges; // pixel geometry changes (font resize)
        public ulong Fbbytes; // total bytes devoted to all active framebuffers
        public uint Planes; // number of planes currently in existence
    }
}
