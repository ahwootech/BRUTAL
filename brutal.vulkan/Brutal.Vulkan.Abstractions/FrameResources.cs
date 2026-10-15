namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Structure to hold frame resources for the Renderer
/// </summary>
public class FrameResources(Device inDevice) : IDisposable
{
    /// <summary> Index of this frame </summary>
    public int FrameIndex = 0;

    /// <summary> Framebuffer for this frame </summary>
    public VkFramebuffer Framebuffer = default;

    /// <summary> Image for the swapchain </summary>
    public VkImage ColorImage = default;

    /// <summary> Whether this frame owns the color image </summary>
    public bool OwnsColorImage = false;

    /// <summary> Bound memory for the SwapchainImage </summary>
    public VkDeviceMemory ColorImageMemory = default;

    /// <summary> Image view for the swapchain </summary>
    public VkImageView ColorImageView = default;

    /// <summary> Image for the depth buffer </summary>
    public VkImage DepthImage = default;

    /// <summary> Bound memory for the DepthImage </summary>
    public VkDeviceMemory DepthImageMemory = default;

    /// <summary> Image view for the depth buffer </summary>
    public VkImageView DepthImageView = default;

    /// <summary> Image for the multisampled image </summary>
    public VkImage MultisampledImage = default;

    /// <summary> Bound memory for the MultisampledImage </summary>
    public VkDeviceMemory MultisampledImageMemory = default;

    /// <summary> Image view for the multisampled image </summary>
    public VkImageView MultisampledImageView = default;

    public required VkAllocator? Allocator;

    public void Dispose()
    {
        inDevice.DestroyImageView(ColorImageView, Allocator);
        inDevice.DestroyImageView(DepthImageView, Allocator);
        inDevice.DestroyImageView(MultisampledImageView, Allocator);

        if (OwnsColorImage)
        {
            inDevice.DestroyImage(ColorImage, Allocator);
            inDevice.FreeMemory(ColorImageMemory, Allocator);
        }

        inDevice.DestroyImage(DepthImage, Allocator);
        inDevice.DestroyImage(MultisampledImage, Allocator);
        inDevice.FreeMemory(DepthImageMemory, Allocator);
        inDevice.FreeMemory(MultisampledImageMemory, Allocator);

        inDevice.DestroyFramebuffer(Framebuffer, Allocator);
    }
}
