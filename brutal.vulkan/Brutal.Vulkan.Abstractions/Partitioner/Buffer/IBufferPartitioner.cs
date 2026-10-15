namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Interface for a buffer partitioner object capable of allocating and freeing partitions of a buffer
/// </summary>
public interface IBufferPartitioner
{
    BufferPartitionInfo BackingPartition { get; protected set; }

    /// <summary>
    /// Reset the partitioner to its initial state with the given partition info. Invalidates all current allocations.
    /// </summary>
    /// <param name="info"></param>
    public void Reset(BufferPartitionInfo info);

    /// <summary>
    /// Allocate a buffer partition with the given required size
    /// </summary>
    /// <param name="createInfo">Struct containing all relevant information about the allocation</param>
    /// <param name="partition">The resulting partition</param>
    /// <returns>True if the allocation was successful</returns>
    public bool TryCreatePartition(BufferPartitionInfo.CreateInfo createInfo, out BufferPartitionInfo partition);
}

/// <summary>
/// Interface for a buffer partitioner object capable of allocating and freeing partitions of a buffer
/// </summary>
public interface IRecycleBufferPartitioner : IBufferPartitioner
{
    /// <summary>
    /// Free a buffer partition
    /// </summary>
    /// <param name="inAllocation">Struct containing all relevant information about the allocation</param>
    public void FreePartition(in BufferPartitionInfo inAllocation);
}

public static class BufferPartitionerExtensions
{
    public static BufferPartitionInfo CreatePartition<T>(
        this T partitioner,
        in BufferPartitionInfo.CreateInfo createInfo
    )
        where T : IBufferPartitioner
    {
        if (!partitioner.TryCreatePartition(createInfo, out var partition))
            throw new OutOfMemoryException("Failed to create partition");

        return partition;
    }

    /// <inheritdoc cref="IBufferPartitioner.Reset"/>
    public static void Reset(this IBufferPartitioner partitioner)
    {
        partitioner.Reset(partitioner.BackingPartition);
    }
}
