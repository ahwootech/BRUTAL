namespace Brutal.GliApi;

public static partial class Gli
{
    /// <summary>
    ///     Texture target: type/shape of the texture data
    /// </summary>
    public enum Target
    {
        _1D,
        _1DArray,
        _2D,
        _2DArray,
        _3D,
        Rect,
        RectArray,
        Cube,
        CubeArray,
    }
}

public static class GliTargetExtensions
{
    public static int DimensionCount(this Gli.Target target) =>
        target.Is1d() ? 1 : (target.Is2d() ? 2 : (target.Is3d() ? 3 : 2));

    public static bool Is1d(this Gli.Target target)
    {
        return target is Gli.Target._1D or Gli.Target._1DArray;
    }

    public static bool Is2d(this Gli.Target target)
    {
        return target is Gli.Target._2D or Gli.Target._2DArray or Gli.Target.Rect or Gli.Target.RectArray;
    }

    public static bool Is3d(this Gli.Target target)
    {
        return target is Gli.Target._3D;
    }

    public static bool IsArray(this Gli.Target target)
    {
        return target is Gli.Target._1DArray or Gli.Target._2DArray or Gli.Target.CubeArray;
    }

    public static bool IsCube(this Gli.Target target)
    {
        return target is Gli.Target.Cube or Gli.Target.CubeArray;
    }

    public static bool IsRect(this Gli.Target target)
    {
        return target is Gli.Target.Rect or Gli.Target.RectArray;
    }
}
