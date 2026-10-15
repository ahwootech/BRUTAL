using Brutal.VulkanApi.Abstractions;

namespace Brutal.VulkanApi.Vma
{
    /// <summary>
    /// Interface for a VMA allocator
    /// </summary>
    public interface IVmaAllocator
    {
        public VmaAllocatorHandle VkHandle { get; }
    }

    /// <summary>
    /// A struct to contain the VmaAllocator handle which is passed to VMA functions
    /// </summary>
    public readonly struct VmaAllocatorHandle(nint handle)
    {
        public VkObjectType VkObjectType => VkObjectType.Unknown;
        public IntPtr VkHandle { get; } = handle;

        public bool IsNull()
        {
            return VkHandle == 0;
        }
    }

    /// <summary>
    /// VMA wrapper implementing IImageAllocator and IBufferAllocator, allowing VMA to be used like any other allocator
    /// </summary>
    public partial class VmaAllocator(Device device, VmaAllocatorHandle inHandle)
        : IVmaAllocator,
            IImageAllocator,
            IBufferAllocator
    {
        private readonly Device _device = device;

        public VmaAllocatorHandle VkHandle { get; } = inHandle;

        /// <inheritdoc/>
        public Device GetDevice() => _device;

        public VkAllocator? VkAllocator { get; }

        #region Memory mapping

        public unsafe Ptr MapMemory(in AllocationMapInfo allocationMapInfo)
        {
            void* mapped;
            var allocationInfo = new VmaAllocation(allocationMapInfo.AllocationInfo.AllocHandle);
            var result = this.MapMemory(allocationInfo, &mapped);
            if (result != VkResult.Success)
                throw new Exception("Failed to map memory");
            return mapped;
        }

        public unsafe void UnmapMemory(in AllocationMapInfo allocationMapInfo)
        {
            var allocationInfo = new VmaAllocation(allocationMapInfo.AllocationInfo.AllocHandle);
            this.UnmapMemory(allocationInfo);
        }

        #endregion

        #region Buffer Allocator

        public BufferAllocationInfo AllocateBuffer(
            in VkBufferCreateInfo bufferCreateInfo,
            in AllocationInfo.CreateInfo allocateCreateInfo
        )
        {
            return AllocateBuffer("", bufferCreateInfo, allocateCreateInfo);
        }

        /// <inheritdoc/>
        public BufferAllocationInfo AllocateBuffer(
            in string name,
            in VkBufferCreateInfo bufferCreateInfo,
            in AllocationInfo.CreateInfo allocateCreateInfo
        )
        {
            var vmaInfo = ConvertInfo(allocateCreateInfo);
            var result = this.CreateBuffer(
                bufferCreateInfo,
                vmaInfo,
                out var buffer,
                out var allocation,
                out var allocationInfo
            );

            if (result != VkResult.Success)
                throw new Exception("Vma Failed to create buffer");

            var vkBufferAllocationInfo = new BufferAllocationInfo(
                buffer,
                ByteSize.Zero,
                bufferCreateInfo.Size,
                bufferCreateInfo.Usage,
                new AllocationInfo
                {
                    Allocator = this,
                    Memory = allocationInfo.DeviceMemory,
                    MemoryTypeIndex = (int)allocationInfo.MemoryType,
                    AllocOffset = allocationInfo.Offset,
                    AllocSize = allocationInfo.Size,
                    AllocHandle = allocation.VkHandle,
                }
            );

            if (name.Length > 0)
                _device.SetDebugName(buffer, name);

            return vkBufferAllocationInfo;
        }

        /// <inheritdoc/>
        public void FreeAllocation(in BufferAllocationInfo inAllocation)
        {
            if (inAllocation.AllocationInfo.Memory.IsNull())
                return; // No allocation to free
            if (inAllocation.AllocationInfo.Allocator == null)
                throw new InvalidOperationException("Tried to free memory but allocator was null. Who allocated this?");
            if (inAllocation.AllocationInfo.Allocator != this)
                throw new InvalidOperationException("Allocation was not made from this allocator.");

            this.DestroyBuffer(inAllocation.VkBuffer, new(inAllocation.AllocationInfo.AllocHandle));
        }

        #endregion

        #region Image Allocator

        public ImageAllocationInfo AllocateImage(
            in VkImageCreateInfo imageCreateInfo,
            in AllocationInfo.CreateInfo allocateCreateInfo
        )
        {
            return AllocateImage("", imageCreateInfo, allocateCreateInfo);
        }

        /// <inheritdoc/>
        public ImageAllocationInfo AllocateImage(
            in string name,
            in VkImageCreateInfo imageCreateInfo,
            in AllocationInfo.CreateInfo allocateCreateInfo
        )
        {
            var vmaInfo = ConvertInfo(allocateCreateInfo);
            var result = this.CreateImage(
                imageCreateInfo,
                vmaInfo,
                out VkImage image,
                out VmaAllocation allocation,
                out VmaAllocationInfo allocationInfo
            );

            if (result != VkResult.Success)
                throw new Exception("Vma Failed to create image");

            var vkImageAllocationInfo = new ImageAllocationInfo
            {
                Image = image,
                Extent = imageCreateInfo.Extent,
                Format = imageCreateInfo.Format,
                MipLevels = imageCreateInfo.MipLevels,
                ArrayLayers = imageCreateInfo.ArrayLayers,
                MemAllocationInfo = new AllocationInfo
                {
                    Allocator = this,
                    Memory = allocationInfo.DeviceMemory,
                    MemoryTypeIndex = (int)allocationInfo.MemoryType,
                    AllocOffset = allocationInfo.Offset,
                    AllocSize = allocationInfo.Size,
                    AllocHandle = allocation.VkHandle,
                },
            };

            if (name.Length > 0)
                _device.SetDebugName(image, name);

            return vkImageAllocationInfo;
        }

        /// <inheritdoc/>
        public void FreeAllocation(in ImageAllocationInfo inAllocation)
        {
            if (inAllocation.MemAllocationInfo.Memory.IsNull())
                return; // No allocation to free
            if (inAllocation.MemAllocationInfo.Allocator == null)
                throw new InvalidOperationException("Tried to free memory but allocator was null. Who allocated this?");
            if (inAllocation.MemAllocationInfo.Allocator != this)
                throw new InvalidOperationException("Allocation was not made from this allocator.");

            this.DestroyImage(inAllocation.Image, new(inAllocation.AllocHandle));
        }

        #endregion

        #region Conversion helpers

        /// <summary>
        /// Convert an AllocationCreateInfo to a VmaAllocationCreateInfo
        /// </summary>
        /// <param name="allocationCreateInfo">IVkAllocator's creation info struct</param>
        /// <returns>Vma creation info struct</returns>
        private static VmaAllocationCreateInfo ConvertInfo(in AllocationInfo.CreateInfo allocationCreateInfo)
        {
            VmaAllocationCreateFlags flags = 0;
            VmaMemoryUsage usage = VmaMemoryUsage.Auto;
            if (allocationCreateInfo.Preference == MemoryPreference.PreferGpu)
                usage = VmaMemoryUsage.AutoPreferDevice;
            else if (allocationCreateInfo.Preference == MemoryPreference.PreferCpu)
            {
                usage = VmaMemoryUsage.Auto;
                flags |= VmaAllocationCreateFlags.HostAccessRandomBit;
            }

            // If the allocation is not host visible, we need to set the flags to allow for VMA to map it
            if (
                (
                    allocationCreateInfo.RequiredProperties
                    & (VkMemoryPropertyFlags.HostCoherentBit | VkMemoryPropertyFlags.HostVisibleBit)
                ) != 0
            )
            {
                flags |= VmaAllocationCreateFlags.HostAccessRandomBit;
            }

            var vmaAllocationCreateInfo = new VmaAllocationCreateInfo
            {
                Usage = usage,
                RequiredFlags = allocationCreateInfo.RequiredProperties,
                Flags = flags,
                PreferredFlags = allocationCreateInfo.PreferredProperties,
                Priority = allocationCreateInfo.Priority,
                MemoryTypeBits = 0, // Let VMA figure out the memory type bits based on the buffer/image requirements
            };
            return vmaAllocationCreateInfo;
        }

        #endregion
    }
}
