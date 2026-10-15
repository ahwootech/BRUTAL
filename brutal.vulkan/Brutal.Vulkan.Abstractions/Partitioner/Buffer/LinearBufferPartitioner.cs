namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Basic linear allocator/partitioner, allocates memory/partitions in a linear fashion
/// Very simple design, doesn't support freeing any space except for a full clear
/// Provides optional alignment for buffers that require a minimum alignment offset
/// </summary>
public class LinearBufferPartitioner : IBufferPartitioner, ISize
{
    /// <summary>
    /// Basic linear allocator/partitioner, allocates memory/partitions in a linear fashion
    /// Very simple design, doesn't support freeing any space except for a full clear
    /// Provides optional alignment for buffers that require a minimum alignment offset
    /// </summary>
    public LinearBufferPartitioner(BufferPartitionInfo backingPartition, ByteSize alignment = default)
    {
        Alignment = alignment;
        BackingPartition = backingPartition;
        if (GetAlignedOffset(Alignment, backingPartition.BindOffset) != backingPartition.BindOffset)
            throw new Exception("Invalid alignment of backing buffer partition");
    }

    /// <summary>
    /// Backing partition this partitioner is slicing up buffer portions of
    /// </summary>
    public BufferPartitionInfo BackingPartition { get; set; }

    /// <summary>
    /// Capacity of this partitioner
    /// </summary>
    public ByteSize Capacity => BackingPartition.PartitionSize;

    /// <summary>
    /// Current offset from the start of the backing partition
    /// </summary>
    public ByteSize CurrentOffset { get; private set; }

    /// <summary>
    /// Alignment of allocations: if zero, no alignment applied
    /// </summary>
    public readonly ByteSize Alignment;

    /// <inheritdoc />
    int ISize.Size => (int)Capacity;

    /// <summary>
    /// Number of bytes remaining in the partitioner
    /// </summary>
    public ByteSize FreeSpace => Capacity - CurrentOffset;

    /// <inheritdoc />
    public bool TryCreatePartition(BufferPartitionInfo.CreateInfo info, out BufferPartitionInfo partition)
    {
        var size = Alignment > 0 ? GetAlignedOffset(Alignment, info.Size) : info.Size;
        // Check we haven't exceeded the capacity of the partitioner
        if (CurrentOffset + size > Capacity)
        {
            partition = default;
            return false;
        }

        // Claim the space
        var offset = CurrentOffset;
        CurrentOffset += size;

        // Create the partition info object
        partition = new BufferPartitionInfo(
            Partitioner: this,
            BufferInfo: BackingPartition.BufferInfo,
            PartitionOffset: offset + BackingPartition.PartitionOffset,
            PartitionSize: size
        );

        return true;
    }

    /// <inheritdoc />
    public void Reset(BufferPartitionInfo info)
    {
        BackingPartition = info;
        CurrentOffset = ByteSize.Zero;
    }

    /// <summary>
    /// Get an offset (or size of an object) fitting correct minimum memory alignment
    /// </summary>
    /// <param name="alignment">Min Alignment</param>
    /// <param name="offset">Required offset</param>
    /// <returns>Aligned offset</returns>
    public static ByteSize GetAlignedOffset(ByteSize alignment, ByteSize offset)
    {
        return ByteSize.Of((offset + alignment - 1) & ~(alignment - 1));
    }
}
