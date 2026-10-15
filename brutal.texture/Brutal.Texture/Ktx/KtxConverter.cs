using Brutal.KtxApi;

namespace Brutal.TextureApi.Ktx;

/// <summary>
/// Static class that provides conversion functions from other formats to a KtxTexture.
/// </summary>
public static partial class Converter
{
    /// <summary>
    /// Takes any ITexture and creates a KTX version 2 ITexture from it. The original
    /// texture is kept as is and it is up to the caller to unload it if it is no longer
    /// used.
    /// </summary>
    /// <param name="texture">The ITexture to use as the source</param>
    /// <returns>The KTX Version 2 texture created from the source texture</returns>
    public static KtxTexture ToV2KtxTexture(ITexture texture)
    {
        var saveData = new TextureDescriptor
        {
            Data = texture.Data,
            Extent = texture.Extent,
            Format = texture.Format,
            LayerCount = texture.LayerCount,
            FaceCount = texture.FaceCount,
            MipmapCount = texture.LevelCount,
            IsCubemap = texture.IsCubemap,
        };

        return new KtxTexture(ToKtxTexture2Handle(saveData));
    }

    /// <summary>
    /// Creates a KTX version 2 texture handle from a TextureSaveInfo structure.
    /// It is your responsibility to free the texture handle.
    /// </summary>
    /// <param name="descriptor">The structure describing the texture to build</param>
    /// <returns>KtxTexture2Handle of the created texture</returns>
    /// <exception cref="KtxTextureException">Thrown if the texture could not be created, or
    /// the new texture data size is different to the source data size</exception>
    internal static unsafe KtxTexture2Handle ToKtxTexture2Handle(TextureDescriptor descriptor)
    {
        ValidateSaveInfo(descriptor);

        var createInfo = new KtxTextureCreateInfo()
        {
            BaseWidth = (uint)descriptor.Extent.X,
            BaseHeight = (uint)descriptor.Extent.Y,
            BaseDepth = (uint)descriptor.Extent.Z,
            GenerateMipmaps = false,
            NumLevels = (uint)descriptor.MipmapCount,
            NumLayers = (uint)descriptor.LayerCount,
            NumDimensions = CalculateDimensions(descriptor),
            NumFaces = (uint)descriptor.FaceCount,
            IsArray =
                descriptor.Extent.X > 0
                && descriptor.LayerCount > 1
                && (descriptor.FaceCount == 1 || descriptor.IsCubemap),
            PDfd = null,
            VkFormat = (uint)descriptor.Format,
            GlInternalformat = 0, // Ignored
        };

        var createResult = KtxTexture2.Create(
            ref createInfo,
            KtxTextureCreateStorageEnum.TextureCreateAllocStorage,
            out var texture2Handle
        );
        if (createResult != KtxErrorCode.Success)
            throw new KtxTextureException(
                $"Failed to create texture to save. KtxErrorCode:{createResult}",
                createResult
            );

        if (descriptor.Data.Length != (int)texture2Handle.GetDataSize())
            throw new KtxTextureException(
                $"Size mismatch. Brutal.Ktx allocated {texture2Handle.GetDataSize()} bytes but the save data had {descriptor.Data.Length}"
            );

        descriptor.Data.CopyTo(new Span<byte>(texture2Handle.GetData(), (int)texture2Handle.GetDataSize()));

        return texture2Handle;
    }

    private static void ValidateSaveInfo(TextureDescriptor descriptor)
    {
        if (descriptor.Extent.X == 0)
            throw new KtxTextureException("Texture width cannot be 0");

        if (descriptor.FaceCount == 6 && (descriptor.Extent.Y != descriptor.Extent.X || descriptor.Extent.Z != 1))
            throw new KtxTextureException(
                "Cubemap textures must have 6 faces, have the same width and height, and have a depth of 1"
            );
    }

    private static uint CalculateDimensions(TextureDescriptor descriptor)
    {
        if (descriptor.IsCubemap)
            return 2;

        var saveDataExtent = descriptor.Extent;
        // A depth of 1 is a 2D texture, not a 3D one. Only Z > 1 denotes a true 3D (volume) texture.
        if (saveDataExtent is { X: > 0, Y: > 0, Z: > 1 })
            return 3;
        if (saveDataExtent is { X: > 0, Y: > 0, Z: 1 })
            return 2;
        if (saveDataExtent is { X: > 0, Y: 1, Z: 1 })
            return 1;
        throw new KtxTextureException(
            $"Invalid extent for dimension calculation. extent: {saveDataExtent.X}, {saveDataExtent.Y}, {saveDataExtent.Z}"
        );
    }
}
