namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalComputeQueuePropertiesNV.html">VkPhysicalDeviceExternalComputeQueuePropertiesNV</see> - Structure specifying hardware specific information and limits for VK_NV_external_compute_queue functionality
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExternalComputeQueuePropertiesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_compute_queue
    ///         typedef struct VkPhysicalDeviceExternalComputeQueuePropertiesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           externalDataSize;
    ///             uint32_t           maxExternalQueues;
    ///         } VkPhysicalDeviceExternalComputeQueuePropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceExternalComputeQueuePropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExternalComputeQueuePropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExternalDataSize</c> is the minimum size of the memory allocation that applications <i>can</i> pass to <c>vkGetExternalComputeQueueDataNV</c>.
        /// </summary>
        [FieldOffset(16)]
        public int ExternalDataSize;

        /// <summary>
        ///     <c>MaxExternalQueues</c> is the maximum number of external queues that an application can create.
        /// </summary>
        [FieldOffset(20)]
        public int MaxExternalQueues;
    }
}
