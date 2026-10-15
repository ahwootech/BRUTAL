namespace Brutal.KtxApi.Abstractions;

public static class GpuUploadUtils
{
    public static bool IsRowSize4BytePadded(KtxTextureHandle textureHandle, int level)
    {
        if (textureHandle.ClassId == ClassId.Texture2C)
            return false;

        // Catches compressed textures (All multiple of 4 in element size), and uncompressed with 4 byte elements
        if (textureHandle.GetElementSize() % 4 == 0)
            return false;

        var levelPixelWidth = textureHandle.BaseWidth >> level;

        return textureHandle.GetRowPitch((uint)level) != textureHandle.GetElementSize() * levelPixelWidth;
    }
}
