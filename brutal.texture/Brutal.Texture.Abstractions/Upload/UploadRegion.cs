namespace Brutal.TextureApi.Abstractions;

/// <summary>
/// A region of data for uploading to a range of layers within a single level of an image.
/// </summary>
public class UploadRegion
{
    /// <summary>
    /// Offset in the staging buffer where this region starts.
    /// </summary>
    public ByteSize BufferOffset;

    /// <summary>
    /// The array (or faces if this is a non-array cube map) layer index this region starts at.
    /// </summary>
    public int BaseLayer { get; set; }

    /// <summary>
    /// The number of array layers (or faces if this is a non-array cube map)
    /// this region encompasses.
    /// </summary>
    public int LayerCount { get; set; }

    /// <summary>
    /// The mip level that this UploadRegion starts at.
    /// </summary>
    public int BaseLevel { get; set; }
}
