namespace Brutal.TextureApi.Gli;

public static class GliConversionUtils
{
    public static GliTexture ToGliTexture(this ITexture texture)
    {
        var gliTarget = GetTarget(texture);
        var gliNative = new Brutal.GliApi.Gli.Texture(
            gliTarget,
            texture.Format.ToGliFormat(),
            new(texture.Extent.X, texture.Extent.Y, texture.Extent.Z),
            texture.LayerCount,
            texture.FaceCount,
            texture.LevelCount,
            GliApi.Gli.Swizzles.Identity
        );
        var outTexture = new GliTexture(gliNative);
        texture.Data.CopyTo(outTexture.Data);
        return outTexture;
    }

    public static Brutal.GliApi.Gli.Target GetTarget(ITexture texture)
    {
        return GetTarget(texture.Extent, texture.LayerCount, texture.IsCubemap);
    }

    public static GliApi.Gli.Target GetTarget(TexelCount3 extent, int layerCount, bool isCubemap)
    {
        var isArray = layerCount > 1;

        if (isCubemap)
        {
            return isArray ? GliApi.Gli.Target.CubeArray : GliApi.Gli.Target.Cube;
        }
        if (extent.Y is 1)
        {
            return isArray ? GliApi.Gli.Target._1DArray : GliApi.Gli.Target._1D;
        }

        if (extent.Z is 1)
        {
            return isArray ? GliApi.Gli.Target._2DArray : GliApi.Gli.Target._2D;
        }

        if (isArray)
            throw new NotImplementedException("Didn't anticipate Gli compatibility with 3d array textures");

        return GliApi.Gli.Target._3D;
    }
}
