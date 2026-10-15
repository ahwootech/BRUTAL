namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Structure to hold synchronization objects for the Renderer
/// </summary>
public class SyncObjects(Device inDevice) : IDisposable
{
    /// <summary>
    ///
    /// </summary>
    public required VkSemaphore ImageReadySemaphore;

    /// <summary>
    ///
    /// </summary>
    public required VkSemaphore RenderingFinishedSemaphore;

    /// <summary>
    /// Signaled Fence
    /// </summary>
    public required VkFence Fence;

    /// <summary>
    /// A CommandBuffer from the Graphics pool which can be used for rendering commands.
    /// </summary>
    public required CommandBuffer CommandBuffer;

    /// <summary>
    /// The allocator the sync objects were created with
    /// </summary>
    public required VkAllocator? Allocator;

    public void Dispose()
    {
        inDevice.DestroyFence(Fence, Allocator);
        inDevice.DestroySemaphore(ImageReadySemaphore, Allocator);
        inDevice.DestroySemaphore(RenderingFinishedSemaphore, Allocator);
    }
}
