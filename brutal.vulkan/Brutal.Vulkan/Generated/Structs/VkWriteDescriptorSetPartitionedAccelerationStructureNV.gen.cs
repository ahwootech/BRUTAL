namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkWriteDescriptorSetPartitionedAccelerationStructureNV.html">VkWriteDescriptorSetPartitionedAccelerationStructureNV</see> - Structure specifying descriptor for PTLAS
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkWriteDescriptorSetPartitionedAccelerationStructureNV
    ///     </para>
    ///     <para>
    ///         If the <c>descriptorType</c> member of <c>VkWriteDescriptorSet</c> is
    ///         <c>VK_DESCRIPTOR_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_NV</c>, then the
    ///         data to write to the descriptor set is specified through a
    ///         <c>VkWriteDescriptorSetPartitionedAccelerationStructureNV</c> structure
    ///         included in the <c>pNext</c> chain of <c>VkWriteDescriptorSet</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkWriteDescriptorSetPartitionedAccelerationStructureNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_partitioned_acceleration_structure
    ///         typedef struct VkWriteDescriptorSetPartitionedAccelerationStructureNV {
    ///             VkStructureType           sType;
    ///             void*                     pNext;
    ///             uint32_t                  accelerationStructureCount;
    ///             const VkDeviceAddress*    pAccelerationStructures;
    ///         } VkWriteDescriptorSetPartitionedAccelerationStructureNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkWriteDescriptorSetPartitionedAccelerationStructureNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.WriteDescriptorSetPartitionedAccelerationStructureNV;

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
        ///     <c>AccelerationStructures</c> is a pointer to an array of <c>accelerationStructureCount</c> device addresses pointing to previously built PTLAS.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceAddress* AccelerationStructures;
    }
}
