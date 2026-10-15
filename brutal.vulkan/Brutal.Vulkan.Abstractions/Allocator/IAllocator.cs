namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Base interface for a Vulkan allocator
/// </summary>
public interface IAllocator
{
    /// <summary>
    /// Get the Vulkan device this allocator is associated with
    /// </summary>
    /// <returns>Vulkan device handle</returns>
    Device GetDevice();

    VkAllocator? VkAllocator { get; }

    /// <summary>
    /// Safely maps memory (allocated by this allocator) to a pointer.
    /// </summary>
    /// <param name="allocationMapInfo">Allocation info for memory</param>
    /// <returns>Pointer to mapped memory</returns>
    Ptr MapMemory(in AllocationMapInfo allocationMapInfo);

    /// <summary>
    /// Safely unmaps memory (allocated by this allocator) from a pointer
    /// </summary>
    /// <param name="allocationMapInfo">Allocation info for memory</param>
    void UnmapMemory(in AllocationMapInfo allocationMapInfo);
}
