namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Interface for a sub-image allocator object capable of allocating portions of an image (e.g.: texture atlas, or texture array)
/// </summary>
public interface IImageViewPartitioner
{
    /// <summary>
    /// Get the handle to the backing ImageView this partitioner is based on
    /// </summary>
    /// <returns></returns>
    public ImageViewPartitionInfo BackingPartition { get; protected set; }

    /// <summary>
    /// Reset the partitioner to its initial state with the given partition info. Invalidates all current allocations.
    /// </summary>
    /// <param name="info"></param>
    public void Reset(ImageViewPartitionInfo info);

    /// <summary>
    /// Get a partition of an imageview with the given creation info.
    /// </summary>
    /// <param name="createInfo">Partition creation info</param>
    /// <param name="partition">The resulting partition</param>
    /// <returns>True if the allocation was successful</returns>
    public bool TryCreatePartition(
        in ImageViewPartitionInfo.CreateInfo createInfo,
        out ImageViewPartitionInfo partition
    );
}

/// <summary>
/// Interface for a sub-image allocator object capable of allocating portions of an image (e.g.: texture atlas, or texture array)
/// </summary>
public interface IRecycleImageViewPartitioner : IImageViewPartitioner
{
    /// <summary>
    /// Free an imageview partition sourced from this partitioner
    /// </summary>
    /// <param name="inAllocation">Struct containing all relevant information about the allocation/partition</param>
    public void FreePartition(in ImageViewPartitionInfo inAllocation);
}

public static class ImageViewPartitionerExtensions
{
    public static ImageViewPartitionInfo CreatePartition<T>(
        this T partitioner,
        in ImageViewPartitionInfo.CreateInfo createInfo
    )
        where T : IImageViewPartitioner
    {
        if (!partitioner.TryCreatePartition(createInfo, out var partition))
            throw new OutOfMemoryException("Failed to create partition");

        return partition;
    }
}
