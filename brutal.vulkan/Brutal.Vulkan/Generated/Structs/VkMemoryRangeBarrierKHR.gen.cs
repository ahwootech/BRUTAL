namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryRangeBarrierKHR.html">VkMemoryRangeBarrierKHR</see> - Structure specifying a memory range barrier
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkMemoryRangeBarrierKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkMemoryRangeBarrierKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands
    ///         typedef struct VkMemoryRangeBarrierKHR {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkPipelineStageFlags2       srcStageMask;
    ///             VkAccessFlags2              srcAccessMask;
    ///             VkPipelineStageFlags2       dstStageMask;
    ///             VkAccessFlags2              dstAccessMask;
    ///             uint32_t                    srcQueueFamilyIndex;
    ///             uint32_t                    dstQueueFamilyIndex;
    ///             VkDeviceAddressRangeKHR     addressRange;
    ///             VkAddressCommandFlagsKHR    addressFlags;
    ///         } VkMemoryRangeBarrierKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public unsafe partial struct VkMemoryRangeBarrierKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryRangeBarrierKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcStageMask</c> is a <c>VkPipelineStageFlags2</c> mask of pipeline stages to be included in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-dependencies-scopes">first synchronization scope^</see>.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineStageFlags2 SrcStageMask;

        /// <summary>
        ///     <c>SrcAccessMask</c> is a <c>VkAccessFlags2</c> mask of access flags to be included in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-dependencies-access-scopes">first access scope^</see>.
        /// </summary>
        [FieldOffset(24)]
        public VkAccessFlags2 SrcAccessMask;

        /// <summary>
        ///     <c>DstStageMask</c> is a <c>VkPipelineStageFlags2</c> mask of pipeline stages to be included in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-dependencies-scopes">second synchronization scope^</see>.
        /// </summary>
        [FieldOffset(32)]
        public VkPipelineStageFlags2 DstStageMask;

        /// <summary>
        ///     <c>DstAccessMask</c> is a <c>VkAccessFlags2</c> mask of access flags to be included in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-dependencies-access-scopes">second access scope^</see>.
        /// </summary>
        [FieldOffset(40)]
        public VkAccessFlags2 DstAccessMask;

        /// <summary>
        ///     <c>SrcQueueFamilyIndex</c> is the source queue family for a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-queue-transfers">queue family ownership transfer^</see>.
        /// </summary>
        [FieldOffset(48)]
        public int SrcQueueFamilyIndex;

        /// <summary>
        ///     <c>DstQueueFamilyIndex</c> is the destination queue family for a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-queue-transfers">queue family ownership transfer^</see>.
        /// </summary>
        [FieldOffset(52)]
        public int DstQueueFamilyIndex;

        /// <summary>
        ///     <c>AddressRange</c> is a <c>VkDeviceAddressRangeKHR</c> structure specifying the address range affected by the barrier.
        /// </summary>
        [FieldOffset(56)]
        public VkDeviceAddressRangeKHR AddressRange;

        /// <summary>
        ///     <c>AddressFlags</c> is a <c>VkAddressCommandFlagsKHR</c> value defining the flags for the address range.
        /// </summary>
        [FieldOffset(72)]
        public VkAddressCommandFlagsKHR AddressFlags;
    }
}
