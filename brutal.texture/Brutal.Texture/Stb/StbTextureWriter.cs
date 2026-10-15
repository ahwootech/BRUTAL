using System.Collections.Frozen;
using CommunityToolkit.HighPerformance;

namespace Brutal.TextureApi.Stb;

public class StbTextureWriteException(string message) : Exception(message);

public static partial class Writer
{
    // The formats stb_image_write can ENCODE. This is the writable subset of the formats the
    // Stb loader can decode (see Stb.Loader.SupportedExtensions). TextureWriter dispatches on
    // this set so load-only formats are rejected at the dispatch layer rather than reaching the
    // SaveToFile switch below.
    public static FrozenSet<string> SupportedExtensions { get; } =
        FrozenSet.Create(StringComparer.OrdinalIgnoreCase, [".png", ".jpg", ".jpeg", ".hdr", ".tga", ".bmp"]);

    public static void SaveToFile(TextureDescriptor descriptor, string filePath, JpegWriteSettings? saveOptions = null)
    {
        SaveToFile(
            filePath,
            descriptor.Format.ToStbDataType(),
            descriptor.Extent.X,
            descriptor.Extent.Y,
            NumChannels(descriptor.Format),
            descriptor.Data,
            saveOptions
        );
    }

    public static void SaveToFile(ITexture texture, string filePath, JpegWriteSettings? saveInfo = null)
    {
        if (texture is StbTexture stbTexture)
        {
            SaveToFile(
                filePath,
                texture.Format.ToStbDataType(),
                texture.Width,
                texture.Height,
                stbTexture.Channels,
                texture.Data,
                saveInfo
            );
        }
        else
        {
            SaveToFile(
                filePath,
                texture.Format.ToStbDataType(),
                texture.Width,
                texture.Height,
                NumChannels(texture.Format),
                texture.Data,
                saveInfo
            );
        }
    }

    internal static void SaveToFile(
        string filePath,
        StbApi.Stb.DataType dataType,
        int width,
        int height,
        int channels,
        ReadOnlySpan<byte> data,
        JpegWriteSettings? saveInfo
    )
    {
        var extension = Path.GetExtension(filePath.ToLowerInvariant().AsSpan());

        ValidateDataType(dataType, extension);

        bool result;
        switch (extension)
        {
            case ".png":
            {
                var stride = channels * width;
                result = StbApi.Stb.WritePng(filePath, width, height, channels, data, stride);
                break;
            }
            case ".bmp":
                result = StbApi.Stb.WriteBmp(filePath, width, height, channels, data);
                break;
            case ".tga":
                result = StbApi.Stb.WriteTga(filePath, width, height, channels, data);
                break;
            case ".jpg" or ".jpeg":
            {
                var settings = saveInfo ?? JpegWriteSettings.Default;
                var quality = settings.Quality;

                result = StbApi.Stb.WriteJpg(filePath, width, height, channels, data, quality);
                break;
            }
            case ".hdr":
                result = StbApi.Stb.WriteHdr(filePath, width, height, channels, data.Cast<byte, float>());
                break;
            default:
                throw new StbTextureWriteException($"Unsupported file extension {extension}");
        }

        if (result)
            return;

        var failureReason = (StbApi.Stb.TryGetFailureReason(out var reason) ? reason : "Unknown");
        throw new StbTextureWriteException(
            $"Failed to write texture to file at path: {filePath}, reason: {failureReason}"
        );
    }

    private static void ValidateDataType(StbApi.Stb.DataType dataType, ReadOnlySpan<char> extension)
    {
        // Validate that we can write this format to the desired file type.
        // Stb only supports writing from 8 bit data, with the exception of .hdr which requires float data
        if (extension is ".hdr" && dataType is not StbApi.Stb.DataType.Float)
            throw new StbTextureWriteException("Textures can only be saved as .hdr if they are of a float-type format");

        if (dataType is not StbApi.Stb.DataType._8Bit)
            throw new StbTextureWriteException(".png, .bmp, .tga, .jpg, .jpeg only support 8-bit textures");
    }

    public class JpegWriteSettings
    {
        public const int DEFAULT_QUALITY = 90;

        /// <summary>
        ///     The quality value to use in jpeg write compression, 1 lowest => 100 highest
        /// </summary>
        public int Quality;

        public static JpegWriteSettings Default => new() { Quality = DEFAULT_QUALITY };
    }

    private static int NumChannels(TextureFormat format)
    {
        switch (format)
        {
            case TextureFormat.R8_UNorm:
            case TextureFormat.R16_UNorm:
            case TextureFormat.R32_SFloat:
                return 1;
            case TextureFormat.R8G8_UNorm:
            case TextureFormat.R16G16_UNorm:
            case TextureFormat.R32G32_SFloat:
                return 2;
            case TextureFormat.R8G8B8_UNorm:
            case TextureFormat.R16G16B16_UNorm:
            case TextureFormat.R32G32B32_SFloat:
                return 3;
            case TextureFormat.R8G8B8A8_UNorm:
            case TextureFormat.R16G16B16A16_UNorm:
            case TextureFormat.R32G32B32A32_SFloat:
                return 4;
            default:
                throw new ArgumentOutOfRangeException(nameof(format), format, "TextureFormat not supported by Stb");
        }
    }
}
