namespace Brutal.TextureApi.Abstractions;

/// <summary>
/// Represents the 3 dimensional extents of one image (mip level) of a texture and includes
/// its dimensions in both texels and blocks.
/// </summary>
public readonly record struct ImageExtent
{
    /// <summary>
    /// Creates an ImageExtent representing the 3 dimensions of one mip level of a texture from the larges image dimension
    /// of the texture and texel dimensions of one block of the image.
    /// </summary>
    /// <remarks>
    /// <para />The Blocks property dimensions are rounded-up from Texels / blockTexelDimensions and will always be at least 1
    /// </remarks>
    /// <param name="level0ImageTexelDimensions">Dimensions of the largest mip level, in whole texels.</param>
    /// <param name="blockTexelDimensions">The dimensions of one block, in whole texels</param>
    /// <exception cref="ArgumentOutOfRangeException">Throws ArgumentOutOfRangeException if level is less than 0</exception>
    public ImageExtent(TexelCount3 level0ImageTexelDimensions, int mipLevel, TexelCount3 blockTexelDimensions)
    {
        Level = mipLevel;

        Texels = new TexelCount3(
            level0ImageTexelDimensions.X >> mipLevel,
            level0ImageTexelDimensions.Y >> mipLevel,
            level0ImageTexelDimensions.Z >> mipLevel
        );
        Blocks = InBlocks(Texels, blockTexelDimensions);
    }

    /// <summary>
    /// The dimensions of this texture in Blocks
    /// </summary>
    public BlockCount3 Blocks { get; }
    public TexelCount3 Texels { get; }
    public int Level { get; init; }

    public static BlockCount3 InBlocks(TexelCount3 imageTexelDimensions, TexelCount3 blockTexelDimensions)
    {
        return new BlockCount3(
            (int)MathF.Max(1, MathF.Ceiling(imageTexelDimensions.X / (float)blockTexelDimensions.X)),
            (int)MathF.Max(1, MathF.Ceiling(imageTexelDimensions.Y / (float)blockTexelDimensions.Y)),
            (int)MathF.Max(1, MathF.Ceiling(imageTexelDimensions.Z / (float)blockTexelDimensions.Z))
        );
    }
}
