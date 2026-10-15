namespace Brutal.TextureApi.Abstractions;

/// <summary>
/// Represents a region of texture data to be copied to a staging buffer.
/// </summary>
public class StagingRegion
{
    /// <summary>
    /// Offset from the start of the texture data to start copying from.
    /// </summary>
    public ByteSize SourceStartOffset;

    /// <summary>
    /// Offset within the destination staging buffer to start copying data to.
    /// </summary>
    public ByteSize DestinationOffset;

    /// <summary>
    /// How many bytes of data to copy.
    /// </summary>
    public ByteSize SizeInBytes;

    /// <summary>
    /// How many blocks wide is a single row of image data.
    /// </summary>
    public int RowWidthInBlocks;

    /// <summary>
    /// How many bytes does a block take up. This is directly related
    /// to the <see cref="TextureFormat" /> of the texture data that's being staged.
    /// </summary>
    public ByteSize BlockSizeBytes;

    /// <summary>
    /// How many bytes from the start of one one row of the texture to the start
    /// of the next row.
    ///
    /// This can be > BlockSizeBytes * RowWidthInBlocks. Specifically this is the case
    /// for some KTX version 1 textures because they are padded to support OpenGL texture uploading.
    /// Almost all other formats will have RowPitch == RowwidthInBlocks * BlockSizeBytes but
    /// do not just assume that is the case and use this field for memory calculations on texture data.
    /// </summary>
    public required ByteSize RowPitch;
}
