namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Struct containing information about an intention to map a memory allocation.
/// </summary>
public readonly record struct AllocationMapInfo(AllocationInfo AllocationInfo)
{
    public MapRegion Region { get; init; } = new();
    public VkMemoryMapFlags Flags { get; init; } = VkMemoryMapFlags.None;

    public record struct MapKey(Ptr MapPtr, ByteSize MapSize, ByteSize MapOffset);

    /// <summary>
    /// Check if this MappedInfo is a subset of another MappedInfo, in terms of size and offset.
    /// </summary>
    public bool IsSubsetOf(MapKey other)
    {
        return other.MapSize >= Region.Size
            && other.MapOffset <= Region.Offset
            && other.MapOffset + other.MapSize >= Region.Offset + Region.Size;
    }
}

/// <summary>
/// Describes an object that can be mapped to a pointer.
/// </summary>
public interface IMappable
{
    AllocationInfo AllocationInfo { get; }
    ByteSize MapSize { get; }
    ByteSize MapOffset { get; }

    /// <summary>
    /// Information required to map a memory region.
    /// </summary>
    public readonly struct MapInfo()
    {
        public MapRegion Region { get; init; } = new();
        public VkMemoryMapFlags Flags { get; init; } = VkMemoryMapFlags.None;
    }
}

public static class MappableExtensions
{
    /// <summary>
    /// Map the given object to a pointer.
    /// </summary>
    /// <param name="mappable"> The object to map</param>
    public static MappedMemory Map<T>(this T mappable)
        where T : IMappable
    {
        return mappable.Map(new IMappable.MapInfo());
    }

    /// <summary>
    /// Map the given object to a pointer.
    /// </summary>
    /// <param name="mappable"> The object to map</param>
    public static MappedMemory Map<T>(this T mappable, IMappable.MapInfo mapInfo)
        where T : IMappable
    {
        var region = mapInfo.Region;

        // The byte offset must be within the buffer size
        if (region.Offset > mappable.MapSize)
            throw new ArgumentException(@"Byte offset exceeds buffer size", nameof(region.Offset));

        // A negative byte size is invalid
        if (region.Size.Bytes == VK.WHOLE_SIZE)
            region = region with { Size = mappable.MapSize - region.Offset };

        // The byte size must be within the buffer size
        if (region.Offset + region.Size > mappable.MapSize)
            throw new ArgumentException(@"Data exceeds buffer size", nameof(region.Size));

        return new MappedMemory(
            new AllocationMapInfo(mappable.AllocationInfo)
            {
                Region = region with { Offset = region.Offset + mappable.MapOffset },
                Flags = mapInfo.Flags,
            },
            null
        );
    }
}
