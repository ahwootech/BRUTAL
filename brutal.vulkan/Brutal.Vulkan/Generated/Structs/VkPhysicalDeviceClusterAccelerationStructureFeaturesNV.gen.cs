namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceClusterAccelerationStructureFeaturesNV.html">VkPhysicalDeviceClusterAccelerationStructureFeaturesNV</see> - Structure describing the ray tracing cluster geometry feature supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceClusterAccelerationStructureFeaturesNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkPhysicalDeviceClusterAccelerationStructureFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           clusterAccelerationStructure;
    ///         } VkPhysicalDeviceClusterAccelerationStructureFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceClusterAccelerationStructureFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceClusterAccelerationStructureFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ClusterAccelerationStructure</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ClusterAccelerationStructure;
    }
}
