namespace Brutal.VulkanApi;

public class VkAllocator(VkAllocationCallbacks callbacks) : IDisposable
{
    PtrOwner<VkAllocationCallbacks> ptr = new(callbacks);

    public static unsafe implicit operator VkAllocationCallbacks*(VkAllocator? allocator) => allocator?.ptr ?? null;

    public void Dispose()
    {
        ptr.Dispose();
    }
}
