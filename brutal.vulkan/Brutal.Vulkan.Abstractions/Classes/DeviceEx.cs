namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// An allocator that allocates images and buffers directly from a Vulkan device.
/// </summary>
public class DeviceEx : Device, IImageAllocator, IBufferAllocator
{
    public new ref struct CreateInfo()
    {
        public HashSet<string> Extensions = [];
        public Ptr<VkPhysicalDeviceFeatures> Features = null;
        public ReadOnlySpan<VkDeviceQueueCreateInfo> QueueCreateInfos = [];
        public Ptr Next = null;
        public VkAllocator? Allocator = null;
    }

    internal DeviceEx(PhysicalDevice physicalDevice, CreateInfo createInfo)
        : base(
            physicalDevice,
            new Device.CreateInfo
            {
                Extensions = createInfo.Extensions,
                Features = createInfo.Features,
                QueueCreateInfos = createInfo.QueueCreateInfos,
                Next = createInfo.Next,
                Allocator = createInfo.Allocator,
            }
        ) { }

    // No finalizer: the base Device owns the only native handle and frees it in Dispose().

    /// <inheritdoc/>
    public ImageAllocationInfo AllocateImage(
        in string name,
        in VkImageCreateInfo imageCreateInfo,
        in AllocationInfo.CreateInfo allocateCreateInfo
    )
    {
        var image = this.CreateImage(imageCreateInfo, VkAllocator);
        // Check the memory requirements for the vertex buffer
        var memoryRequirements = this.GetImageMemoryRequirements(image);

        // Pick the first memory type that fits the requirements
        var selectedMemoryTypeIndex = PhysicalDevice.FindMemoryType(
            memoryRequirements.MemoryTypeBits,
            allocateCreateInfo.RequiredProperties,
            allocateCreateInfo.PreferredProperties
        );

        // TODO: preferred properties?
        var memory = this.AllocateMemory(PhysicalDevice, image, allocateCreateInfo.RequiredProperties, VkAllocator);

        this.BindImageMemory(image, memory, ByteSize.Zero);

        if (name.Length > 0)
        {
            this.SetDebugName(image, name);
            this.SetDebugName(memory, name);
        }

        return new ImageAllocationInfo
        {
            Image = image,
            Extent = imageCreateInfo.Extent,
            Format = imageCreateInfo.Format,
            MipLevels = imageCreateInfo.MipLevels,
            ArrayLayers = imageCreateInfo.ArrayLayers,
            MemAllocationInfo = new AllocationInfo
            {
                Allocator = this,
                Memory = memory,
                AllocOffset = ByteSize.Zero,
                AllocSize = memoryRequirements.Size,
                MemoryTypeIndex = selectedMemoryTypeIndex,
            },
        };
    }

    public void FreeAllocation(in ImageAllocationInfo inAllocation)
    {
        if (inAllocation.MemAllocationInfo.Memory.IsNull())
            return; // No allocation to free
        if (inAllocation.MemAllocationInfo.Allocator == null)
            throw new InvalidOperationException("Tried to free memory but allocator was null. Who allocated this?");
        if (inAllocation.MemAllocationInfo.Allocator != this)
            throw new InvalidOperationException("Allocation was not made from this allocator.");
        this.DestroyImage(inAllocation.Image, VkAllocator);
        this.FreeMemory(inAllocation.MemAllocationInfo.Memory, VkAllocator);
    }

    public unsafe void FreeAllocation(in BufferAllocationInfo inAllocation)
    {
        if (inAllocation.AllocationInfo.Memory.IsNull())
            return; // No allocation to free
        if (inAllocation.AllocationInfo.Allocator == null)
            throw new InvalidOperationException("Tried to free memory but allocator was null. Who allocated this?");
        if (inAllocation.AllocationInfo.Allocator != this)
            throw new InvalidOperationException("Allocation was not made from this allocator.");
        var handle = (BufferAllocationHandle*)inAllocation.AllocationInfo.AllocHandle;
        if (handle == null)
            throw new InvalidOperationException("Allocation handle is null.");
        if (handle->RefCount != 0)
            throw new InvalidOperationException("Memory is still mapped. Unmap the memory before freeing it.");

        this.DestroyBuffer(inAllocation.VkBuffer, VkAllocator);
        this.FreeMemory(inAllocation.AllocationInfo.Memory, VkAllocator);

        Mem.Free(handle);
    }

    private struct BufferAllocationHandle
    {
        public int RefCount;
        public AllocationMapInfo.MapKey Key;
    }

    /// <inheritdoc/>
    public unsafe BufferAllocationInfo AllocateBuffer(
        in string name,
        in VkBufferCreateInfo bufferCreateInfo,
        in AllocationInfo.CreateInfo allocateCreateInfo
    )
    {
        var buffer = this.CreateBuffer(bufferCreateInfo, VkAllocator);

        // Check the memory requirements for the vertex buffer
        var bufferMemoryRequirements = this.GetBufferMemoryRequirements(buffer);

        // Pick the first memory type that fits the requirements
        var selectedMemoryTypeIndex = PhysicalDevice.FindMemoryType(
            bufferMemoryRequirements.MemoryTypeBits,
            allocateCreateInfo.RequiredProperties,
            allocateCreateInfo.PreferredProperties
        );

        var memory = this.AllocateMemory(
            new VkMemoryAllocateInfo
            {
                AllocationSize = bufferMemoryRequirements.Size,
                MemoryTypeIndex = selectedMemoryTypeIndex,
                Next = allocateCreateInfo.Next,
            },
            VkAllocator
        );
        this.BindBufferMemory(buffer, memory, ByteSize.Zero);
        if (name.Length > 0)
        {
            this.SetDebugName(buffer, name);
            this.SetDebugName(memory, name);
        }

        var handle = Mem.AllocZeroed<BufferAllocationHandle>();

        return new BufferAllocationInfo(
            buffer,
            ByteSize.Zero,
            bufferCreateInfo.Size,
            bufferCreateInfo.Usage,
            new AllocationInfo
            {
                Allocator = this,
                Memory = memory,
                AllocOffset = ByteSize.Zero,
                AllocSize = bufferMemoryRequirements.Size,
                MemoryTypeIndex = selectedMemoryTypeIndex,
                AllocHandle = (nint)handle,
            }
        );
    }

    /// <inheritdoc/>
    unsafe Ptr IAllocator.MapMemory(in AllocationMapInfo allocationMapInfo)
    {
        var allocationInfo = allocationMapInfo.AllocationInfo;

        var handle = (BufferAllocationHandle*)allocationMapInfo.AllocationInfo.AllocHandle;

        if (handle->RefCount != 0)
        {
            if (!allocationMapInfo.IsSubsetOf(handle->Key))
                throw new InvalidOperationException(
                    "Memory is already mapped to a different region. Unmap the memory before mapping again."
                );

            handle->RefCount++;
            return handle->Key.MapPtr.Offset(allocationMapInfo.Region.Offset - handle->Key.MapOffset);
        }

        var ptr = this.MapMemory(
            allocationInfo.Memory,
            allocationMapInfo.Region.Offset,
            allocationMapInfo.Region.Size,
            VkMemoryMapFlags.None
        );
        if (ptr == null)
            throw new InvalidOperationException("Failed to map memory.");

        handle->RefCount = 1;
        handle->Key = new AllocationMapInfo.MapKey(ptr, allocationMapInfo.Region.Size, allocationMapInfo.Region.Offset);

        return ptr;
    }

    /// <inheritdoc/>
    unsafe void IAllocator.UnmapMemory(in AllocationMapInfo allocationMapInfo)
    {
        var allocationInfo = allocationMapInfo.AllocationInfo;

        var handle = (BufferAllocationHandle*)allocationInfo.AllocHandle;

        if (handle->RefCount == 0)
            throw new InvalidOperationException("Memory is not mapped.");
        if (--handle->RefCount > 0)
            return;

        this.UnmapMemory(allocationInfo.Memory);
        handle->Key = new AllocationMapInfo.MapKey(null, ByteSize.Zero, ByteSize.Zero);
    }

    Device IAllocator.GetDevice() => this;

    /// <inheritdoc/>
    public VkAllocator? VkAllocator => _vkAllocator;
}
