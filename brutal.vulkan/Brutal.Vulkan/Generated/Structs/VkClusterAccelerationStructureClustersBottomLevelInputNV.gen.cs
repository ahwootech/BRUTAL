namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureClustersBottomLevelInputNV.html">VkClusterAccelerationStructureClustersBottomLevelInputNV</see> - Parameters describing bottom level acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkClusterAccelerationStructureClustersBottomLevelInputNV
    ///     </para>
    ///     <para>
    ///         The <c>VkClusterAccelerationStructureClustersBottomLevelInputNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkClusterAccelerationStructureClustersBottomLevelInputNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxTotalClusterCount;
    ///             uint32_t           maxClusterCountPerAccelerationStructure;
    ///         } VkClusterAccelerationStructureClustersBottomLevelInputNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkClusterAccelerationStructureClustersBottomLevelInputNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.ClusterAccelerationStructureClustersBottomLevelInputNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxTotalClusterCount</c> is the total number of clusters acceleration structures that will be built or moved across all input arguments.
        /// </summary>
        [FieldOffset(16)]
        public int MaxTotalClusterCount;

        /// <summary>
        ///     <c>MaxClusterCountPerAccelerationStructure</c> is the maximum number of clusters acceleration structures that will be built or moved per input argument.
        /// </summary>
        [FieldOffset(20)]
        public int MaxClusterCountPerAccelerationStructure;
    }
}
