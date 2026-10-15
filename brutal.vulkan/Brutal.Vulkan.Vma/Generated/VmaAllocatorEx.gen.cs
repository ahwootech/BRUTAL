using System.Runtime.CompilerServices;

namespace Brutal.VulkanApi.Vma
{
    public static partial class VmaAllocatorEx
    {
        extension<T>(T allocator)
            where T : IVmaAllocator
        {
            /// <summary>
            /// Returns information about existing #VmaAllocator object - handle to Vulkan device etc.
            /// It might be useful if you want to keep just the #VmaAllocator handle and fetch other required handles to
            /// `VkPhysicalDevice`, `VkDevice` etc. every time using this function.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void GetAllocatorInfo(out VmaAllocatorInfo pAllocatorInfo)
            {
                fixed (VmaAllocatorInfo* pAllocatorInfoPtr = &pAllocatorInfo)
                    Vma.PInvoke.vmaGetAllocatorInfo(allocator.VkHandle, pAllocatorInfoPtr);
            }

            /// <summary>
            /// PhysicalDeviceProperties are fetched from physicalDevice by the allocator.
            /// You can access it here, without fetching it again on your own.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void GetPhysicalDeviceProperties(
                out Ptr<VkPhysicalDeviceProperties> ppPhysicalDeviceProperties
            )
            {
                fixed (Ptr<VkPhysicalDeviceProperties>* ppPhysicalDevicePropertiesPtr = &ppPhysicalDeviceProperties)
                    Vma.PInvoke.vmaGetPhysicalDeviceProperties(
                        allocator.VkHandle,
                        (VkPhysicalDeviceProperties**)ppPhysicalDevicePropertiesPtr
                    );
            }

            /// <summary>
            /// PhysicalDeviceMemoryProperties are fetched from physicalDevice by the allocator.
            /// You can access it here, without fetching it again on your own.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void GetMemoryProperties(
                out Ptr<VkPhysicalDeviceMemoryProperties> ppPhysicalDeviceMemoryProperties
            )
            {
                fixed (
                    Ptr<VkPhysicalDeviceMemoryProperties>* ppPhysicalDeviceMemoryPropertiesPtr =
                        &ppPhysicalDeviceMemoryProperties
                )
                    Vma.PInvoke.vmaGetMemoryProperties(
                        allocator.VkHandle,
                        (VkPhysicalDeviceMemoryProperties**)ppPhysicalDeviceMemoryPropertiesPtr
                    );
            }

            /// <summary>
            /// Given Memory Type Index, returns Property Flags of this memory type.
            /// This is just a convenience function. Same information can be obtained using
            /// vmaGetMemoryProperties().
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void GetMemoryTypeProperties(uint memoryTypeIndex, out VkMemoryPropertyFlags pFlags)
            {
                fixed (VkMemoryPropertyFlags* pFlagsPtr = &pFlags)
                    Vma.PInvoke.vmaGetMemoryTypeProperties(allocator.VkHandle, memoryTypeIndex, pFlagsPtr);
            }

            /// <summary>
            /// Sets index of the current frame.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void SetCurrentFrameIndex(uint frameIndex)
            {
                Vma.PInvoke.vmaSetCurrentFrameIndex(allocator.VkHandle, frameIndex);
            }

            /// <summary>
            /// Retrieves statistics from current state of the Allocator.
            /// This function is called "calculate" not "get" because it has to traverse all
            /// internal data structures, so it may be quite slow. Use it for debugging purposes.
            /// For faster but more brief statistics suitable to be called every frame or every allocation,
            /// use vmaGetHeapBudgets().
            /// Note that when using allocator from multiple threads, returned information may immediately
            /// become outdated.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void CalculateStatistics(out VmaTotalStatistics pStats)
            {
                fixed (VmaTotalStatistics* pStatsPtr = &pStats)
                    Vma.PInvoke.vmaCalculateStatistics(allocator.VkHandle, pStatsPtr);
            }

            /// <summary>
            /// Retrieves information about current memory usage and budget for all memory heaps.
            /// This function is called "get" not "calculate" because it is very fast, suitable to be called
            /// every frame or every allocation. For more detailed statistics use vmaCalculateStatistics().
            /// Note that when using allocator from multiple threads, returned information may immediately
            /// become outdated.
            /// </summary>
            /// <param name="allocator"/>
            /// <param name="pBudgets">Must point to array with number of elements at least equal to number of memory heaps in physical device used.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void GetHeapBudgets(scoped Span<VmaBudget> pBudgets)
            {
                fixed (VmaBudget* pBudgetsPtr = pBudgets)
                    Vma.PInvoke.vmaGetHeapBudgets(allocator.VkHandle, pBudgetsPtr);
            }

            /// <summary>
            /// Helps to find `memoryTypeIndex`, given `memoryTypeBits` and #VmaAllocationCreateInfo.
            /// This algorithm tries to find a memory type that:
            /// - Is allowed by `memoryTypeBits`.
            /// - Contains all the flags from `pAllocationCreateInfo->requiredFlags`.
            /// - Matches intended usage.
            /// - Has as many flags from `pAllocationCreateInfo->preferredFlags` as possible.
            /// Returns `VK_ERROR_FEATURE_NOT_PRESENT` if not found. Receiving such result from this function or any other allocating function probably means that your device doesn't support any memory type with requested features for the specific type of resource you want to use it for. Please check parameters of your resource, like image layout (`OPTIMAL` versus `LINEAR`) or mip level count.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult FindMemoryTypeIndex(
                uint memoryTypeBits,
                VmaAllocationCreateInfo pAllocationCreateInfo,
                out uint pMemoryTypeIndex
            )
            {
                fixed (uint* pMemoryTypeIndexPtr = &pMemoryTypeIndex)
                    return Vma.PInvoke.vmaFindMemoryTypeIndex(
                        allocator.VkHandle,
                        memoryTypeBits,
                        &pAllocationCreateInfo,
                        pMemoryTypeIndexPtr
                    );
            }

            /// <summary>
            /// Helps to find `memoryTypeIndex`, given `VkBufferCreateInfo` and #VmaAllocationCreateInfo.
            /// It can be useful e.g. to determine value to be used as VmaPoolCreateInfo::memoryTypeIndex.
            /// It may need to internally create a temporary, dummy buffer that never has memory bound.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult FindMemoryTypeIndexForBufferInfo(
                VkBufferCreateInfo pBufferCreateInfo,
                VmaAllocationCreateInfo pAllocationCreateInfo,
                out uint pMemoryTypeIndex
            )
            {
                fixed (uint* pMemoryTypeIndexPtr = &pMemoryTypeIndex)
                    return Vma.PInvoke.vmaFindMemoryTypeIndexForBufferInfo(
                        allocator.VkHandle,
                        &pBufferCreateInfo,
                        &pAllocationCreateInfo,
                        pMemoryTypeIndexPtr
                    );
            }

            /// <summary>
            /// Helps to find `memoryTypeIndex`, given `VkImageCreateInfo` and #VmaAllocationCreateInfo.
            /// It can be useful e.g. to determine value to be used as VmaPoolCreateInfo::memoryTypeIndex.
            /// It may need to internally create a temporary, dummy image that never has memory bound.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult FindMemoryTypeIndexForImageInfo(
                VkImageCreateInfo pImageCreateInfo,
                VmaAllocationCreateInfo pAllocationCreateInfo,
                out uint pMemoryTypeIndex
            )
            {
                fixed (uint* pMemoryTypeIndexPtr = &pMemoryTypeIndex)
                    return Vma.PInvoke.vmaFindMemoryTypeIndexForImageInfo(
                        allocator.VkHandle,
                        &pImageCreateInfo,
                        &pAllocationCreateInfo,
                        pMemoryTypeIndexPtr
                    );
            }

            /// <summary>
            /// Allocates Vulkan device memory and creates #VmaPool object.
            /// </summary>
            /// <param name="allocator">Allocator object.</param>
            /// <param name="pCreateInfo">Parameters of pool to create.</param>
            /// <param name="pPool">Handle to created pool.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult CreatePool(VmaPoolCreateInfo pCreateInfo, out VmaPool pPool)
            {
                fixed (VmaPool* pPoolPtr = &pPool)
                    return Vma.PInvoke.vmaCreatePool(allocator.VkHandle, &pCreateInfo, pPoolPtr);
            }

            /// <summary>
            /// Destroys #VmaPool object and frees Vulkan device memory.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void DestroyPool(VmaPool pool)
            {
                Vma.PInvoke.vmaDestroyPool(allocator.VkHandle, pool);
            }

            /// <summary>
            /// Retrieves statistics of existing #VmaPool object.
            /// Note that when using the pool from multiple threads, returned information may immediately
            /// become outdated.
            /// </summary>
            /// <param name="allocator">Allocator object.</param>
            /// <param name="pool">Pool object.</param>
            /// <param name="pPoolStats">Statistics of specified pool.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void GetPoolStatistics(VmaPool pool, out VmaStatistics pPoolStats)
            {
                fixed (VmaStatistics* pPoolStatsPtr = &pPoolStats)
                    Vma.PInvoke.vmaGetPoolStatistics(allocator.VkHandle, pool, pPoolStatsPtr);
            }

            /// <summary>
            /// Retrieves detailed statistics of existing #VmaPool object.
            /// </summary>
            /// <param name="allocator">Allocator object.</param>
            /// <param name="pool">Pool object.</param>
            /// <param name="pPoolStats">Statistics of specified pool.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void CalculatePoolStatistics(VmaPool pool, out VmaDetailedStatistics pPoolStats)
            {
                fixed (VmaDetailedStatistics* pPoolStatsPtr = &pPoolStats)
                    Vma.PInvoke.vmaCalculatePoolStatistics(allocator.VkHandle, pool, pPoolStatsPtr);
            }

            /// <summary>
            /// Checks magic number in margins around all allocations in given memory pool in search for corruptions.
            /// Corruption detection is enabled only when `VMA_DEBUG_DETECT_CORRUPTION` macro is defined to nonzero,
            /// `VMA_DEBUG_MARGIN` is defined to nonzero and the pool is created in memory type that is
            /// `HOST_VISIBLE` and `HOST_COHERENT`. For more information, see [Corruption detection](
            /// Possible return values:
            /// - `VK_ERROR_FEATURE_NOT_PRESENT` - corruption detection is not enabled for specified pool.
            /// - `VK_SUCCESS` - corruption detection has been performed and succeeded.
            /// - `VK_ERROR_UNKNOWN` - corruption detection has been performed and found memory corruptions around one of the allocations.
            /// `VMA_ASSERT` is also fired in that case.
            /// - Other value: Error returned by Vulkan, e.g. memory mapping failure.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public VkResult CheckPoolCorruption(VmaPool pool)
            {
                return Vma.PInvoke.vmaCheckPoolCorruption(allocator.VkHandle, pool);
            }

            /// <summary>
            /// Retrieves name of a custom pool.
            /// After the call `ppName` is either null or points to an internally-owned null-terminated string
            /// containing name of the pool that was previously set. The pointer becomes invalid when the pool is
            /// destroyed or its name is changed using vmaSetPoolName().
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void GetPoolName(VmaPool pool, out Ptr<byte> ppName)
            {
                fixed (Ptr<byte>* ppNamePtr = &ppName)
                    Vma.PInvoke.vmaGetPoolName(allocator.VkHandle, pool, (byte**)ppNamePtr);
            }

            /// <summary>
            /// Sets name of a custom pool.
            /// `pName` can be either null or pointer to a null-terminated string with new name for the pool.
            /// Function makes internal copy of the string, so it can be changed or freed immediately after this call.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void SetPoolName(VmaPool pool, scoped ReadOnlySpan<byte> pName)
            {
                fixed (byte* pNamePtr = pName)
                    Vma.PInvoke.vmaSetPoolName(allocator.VkHandle, pool, pNamePtr);
            }

            /// <summary>
            /// General purpose memory allocation.
            /// The function creates a #VmaAllocation object without creating a buffer or an image together with it.
            /// - It is recommended to use vmaAllocateMemoryForBuffer(), vmaAllocateMemoryForImage(),
            /// vmaCreateBuffer(), vmaCreateImage() instead whenever possible.
            /// - You can also create a buffer or an image later in an existing allocation using
            /// vmaCreateAliasingBuffer2(), vmaCreateAliasingImage2().
            /// - You can also create a buffer or an image on your own and bind it to an existing allocation
            /// using vmaBindBufferMemory2(), vmaBindImageMemory2().
            /// You must free the returned allocation object using vmaFreeMemory() or vmaFreeMemoryPages().
            /// There is also extended version of this function: vmaAllocateDedicatedMemory()
            /// that offers additional parameter `pMemoryAllocateNext`.
            /// </summary>
            /// <param name="allocator">The main allocator object.</param>
            /// <param name="pVkMemoryRequirements">Requirements for the allocated memory.</param>
            /// <param name="pCreateInfo">Allocation creation parameters.</param>
            /// <param name="pAllocation">Handle to allocated memory.</param>
            /// <param name="pAllocationInfo">Optional, can be null. Information about allocated memory. It can be also fetched later using vmaGetAllocationInfo().</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult AllocateMemory(
                VkMemoryRequirements pVkMemoryRequirements,
                VmaAllocationCreateInfo pCreateInfo,
                out VmaAllocation pAllocation,
                out VmaAllocationInfo pAllocationInfo
            )
            {
                fixed (VmaAllocationInfo* pAllocationInfoPtr = &pAllocationInfo)
                fixed (VmaAllocation* pAllocationPtr = &pAllocation)
                    return Vma.PInvoke.vmaAllocateMemory(
                        allocator.VkHandle,
                        &pVkMemoryRequirements,
                        &pCreateInfo,
                        pAllocationPtr,
                        pAllocationInfoPtr
                    );
            }

            /// <summary>
            /// General purpose allocation of a dedicated memory.
            /// This function is similar vmaAllocateMemory(), but
            /// it always allocates dedicated memory - flag #VMA_ALLOCATION_CREATE_DEDICATED_MEMORY_BIT is implied.
            /// It offers additional parameter `pMemoryAllocateNext`,
            /// which can be used to attach `pNext` chain to the `VkMemoryAllocateInfo` structure.
            /// It can be useful for importing external memory. For more information, see
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult AllocateDedicatedMemory(
                VkMemoryRequirements pVkMemoryRequirements,
                VmaAllocationCreateInfo pCreateInfo,
                Ptr pMemoryAllocateNext,
                VmaAllocation pAllocation,
                VmaAllocationInfo pAllocationInfo
            )
            {
                return Vma.PInvoke.vmaAllocateDedicatedMemory(
                    allocator.VkHandle,
                    &pVkMemoryRequirements,
                    &pCreateInfo,
                    pMemoryAllocateNext,
                    &pAllocation,
                    &pAllocationInfo
                );
            }

            /// <summary>
            /// General purpose memory allocation for multiple allocation objects at once.
            /// You should free the memory using vmaFreeMemory() or vmaFreeMemoryPages().
            /// Word "pages" is just a suggestion to use this function to allocate pieces of memory needed for sparse binding.
            /// It is just a general purpose allocation function able to make multiple allocations at once.
            /// It may be internally optimized to be more efficient than calling vmaAllocateMemory() `allocationCount` times.
            /// All allocations are made using same parameters. All of them are created out of the same memory pool and type.
            /// If any allocation fails, all allocations already made within this function call are also freed, so that when
            /// returned result is not `VK_SUCCESS`, `pAllocation` array is always entirely filled with `VK_NULL_HANDLE`.
            /// </summary>
            /// <param name="allocator">Allocator object.</param>
            /// <param name="pVkMemoryRequirements">Memory requirements for each allocation.</param>
            /// <param name="pCreateInfo">Creation parameters for each allocation.</param>
            /// <param name="allocationCount">Number of allocations to make.</param>
            /// <param name="pAllocations">Pointer to array that will be filled with handles to created allocations.</param>
            /// <param name="pAllocationInfo">Optional. Pointer to array that will be filled with parameters of created allocations.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult AllocateMemoryPages(
                VkMemoryRequirements pVkMemoryRequirements,
                VmaAllocationCreateInfo pCreateInfo,
                nuint allocationCount,
                scoped Span<VmaAllocation> pAllocations,
                scoped Span<VmaAllocationInfo> pAllocationInfo
            )
            {
                fixed (VmaAllocationInfo* pAllocationInfoPtr = pAllocationInfo)
                fixed (VmaAllocation* pAllocationsPtr = pAllocations)
                    return Vma.PInvoke.vmaAllocateMemoryPages(
                        allocator.VkHandle,
                        &pVkMemoryRequirements,
                        &pCreateInfo,
                        allocationCount,
                        pAllocationsPtr,
                        pAllocationInfoPtr
                    );
            }

            /// <summary>
            /// Allocates memory suitable for given `VkBuffer`.
            /// It only creates #VmaAllocation. To bind the memory to the buffer, use vmaBindBufferMemory().
            /// This is a special-purpose function. In most cases you should use vmaCreateBuffer().
            /// You must free the allocation using vmaFreeMemory() when no longer needed.
            /// </summary>
            /// <param name="allocator"/>
            /// <param name="buffer"/>
            /// <param name="pCreateInfo"/>
            /// <param name="pAllocation">Handle to allocated memory.</param>
            /// <param name="pAllocationInfo">Optional. Information about allocated memory. It can be later fetched using function vmaGetAllocationInfo().</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult AllocateMemoryForBuffer(
                VkBuffer buffer,
                VmaAllocationCreateInfo pCreateInfo,
                out VmaAllocation pAllocation,
                out VmaAllocationInfo pAllocationInfo
            )
            {
                fixed (VmaAllocationInfo* pAllocationInfoPtr = &pAllocationInfo)
                fixed (VmaAllocation* pAllocationPtr = &pAllocation)
                    return Vma.PInvoke.vmaAllocateMemoryForBuffer(
                        allocator.VkHandle,
                        buffer,
                        &pCreateInfo,
                        pAllocationPtr,
                        pAllocationInfoPtr
                    );
            }

            /// <summary>
            /// Allocates memory suitable for given `VkImage`.
            /// It only creates #VmaAllocation. To bind the memory to the buffer, use vmaBindImageMemory().
            /// This is a special-purpose function. In most cases you should use vmaCreateImage().
            /// You must free the allocation using vmaFreeMemory() when no longer needed.
            /// </summary>
            /// <param name="allocator"/>
            /// <param name="image"/>
            /// <param name="pCreateInfo"/>
            /// <param name="pAllocation">Handle to allocated memory.</param>
            /// <param name="pAllocationInfo">Optional. Information about allocated memory. It can be later fetched using function vmaGetAllocationInfo().</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult AllocateMemoryForImage(
                VkImage image,
                VmaAllocationCreateInfo pCreateInfo,
                out VmaAllocation pAllocation,
                out VmaAllocationInfo pAllocationInfo
            )
            {
                fixed (VmaAllocationInfo* pAllocationInfoPtr = &pAllocationInfo)
                fixed (VmaAllocation* pAllocationPtr = &pAllocation)
                    return Vma.PInvoke.vmaAllocateMemoryForImage(
                        allocator.VkHandle,
                        image,
                        &pCreateInfo,
                        pAllocationPtr,
                        pAllocationInfoPtr
                    );
            }

            /// <summary>
            /// Frees memory previously allocated using vmaAllocateMemory(), vmaAllocateMemoryForBuffer(), or vmaAllocateMemoryForImage().
            /// Passing `VK_NULL_HANDLE` as `allocation` is valid. Such function call is just skipped.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void FreeMemory(VmaAllocation allocation)
            {
                Vma.PInvoke.vmaFreeMemory(allocator.VkHandle, allocation);
            }

            /// <summary>
            /// Frees memory and destroys multiple allocations.
            /// Word "pages" is just a suggestion to use this function to free pieces of memory used for sparse binding.
            /// It is just a general purpose function to free memory and destroy allocations made using e.g. vmaAllocateMemory(),
            /// vmaAllocateMemoryPages() and other functions.
            /// It may be internally optimized to be more efficient than calling vmaFreeMemory() `allocationCount` times.
            /// Allocations in `pAllocations` array can come from any memory pools and types.
            /// Passing `VK_NULL_HANDLE` as elements of `pAllocations` array is valid. Such entries are just skipped.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void FreeMemoryPages(nuint allocationCount, scoped Span<VmaAllocation> pAllocations)
            {
                fixed (VmaAllocation* pAllocationsPtr = pAllocations)
                    Vma.PInvoke.vmaFreeMemoryPages(allocator.VkHandle, allocationCount, pAllocationsPtr);
            }

            /// <summary>
            /// Returns current information about specified allocation.
            /// Current parameters of given allocation are returned in `pAllocationInfo`.
            /// Although this function doesn't lock any mutex, so it should be quite efficient,
            /// you should avoid calling it too often.
            /// You can retrieve same VmaAllocationInfo structure while creating your resource, from function
            /// vmaCreateBuffer(), vmaCreateImage(). You can remember it if you are sure parameters don't change
            /// (e.g. due to defragmentation).
            /// There is also a new function vmaGetAllocationInfo2() that offers extended information
            /// about the allocation, returned using new structure #VmaAllocationInfo2.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void GetAllocationInfo(VmaAllocation allocation, out VmaAllocationInfo pAllocationInfo)
            {
                fixed (VmaAllocationInfo* pAllocationInfoPtr = &pAllocationInfo)
                    Vma.PInvoke.vmaGetAllocationInfo(allocator.VkHandle, allocation, pAllocationInfoPtr);
            }

            /// <summary>
            /// Returns extended information about specified allocation.
            /// Current parameters of given allocation are returned in `pAllocationInfo`.
            /// Extended parameters in structure #VmaAllocationInfo2 include memory block size
            /// and a flag telling whether the allocation has dedicated memory.
            /// It can be useful e.g. for interop with OpenGL.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void GetAllocationInfo2(VmaAllocation allocation, out VmaAllocationInfo2 pAllocationInfo)
            {
                fixed (VmaAllocationInfo2* pAllocationInfoPtr = &pAllocationInfo)
                    Vma.PInvoke.vmaGetAllocationInfo2(allocator.VkHandle, allocation, pAllocationInfoPtr);
            }

            /// <summary>
            /// Sets pUserData in given allocation to new value.
            /// The value of pointer `pUserData` is copied to allocation's `pUserData`.
            /// It is opaque, so you can use it however you want - e.g.
            /// as a pointer, ordinal number or some handle to you own data.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void SetAllocationUserData(VmaAllocation allocation, Ptr pUserData)
            {
                Vma.PInvoke.vmaSetAllocationUserData(allocator.VkHandle, allocation, pUserData);
            }

            /// <summary>
            /// Sets pName in given allocation to new value.
            /// `pName` must be either null, or pointer to a null-terminated string. The function
            /// makes local copy of the string and sets it as allocation's `pName`. String
            /// passed as pName doesn't need to be valid for whole lifetime of the allocation -
            /// you can free it after this call. String previously pointed by allocation's
            /// `pName` is freed from memory.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void SetAllocationName(VmaAllocation allocation, scoped ReadOnlySpan<byte> pName)
            {
                fixed (byte* pNamePtr = pName)
                    Vma.PInvoke.vmaSetAllocationName(allocator.VkHandle, allocation, pNamePtr);
            }

            /// <summary>
            /// Given an allocation, returns Property Flags of its memory type.
            /// This is just a convenience function. Same information can be obtained using
            /// vmaGetAllocationInfo() + vmaGetMemoryProperties().
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void GetAllocationMemoryProperties(VmaAllocation allocation, VkMemoryPropertyFlags pFlags)
            {
                Vma.PInvoke.vmaGetAllocationMemoryProperties(allocator.VkHandle, allocation, &pFlags);
            }

            /// <summary>
            /// Maps memory represented by given allocation and returns pointer to it.
            /// Maps memory represented by given allocation to make it accessible to CPU code.
            /// When succeeded, `*ppData` contains pointer to first byte of this memory.
            /// If the allocation is part of a bigger `VkDeviceMemory` block, returned pointer is correctly offsetted to the beginning of region assigned to this particular allocation. Unlike the result of `vkMapMemory`, it points to the allocation, not to the beginning of the whole block. You should not add VmaAllocationInfo::offset to it!
            /// Mapping is internally reference-counted and synchronized, so despite raw Vulkan
            /// function `vkMapMemory()` cannot be used to map same block of `VkDeviceMemory`
            /// multiple times simultaneously, it is safe to call this function on allocations
            /// assigned to the same memory block. Actual Vulkan memory will be mapped on first
            /// mapping and unmapped on last unmapping.
            /// If the function succeeded, you must call vmaUnmapMemory() to unmap the
            /// allocation when mapping is no longer needed or before freeing the allocation, at
            /// the latest.
            /// It also safe to call this function multiple times on the same allocation. You
            /// must call vmaUnmapMemory() same number of times as you called vmaMapMemory().
            /// It is also safe to call this function on allocation created with
            /// #VMA_ALLOCATION_CREATE_MAPPED_BIT flag. Its memory stays mapped all the time.
            /// You must still call vmaUnmapMemory() same number of times as you called
            /// vmaMapMemory(). You must not call vmaUnmapMemory() additional time to free the
            /// "0-th" mapping made automatically due to #VMA_ALLOCATION_CREATE_MAPPED_BIT flag.
            /// This function fails when used on allocation made in memory type that is not
            /// `HOST_VISIBLE`.
            /// This function doesn't automatically flush or invalidate caches.
            /// If the allocation is made from a memory types that is not `HOST_COHERENT`,
            /// you also need to use vmaInvalidateAllocation() / vmaFlushAllocation(), as required by Vulkan specification.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult MapMemory(VmaAllocation allocation, PtrPtr ppData)
            {
                return Vma.PInvoke.vmaMapMemory(allocator.VkHandle, allocation, ppData);
            }

            /// <summary>
            /// Unmaps memory represented by given allocation, mapped previously using vmaMapMemory().
            /// For details, see description of vmaMapMemory().
            /// This function doesn't automatically flush or invalidate caches.
            /// If the allocation is made from a memory types that is not `HOST_COHERENT`,
            /// you also need to use vmaInvalidateAllocation() / vmaFlushAllocation(), as required by Vulkan specification.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void UnmapMemory(VmaAllocation allocation)
            {
                Vma.PInvoke.vmaUnmapMemory(allocator.VkHandle, allocation);
            }

            /// <summary>
            /// Flushes memory of given allocation.
            /// Calls `vkFlushMappedMemoryRanges()` for memory associated with given range of given allocation.
            /// It needs to be called after writing to a mapped memory for memory types that are not `HOST_COHERENT`.
            /// Unmap operation doesn't do that automatically.
            /// - `offset` must be relative to the beginning of allocation.
            /// - `size` can be `VK_WHOLE_SIZE`. It means all memory from `offset` the the end of given allocation.
            /// - `offset` and `size` don't have to be aligned.
            /// They are internally rounded down/up to multiply of `nonCoherentAtomSize`.
            /// - If `size` is 0, this call is ignored.
            /// - If memory type that the `allocation` belongs to is not `HOST_VISIBLE` or it is `HOST_COHERENT`,
            /// this call is ignored.
            /// Warning! `offset` and `size` are relative to the contents of given `allocation`.
            /// If you mean whole allocation, you can pass 0 and `VK_WHOLE_SIZE`, respectively.
            /// Do not pass allocation's offset as `offset`!!!
            /// This function returns the `VkResult` from `vkFlushMappedMemoryRanges` if it is
            /// called, otherwise `VK_SUCCESS`.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public VkResult FlushAllocation(VmaAllocation allocation, ByteSize offset, ByteSize size)
            {
                return Vma.PInvoke.vmaFlushAllocation(allocator.VkHandle, allocation, offset, size);
            }

            /// <summary>
            /// Invalidates memory of given allocation.
            /// Calls `vkInvalidateMappedMemoryRanges()` for memory associated with given range of given allocation.
            /// It needs to be called before reading from a mapped memory for memory types that are not `HOST_COHERENT`.
            /// Map operation doesn't do that automatically.
            /// - `offset` must be relative to the beginning of allocation.
            /// - `size` can be `VK_WHOLE_SIZE`. It means all memory from `offset` the the end of given allocation.
            /// - `offset` and `size` don't have to be aligned.
            /// They are internally rounded down/up to multiply of `nonCoherentAtomSize`.
            /// - If `size` is 0, this call is ignored.
            /// - If memory type that the `allocation` belongs to is not `HOST_VISIBLE` or it is `HOST_COHERENT`,
            /// this call is ignored.
            /// Warning! `offset` and `size` are relative to the contents of given `allocation`.
            /// If you mean whole allocation, you can pass 0 and `VK_WHOLE_SIZE`, respectively.
            /// Do not pass allocation's offset as `offset`!!!
            /// This function returns the `VkResult` from `vkInvalidateMappedMemoryRanges` if
            /// it is called, otherwise `VK_SUCCESS`.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public VkResult InvalidateAllocation(VmaAllocation allocation, ByteSize offset, ByteSize size)
            {
                return Vma.PInvoke.vmaInvalidateAllocation(allocator.VkHandle, allocation, offset, size);
            }

            /// <summary>
            /// Flushes memory of given set of allocations.
            /// Calls `vkFlushMappedMemoryRanges()` for memory associated with given ranges of given allocations.
            /// For more information, see documentation of vmaFlushAllocation().
            /// This function returns the `VkResult` from `vkFlushMappedMemoryRanges` if it is
            /// called, otherwise `VK_SUCCESS`.
            /// </summary>
            /// <param name="allocator"/>
            /// <param name="allocationCount"/>
            /// <param name="allocations"/>
            /// <param name="offsets">If not null, it must point to an array of offsets of regions to flush, relative to the beginning of respective allocations. Null means all offsets are zero.</param>
            /// <param name="sizes">If not null, it must point to an array of sizes of regions to flush in respective allocations. Null means `VK_WHOLE_SIZE` for all allocations.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult FlushAllocations(
                uint allocationCount,
                scoped Span<VmaAllocation> allocations,
                scoped Span<ByteSize> offsets,
                scoped Span<ByteSize> sizes
            )
            {
                fixed (ByteSize* sizesPtr = sizes)
                fixed (ByteSize* offsetsPtr = offsets)
                fixed (VmaAllocation* allocationsPtr = allocations)
                    return Vma.PInvoke.vmaFlushAllocations(
                        allocator.VkHandle,
                        allocationCount,
                        allocationsPtr,
                        offsetsPtr,
                        sizesPtr
                    );
            }

            /// <summary>
            /// Invalidates memory of given set of allocations.
            /// Calls `vkInvalidateMappedMemoryRanges()` for memory associated with given ranges of given allocations.
            /// For more information, see documentation of vmaInvalidateAllocation().
            /// This function returns the `VkResult` from `vkInvalidateMappedMemoryRanges` if it is
            /// called, otherwise `VK_SUCCESS`.
            /// </summary>
            /// <param name="allocator"/>
            /// <param name="allocationCount"/>
            /// <param name="allocations"/>
            /// <param name="offsets">If not null, it must point to an array of offsets of regions to flush, relative to the beginning of respective allocations. Null means all offsets are zero.</param>
            /// <param name="sizes">If not null, it must point to an array of sizes of regions to flush in respective allocations. Null means `VK_WHOLE_SIZE` for all allocations.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult InvalidateAllocations(
                uint allocationCount,
                scoped Span<VmaAllocation> allocations,
                scoped Span<ByteSize> offsets,
                scoped Span<ByteSize> sizes
            )
            {
                fixed (ByteSize* sizesPtr = sizes)
                fixed (ByteSize* offsetsPtr = offsets)
                fixed (VmaAllocation* allocationsPtr = allocations)
                    return Vma.PInvoke.vmaInvalidateAllocations(
                        allocator.VkHandle,
                        allocationCount,
                        allocationsPtr,
                        offsetsPtr,
                        sizesPtr
                    );
            }

            /// <summary>
            /// Maps the allocation temporarily if needed, copies data from specified host pointer to it, and flushes the memory from the host caches if needed.
            /// This is a convenience function that allows to copy data from a host pointer to an allocation easily.
            /// Same behavior can be achieved by calling vmaMapMemory(), `memcpy()`, vmaUnmapMemory(), vmaFlushAllocation().
            /// This function can be called only for allocations created in a memory type that has `VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT` flag.
            /// It can be ensured e.g. by using #VMA_MEMORY_USAGE_AUTO and #VMA_ALLOCATION_CREATE_HOST_ACCESS_SEQUENTIAL_WRITE_BIT or
            /// #VMA_ALLOCATION_CREATE_HOST_ACCESS_RANDOM_BIT.
            /// Otherwise, the function will fail and generate a Validation Layers error.
            /// `dstAllocationLocalOffset` is relative to the contents of given `dstAllocation`.
            /// If you mean whole allocation, you should pass 0.
            /// Do not pass allocation's offset within device memory block this parameter!
            /// </summary>
            /// <param name="allocator"/>
            /// <param name="pSrcHostPointer">Pointer to the host data that become source of the copy.</param>
            /// <param name="dstAllocation">Handle to the allocation that becomes destination of the copy.</param>
            /// <param name="dstAllocationLocalOffset">Offset within `dstAllocation` where to write copied data, in bytes.</param>
            /// <param name="size">Number of bytes to copy.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult CopyMemoryToAllocation(
                Ptr pSrcHostPointer,
                VmaAllocation dstAllocation,
                ByteSize dstAllocationLocalOffset,
                ByteSize size
            )
            {
                return Vma.PInvoke.vmaCopyMemoryToAllocation(
                    allocator.VkHandle,
                    pSrcHostPointer,
                    dstAllocation,
                    dstAllocationLocalOffset,
                    size
                );
            }

            /// <summary>
            /// Invalidates memory in the host caches if needed, maps the allocation temporarily if needed, and copies data from it to a specified host pointer.
            /// This is a convenience function that allows to copy data from an allocation to a host pointer easily.
            /// Same behavior can be achieved by calling vmaInvalidateAllocation(), vmaMapMemory(), `memcpy()`, vmaUnmapMemory().
            /// This function should be called only for allocations created in a memory type that has `VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT`
            /// and `VK_MEMORY_PROPERTY_HOST_CACHED_BIT` flag.
            /// It can be ensured e.g. by using #VMA_MEMORY_USAGE_AUTO and #VMA_ALLOCATION_CREATE_HOST_ACCESS_RANDOM_BIT.
            /// Otherwise, the function may fail and generate a Validation Layers error.
            /// It may also work very slowly when reading from an uncached memory.
            /// `srcAllocationLocalOffset` is relative to the contents of given `srcAllocation`.
            /// If you mean whole allocation, you should pass 0.
            /// Do not pass allocation's offset within device memory block as this parameter!
            /// </summary>
            /// <param name="allocator"/>
            /// <param name="srcAllocation">Handle to the allocation that becomes source of the copy.</param>
            /// <param name="srcAllocationLocalOffset">Offset within `srcAllocation` where to read copied data, in bytes.</param>
            /// <param name="pDstHostPointer">Pointer to the host memory that become destination of the copy.</param>
            /// <param name="size">Number of bytes to copy.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult CopyAllocationToMemory(
                VmaAllocation srcAllocation,
                ByteSize srcAllocationLocalOffset,
                Ptr pDstHostPointer,
                ByteSize size
            )
            {
                return Vma.PInvoke.vmaCopyAllocationToMemory(
                    allocator.VkHandle,
                    srcAllocation,
                    srcAllocationLocalOffset,
                    pDstHostPointer,
                    size
                );
            }

            /// <summary>
            /// Checks magic number in margins around all allocations in given memory types (in both default and custom pools) in search for corruptions.
            /// Corruption detection is enabled only when `VMA_DEBUG_DETECT_CORRUPTION` macro is defined to nonzero,
            /// `VMA_DEBUG_MARGIN` is defined to nonzero and only for memory types that are
            /// `HOST_VISIBLE` and `HOST_COHERENT`. For more information, see [Corruption detection](
            /// Possible return values:
            /// - `VK_ERROR_FEATURE_NOT_PRESENT` - corruption detection is not enabled for any of specified memory types.
            /// - `VK_SUCCESS` - corruption detection has been performed and succeeded.
            /// - `VK_ERROR_UNKNOWN` - corruption detection has been performed and found memory corruptions around one of the allocations.
            /// `VMA_ASSERT` is also fired in that case.
            /// - Other value: Error returned by Vulkan, e.g. memory mapping failure.
            /// </summary>
            /// <param name="allocator"/>
            /// <param name="memoryTypeBits">Bit mask, where each bit set means that a memory type with that index should be checked.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public VkResult CheckCorruption(uint memoryTypeBits)
            {
                return Vma.PInvoke.vmaCheckCorruption(allocator.VkHandle, memoryTypeBits);
            }

            /// <summary>
            /// Begins defragmentation process.
            /// - `VK_SUCCESS` if defragmentation can begin. - `VK_ERROR_FEATURE_NOT_PRESENT` if defragmentation is not supported.
            /// For more information about defragmentation, see documentation chapter:
            /// [Defragmentation](
            /// </summary>
            /// <param name="allocator">Allocator object.</param>
            /// <param name="pInfo">Structure filled with parameters of defragmentation.</param>
            /// <param name="pContext">Context object that must be passed to vmaEndDefragmentation() to finish defragmentation.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult BeginDefragmentation(
                VmaDefragmentationInfo pInfo,
                out VmaDefragmentationContext pContext
            )
            {
                fixed (VmaDefragmentationContext* pContextPtr = &pContext)
                    return Vma.PInvoke.vmaBeginDefragmentation(allocator.VkHandle, &pInfo, pContextPtr);
            }

            /// <summary>
            /// Ends defragmentation process.
            /// Use this function to finish defragmentation started by vmaBeginDefragmentation().
            /// </summary>
            /// <param name="allocator">Allocator object.</param>
            /// <param name="context">Context object that has been created by vmaBeginDefragmentation().</param>
            /// <param name="pStats">Optional stats for the defragmentation. Can be null.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void EndDefragmentation(VmaDefragmentationContext context, out VmaDefragmentationStats pStats)
            {
                fixed (VmaDefragmentationStats* pStatsPtr = &pStats)
                    Vma.PInvoke.vmaEndDefragmentation(allocator.VkHandle, context, pStatsPtr);
            }

            /// <summary>
            /// Starts single defragmentation pass.
            /// - `VK_SUCCESS` if no more moves are possible. Then you can omit call to vmaEndDefragmentationPass() and simply end whole defragmentation. - `VK_INCOMPLETE` if there are pending moves returned in `pPassInfo`. You need to perform them, call vmaEndDefragmentationPass(), and then preferably try another pass with vmaBeginDefragmentationPass().
            /// </summary>
            /// <param name="allocator">Allocator object.</param>
            /// <param name="context">Context object that has been created by vmaBeginDefragmentation().</param>
            /// <param name="pPassInfo">Computed information for current pass.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult BeginDefragmentationPass(
                VmaDefragmentationContext context,
                out VmaDefragmentationPassMoveInfo pPassInfo
            )
            {
                fixed (VmaDefragmentationPassMoveInfo* pPassInfoPtr = &pPassInfo)
                    return Vma.PInvoke.vmaBeginDefragmentationPass(allocator.VkHandle, context, pPassInfoPtr);
            }

            /// <summary>
            /// Ends single defragmentation pass.
            /// Returns `VK_SUCCESS` if no more moves are possible or `VK_INCOMPLETE` if more defragmentations are possible.
            /// Ends incremental defragmentation pass and commits all defragmentation moves from `pPassInfo`.
            /// After this call:
            /// - Allocations at `pPassInfo[i].srcAllocation` that had `pPassInfo[i].operation ==` #VMA_DEFRAGMENTATION_MOVE_OPERATION_COPY
            /// (which is the default) will be pointing to the new destination place.
            /// - Allocation at `pPassInfo[i].srcAllocation` that had `pPassInfo[i].operation ==` #VMA_DEFRAGMENTATION_MOVE_OPERATION_DESTROY
            /// will be freed.
            /// If no more moves are possible you can end whole defragmentation.
            /// </summary>
            /// <param name="allocator">Allocator object.</param>
            /// <param name="context">Context object that has been created by vmaBeginDefragmentation().</param>
            /// <param name="pPassInfo">Computed information for current pass filled by vmaBeginDefragmentationPass() and possibly modified by you.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult EndDefragmentationPass(
                VmaDefragmentationContext context,
                ref VmaDefragmentationPassMoveInfo pPassInfo
            )
            {
                fixed (VmaDefragmentationPassMoveInfo* pPassInfoPtr = &pPassInfo)
                    return Vma.PInvoke.vmaEndDefragmentationPass(allocator.VkHandle, context, pPassInfoPtr);
            }

            /// <summary>
            /// Binds buffer to allocation.
            /// Binds specified buffer to region of memory represented by specified allocation.
            /// Gets `VkDeviceMemory` handle and offset from the allocation.
            /// If you want to create a buffer, allocate memory for it and bind them together separately,
            /// you should use this function for binding instead of standard `vkBindBufferMemory()`,
            /// because it ensures proper synchronization so that when a `VkDeviceMemory` object is used by multiple
            /// allocations, calls to `vkBind*Memory()` or `vkMapMemory()` won't happen from multiple threads simultaneously
            /// (which is illegal in Vulkan).
            /// It is recommended to use function vmaCreateBuffer() instead of this one.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public VkResult BindBufferMemory(VmaAllocation allocation, VkBuffer buffer)
            {
                return Vma.PInvoke.vmaBindBufferMemory(allocator.VkHandle, allocation, buffer);
            }

            /// <summary>
            /// Binds buffer to allocation with additional parameters.
            /// This function is similar to vmaBindBufferMemory(), but it provides additional parameters.
            /// If `pNext` is not null, #VmaAllocator object must have been created with #VMA_ALLOCATOR_CREATE_KHR_BIND_MEMORY2_BIT flag
            /// or with VmaAllocatorCreateInfo::vulkanApiVersion `>= VK_API_VERSION_1_1`. Otherwise the call fails.
            /// </summary>
            /// <param name="allocator"/>
            /// <param name="allocation"/>
            /// <param name="allocationLocalOffset">Additional offset to be added while binding, relative to the beginning of the `allocation`. Normally it should be 0.</param>
            /// <param name="buffer"/>
            /// <param name="pNext">A chain of structures to be attached to `VkBindBufferMemoryInfoKHR` structure used internally. Normally it should be null.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult BindBufferMemory2(
                VmaAllocation allocation,
                ByteSize allocationLocalOffset,
                VkBuffer buffer,
                Ptr pNext
            )
            {
                return Vma.PInvoke.vmaBindBufferMemory2(
                    allocator.VkHandle,
                    allocation,
                    allocationLocalOffset,
                    buffer,
                    pNext
                );
            }

            /// <summary>
            /// Binds image to allocation.
            /// Binds specified image to region of memory represented by specified allocation.
            /// Gets `VkDeviceMemory` handle and offset from the allocation.
            /// If you want to create an image, allocate memory for it and bind them together separately,
            /// you should use this function for binding instead of standard `vkBindImageMemory()`,
            /// because it ensures proper synchronization so that when a `VkDeviceMemory` object is used by multiple
            /// allocations, calls to `vkBind*Memory()` or `vkMapMemory()` won't happen from multiple threads simultaneously
            /// (which is illegal in Vulkan).
            /// It is recommended to use function vmaCreateImage() instead of this one.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public VkResult BindImageMemory(VmaAllocation allocation, VkImage image)
            {
                return Vma.PInvoke.vmaBindImageMemory(allocator.VkHandle, allocation, image);
            }

            /// <summary>
            /// Binds image to allocation with additional parameters.
            /// This function is similar to vmaBindImageMemory(), but it provides additional parameters.
            /// If `pNext` is not null, #VmaAllocator object must have been created with #VMA_ALLOCATOR_CREATE_KHR_BIND_MEMORY2_BIT flag
            /// or with VmaAllocatorCreateInfo::vulkanApiVersion `>= VK_API_VERSION_1_1`. Otherwise the call fails.
            /// </summary>
            /// <param name="allocator"/>
            /// <param name="allocation"/>
            /// <param name="allocationLocalOffset">Additional offset to be added while binding, relative to the beginning of the `allocation`. Normally it should be 0.</param>
            /// <param name="image"/>
            /// <param name="pNext">A chain of structures to be attached to `VkBindImageMemoryInfoKHR` structure used internally. Normally it should be null.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult BindImageMemory2(
                VmaAllocation allocation,
                ByteSize allocationLocalOffset,
                VkImage image,
                Ptr pNext
            )
            {
                return Vma.PInvoke.vmaBindImageMemory2(
                    allocator.VkHandle,
                    allocation,
                    allocationLocalOffset,
                    image,
                    pNext
                );
            }

            /// <summary>
            /// Creates a new `VkBuffer`, allocates and binds memory for it.
            /// This function automatically:
            /// -# Creates buffer.
            /// -# Allocates appropriate memory for it.
            /// -# Binds the buffer with the memory.
            /// If any of these operations fail, buffer and allocation are not created,
            /// returned value is negative error code, `*pBuffer` and `*pAllocation` are returned as null.
            /// If the function succeeded, you must destroy both buffer and allocation when you
            /// no longer need them using either convenience function vmaDestroyBuffer() or
            /// separately, using `vkDestroyBuffer()` and vmaFreeMemory().
            /// If VK_KHR_dedicated_allocation extenion or Vulkan version >= 1.1 is used,
            /// the function queries the driver whether
            /// it requires or prefers the new buffer to have dedicated allocation. If yes,
            /// and if dedicated allocation is possible
            /// (#VMA_ALLOCATION_CREATE_NEVER_ALLOCATE_BIT is not used), it creates dedicated
            /// allocation for this buffer, just like when using
            /// #VMA_ALLOCATION_CREATE_DEDICATED_MEMORY_BIT.
            /// This function creates a new `VkBuffer`. Sub-allocation of parts of one large buffer, although recommended as a good practice, is out of scope of this library and could be implemented by the user as a higher-level logic on top of VMA.
            /// There is also an extended versions of this function available with additional parameter `pMemoryAllocateNext` -
            /// see vmaCreateDedicatedBuffer().
            /// </summary>
            /// <param name="allocator">The main allocator object.</param>
            /// <param name="pBufferCreateInfo">Buffer creation parameters.</param>
            /// <param name="pAllocationCreateInfo">Allocation creation parameters.</param>
            /// <param name="pBuffer">Buffer that was created.</param>
            /// <param name="pAllocation">Allocation that was created.</param>
            /// <param name="pAllocationInfo">Optional, can be null. Information about allocated memory.It can be also fetched later using vmaGetAllocationInfo().</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult CreateBuffer(
                VkBufferCreateInfo pBufferCreateInfo,
                VmaAllocationCreateInfo pAllocationCreateInfo,
                out VkBuffer pBuffer,
                out VmaAllocation pAllocation,
                out VmaAllocationInfo pAllocationInfo
            )
            {
                fixed (VmaAllocationInfo* pAllocationInfoPtr = &pAllocationInfo)
                fixed (VmaAllocation* pAllocationPtr = &pAllocation)
                fixed (VkBuffer* pBufferPtr = &pBuffer)
                    return Vma.PInvoke.vmaCreateBuffer(
                        allocator.VkHandle,
                        &pBufferCreateInfo,
                        &pAllocationCreateInfo,
                        pBufferPtr,
                        pAllocationPtr,
                        pAllocationInfoPtr
                    );
            }

            /// <summary>
            /// Creates a buffer with additional minimum alignment.
            /// Similar to vmaCreateBuffer() but provides additional parameter `minAlignment` which allows to specify custom,
            /// minimum alignment to be used when placing the buffer inside a larger memory block, which may be needed e.g.
            /// for interop with OpenGL.
            /// This function in obsolete since new VmaAllocationCreateInfo::minAlignment member allows specifying custom alignment while using any allocation function, like the standard vmaCreateBuffer().
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult CreateBufferWithAlignment(
                VkBufferCreateInfo pBufferCreateInfo,
                VmaAllocationCreateInfo pAllocationCreateInfo,
                ByteSize minAlignment,
                VkBuffer pBuffer,
                VmaAllocation pAllocation,
                VmaAllocationInfo pAllocationInfo
            )
            {
                return Vma.PInvoke.vmaCreateBufferWithAlignment(
                    allocator.VkHandle,
                    &pBufferCreateInfo,
                    &pAllocationCreateInfo,
                    minAlignment,
                    &pBuffer,
                    &pAllocation,
                    &pAllocationInfo
                );
            }

            /// <summary>
            /// Creates a dedicated buffer while offering extra parameter `pMemoryAllocateNext`.
            /// This function is similar vmaCreateBuffer(), but
            /// it always allocates dedicated memory for the buffer - flag #VMA_ALLOCATION_CREATE_DEDICATED_MEMORY_BIT is implied.
            /// It offers additional parameter `pMemoryAllocateNext`,
            /// which can be used to attach `pNext` chain to the `VkMemoryAllocateInfo` structure.
            /// It can be useful for importing external memory. For more information, see
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult CreateDedicatedBuffer(
                VkBufferCreateInfo pBufferCreateInfo,
                VmaAllocationCreateInfo pAllocationCreateInfo,
                Ptr pMemoryAllocateNext,
                VkBuffer pBuffer,
                VmaAllocation pAllocation,
                VmaAllocationInfo pAllocationInfo
            )
            {
                return Vma.PInvoke.vmaCreateDedicatedBuffer(
                    allocator.VkHandle,
                    &pBufferCreateInfo,
                    &pAllocationCreateInfo,
                    pMemoryAllocateNext,
                    &pBuffer,
                    &pAllocation,
                    &pAllocationInfo
                );
            }

            /// <summary>
            /// Creates a new `VkBuffer`, binds already created memory for it.
            /// This function automatically:
            /// -# Creates buffer.
            /// -# Binds the buffer with the supplied memory.
            /// If any of these operations fail, buffer is not created,
            /// returned value is negative error code and `*pBuffer` is null.
            /// If the function succeeded, you must destroy the buffer when you
            /// no longer need it using `vkDestroyBuffer()`. If you want to also destroy the corresponding
            /// allocation you can use convenience function vmaDestroyBuffer().
            /// There is a new version of this function augmented with parameter `allocationLocalOffset` - see vmaCreateAliasingBuffer2().
            /// </summary>
            /// <param name="allocator"/>
            /// <param name="allocation">Allocation that provides memory to be used for binding new buffer to it.</param>
            /// <param name="pBufferCreateInfo"/>
            /// <param name="pBuffer">Buffer that was created.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult CreateAliasingBuffer(
                VmaAllocation allocation,
                VkBufferCreateInfo pBufferCreateInfo,
                out VkBuffer pBuffer
            )
            {
                fixed (VkBuffer* pBufferPtr = &pBuffer)
                    return Vma.PInvoke.vmaCreateAliasingBuffer(
                        allocator.VkHandle,
                        allocation,
                        &pBufferCreateInfo,
                        pBufferPtr
                    );
            }

            /// <summary>
            /// Creates a new `VkBuffer`, binds already created memory for it.
            /// This function automatically:
            /// -# Creates buffer.
            /// -# Binds the buffer with the supplied memory.
            /// If any of these operations fail, buffer is not created,
            /// returned value is negative error code and `*pBuffer` is null.
            /// If the function succeeded, you must destroy the buffer when you
            /// no longer need it using `vkDestroyBuffer()`. If you want to also destroy the corresponding
            /// allocation you can use convenience function vmaDestroyBuffer().
            /// This is a new version of the function augmented with parameter `allocationLocalOffset`.
            /// </summary>
            /// <param name="allocator"/>
            /// <param name="allocation">Allocation that provides memory to be used for binding new buffer to it.</param>
            /// <param name="allocationLocalOffset">Additional offset to be added while binding, relative to the beginning of the allocation. Normally it should be 0.</param>
            /// <param name="pBufferCreateInfo"/>
            /// <param name="pBuffer">Buffer that was created.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult CreateAliasingBuffer2(
                VmaAllocation allocation,
                ByteSize allocationLocalOffset,
                VkBufferCreateInfo pBufferCreateInfo,
                out VkBuffer pBuffer
            )
            {
                fixed (VkBuffer* pBufferPtr = &pBuffer)
                    return Vma.PInvoke.vmaCreateAliasingBuffer2(
                        allocator.VkHandle,
                        allocation,
                        allocationLocalOffset,
                        &pBufferCreateInfo,
                        pBufferPtr
                    );
            }

            /// <summary>
            /// Destroys Vulkan buffer and frees allocated memory.
            /// This is just a convenience function equivalent to:
            /// @code vkDestroyBuffer(device, buffer, allocationCallbacks); vmaFreeMemory(allocator, allocation); @endcode
            /// It is safe to pass null as buffer and/or allocation.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void DestroyBuffer(VkBuffer buffer, VmaAllocation allocation)
            {
                Vma.PInvoke.vmaDestroyBuffer(allocator.VkHandle, buffer, allocation);
            }

            /// <summary>
            /// Function similar to vmaCreateBuffer() but for images.
            /// There is also an extended version of this function available: vmaCreateDedicatedImage()
            /// which offers additional parameter `pMemoryAllocateNext`.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult CreateImage(
                VkImageCreateInfo pImageCreateInfo,
                VmaAllocationCreateInfo pAllocationCreateInfo,
                out VkImage pImage,
                out VmaAllocation pAllocation,
                out VmaAllocationInfo pAllocationInfo
            )
            {
                fixed (VmaAllocationInfo* pAllocationInfoPtr = &pAllocationInfo)
                fixed (VmaAllocation* pAllocationPtr = &pAllocation)
                fixed (VkImage* pImagePtr = &pImage)
                    return Vma.PInvoke.vmaCreateImage(
                        allocator.VkHandle,
                        &pImageCreateInfo,
                        &pAllocationCreateInfo,
                        pImagePtr,
                        pAllocationPtr,
                        pAllocationInfoPtr
                    );
            }

            /// <summary>
            /// Function similar to vmaCreateDedicatedBuffer() but for images.
            /// This function is similar vmaCreateImage(), but
            /// it always allocates dedicated memory for the image - flag #VMA_ALLOCATION_CREATE_DEDICATED_MEMORY_BIT is implied.
            /// It offers additional parameter `pMemoryAllocateNext`,
            /// which can be used to attach `pNext` chain to the `VkMemoryAllocateInfo` structure.
            /// It can be useful for importing external memory. For more information, see
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult CreateDedicatedImage(
                VkImageCreateInfo pImageCreateInfo,
                VmaAllocationCreateInfo pAllocationCreateInfo,
                Ptr pMemoryAllocateNext,
                out VkImage pImage,
                out VmaAllocation pAllocation,
                out VmaAllocationInfo pAllocationInfo
            )
            {
                fixed (VmaAllocationInfo* pAllocationInfoPtr = &pAllocationInfo)
                fixed (VmaAllocation* pAllocationPtr = &pAllocation)
                fixed (VkImage* pImagePtr = &pImage)
                    return Vma.PInvoke.vmaCreateDedicatedImage(
                        allocator.VkHandle,
                        &pImageCreateInfo,
                        &pAllocationCreateInfo,
                        pMemoryAllocateNext,
                        pImagePtr,
                        pAllocationPtr,
                        pAllocationInfoPtr
                    );
            }

            /// <summary>
            /// Function similar to vmaCreateAliasingBuffer() but for images.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult CreateAliasingImage(
                VmaAllocation allocation,
                VkImageCreateInfo pImageCreateInfo,
                out VkImage pImage
            )
            {
                fixed (VkImage* pImagePtr = &pImage)
                    return Vma.PInvoke.vmaCreateAliasingImage(
                        allocator.VkHandle,
                        allocation,
                        &pImageCreateInfo,
                        pImagePtr
                    );
            }

            /// <summary>
            /// Function similar to vmaCreateAliasingBuffer2() but for images.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult CreateAliasingImage2(
                VmaAllocation allocation,
                ByteSize allocationLocalOffset,
                VkImageCreateInfo pImageCreateInfo,
                out VkImage pImage
            )
            {
                fixed (VkImage* pImagePtr = &pImage)
                    return Vma.PInvoke.vmaCreateAliasingImage2(
                        allocator.VkHandle,
                        allocation,
                        allocationLocalOffset,
                        &pImageCreateInfo,
                        pImagePtr
                    );
            }

            /// <summary>
            /// Destroys Vulkan image and frees allocated memory.
            /// This is just a convenience function equivalent to:
            /// @code vkDestroyImage(device, image, allocationCallbacks); vmaFreeMemory(allocator, allocation); @endcode
            /// It is safe to pass null as image and/or allocation.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void DestroyImage(VkImage image, VmaAllocation allocation)
            {
                Vma.PInvoke.vmaDestroyImage(allocator.VkHandle, image, allocation);
            }

            /// <summary>
            /// Creates new #VmaVirtualBlock object.
            /// </summary>
            /// <param name="pCreateInfo">Parameters for creation.</param>
            /// <param name="pVirtualBlock">Returned virtual block object or `VMA_NULL` if creation failed.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult CreateVirtualBlock(
                VmaVirtualBlockCreateInfo pCreateInfo,
                out VmaVirtualBlock pVirtualBlock
            )
            {
                fixed (VmaVirtualBlock* pVirtualBlockPtr = &pVirtualBlock)
                    return Vma.PInvoke.vmaCreateVirtualBlock(&pCreateInfo, pVirtualBlockPtr);
            }

            /// <summary>
            /// Destroys #VmaVirtualBlock object.
            /// Please note that you should consciously handle virtual allocations that could remain unfreed in the block.
            /// You should either free them individually using vmaVirtualFree() or call vmaClearVirtualBlock()
            /// if you are sure this is what you want. If you do neither, an assert is called.
            /// If you keep pointers to some additional metadata associated with your virtual allocations in their `pUserData`,
            /// don't forget to free them.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void DestroyVirtualBlock(VmaVirtualBlock virtualBlock)
            {
                Vma.PInvoke.vmaDestroyVirtualBlock(virtualBlock);
            }

            /// <summary>
            /// Returns true of the #VmaVirtualBlock is empty - contains 0 virtual allocations and has all its space available for new allocations.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Bool32 IsVirtualBlockEmpty(VmaVirtualBlock virtualBlock)
            {
                return Vma.PInvoke.vmaIsVirtualBlockEmpty(virtualBlock);
            }

            /// <summary>
            /// Returns information about a specific virtual allocation within a virtual block, like its size and `pUserData` pointer.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void GetVirtualAllocationInfo(
                VmaVirtualBlock virtualBlock,
                VmaVirtualAllocation allocation,
                out VmaVirtualAllocationInfo pVirtualAllocInfo
            )
            {
                fixed (VmaVirtualAllocationInfo* pVirtualAllocInfoPtr = &pVirtualAllocInfo)
                    Vma.PInvoke.vmaGetVirtualAllocationInfo(virtualBlock, allocation, pVirtualAllocInfoPtr);
            }

            /// <summary>
            /// Allocates new virtual allocation inside given #VmaVirtualBlock.
            /// If the allocation fails due to not enough free space available, `VK_ERROR_OUT_OF_DEVICE_MEMORY` is returned
            /// (despite the function doesn't ever allocate actual GPU memory).
            /// `pAllocation` is then set to `VK_NULL_HANDLE` and `pOffset`, if not null, it set to `UINT64_MAX`.
            /// </summary>
            /// <param name="virtualBlock">Virtual block</param>
            /// <param name="pCreateInfo">Parameters for the allocation</param>
            /// <param name="pAllocation">Returned handle of the new allocation</param>
            /// <param name="pOffset">Returned offset of the new allocation. Optional, can be null.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe VkResult VirtualAllocate(
                VmaVirtualBlock virtualBlock,
                VmaVirtualAllocationCreateInfo pCreateInfo,
                out VmaVirtualAllocation pAllocation,
                out ByteSize pOffset
            )
            {
                fixed (ByteSize* pOffsetPtr = &pOffset)
                fixed (VmaVirtualAllocation* pAllocationPtr = &pAllocation)
                    return Vma.PInvoke.vmaVirtualAllocate(virtualBlock, &pCreateInfo, pAllocationPtr, pOffsetPtr);
            }

            /// <summary>
            /// Frees virtual allocation inside given #VmaVirtualBlock.
            /// It is correct to call this function with `allocation == VK_NULL_HANDLE` - it does nothing.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void VirtualFree(VmaVirtualBlock virtualBlock, VmaVirtualAllocation allocation)
            {
                Vma.PInvoke.vmaVirtualFree(virtualBlock, allocation);
            }

            /// <summary>
            /// Frees all virtual allocations inside given #VmaVirtualBlock.
            /// You must either call this function or free each virtual allocation individually with vmaVirtualFree()
            /// before destroying a virtual block. Otherwise, an assert is called.
            /// If you keep pointer to some additional metadata associated with your virtual allocation in its `pUserData`,
            /// don't forget to free it as well.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void ClearVirtualBlock(VmaVirtualBlock virtualBlock)
            {
                Vma.PInvoke.vmaClearVirtualBlock(virtualBlock);
            }

            /// <summary>
            /// Changes custom pointer associated with given virtual allocation.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void SetVirtualAllocationUserData(
                VmaVirtualBlock virtualBlock,
                VmaVirtualAllocation allocation,
                Ptr pUserData
            )
            {
                Vma.PInvoke.vmaSetVirtualAllocationUserData(virtualBlock, allocation, pUserData);
            }

            /// <summary>
            /// Calculates and returns statistics about virtual allocations and memory usage in given #VmaVirtualBlock.
            /// This function is fast to call. For more detailed statistics, see vmaCalculateVirtualBlockStatistics().
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void GetVirtualBlockStatistics(VmaVirtualBlock virtualBlock, out VmaStatistics pStats)
            {
                fixed (VmaStatistics* pStatsPtr = &pStats)
                    Vma.PInvoke.vmaGetVirtualBlockStatistics(virtualBlock, pStatsPtr);
            }

            /// <summary>
            /// Calculates and returns detailed statistics about virtual allocations and memory usage in given #VmaVirtualBlock.
            /// This function is slow to call. Use for debugging purposes.
            /// For less detailed statistics, see vmaGetVirtualBlockStatistics().
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void CalculateVirtualBlockStatistics(
                VmaVirtualBlock virtualBlock,
                out VmaDetailedStatistics pStats
            )
            {
                fixed (VmaDetailedStatistics* pStatsPtr = &pStats)
                    Vma.PInvoke.vmaCalculateVirtualBlockStatistics(virtualBlock, pStatsPtr);
            }

            /// <summary>
            /// Builds and returns a null-terminated string in JSON format with information about given #VmaVirtualBlock.
            /// Returned string must be freed using vmaFreeVirtualBlockStatsString().
            /// </summary>
            /// <param name="virtualBlock">Virtual block.</param>
            /// <param name="ppStatsString">Returned string.</param>
            /// <param name="detailedMap">Pass `VK_FALSE` to only obtain statistics as returned by vmaCalculateVirtualBlockStatistics(). Pass `VK_TRUE` to also obtain full list of allocations and free spaces.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void BuildVirtualBlockStatsString(
                VmaVirtualBlock virtualBlock,
                out Ptr<byte> ppStatsString,
                Bool32 detailedMap
            )
            {
                fixed (Ptr<byte>* ppStatsStringPtr = &ppStatsString)
                    Vma.PInvoke.vmaBuildVirtualBlockStatsString(virtualBlock, (byte**)ppStatsStringPtr, detailedMap);
            }

            /// <summary>
            /// Frees a string returned by vmaBuildVirtualBlockStatsString().
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void FreeVirtualBlockStatsString(
                VmaVirtualBlock virtualBlock,
                scoped ReadOnlySpan<byte> pStatsString
            )
            {
                fixed (byte* pStatsStringPtr = pStatsString)
                    Vma.PInvoke.vmaFreeVirtualBlockStatsString(virtualBlock, pStatsStringPtr);
            }

            /// <summary>
            /// Builds and returns statistics as a null-terminated string in JSON format.
            /// </summary>
            /// <param name="allocator"/>
            /// <param name="ppStatsString">Must be freed using vmaFreeStatsString() function.</param>
            /// <param name="detailedMap"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void BuildStatsString(out Ptr<byte> ppStatsString, Bool32 detailedMap)
            {
                fixed (Ptr<byte>* ppStatsStringPtr = &ppStatsString)
                    Vma.PInvoke.vmaBuildStatsString(allocator.VkHandle, (byte**)ppStatsStringPtr, detailedMap);
            }

            /// <summary>
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void FreeStatsString(scoped ReadOnlySpan<byte> pStatsString)
            {
                fixed (byte* pStatsStringPtr = pStatsString)
                    Vma.PInvoke.vmaFreeStatsString(allocator.VkHandle, pStatsStringPtr);
            }
        }
    }
}
