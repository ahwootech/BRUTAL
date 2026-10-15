namespace Brutal.ImPlotApi;

public partial class ImPlot
{
    public static void PlotLine(
        ImString labelId,
        ReadOnlySpan<float2> values,
        ImPlotLineFlags flags = default,
        int offset = 0
    )
    {
        unsafe
        {
            fixed (float2* valuesPtr = values)
            {
                var xs = (float*)valuesPtr;
                var ys = xs + 1;
                PlotLine(labelId, xs, ys, values.Length, flags, offset, sizeof(float2));
            }
        }
    }

    public static void PlotLine(
        ImString labelId,
        ReadOnlySpan<double2> values,
        ImPlotLineFlags flags = default,
        int offset = 0
    )
    {
        unsafe
        {
            fixed (double2* valuesPtr = values)
            {
                var xs = (double*)valuesPtr;
                var ys = xs + 1;
                PlotLine(labelId, xs, ys, values.Length, flags, offset, sizeof(double2));
            }
        }
    }
}
