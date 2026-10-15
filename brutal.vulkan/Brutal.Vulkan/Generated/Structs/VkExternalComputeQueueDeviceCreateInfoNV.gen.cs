namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalComputeQueueDeviceCreateInfoNV.html">VkExternalComputeQueueDeviceCreateInfoNV</see> - Structure specifying information about external compute queues relevant to device creation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkExternalComputeQueueDeviceCreateInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_compute_queue
    ///         typedef struct VkExternalComputeQueueDeviceCreateInfoNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           reservedExternalQueues;
    ///         } VkExternalComputeQueueDeviceCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkExternalComputeQueueDeviceCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalComputeQueueDeviceCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ReservedExternalQueues</c> is the maximum number of external queues an application <i>can</i> create at once. This <i>must</i> be less than or equal to the <c>maxExternalQueues</c> value reported by <c>VkPhysicalDeviceExternalComputeQueuePropertiesNV</c>
        /// </summary>
        [FieldOffset(16)]
        public int ReservedExternalQueues;
    }
}
