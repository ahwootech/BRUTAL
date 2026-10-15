namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV.html">VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV</see> - Structure describing properties supported by a partitioned acceleration structure implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_partitioned_acceleration_structure
    ///         typedef struct VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxPartitionCount;
    ///         } VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDevicePartitionedAccelerationStructurePropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxPartitionCount</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxPartitionCount;
    }
}
