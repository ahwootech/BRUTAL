namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkWriteDescriptorSetAccelerationStructureNV.html">VkWriteDescriptorSetAccelerationStructureNV</see> - Structure specifying acceleration structure descriptor information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkWriteDescriptorSetAccelerationStructureNV
    ///     </para>
    ///     <para>
    ///         The <c>VkWriteDescriptorSetAccelerationStructureNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         typedef struct VkWriteDescriptorSetAccelerationStructureNV {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             uint32_t                            accelerationStructureCount;
    ///             const VkAccelerationStructureNV*    pAccelerationStructures;
    ///         } VkWriteDescriptorSetAccelerationStructureNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkWriteDescriptorSetAccelerationStructureNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.WriteDescriptorSetAccelerationStructureNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AccelerationStructureCount</c> is the number of elements in <c>pAccelerationStructures</c>.
        /// </summary>
        [FieldOffset(16)]
        public int AccelerationStructureCount;

        /// <summary>
        ///     <c>AccelerationStructures</c> is a pointer to an array of <c>VkAccelerationStructureNV</c> structures specifying the acceleration structures to update.
        /// </summary>
        [FieldOffset(24)]
        public VkAccelerationStructureNV* AccelerationStructures;
    }
}
