namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalMemoryRDMAFeaturesNV.html">VkPhysicalDeviceExternalMemoryRDMAFeaturesNV</see> - Structure describing the external memory RDMA features supported by the implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExternalMemoryRDMAFeaturesNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_memory_rdma
    ///         typedef struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           externalMemoryRDMA;
    ///         } VkPhysicalDeviceExternalMemoryRDMAFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceExternalMemoryRdmaFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExternalMemoryRdmaFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExternalMemoryRDMA</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ExternalMemoryRDMA;
    }
}
