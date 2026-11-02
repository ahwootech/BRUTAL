/*
 * HelloTexture
 *
 * Prints texture format descriptors, fills a GenericTexture with a gradient, saves it as .png
 * and .ktx2, then loads both back with TextureLoader.
 */

#:package Ahwoo.Brutal.Texture@2026.10.3
#:package Ahwoo.Brutal.Texture.Abstractions@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2

using System.Runtime.InteropServices;
using Brutal.Numerics;
using Brutal.TextureApi;
using Brutal.TextureApi.Abstractions;

Run();

static void Run()
{
    // Format descriptors describe how texels are laid out in memory.
    foreach (var format in new[] { TextureFormat.R8G8B8A8_UNorm, TextureFormat.BC7_UNorm_Block })
    {
        var descriptor = format.Descriptor();
        Console.WriteLine(
            $"{format}: {descriptor.BlockSizeInBytes} per {descriptor.BlockWidth}x{descriptor.BlockHeight} block, compressed: {descriptor.IsBlockCompressed}"
        );
    }

    var pngPath = Path.Combine(Path.GetTempPath(), "HelloTexture.png");
    var ktxPath = Path.Combine(Path.GetTempPath(), "HelloTexture.ktx2");

    // GenericTexture is a plain in-memory texture you can fill and pass to any writer or uploader.
    // Textures aren't IDisposable, so each one is destroyed or unloaded by hand.
    var texture = GenericTexture.Defaults.RGBA8UNorm(new int2(64, 64));
    var texels = MemoryMarshal.Cast<byte, byte4>(texture.Data);
    for (var i = 0; i < texels.Length; i++)
        texels[i] = new byte4((byte)(i % 64 * 4), (byte)(i / 64 * 4), 128, 255);

    TextureWriter.SaveToFile(texture, pngPath);
    TextureWriter.SaveToFile(texture, ktxPath);
    texture.Destroy();

    // TextureLoader picks the right backend (stb, KTX or GLI) from the file extension.
    foreach (var path in new[] { pngPath, ktxPath })
    {
        var loaded = TextureLoader.LoadFromFile(path);
        Console.WriteLine(
            $"{Path.GetFileName(path)}: {loaded.GetType().Name}, {loaded.Format}, {loaded.Extent.X}x{loaded.Extent.Y}, {loaded.Data.Length} bytes"
        );
        TextureLoader.Unload(loaded);
    }
}
