using System.Text;
using Brutal.Numerics;

namespace Brutal.KtxApi.Abstractions;

/// <summary>
/// Provides useful extensions to the KTX texture types.
/// </summary>
public static class KtxTextureExtensions
{
    #region File IO

    public static KtxErrorCode WriteToNamedFile(this KtxTexture2Handle textureHandle, string filePath) =>
        textureHandle.WriteToNamedFile(Encoding.UTF8.GetBytes(filePath + "\0"));

    public static KtxErrorCode WriteToNamedFile(this KtxTexture1Handle textureHandle, string filePath) =>
        textureHandle.WriteToNamedFile(Encoding.UTF8.GetBytes(filePath + "\0"));

    public static KtxErrorCode WriteToNamedFile(this KtxTextureHandle textureHandle, string filePath) =>
        textureHandle.WriteToNamedFile(Encoding.UTF8.GetBytes(filePath + "\0"));

    #endregion

    #region Data Access
    /// <summary>
    /// Returns a span covering the image data for a given level, layer and face.
    /// </summary>
    /// <param name="textureHandle">Handle to KTX texture of any version</param>
    /// <param name="level">The mip level to retrieve data for</param>
    /// <param name="layer">The layer</param>
    /// <param name="faceSlice">The face if this is cubemap texture </param>
    /// <param name="data"></param>
    /// <returns>KtxErrorCode for the result the function</returns>
    public static unsafe KtxErrorCode GetImageData(
        this KtxTextureHandle textureHandle,
        uint level,
        uint layer,
        uint faceSlice,
        out Span<byte> data
    )
    {
        var result = textureHandle.GetImageOffset(level, layer, faceSlice, out var imageOffset);
        if (result != KtxErrorCode.Success)
        {
            data = new Span<byte>();
            return result;
        }

        data = new Span<byte>(textureHandle.GetData() + imageOffset, (int)textureHandle.GetImageSize(level));
        return KtxErrorCode.Success;
    }

    /// <summary>
    /// Returns a span of the image data for a given level, layer and face for a v2 texture.
    /// </summary>
    /// <param name="textureHandle">Handle to version 2 KTX texture</param>
    /// <param name="level">The mip level to retrieve data for</param>
    /// <param name="layer">The layer</param>
    /// <param name="faceSlice">The face if this is cubemap texture </param>
    /// <param name="data"></param>
    /// <returns>KtxErrorCode for the result the function</returns>
    public static KtxErrorCode GetImageData(
        this KtxTexture2Handle textureHandle,
        uint level,
        uint layer,
        uint faceSlice,
        out Span<byte> data
    )
    {
        return ((KtxTextureHandle)textureHandle).GetImageData(level, layer, faceSlice, out data);
    }

    #endregion

    /// <summary>
    /// Returns a span of the image data for a given level, layer and face for a v1 texture.
    /// </summary>
    /// <param name="textureHandle">Handle to version 1 KTX texture</param>
    /// <param name="level">The mip level to retrieve data for</param>
    /// <param name="layer">The layer</param>
    /// <param name="faceSlice">The face if this is cubemap texture </param>
    /// <param name="data"></param>
    /// <returns>KtxErrorCode for the result the function</returns>
    public static KtxErrorCode GetImageData(
        this KtxTexture1Handle textureHandle,
        uint level,
        uint layer,
        uint faceSlice,
        out Span<byte> data
    )
    {
        return ((KtxTextureHandle)textureHandle).GetImageData(level, layer, faceSlice, out data);
    }

    public static unsafe int3 GetBlockExtent(this KtxTextureHandle textureHandle)
    {
        return new(
            (int)textureHandle.Protected->FormatSize.BlockWidth,
            (int)textureHandle.Protected->FormatSize.BlockHeight,
            (int)textureHandle.Protected->FormatSize.BlockDepth
        );
    }

    #region Texture Version Conversion

    /// <summary>
    /// Converts a generic KtxTextureHandle to a KtxTexture2Handle if the underlying texture is a version 2
    /// texture.
    /// </summary>
    /// <param name="handle">Handle to the version agnostic KTX texture</param>
    /// <returns>The KtxTexture2Handle of the texture</returns>
    /// <exception cref="InvalidCastException">Thrown if the texture is not a version 2 texture</exception>
    public static KtxTexture2Handle AsKtxTexture2Handle(this KtxTextureHandle handle)
    {
        if (handle.ClassId != ClassId.Texture2C)
            throw new InvalidCastException($"Texture is not a v2 texture");

        return new KtxTexture2Handle(handle.Impl);
    }

    /// <summary>
    /// Converts a generic KtxTextureHandle to a KtxTexture1Handle if the underlying texture is a version 1
    /// texture.
    /// </summary>
    /// <param name="handle">Handle to the version agnostic KTX texture</param>
    /// <returns>The KtxTexture1Handle of the texture</returns>
    /// <exception cref="InvalidCastException">Thrown if the texture is not a version 1 texture</exception>
    public static KtxTexture1Handle AsKtxTexture1Handle(this KtxTextureHandle handle)
    {
        if (handle.ClassId != ClassId.Texture1C)
            throw new InvalidCastException($"Texture is not a v1 texture");

        return new KtxTexture1Handle(handle.Impl);
    }

    #endregion
}
