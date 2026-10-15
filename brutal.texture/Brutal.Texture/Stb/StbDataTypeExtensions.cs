using Brutal.TextureApi;

namespace Brutal.TextureApi.Stb;

public static class StbDataTypeExtensions
{
    public static StbApi.Stb.DataType ToStbDataType(this TextureFormat format)
    {
        switch (format)
        {
            case TextureFormat.R8_UNorm:
            case TextureFormat.R8G8_UNorm:
            case TextureFormat.R8G8B8_UNorm:
            case TextureFormat.R8G8B8A8_UNorm:
                return StbApi.Stb.DataType._8Bit;
            case TextureFormat.R16_UNorm:
            case TextureFormat.R16G16_UNorm:
            case TextureFormat.R16G16B16_UNorm:
            case TextureFormat.R16G16B16A16_UNorm:
                return StbApi.Stb.DataType._16Bit;
            case TextureFormat.R32_SFloat:
            case TextureFormat.R32G32_SFloat:
            case TextureFormat.R32G32B32_SFloat:
            case TextureFormat.R32G32B32A32_SFloat:
                return StbApi.Stb.DataType.Float;
            default:
                throw new ArgumentOutOfRangeException(nameof(format), format, "TextureFormat not supported by Stb");
        }
    }
}
