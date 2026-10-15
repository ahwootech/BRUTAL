namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Struct containing information about a buffer allocation
/// </summary>
/// <param name="VkBuffer">Handle to the Vulkan buffer</param>
/// <param name="BufferOffset">Offset within the buffer where this allocation starts</param>
/// <param name="BufferSize">Size of the allocation within the buffer</param>
/// <param name="Usage">Usage flags this buffer supports, for reference</param>
/// <param name="AllocationInfo">The internal memory allocation</param>
public readonly record struct BufferAllocationInfo(
    VkBuffer VkBuffer,
    ByteSize BufferOffset,
    ByteSize BufferSize,
    VkBufferUsageFlags Usage,
    AllocationInfo AllocationInfo
) : IMappable
{
    ByteSize IMappable.MapSize => BufferSize;
    ByteSize IMappable.MapOffset => BufferOffset;
}

/// <summary>
/// Interface for a buffer allocator object capable of allocating and freeing buffers
/// </summary>
public interface IBufferAllocator : IAllocator
{
    /// <summary>
    /// Allocate a buffer with the given creation and allocation info
    /// </summary>
    /// <param name="name"></param>
    /// <param name="bufferCreateInfo">Vulkan buffer creation info</param>
    /// <param name="allocateCreateInfo">Memory allocation info</param>
    /// <returns>Struct containing all relevant information about allocation</returns>
    public BufferAllocationInfo AllocateBuffer(
        in string name,
        in VkBufferCreateInfo bufferCreateInfo,
        in AllocationInfo.CreateInfo allocateCreateInfo
    );

    /// <summary>
    /// Free buffer allocation
    /// </summary>
    /// <param name="inAllocation">Allocation info for the buffer previously sourced from this allocator</param>
    public void FreeAllocation(in BufferAllocationInfo inAllocation);
}
