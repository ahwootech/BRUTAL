namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Wrapper struct for a Vulkan image view
/// </summary>
public readonly struct ImageViewEx(
    Device device,
    ImageEx image,
    VkImageView imageView,
    VkImageViewType imageViewType,
    VkImageSubresourceRange subresourceRange,
    VkAllocator? allocator
) : IDisposable, INullable
{
    public readonly ImageEx Image = image;
    public readonly VkImageView VkImageView = imageView;
    public readonly VkImageViewType Type = imageViewType;
    public readonly VkImageSubresourceRange SubresourceRange = subresourceRange;

    public bool IsNull() => VkImageView.IsNull();

    /// <inheritdoc />
    public void Dispose()
    {
        device.DestroyImageView(VkImageView, allocator);
    }

    public ImageViewPartitionInfo AsPartition()
    {
        if (IsNull())
            throw new NullReferenceException(nameof(VkImageView));

        return new ImageViewPartitionInfo(
            this,
            Image.AllocationInfo.ArrayLayers,
            0,
            Image.Extent,
            new VkOffset3D(),
            null
        );
    }

    public static implicit operator ImageViewPartitionInfo(ImageViewEx inValue) => inValue.AsPartition();
}
