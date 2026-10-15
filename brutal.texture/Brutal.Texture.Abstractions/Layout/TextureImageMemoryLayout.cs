namespace Brutal.TextureApi.Abstractions;

/// <summary>
/// Describes how one image (mip level) of a texture is laid out in memory.
/// </summary>
public class TextureImageMemoryLayout
{
    /// <summary>
    /// Create a TextureImageMemoryLayout from a set of texture properties.
    /// </summary>
    /// <param name="extent">The ImageExtent of the image</param>
    /// <param name="rowPitch">The rowpitch in bytes of the image</param>
    /// <param name="blockSizeInBytes">The number of bytes a single block takes up.</param>
    public TextureImageMemoryLayout(ImageExtent extent, ByteSize rowPitch, ByteSize blockSizeInBytes)
    {
        Extent = extent;
        RowPitch = rowPitch;
        RowPadBytes = RowPitch - Extent.Blocks.X * blockSizeInBytes;
    }

    /// <summary>
    /// Gets the ImageExtent of this TextureImageMemoryLayout. This includes both the extents in texels
    /// and in blocks.
    /// </summary>
    public ImageExtent Extent { get; }

    /// <summary>
    /// Gets the number of bytes between the start of consecutive rows in the buffer.
    /// </summary>
    public ByteSize RowPitch { get; }

    /// <summary>
    /// Gets the number of padding bytes added to each row in the data structure.
    /// </summary>
    public ByteSize RowPadBytes { get; }

    /// <summary>
    /// The number of bytes the x extent texel blocks take up.
    /// For uncompressed formats this is the extent texel width * bytes per texel.
    /// For compressed formats this is the extent in whole blocks * bytes per block.
    /// </summary>
    public ByteSize RowExtentBytes => RowPitch - RowPadBytes;

    /// <summary>
    /// Does this layout have padding at the end of each row?
    /// </summary>
    public bool IsRowPadded => RowPadBytes > 0;
}
