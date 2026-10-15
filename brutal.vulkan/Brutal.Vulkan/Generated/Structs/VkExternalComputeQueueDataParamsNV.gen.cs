namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalComputeQueueDataParamsNV.html">VkExternalComputeQueueDataParamsNV</see> - Structure specifying parameters for implementation-specific data retrieval from the external compute queue
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkExternalComputeQueueDataParamsNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_compute_queue
    ///         typedef struct VkExternalComputeQueueDataParamsNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           deviceIndex;
    ///         } VkExternalComputeQueueDataParamsNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkExternalComputeQueueDataParamsNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalComputeQueueDataParamsNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DeviceIndex</c> is the index of the device within a device group that the data is being queried for. This is ignored if device groups are not utilized.
        /// </summary>
        [FieldOffset(16)]
        public int DeviceIndex;
    }
}
