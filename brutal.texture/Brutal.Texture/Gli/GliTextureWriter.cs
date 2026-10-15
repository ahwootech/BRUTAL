namespace Brutal.TextureApi.Gli;

public static partial class Writer
{
    public static void SaveToFile(ITexture texture, string filePath)
    {
        if (texture is GliTexture gliTexture)
        {
            SaveToFileImpl(gliTexture, filePath);
            return;
        }

        SaveToFile(
            new TextureDescriptor
            {
                Data = texture.Data,
                Extent = texture.Extent,
                Format = texture.Format,
                LayerCount = texture.LayerCount,
                FaceCount = texture.FaceCount,
                MipmapCount = texture.LevelCount,
                IsCubemap = texture.IsCubemap,
            },
            filePath
        );
    }

    public static void SaveToFile(TextureDescriptor descriptor, string filePath)
    {
        var gliTarget = GliConversionUtils.GetTarget(descriptor.Extent, descriptor.LayerCount, descriptor.IsCubemap);

        using var gliNative = new GliApi.Gli.Texture(
            gliTarget,
            descriptor.Format.ToGliFormat(),
            new(descriptor.Extent.X, descriptor.Extent.Y, descriptor.Extent.Z),
            descriptor.LayerCount,
            descriptor.FaceCount,
            descriptor.MipmapCount,
            GliApi.Gli.Swizzles.Identity
        );

        unsafe
        {
            descriptor.Data.CopyTo(new Span<byte>(gliNative.Data, descriptor.Data.Length));
        }

        SaveToFileImpl(gliNative, filePath);
    }

    private static void SaveToFileImpl(GliApi.Gli.Texture texture, string filePath)
    {
        var result = texture.Save(filePath);

        if (!result)
        {
            throw new GliTextureSaveException($"Failed to save texture to file at path: \"{filePath}\".");
        }
    }
}
