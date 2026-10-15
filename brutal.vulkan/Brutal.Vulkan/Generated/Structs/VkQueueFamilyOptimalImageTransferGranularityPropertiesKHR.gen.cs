namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyOptimalImageTransferGranularityPropertiesKHR.html">VkQueueFamilyOptimalImageTransferGranularityPropertiesKHR</see> - Structure specifying the optimal image transfer granularity for a queue family
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueueFamilyOptimalImageTransferGranularityPropertiesKHR</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance11
    ///         typedef struct VkQueueFamilyOptimalImageTransferGranularityPropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkExtent3D         optimalImageTransferGranularity;
    ///         } VkQueueFamilyOptimalImageTransferGranularityPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkQueueFamilyOptimalImageTransferGranularityPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.QueueFamilyOptimalImageTransferGranularityPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>OptimalImageTransferGranularity</c> is the optimal granularity for image copy operations in this queue family.
        /// </summary>
        [FieldOffset(16)]
        public VkExtent3D OptimalImageTransferGranularity;
    }
}
