namespace Brutal.ImPlotApi
{
    public abstract partial class ImPlot
    {
        public abstract partial class Internal : Brutal.ImPlotApi.ImPlot
        {
            public new abstract class PInvoke : Brutal.ImPlotApi.Internal.PInvoke;
        }
    }
}

namespace Brutal.ImPlotApi.Internal
{
    public abstract partial class PInvoke : Brutal.ImPlotApi.ImPlot.PInvoke;
}
