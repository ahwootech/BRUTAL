using System.Collections.Frozen;
using System.Text;
using Brutal.KtxApi;
using Brutal.KtxApi.Abstractions;

namespace Brutal.TextureApi.Ktx;

public static partial class Loader
{
    /// <summary>
    /// Loads a ktx texture from a file.
    /// </summary>
    /// <param name="filePath">Path to file</param>
    /// <param name="loadOptions">Options for the load</param>
    /// <returns>Texture that was loaded</returns>
    /// <exception cref="KtxTextureException">If the texture could not be loaded.
    /// e.g The SuperCompressionFamily was not compatible with the texture's data,
    /// The file could not be found etc.
    /// </exception>
    public static KtxTexture LoadFromFile(string filePath, LoadSettings? loadOptions = null)
    {
        var loadSettings = loadOptions ?? LoadSettings.Default;

        var loadResult = KtxApi.KtxTexture.CreateFromNamedFile(
            Encoding.UTF8.GetBytes(filePath),
            LoadFlags(loadSettings),
            out var textureHandle
        );

        if (loadResult != KtxErrorCode.Success)
        {
            textureHandle.Dispose();
            throw new KtxTextureException(
                $"Failed to load texture from filePath \"{filePath}\". error:{loadResult}",
                loadResult
            );
        }

        if (!textureHandle.NeedsTranscoding())
            return new KtxTexture(textureHandle);

        var result = Transcode(textureHandle, loadSettings.SuperCompressionTranscodeFormat);
        if (result == KtxErrorCode.Success)
            return new KtxTexture(textureHandle);

        textureHandle.Dispose();
        throw new KtxTextureException($"Failed to transcode supercompressed texture. KtxErrorCode:{result}");
    }

    public static KtxTexture LoadFromMemory(ReadOnlySpan<byte> data, LoadSettings? loadData = null)
    {
        var loadSettings = loadData ?? new LoadSettings();

        var createResult = KtxTexture2.CreateFromMemory(data, LoadFlags(loadSettings), out var texture2Handle);
        if (createResult != KtxErrorCode.Success)
            throw new KtxTextureException("Failed to create texture from memory", createResult);

        return new KtxTexture(texture2Handle);
    }

    public class LoadSettings : TextureLoadSettings
    {
        public static LoadSettings Default { get; } = new();

        /// <summary>
        /// If the texture is supercompressed, this indicates the format to transcode it to on load.
        /// </summary>
        /// <value>Defaults to KtxTranscodeFmt.Bc7Rgba</value>
        public KtxTranscodeFmt SuperCompressionTranscodeFormat = KtxTranscodeFmt.Bc7Rgba;

        /// <summary>
        /// If true, does not immediately load the texture data.
        /// Data is loaded when accessed.
        /// This flag is ignored if the texture is super compressed and needs transcoding because transcoding
        /// will happen when loading the file.
        /// </summary>
        public bool LazyLoad = false;
    }

    private static KtxTextureCreateFlagBits LoadFlags(LoadSettings loadSettings)
    {
        return loadSettings.LazyLoad ? KtxTextureCreateFlagBits.NoFlags : KtxTextureCreateFlagBits.LoadImageDataBit;
    }

    private static KtxErrorCode Transcode(KtxTextureHandle textureHandle, KtxTranscodeFmt transcodeFormat)
    {
        var ktxTexture2Handle = textureHandle.AsKtxTexture2Handle();
        var result = ktxTexture2Handle.TranscodeBasis(transcodeFormat, KtxTranscodeFlagBits.HighQuality);
        return result;
    }

    public static FrozenSet<string> SupportedExtensions { get; } =
        FrozenSet.Create(StringComparer.OrdinalIgnoreCase, [".ktx", ".ktx2"]);
}
