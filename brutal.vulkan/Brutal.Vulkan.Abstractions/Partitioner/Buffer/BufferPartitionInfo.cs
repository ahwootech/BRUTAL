namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Allocation information for a partition of a buffer allocation (portion of a larger buffer)
/// </summary>
/// <param name="Partitioner">Buffer partitioner that created this partition</param>
/// <param name="BufferInfo">Information about this allocation within the buffer</param>
/// <param name="PartitionOffset">Offset within owning buffer where this partition starts</param>
/// <param name="PartitionSize">Size of this partition</param>
public readonly record struct BufferPartitionInfo(
    IBufferPartitioner? Partitioner,
    BufferAllocationInfo BufferInfo,
    ByteSize PartitionOffset,
    ByteSize PartitionSize
) : IMappable, IBindBuffer
{
    public record struct CreateInfo(ByteSize Size);

    /// <summary>
    /// Reference to the parent Vulkan buffer
    /// </summary>
    public VkBuffer VkBuffer => BufferInfo.VkBuffer;

    /// <summary>
    /// Offset within the parent buffer where this partition starts
    /// </summary>
    public ByteSize BindOffset => BufferInfo.BufferOffset + PartitionOffset;

    /// <summary>
    /// Offset within the owning device memory allocation where this partition starts
    /// </summary>
    public ByteSize MemoryOffset => BufferInfo.AllocationInfo.AllocOffset + BindOffset;

    /// <summary>
    /// If true, this partition is a full buffer allocation
    /// </summary>
    public bool IsFullPartition => Partitioner is null;

    /// <summary>
    /// Convenience function to create a partition info object for a full buffer allocation
    /// </summary>
    /// <param name="bufferAllocationInfo">BufferAllocationInfo object</param>
    /// <returns>BufferAllocationInfo as BufferPartitionInfo, with the 'partition' covering the entire buffer</returns>
    public static BufferPartitionInfo FullPartition(BufferAllocationInfo bufferAllocationInfo)
    {
        return new BufferPartitionInfo(
            Partitioner: null,
            BufferInfo: bufferAllocationInfo,
            PartitionSize: bufferAllocationInfo.BufferSize,
            PartitionOffset: ByteSize.Zero
        );
    }

    AllocationInfo IMappable.AllocationInfo => BufferInfo.AllocationInfo;
    ByteSize IMappable.MapSize => PartitionSize;
    ByteSize IMappable.MapOffset => PartitionOffset;
}
