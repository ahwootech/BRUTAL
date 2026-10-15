namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePartitionedAccelerationStructureFeaturesNV.html">VkPhysicalDevicePartitionedAccelerationStructureFeaturesNV</see> - Structure describing the ray tracing partitioned top level acceleration structure feature supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePartitionedAccelerationStructureFeaturesNV</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_partitioned_acceleration_structure
    ///         typedef struct VkPhysicalDevicePartitionedAccelerationStructureFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           partitionedAccelerationStructure;
    ///         } VkPhysicalDevicePartitionedAccelerationStructureFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePartitionedAccelerationStructureFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDevicePartitionedAccelerationStructureFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PartitionedAccelerationStructure</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PartitionedAccelerationStructure;
    }
}
