using System.Diagnostics;

namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Convenience struct for mapped memory
/// </summary>
public readonly struct MappedMemory : IDisposable, IEquatable<MappedMemory>
{
    /// <summary>
    /// Internal allocator used to map and unmap memory
    /// </summary>
    private IAllocator Allocator => _allocationMapInfo.AllocationInfo.Allocator;

    /// <summary>
    /// Allocation info of the mapped memory, supplied by the allocator
    /// </summary>
    private readonly AllocationMapInfo _allocationMapInfo;
    public MapRegion Region => _allocationMapInfo.Region;

    public readonly Ptr MapPtr;

    /// <summary>
    /// Device memory handle
    /// </summary>
    public VkDeviceMemory DeviceMemory => _allocationMapInfo.AllocationInfo.Memory;

    /// <summary>
    /// Construct and map memory
    /// </summary>
    /// <param name="allocationAllocationMapInfo">Memory allocation info of memory</param>
    /// <param name="existingPtr">Pointer to existing mapped pointer</param>
    internal MappedMemory(in AllocationMapInfo allocationAllocationMapInfo, Ptr existingPtr)
    {
        Debug.Assert(allocationAllocationMapInfo.Region.Size > 0);
        _allocationMapInfo = allocationAllocationMapInfo;
        MapPtr = existingPtr;
        if (existingPtr.IsNull())
            MapPtr = allocationAllocationMapInfo.AllocationInfo.Allocator.MapMemory(_allocationMapInfo);
    }

    /// <summary>
    /// Create a view into a mapped memory region that is a subset of the original mapped region
    /// </summary>
    /// <exception cref="ArgumentException">Thrown if the byte offset or size is invalid</exception>
    public MappedMemory Offset(MapRegion region)
    {
        if (region.Offset > Region.Size)
            throw new ArgumentException(@"Byte offset exceeds buffer size", nameof(region.Offset));

        if (region.Size == VK.WHOLE_SIZE)
        {
            region = region with { Size = Region.Size - region.Offset };
        }

        if (region.Offset + region.Size > Region.Size)
            throw new ArgumentException(@"Data exceeds buffer size", nameof(region.Size));

        return new MappedMemory(
            _allocationMapInfo with
            {
                Region = region with { Offset = region.Offset + Region.Offset },
            },
            MapPtr.Offset(region.Offset)
        );
    }

    public MappedMemory Offset(ByteSize bytes)
    {
        return Offset(new MapRegion { Offset = bytes });
    }

    /// <summary>
    /// Unmap the memory region using source allocator
    /// </summary>
    public void Unmap()
    {
        Allocator.UnmapMemory(_allocationMapInfo);
    }

    /// <summary>
    /// Flush the mapped memory range
    /// </summary>
    public void Flush()
    {
        Allocator
            .GetDevice()
            .FlushMappedMemoryRanges(
                [
                    new VkMappedMemoryRange
                    {
                        Memory = DeviceMemory,
                        Offset = Region.Offset,
                        Size = Region.Size,
                    },
                ]
            );
    }

    /// <summary>
    /// Invalidate the mapped memory range
    /// </summary>
    public void Invalidate()
    {
        Allocator
            .GetDevice()
            .InvalidateMappedMemoryRanges(
                [
                    new VkMappedMemoryRange
                    {
                        Memory = DeviceMemory,
                        Offset = Region.Offset,
                        Size = Region.Size,
                    },
                ]
            );
    }

    /// <summary>
    /// Cast the mapped memory to a reference of type T
    /// </summary>
    /// <typeparam name="T">Type to cast</typeparam>
    /// <returns>Cast object</returns>
    /// <exception cref="ArgumentException">Data exceeds buffer size</exception>
    public unsafe ref T As<T>()
        where T : unmanaged
    {
        if (ByteSize.Of<T>() > Region.Size)
            throw new ArgumentException(@"Data exceeds buffer size", nameof(T));

        var firstElement = (T*)MapPtr;
        return ref *firstElement;
    }

    /// <summary>
    /// Cast the mapped memory to a span of bytes
    /// </summary>
    /// <returns>Byte span</returns>
    public Span<byte> AsSpan() => AsSpan<byte>();

    /// <summary>
    /// Cast the mapped memory to a span of type T
    /// </summary>
    /// <typeparam name="T">Span element type</typeparam>
    /// <returns>Span of type T</returns>
    /// <exception cref="ArgumentException">Requested data exceeds buffer size</exception>
    public Span<T> AsSpan<T>()
        where T : unmanaged
    {
        if (Region.Size < ByteSize.Of<T>())
            throw new ArgumentException(@"Requested data exceeds buffer size", nameof(T));

        unsafe
        {
            return new Span<byte>(MapPtr, (int)Region.Size).Cast<byte, T>();
        }
    }

    /// <inheritdoc />
    public void Dispose()
    {
        Unmap();
    }

    public static MappedMemory Map(AllocationMapInfo allocationMapInfo)
    {
        return new MappedMemory(allocationMapInfo, null);
    }

    public bool Equals(MappedMemory other)
    {
        return _allocationMapInfo.Equals(other._allocationMapInfo) && MapPtr == other.MapPtr;
    }

    public override bool Equals(object? obj)
    {
        return obj is MappedMemory other && Equals(other);
    }

    public override int GetHashCode()
    {
        return _allocationMapInfo.GetHashCode();
    }
}
