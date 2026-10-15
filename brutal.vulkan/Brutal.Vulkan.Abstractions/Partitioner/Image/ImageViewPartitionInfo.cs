namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Allocation information for a partition of an image allocation (portion of a larger image)
/// </summary>
/// <param name="ImageView">Handle to the source image view</param>
/// <param name="ArrayCount">Number of array layers allocated to this sub-image, within ImageViewSubresourceRange</param>
/// <param name="ArrayOffset">Array offset of the sub-image, within ImageViewSubresourceRange</param>
/// <param name="Extent">Size of the sub-image</param>
/// <param name="Offset">Offset of the sub-image within the original image</param>
/// <param name="Partitioner">Source object that created this partition, if any. If null, assume this is a full image allocation</param>
public readonly record struct ImageViewPartitionInfo(
    ImageViewEx ImageView,
    int ArrayCount,
    int ArrayOffset,
    VkExtent3D Extent,
    VkOffset3D Offset,
    IImageViewPartitioner? Partitioner
)
{
    /// <summary>
    /// Creation information for a sub-image allocation
    /// </summary>
    /// <param name="Extent">Size of the sub-image</param>
    /// <param name="LayerCount">Number of array layers allocated to this sub-image, within ImageViewSubresourceRange</param>
    public record struct CreateInfo(VkExtent3D Extent, int LayerCount);

    /// <summary>
    /// If true, this partition is a full image allocation
    /// </summary>
    public bool IsFullPartition => Partitioner is null;

    public ImageEx Image => ImageView.Image;

    /// <summary>
    /// Image handle
    /// </summary>
    public VkImage VkImage => Image.VkImage;

    /// <summary>
    /// Subresource range of the actual sub-image, within the original image
    /// </summary>
    public VkImageSubresourceRange LocalSubresourceRange =>
        ImageView.SubresourceRange with
        {
            BaseArrayLayer = ImageView.SubresourceRange.BaseArrayLayer + ArrayOffset,
            LayerCount = ArrayCount,
        };

    /// <summary>
    /// Get the normalized offset of the sub-image within the original image.
    /// EG: for UV mapping
    /// </summary>
    /// <returns>Normalized offset as float3</returns>
    public readonly float3 GetNormalizedOffset()
    {
        var totalExtent = Image.Extent;
        return new float3(
            Offset.X / (float)totalExtent.Width,
            Offset.Y / (float)totalExtent.Height,
            Offset.Z / (float)totalExtent.Depth
        );
    }

    /// <summary>
    /// Get the normalized extent of the sub-image within the original image
    /// EG: for UV mapping
    /// </summary>
    /// <returns>Normalized extent as float3</returns>
    public readonly float3 GetNormalizedExtent()
    {
        var totalExtent = Image.Extent;
        return new float3(
            Extent.Width / (float)totalExtent.Width,
            Extent.Height / (float)totalExtent.Height,
            Extent.Depth / (float)totalExtent.Depth
        );
    }
}
