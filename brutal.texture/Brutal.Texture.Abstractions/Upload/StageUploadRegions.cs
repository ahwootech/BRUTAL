namespace Brutal.TextureApi.Abstractions;

/// <summary>
/// Holds a collection of regions for copying texture data from a texture to a staging buffer,
/// and from the staging buffer to an image.
/// </summary>
public class StageUploadRegions
{
    /// <summary>
    /// The regions in the source texture's memory to copy
    /// </summary>
    public List<StagingRegion> StageBufferRegions = [];

    /// <summary>
    /// The regions in a staging buffer copied using the StageBufferRegions
    /// that can be copied to the images on a GPU using a GPU API.
    /// </summary>
    public List<UploadRegion> CopyToImageRegions = [];

    /// <summary>
    /// The minimum number of bytes that your staging buffer needs to be
    /// to accept the copied StageBufferRegions
    /// </summary>
    public ByteSize RequiredBufferSizeBytes;
}
