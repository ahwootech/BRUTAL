namespace Brutal.VulkanApi.Vma
{
    public static partial class Vma
    {
        public static unsafe partial class PInvoke
        {
            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCreateAllocator(
                Ptr<VmaAllocatorCreateInfo> pCreateInfo,
                Ptr<VmaAllocatorHandle> pAllocator
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaDestroyAllocator(VmaAllocatorHandle allocator);

            [LibraryImport("vma")]
            public static unsafe partial void vmaGetAllocatorInfo(
                VmaAllocatorHandle allocator,
                Ptr<VmaAllocatorInfo> pAllocatorInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaGetPhysicalDeviceProperties(
                VmaAllocatorHandle allocator,
                PtrPtr<VkPhysicalDeviceProperties> ppPhysicalDeviceProperties
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaGetMemoryProperties(
                VmaAllocatorHandle allocator,
                PtrPtr<VkPhysicalDeviceMemoryProperties> ppPhysicalDeviceMemoryProperties
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaGetMemoryTypeProperties(
                VmaAllocatorHandle allocator,
                uint memoryTypeIndex,
                Ptr<VkMemoryPropertyFlags> pFlags
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaSetCurrentFrameIndex(VmaAllocatorHandle allocator, uint frameIndex);

            [LibraryImport("vma")]
            public static unsafe partial void vmaCalculateStatistics(
                VmaAllocatorHandle allocator,
                Ptr<VmaTotalStatistics> pStats
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaGetHeapBudgets(VmaAllocatorHandle allocator, Ptr<VmaBudget> pBudgets);

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaFindMemoryTypeIndex(
                VmaAllocatorHandle allocator,
                uint memoryTypeBits,
                Ptr<VmaAllocationCreateInfo> pAllocationCreateInfo,
                Ptr<uint> pMemoryTypeIndex
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaFindMemoryTypeIndexForBufferInfo(
                VmaAllocatorHandle allocator,
                Ptr<VkBufferCreateInfo> pBufferCreateInfo,
                Ptr<VmaAllocationCreateInfo> pAllocationCreateInfo,
                Ptr<uint> pMemoryTypeIndex
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaFindMemoryTypeIndexForImageInfo(
                VmaAllocatorHandle allocator,
                Ptr<VkImageCreateInfo> pImageCreateInfo,
                Ptr<VmaAllocationCreateInfo> pAllocationCreateInfo,
                Ptr<uint> pMemoryTypeIndex
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCreatePool(
                VmaAllocatorHandle allocator,
                Ptr<VmaPoolCreateInfo> pCreateInfo,
                Ptr<VmaPool> pPool
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaDestroyPool(VmaAllocatorHandle allocator, VmaPool pool);

            [LibraryImport("vma")]
            public static unsafe partial void vmaGetPoolStatistics(
                VmaAllocatorHandle allocator,
                VmaPool pool,
                Ptr<VmaStatistics> pPoolStats
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaCalculatePoolStatistics(
                VmaAllocatorHandle allocator,
                VmaPool pool,
                Ptr<VmaDetailedStatistics> pPoolStats
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCheckPoolCorruption(VmaAllocatorHandle allocator, VmaPool pool);

            [LibraryImport("vma")]
            public static unsafe partial void vmaGetPoolName(
                VmaAllocatorHandle allocator,
                VmaPool pool,
                PtrPtr<byte> ppName
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaSetPoolName(
                VmaAllocatorHandle allocator,
                VmaPool pool,
                Ptr<byte> pName
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaAllocateMemory(
                VmaAllocatorHandle allocator,
                Ptr<VkMemoryRequirements> pVkMemoryRequirements,
                Ptr<VmaAllocationCreateInfo> pCreateInfo,
                Ptr<VmaAllocation> pAllocation,
                Ptr<VmaAllocationInfo> pAllocationInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaAllocateDedicatedMemory(
                VmaAllocatorHandle allocator,
                Ptr<VkMemoryRequirements> pVkMemoryRequirements,
                Ptr<VmaAllocationCreateInfo> pCreateInfo,
                Ptr pMemoryAllocateNext,
                Ptr<VmaAllocation> pAllocation,
                Ptr<VmaAllocationInfo> pAllocationInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaAllocateMemoryPages(
                VmaAllocatorHandle allocator,
                Ptr<VkMemoryRequirements> pVkMemoryRequirements,
                Ptr<VmaAllocationCreateInfo> pCreateInfo,
                nuint allocationCount,
                Ptr<VmaAllocation> pAllocations,
                Ptr<VmaAllocationInfo> pAllocationInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaAllocateMemoryForBuffer(
                VmaAllocatorHandle allocator,
                VkBuffer buffer,
                Ptr<VmaAllocationCreateInfo> pCreateInfo,
                Ptr<VmaAllocation> pAllocation,
                Ptr<VmaAllocationInfo> pAllocationInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaAllocateMemoryForImage(
                VmaAllocatorHandle allocator,
                VkImage image,
                Ptr<VmaAllocationCreateInfo> pCreateInfo,
                Ptr<VmaAllocation> pAllocation,
                Ptr<VmaAllocationInfo> pAllocationInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaFreeMemory(VmaAllocatorHandle allocator, VmaAllocation allocation);

            [LibraryImport("vma")]
            public static unsafe partial void vmaFreeMemoryPages(
                VmaAllocatorHandle allocator,
                nuint allocationCount,
                Ptr<VmaAllocation> pAllocations
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaGetAllocationInfo(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                Ptr<VmaAllocationInfo> pAllocationInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaGetAllocationInfo2(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                Ptr<VmaAllocationInfo2> pAllocationInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaSetAllocationUserData(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                Ptr pUserData
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaSetAllocationName(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                Ptr<byte> pName
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaGetAllocationMemoryProperties(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                Ptr<VkMemoryPropertyFlags> pFlags
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaMapMemory(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                PtrPtr ppData
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaUnmapMemory(VmaAllocatorHandle allocator, VmaAllocation allocation);

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaFlushAllocation(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                ByteSize offset,
                ByteSize size
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaInvalidateAllocation(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                ByteSize offset,
                ByteSize size
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaFlushAllocations(
                VmaAllocatorHandle allocator,
                uint allocationCount,
                Ptr<VmaAllocation> allocations,
                Ptr<ByteSize> offsets,
                Ptr<ByteSize> sizes
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaInvalidateAllocations(
                VmaAllocatorHandle allocator,
                uint allocationCount,
                Ptr<VmaAllocation> allocations,
                Ptr<ByteSize> offsets,
                Ptr<ByteSize> sizes
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCopyMemoryToAllocation(
                VmaAllocatorHandle allocator,
                Ptr pSrcHostPointer,
                VmaAllocation dstAllocation,
                ByteSize dstAllocationLocalOffset,
                ByteSize size
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCopyAllocationToMemory(
                VmaAllocatorHandle allocator,
                VmaAllocation srcAllocation,
                ByteSize srcAllocationLocalOffset,
                Ptr pDstHostPointer,
                ByteSize size
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCheckCorruption(VmaAllocatorHandle allocator, uint memoryTypeBits);

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaBeginDefragmentation(
                VmaAllocatorHandle allocator,
                Ptr<VmaDefragmentationInfo> pInfo,
                Ptr<VmaDefragmentationContext> pContext
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaEndDefragmentation(
                VmaAllocatorHandle allocator,
                VmaDefragmentationContext context,
                Ptr<VmaDefragmentationStats> pStats
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaBeginDefragmentationPass(
                VmaAllocatorHandle allocator,
                VmaDefragmentationContext context,
                Ptr<VmaDefragmentationPassMoveInfo> pPassInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaEndDefragmentationPass(
                VmaAllocatorHandle allocator,
                VmaDefragmentationContext context,
                Ptr<VmaDefragmentationPassMoveInfo> pPassInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaBindBufferMemory(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                VkBuffer buffer
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaBindBufferMemory2(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                ByteSize allocationLocalOffset,
                VkBuffer buffer,
                Ptr pNext
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaBindImageMemory(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                VkImage image
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaBindImageMemory2(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                ByteSize allocationLocalOffset,
                VkImage image,
                Ptr pNext
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCreateBuffer(
                VmaAllocatorHandle allocator,
                Ptr<VkBufferCreateInfo> pBufferCreateInfo,
                Ptr<VmaAllocationCreateInfo> pAllocationCreateInfo,
                Ptr<VkBuffer> pBuffer,
                Ptr<VmaAllocation> pAllocation,
                Ptr<VmaAllocationInfo> pAllocationInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCreateBufferWithAlignment(
                VmaAllocatorHandle allocator,
                Ptr<VkBufferCreateInfo> pBufferCreateInfo,
                Ptr<VmaAllocationCreateInfo> pAllocationCreateInfo,
                ByteSize minAlignment,
                Ptr<VkBuffer> pBuffer,
                Ptr<VmaAllocation> pAllocation,
                Ptr<VmaAllocationInfo> pAllocationInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCreateDedicatedBuffer(
                VmaAllocatorHandle allocator,
                Ptr<VkBufferCreateInfo> pBufferCreateInfo,
                Ptr<VmaAllocationCreateInfo> pAllocationCreateInfo,
                Ptr pMemoryAllocateNext,
                Ptr<VkBuffer> pBuffer,
                Ptr<VmaAllocation> pAllocation,
                Ptr<VmaAllocationInfo> pAllocationInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCreateAliasingBuffer(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                Ptr<VkBufferCreateInfo> pBufferCreateInfo,
                Ptr<VkBuffer> pBuffer
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCreateAliasingBuffer2(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                ByteSize allocationLocalOffset,
                Ptr<VkBufferCreateInfo> pBufferCreateInfo,
                Ptr<VkBuffer> pBuffer
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaDestroyBuffer(
                VmaAllocatorHandle allocator,
                VkBuffer buffer,
                VmaAllocation allocation
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCreateImage(
                VmaAllocatorHandle allocator,
                Ptr<VkImageCreateInfo> pImageCreateInfo,
                Ptr<VmaAllocationCreateInfo> pAllocationCreateInfo,
                Ptr<VkImage> pImage,
                Ptr<VmaAllocation> pAllocation,
                Ptr<VmaAllocationInfo> pAllocationInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCreateDedicatedImage(
                VmaAllocatorHandle allocator,
                Ptr<VkImageCreateInfo> pImageCreateInfo,
                Ptr<VmaAllocationCreateInfo> pAllocationCreateInfo,
                Ptr pMemoryAllocateNext,
                Ptr<VkImage> pImage,
                Ptr<VmaAllocation> pAllocation,
                Ptr<VmaAllocationInfo> pAllocationInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCreateAliasingImage(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                Ptr<VkImageCreateInfo> pImageCreateInfo,
                Ptr<VkImage> pImage
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCreateAliasingImage2(
                VmaAllocatorHandle allocator,
                VmaAllocation allocation,
                ByteSize allocationLocalOffset,
                Ptr<VkImageCreateInfo> pImageCreateInfo,
                Ptr<VkImage> pImage
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaDestroyImage(
                VmaAllocatorHandle allocator,
                VkImage image,
                VmaAllocation allocation
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaCreateVirtualBlock(
                Ptr<VmaVirtualBlockCreateInfo> pCreateInfo,
                Ptr<VmaVirtualBlock> pVirtualBlock
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaDestroyVirtualBlock(VmaVirtualBlock virtualBlock);

            [LibraryImport("vma")]
            public static unsafe partial Bool32 vmaIsVirtualBlockEmpty(VmaVirtualBlock virtualBlock);

            [LibraryImport("vma")]
            public static unsafe partial void vmaGetVirtualAllocationInfo(
                VmaVirtualBlock virtualBlock,
                VmaVirtualAllocation allocation,
                Ptr<VmaVirtualAllocationInfo> pVirtualAllocInfo
            );

            [LibraryImport("vma")]
            public static unsafe partial VkResult vmaVirtualAllocate(
                VmaVirtualBlock virtualBlock,
                Ptr<VmaVirtualAllocationCreateInfo> pCreateInfo,
                Ptr<VmaVirtualAllocation> pAllocation,
                Ptr<ByteSize> pOffset
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaVirtualFree(
                VmaVirtualBlock virtualBlock,
                VmaVirtualAllocation allocation
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaClearVirtualBlock(VmaVirtualBlock virtualBlock);

            [LibraryImport("vma")]
            public static unsafe partial void vmaSetVirtualAllocationUserData(
                VmaVirtualBlock virtualBlock,
                VmaVirtualAllocation allocation,
                Ptr pUserData
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaGetVirtualBlockStatistics(
                VmaVirtualBlock virtualBlock,
                Ptr<VmaStatistics> pStats
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaCalculateVirtualBlockStatistics(
                VmaVirtualBlock virtualBlock,
                Ptr<VmaDetailedStatistics> pStats
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaBuildVirtualBlockStatsString(
                VmaVirtualBlock virtualBlock,
                PtrPtr<byte> ppStatsString,
                Bool32 detailedMap
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaFreeVirtualBlockStatsString(
                VmaVirtualBlock virtualBlock,
                Ptr<byte> pStatsString
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaBuildStatsString(
                VmaAllocatorHandle allocator,
                PtrPtr<byte> ppStatsString,
                Bool32 detailedMap
            );

            [LibraryImport("vma")]
            public static unsafe partial void vmaFreeStatsString(VmaAllocatorHandle allocator, Ptr<byte> pStatsString);
        }
    }
}
