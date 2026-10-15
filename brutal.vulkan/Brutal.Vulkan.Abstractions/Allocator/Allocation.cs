namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Struct containing information about a memory allocation. Intentionally made similar to VMA's AllocationInfo
/// </summary>
/// <param name="Allocator">Allocator that sourced this allocation</param>
/// <param name="Memory">Device memory handle</param>
/// <param name="AllocSize">Size available in the memory allocation (might be more than requested)</param>
/// <param name="AllocOffset">Offset into the memory allocation</param>
/// <param name="MemoryTypeIndex">Memory type this allocation was made from</param>
/// <param name="AllocHandle">Custom handle, optionally used by allocator</param>
public readonly record struct AllocationInfo(
    IAllocator Allocator,
    VkDeviceMemory Memory,
    ByteSize AllocSize,
    ByteSize AllocOffset,
    int MemoryTypeIndex,
    nint AllocHandle
)
{
    /// <summary>
    /// Struct containing information about a memory allocation. Intentionally made similar to VMA's AllocationCreateInfo
    /// </summary>
    /// <param name="Preference">Memory location preference can just leave as 'None'</param>
    /// <param name="RequiredProperties">Flags that must be set in a Memory Type chosen for an allocation</param>
    /// <param name="PreferredProperties">Flags that preferably should be set in a memory type chosen for an allocation</param>
    /// <param name="Priority">A floating-point value between 0 and 1, indicating the priority of the allocation relative to other memory allocations</param>
    /// <param name="Next">For advanced use only. A pointer to an application-defined structure that can be used to pass custom data to the allocator</param>
    public record struct CreateInfo(
        MemoryPreference Preference,
        VkMemoryPropertyFlags RequiredProperties,
        VkMemoryPropertyFlags PreferredProperties,
        float Priority,
        Ptr Next
    );
}

/// <summary>
/// Enum listing memory allocation preferences: whether to prefer GPU or CPU memory
/// </summary>
public enum MemoryPreference : byte
{
    None,
    PreferGpu,
    PreferCpu,
}
