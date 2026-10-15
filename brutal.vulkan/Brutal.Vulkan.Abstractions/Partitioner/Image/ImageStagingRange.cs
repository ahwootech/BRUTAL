namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Struct representing a sub-image resource, containing the image handle, subresource, offset and extent
/// Used to help with staging resources
/// </summary>
public struct ImageStagingRange
{
    /// <summary>
    /// Image handle
    /// </summary>
    public VkImage Image;

    /// <summary>
    /// Subresource range of the image
    /// </summary>
    public VkImageSubresourceRange SubresourceRange;

    /// <summary>
    /// Number of mip levels in the subresource
    /// </summary>
    public int MipLevels => SubresourceRange.LevelCount;

    /// <summary>
    /// Offset of the sub-image within the original image
    /// </summary>
    public VkOffset3D Offset;

    /// <summary>
    /// Extent of the sub-image
    /// </summary>
    public VkExtent3D Extent;

    /// <summary>
    /// Create a staging range from an image, extent and subresource range
    /// </summary>
    /// <param name="image"></param>
    /// <param name="extent3D"></param>
    /// <param name="subresourceRange"></param>
    /// <returns></returns>
    public static ImageStagingRange FromImage(
        VkImage image,
        VkExtent3D extent3D,
        VkImageSubresourceRange subresourceRange
    )
    {
        return new ImageStagingRange
        {
            Image = image,
            SubresourceRange = subresourceRange,
            Offset = new VkOffset3D(),
            Extent = extent3D,
        };
    }

    /// <summary>
    /// Convenience method to get a staging subresource struct for this sub-image
    /// </summary>
    /// <returns></returns>
    public static ImageStagingRange FromPartition(ImageViewPartitionInfo subImage)
    {
        return new ImageStagingRange
        {
            Image = subImage.VkImage,
            SubresourceRange = subImage.LocalSubresourceRange,
            Offset = subImage.Offset,
            Extent = subImage.Extent,
        };
    }
}
