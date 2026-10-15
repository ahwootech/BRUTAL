namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Extends the <see cref="VkBuffer"/> type to provide additional functionality.
/// </summary>
public readonly struct BufferEx : IDisposable, INullable, IMappable, IBindBuffer
{
    public ref struct CreateInfo
    {
        /// <summary>The name to apply to the buffer and allocation</summary>
        public required string Name;

        /// <inheritdoc cref="VkBufferCreateInfo.Flags"/>
        public VkBufferCreateFlags BufferFlags;

        /// <inheritdoc cref="VkBufferCreateInfo.Size"/>
        public ByteSize BufferSize;

        /// <inheritdoc cref="VkBufferCreateInfo.Usage"/>
        public VkBufferUsageFlags BufferUsage;

        /// <inheritdoc cref="VkBufferCreateInfo.SharingMode"/>
        public VkSharingMode BufferSharingMode;

        /// <inheritdoc cref="VkBufferCreateInfo.QueueFamilyIndexCount"/>
        public int BufferQueueFamilyIndexCount;

        /// <inheritdoc cref="VkBufferCreateInfo.QueueFamilyIndices"/>
        public unsafe int* BufferQueueFamilyIndices;

        /// <inheritdoc cref="VkBufferCreateInfo.Next"/>
        public Ptr BufferNext { get; set; }

        /// <inheritdoc cref="AllocationInfo.CreateInfo.Preference"/>
        public MemoryPreference AllocPreference;

        /// <inheritdoc cref="AllocationInfo.CreateInfo.RequiredProperties"/>
        public VkMemoryPropertyFlags AllocRequiredProperties;

        /// <inheritdoc cref="AllocationInfo.CreateInfo.PreferredProperties"/>
        public VkMemoryPropertyFlags AllocPreferredProperties;

        /// <inheritdoc cref="AllocationInfo.CreateInfo.Priority"/>
        public float AllocPriority;

        /// <inheritdoc cref="AllocationInfo.CreateInfo.Next"/>
        public Ptr AllocNext { get; set; }

        /// <summary>
        /// Extract or populate this struct with a VkBufferCreateInfo
        /// </summary>
        public unsafe VkBufferCreateInfo BufferCreateInfo
        {
            get =>
                new()
                {
                    Flags = BufferFlags,
                    Size = BufferSize,
                    Usage = BufferUsage,
                    SharingMode = BufferSharingMode,
                    QueueFamilyIndexCount = BufferQueueFamilyIndexCount,
                    QueueFamilyIndices = BufferQueueFamilyIndices,
                    Next = BufferNext,
                };
            set
            {
                BufferFlags = value.Flags;
                BufferSize = value.Size;
                BufferUsage = value.Usage;
                BufferSharingMode = value.SharingMode;
                BufferQueueFamilyIndexCount = value.QueueFamilyIndexCount;
                BufferQueueFamilyIndices = value.QueueFamilyIndices;
                BufferNext = value.Next;
            }
        }

        /// <summary>
        /// Extract or populate this struct with an AllocationInfo.CreateInfo
        /// </summary>
        public AllocationInfo.CreateInfo AllocationInfo
        {
            get =>
                new()
                {
                    Preference = AllocPreference,
                    RequiredProperties = AllocRequiredProperties,
                    PreferredProperties = AllocPreferredProperties,
                    Priority = AllocPriority,
                    Next = AllocNext,
                };
            set
            {
                AllocPreference = value.Preference;
                AllocRequiredProperties = value.RequiredProperties;
                AllocPreferredProperties = value.PreferredProperties;
                AllocPriority = value.Priority;
                AllocNext = value.Next;
            }
        }
    }

    /// <summary>
    /// Source of the buffer allocation
    /// </summary>
    public readonly IBufferAllocator Allocator;

    /// <summary>
    /// Allocation info for the buffer
    /// </summary>
    public readonly BufferAllocationInfo BufferAllocationInfo;

    /// <summary>
    /// The size of the buffer allocation
    /// </summary>
    public ByteSize BufferSize => BufferAllocationInfo.BufferSize;

    /// <summary>
    /// Offset within the owning buffer where this buffer starts
    /// </summary>
    public ByteSize BindOffset => BufferAllocationInfo.BufferOffset;

    /// <summary>
    /// Usage flags this buffer supports
    /// </summary>
    public VkBufferUsageFlags Usage => BufferAllocationInfo.Usage;

    internal BufferEx(IBufferAllocator allocator, CreateInfo createInfo)
    {
        Allocator = allocator;

        BufferAllocationInfo = allocator.AllocateBuffer(
            createInfo.Name,
            createInfo.BufferCreateInfo,
            createInfo.AllocationInfo
        );
    }

    /// <summary>
    /// Construct a BufferEx from an existing buffer allocation
    /// </summary>
    /// <param name="allocationInfo">Pre-allocated buffer sourced from an IBufferAllocator</param>
    public BufferEx(BufferAllocationInfo allocationInfo)
    {
        BufferAllocationInfo = allocationInfo;
        Allocator = (IBufferAllocator)allocationInfo.AllocationInfo.Allocator;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        Allocator.FreeAllocation(BufferAllocationInfo);
    }

    /// <summary>
    /// Vulkan buffer handle
    /// </summary>
    public VkBuffer VkBuffer => BufferAllocationInfo.VkBuffer;

    /// <summary>
    /// Vulkan device memory handle
    /// </summary>
    public VkDeviceMemory VkDeviceMemory => BufferAllocationInfo.AllocationInfo.Memory;

    public BufferPartitionInfo AsPartition()
    {
        if (IsNull())
            throw new NullReferenceException(nameof(VkBuffer));

        return BufferPartitionInfo.FullPartition(BufferAllocationInfo);
    }

    public static implicit operator BufferPartitionInfo(BufferEx buffer) => buffer.AsPartition();

    public bool IsNull()
    {
        return VkBuffer.IsNull();
    }

    AllocationInfo IMappable.AllocationInfo => BufferAllocationInfo.AllocationInfo;
    ByteSize IMappable.MapSize => BufferSize;
    ByteSize IMappable.MapOffset => ByteSize.Zero; // BufferOffset should not be used here
}

public static class BufferExExtensions
{
    public static BufferEx CreateBuffer(this IBufferAllocator allocator, BufferEx.CreateInfo createInfo)
    {
        return new BufferEx(allocator, createInfo);
    }
}
