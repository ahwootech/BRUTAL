using System.Diagnostics;

namespace Brutal.VulkanApi.Abstractions;

[DebuggerDisplay("Offset: {Offset}, Size: {Size}")]
public struct MapRegion()
{
    public ByteSize Offset { get; init; } = ByteSize.Zero;
    public ByteSize Size { get; init; } = VK.WHOLE_SIZE;
}

/// <summary>
/// Information required to map a memory region.
/// </summary>
public readonly struct MapInfo(VkDeviceMemory memory)
{
    public readonly VkDeviceMemory Memory = memory;
    public MapRegion Region { get; init; } = new();
    public VkMemoryMapFlags Flags { get; init; } = VkMemoryMapFlags.None;

    public static implicit operator MapInfo(VkDeviceMemory memory) => new(memory);
}
