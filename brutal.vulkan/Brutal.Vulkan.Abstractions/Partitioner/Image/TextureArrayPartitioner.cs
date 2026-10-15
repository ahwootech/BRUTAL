namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Texture array slot partitioner
/// Creates and manages an image array, and this allocator will distribute slots from the array for users to stage/bind to
/// </summary>
public class TextureArrayPartitioner : IRecycleImageViewPartitioner
{
    public ImageViewPartitionInfo BackingPartition { get; set; }

    /// <summary>
    /// Free list of texture array slots
    /// </summary>
    private readonly FreeListIndexPool _textureArraySlots;

    /// <summary>
    /// Total number of slots in the texture array
    /// </summary>
    public int TotalSlots => BackingPartition.LocalSubresourceRange.LayerCount;

    /// <summary>
    /// Construct a texture array partitioner from an existing image allocation
    /// </summary>
    /// <param name="backingPartition">Backing image allocation</param>
    public TextureArrayPartitioner(ImageViewPartitionInfo backingPartition)
    {
        BackingPartition = backingPartition;
        _textureArraySlots = new FreeListIndexPool(backingPartition.LocalSubresourceRange.LayerCount, false);
    }

    /// <inheritdoc />
    public bool TryCreatePartition(
        in ImageViewPartitionInfo.CreateInfo createInfo,
        out ImageViewPartitionInfo partition
    )
    {
        if (
            createInfo.Extent.Width > BackingPartition.Extent.Width
            || createInfo.Extent.Height > BackingPartition.Extent.Height
            || createInfo.Extent.Depth > BackingPartition.Extent.Depth
        )
        {
            throw new ArgumentException("Extent mismatch");
        }
        if (createInfo.LayerCount > 1)
        {
            throw new ArgumentException("ArraySlots must be 1");
        }

        if (!TryAllocateSlot(out var slot))
        {
            partition = default;
            return false;
        }

        partition = BackingPartition with
        {
            Partitioner = this,
            Extent = createInfo.Extent,
            ArrayCount = 1,
            ArrayOffset = BackingPartition.ArrayOffset + slot,
        };

        return true;
    }

    /// <summary>
    /// Allocate a slot in the texture array and return the array index (slot)
    /// Can call this directly if you don't need the full ImageSubAllocationInfo
    /// </summary>
    /// <returns>Slot/array index allocated</returns>
    public bool TryAllocateSlot(out int slot)
    {
        return _textureArraySlots.TryAdd(out slot);
    }

    /// <inheritdoc />
    public void FreePartition(in ImageViewPartitionInfo inAllocation)
    {
        FreeSlot(inAllocation.ArrayOffset - BackingPartition.LocalSubresourceRange.LayerCount);
    }

    /// <summary>
    /// Free up a slot in texture array
    /// Can call this directly if you didn't need the full ImageSubAllocationInfo and just used the slot handle
    /// </summary>
    /// <param name="slot">Array index (aka slot handle)</param>
    public void FreeSlot(int slot)
    {
        _textureArraySlots.Remove(slot);
    }

    public void Reset(ImageViewPartitionInfo info)
    {
        BackingPartition = info;
        _textureArraySlots.Clear();
        _textureArraySlots.Capacity = BackingPartition.LocalSubresourceRange.LayerCount;
    }
}
