using Brutal.KtxApi;

namespace Brutal.TextureApi.Ktx;

public static partial class Writer
{
    /// <summary>
    /// Writes an ITexture
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="filePath"></param>
    /// <exception cref="KtxTextureException"></exception>
    public static void SaveToFile(ITexture texture, string filePath)
    {
        var ktxTexture = texture as KtxTexture ?? Converter.ToV2KtxTexture(texture);
        try
        {
            var saveResult = ktxTexture.SaveToFile(filePath);
            if (saveResult != KtxErrorCode.Success)
                throw new KtxTextureException($"Failed to save texture KtxErrorCode:{saveResult}", saveResult);
        }
        finally
        {
            if (texture is not KtxTexture)
                ktxTexture.Destroy();
        }
    }

    public static void SaveToFile(TextureDescriptor descriptor, string filePath)
    {
        var texture2Handle = Converter.ToKtxTexture2Handle(descriptor);
        SaveToFile(new KtxTexture(texture2Handle), filePath);
    }
}
