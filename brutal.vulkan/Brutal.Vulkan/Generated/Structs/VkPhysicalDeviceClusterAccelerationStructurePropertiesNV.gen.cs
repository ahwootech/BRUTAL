namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceClusterAccelerationStructurePropertiesNV.html">VkPhysicalDeviceClusterAccelerationStructurePropertiesNV</see> - Structure describing properties supported by a cluster acceleration structure implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceClusterAccelerationStructurePropertiesNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkPhysicalDeviceClusterAccelerationStructurePropertiesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxVerticesPerCluster;
    ///             uint32_t           maxTrianglesPerCluster;
    ///             uint32_t           clusterScratchByteAlignment;
    ///             uint32_t           clusterByteAlignment;
    ///             uint32_t           clusterTemplateByteAlignment;
    ///             uint32_t           clusterBottomLevelByteAlignment;
    ///             uint32_t           clusterTemplateBoundsByteAlignment;
    ///             uint32_t           maxClusterGeometryIndex;
    ///         } VkPhysicalDeviceClusterAccelerationStructurePropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPhysicalDeviceClusterAccelerationStructurePropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceClusterAccelerationStructurePropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxVerticesPerCluster</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxVerticesPerCluster;

        /// <summary>
        ///     <c>MaxTrianglesPerCluster</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxTrianglesPerCluster;

        /// <summary>
        ///     <c>ClusterScratchByteAlignment</c>
        /// </summary>
        [FieldOffset(24)]
        public int ClusterScratchByteAlignment;

        /// <summary>
        ///     <c>ClusterByteAlignment</c>
        /// </summary>
        [FieldOffset(28)]
        public int ClusterByteAlignment;

        /// <summary>
        ///     <c>ClusterTemplateByteAlignment</c>
        /// </summary>
        [FieldOffset(32)]
        public int ClusterTemplateByteAlignment;

        /// <summary>
        ///     <c>ClusterBottomLevelByteAlignment</c>
        /// </summary>
        [FieldOffset(36)]
        public int ClusterBottomLevelByteAlignment;

        /// <summary>
        ///     <c>ClusterTemplateBoundsByteAlignment</c>
        /// </summary>
        [FieldOffset(40)]
        public int ClusterTemplateBoundsByteAlignment;

        /// <summary>
        ///     <c>MaxClusterGeometryIndex</c>
        /// </summary>
        [FieldOffset(44)]
        public int MaxClusterGeometryIndex;
    }
}
