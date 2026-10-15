namespace Brutal.TextureApi.Abstractions;

/// <summary>
/// Holds information about a <see cref="TextureFormat" />.
/// </summary>
/// <remarks>
/// <para />
/// Planar formats are not represented well by a FormatDescriptor. While a FormatDescriptor might be instantiated for a planar
/// texture format, the properties of the FormatDescriptor should not be relied upon.
/// </remarks>
/// <remarks>
/// This structure is taken from libktx in the file KTX-SOFTWARE\lib\vk_format.h
/// </remarks>
public readonly record struct FormatDescriptor
{
    [Flags]
    public enum DescriptorFlags
    {
        None = 0,
        PackedBit = 1,
        CompressedBit = 2,
        DepthBit = 4,
        StencilBit = 8,
        PlanarBit = 16,
    }

    public FormatDescriptor(
        DescriptorFlags flags,
        uint blockSizeInBits,
        uint blockWidth,
        uint blockHeight,
        uint blockDepth,
        uint minBlockX,
        uint minBlockY
    )
    {
        Flags = flags;
        BlockSizeInBits = blockSizeInBits;
        BlockWidth = blockWidth;
        BlockHeight = blockHeight;
        BlockDepth = blockDepth;
        MinBlocksX = minBlockX;
        MinBlocksY = minBlockY;
    }

    public bool IsBlockCompressed => (Flags & DescriptorFlags.CompressedBit) != 0;
    public bool IsPacked => (Flags & DescriptorFlags.PackedBit) != 0;
    public bool IsDepth => (Flags & DescriptorFlags.DepthBit) != 0;
    public bool IsStencil => (Flags & DescriptorFlags.StencilBit) != 0;
    public bool IsPlanar => (Flags & DescriptorFlags.PlanarBit) != 0;

    /// <summary>
    /// Returns the size of a block in bytes
    /// </summary>
    public ByteSize BlockSizeInBytes => (ByteSize)(BlockSizeInBits >> 3);

    /// <summary>
    /// Extent of a block. i.e how many texels wide, high and deep a block one block of this TextureFormat is.
    /// For non block-compressed formats this will be equivalent to TexelCount(1,1,1)
    /// </summary>
    public TexelCount3 BlockExtent => new((int)BlockWidth, (int)BlockHeight, (int)BlockDepth);

    public DescriptorFlags Flags { get; }

    public uint BlockSizeInBits { get; }

    /// <summary>
    /// Width of block in texels. For compressed formats this is how many pixels wide the block represents.
    /// </summary>
    public uint BlockWidth { get; }

    /// <summary>
    /// Height of block in texels. For compressed formats this is how many pixels high the block represents.
    /// </summary>
    public uint BlockHeight { get; }

    /// <summary>
    /// Depth of the block in texels. For compressed formats this is how many pixels deep the block represents.
    /// </summary>
    public uint BlockDepth { get; }

    /// <summary>
    /// Minimum number of blocks wide the format must have
    /// </summary>
    public uint MinBlocksX { get; }

    /// <summary>
    /// Minimum number of blocks high the format must have
    /// </summary>
    public uint MinBlocksY { get; }
}
