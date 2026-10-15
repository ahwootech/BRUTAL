using System.Collections.Frozen;
using Brutal.Pointers.Extensions;

namespace Brutal.TextureApi.Gli;

public static partial class Loader
{
    public static GliTexture LoadFromFile(string filePath)
    {
        var nativeTexture = new GliApi.Gli.Texture(filePath);

        if (nativeTexture.IsNull())
        {
            nativeTexture.Dispose();
            throw new GliTextureException($"Failed to load texture from filePath \"{filePath}\"");
        }

        return new GliTexture(nativeTexture);
    }

    public static unsafe GliTexture LoadFromMemory(ReadOnlySpan<byte> data)
    {
        var nativeTexture = new GliApi.Gli.Texture(data);

        if (nativeTexture.IsNull())
        {
            nativeTexture.Dispose();
            throw new GliTextureException($"Failed to load texture from data at 0x{(nint)data.AsPointer()}");
        }

        return new GliTexture(nativeTexture);
    }

    public static FrozenSet<string> SupportedExtensions { get; } =
        FrozenSet.Create(StringComparer.OrdinalIgnoreCase, [".dds", ".ktx", ".kmg"]);
}
