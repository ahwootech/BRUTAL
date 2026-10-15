using System.Runtime.InteropServices.Marshalling;
using Brutal;
using Brutal.Interop;
using Brutal.Pointers;
namespace Brutal.NotCursesApi
{
    public unsafe partial struct NcPlotOptions
    {
        /// channels for the maximum and minimum levels. linear or exponential
        /// interpolation will be applied across the domain between these two.
        public ulong Maxchannels;
        public ulong Minchannels;
        /// styling used for the legend, if NCPLOT_OPTION_LABELTICKSD is set
        public ushort Legendstyle;
        public NcBlitter Gridtype; // number of "pixels" per row x column
        /// independent variable can either be a contiguous range, or a finite set
        /// of keys. for a time range, say the previous hour sampled with second
        /// resolution, the independent variable would be the range [0..3600): 3600.
        /// if rangex is 0, it is dynamically set to the number of columns.
        public int Rangex;
        public Ptr<byte> Title; // optional, printed by the labels
        public NcPlotOption Flags; // bitfield over NCPLOT_OPTION_*
    }
}
