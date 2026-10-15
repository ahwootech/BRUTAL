namespace Brutal.ImPlotApi;

public partial class ImPlot
{
    public static void PlotShaded(
        ImString labelId,
        ReadOnlySpan<float2> values,
        double yref = 0d,
        ImPlotShadedFlags flags = default,
        int offset = 0
    )
    {
        unsafe
        {
            fixed (float2* valuesPtr = values)
            {
                var xsPtr = (float*)valuesPtr;
                var ysPtr = xsPtr + 1;
                PlotShaded(labelId, xsPtr, ysPtr, values.Length, yref, flags, offset, sizeof(float2));
            }
        }
    }
}
