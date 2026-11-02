/*
 * HelloKtx
 *
 * Creates a KTX2 texture, fills it with a checkerboard, writes it to disk and loads it back.
 */

#:package Ahwoo.Brutal.Ktx@2026.10.2

using Brutal.KtxApi;
using Brutal.KtxApi.Abstractions;

const int SIZE = 64;

Run();

static void Run()
{
    var createInfo = new KtxTextureCreateInfo
    {
        VkFormat = (uint)VkFormat.R8G8B8A8Unorm,
        BaseWidth = SIZE,
        BaseHeight = SIZE,
        BaseDepth = 1,
        NumDimensions = 2,
        NumLevels = 1,
        NumLayers = 1,
        NumFaces = 1,
    };

    KtxTexture2.Create(ref createInfo, KtxTextureCreateStorageEnum.TextureCreateAllocStorage, out var texture);

    var path = Path.Combine(Path.GetTempPath(), "HelloKtx.ktx2");

    // The texture is only needed until it is written, so it is disposed at the end of this block.
    using (texture)
    {
        // Fill mip level 0 with a checkerboard.
        var pixels = new byte[SIZE * SIZE * 4];
        for (var y = 0; y < SIZE; y++)
        for (var x = 0; x < SIZE; x++)
            pixels.AsSpan((y * SIZE + x) * 4, 4).Fill((x / 8 + y / 8) % 2 == 0 ? (byte)255 : (byte)0);

        texture.SetImageFromMemory(0, 0, 0, pixels);
        texture.WriteToNamedFile(path);
    }

    Console.WriteLine($"Wrote {path}");

    KtxTexture2.CreateFromMemory(File.ReadAllBytes(path), KtxTextureCreateFlagBits.LoadImageDataBit, out var loaded);

    using (loaded)
    {
        Console.WriteLine(
            $"Loaded {loaded.BaseWidth}x{loaded.BaseHeight} {loaded.GetVkFormat()}, {loaded.NumLevels} level(s), {loaded.DataSize} bytes"
        );
    }
}
