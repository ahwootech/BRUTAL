/*
 * HelloGli
 *
 * Creates a texture with a full mip chain using GLI, saves it as a .dds and loads it back.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Gli@2026.10.2
#:package Ahwoo.Brutal.Numerics@2026.10.2

// RIAN: This package may be deprecated in the future, as the extensions it supports may be covered by better packages.

using Brutal.GliApi;
using Brutal.Numerics;

Run();

static void Run()
{
    var extent = new int3(64, 64, 1);

    // A 2D RGBA texture with a full mip chain (64x64 down to 1x1).
    using var texture = new Gli.Texture(
        Gli.Target._2D,
        Gli.Format.RGBA8_UNorm_Pack8,
        extent,
        1,
        1,
        7,
        Gli.Swizzles.Identity
    );

    unsafe
    {
        // Only the top mip level is filled; the smaller levels are left empty.
        new Span<byte4>(texture.ImageData(0), extent.X * extent.Y).Fill(new byte4(255, 128, 0, 255));
    }

    var path = Path.Combine(Path.GetTempPath(), "HelloGli.dds");
    texture.Save(path);
    Console.WriteLine($"Wrote {path}");

    using var loaded = new Gli.Texture(path);
    Console.WriteLine($"Loaded {loaded.Target} {loaded.Format}, {loaded.Levels} levels, {loaded.Size} bytes");
    for (var level = 0; level < loaded.Levels; level++)
        Console.WriteLine(
            $"  Level {level}: {loaded.ImageExtent(level).X}x{loaded.ImageExtent(level).Y}, {loaded.ImageSize(level)} bytes"
        );
}
