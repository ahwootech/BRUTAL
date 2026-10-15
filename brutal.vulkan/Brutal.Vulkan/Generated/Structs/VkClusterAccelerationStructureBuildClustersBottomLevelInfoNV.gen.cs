namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureBuildClustersBottomLevelInfoNV.html">VkClusterAccelerationStructureBuildClustersBottomLevelInfoNV</see> - Parameters describing build operation for a bottom level cluster acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkClusterAccelerationStructureBuildClustersBottomLevelInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkClusterAccelerationStructureBuildClustersBottomLevelInfoNV</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkClusterAccelerationStructureBuildClustersBottomLevelInfoNV {
    ///             uint32_t           clusterReferencesCount;
    ///             uint32_t           clusterReferencesStride;
    ///             VkDeviceAddress    clusterReferences;
    ///         } VkClusterAccelerationStructureBuildClustersBottomLevelInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkClusterAccelerationStructureBuildClustersBottomLevelInfoNV()
    {
        /// <summary>
        ///     <c>ClusterReferencesCount</c> is the number of clusters this bottom level acceleration structure will be built from.
        /// </summary>
        [FieldOffset(0)]
        public int ClusterReferencesCount;

        /// <summary>
        ///     <c>ClusterReferencesStride</c> is the stride in <c>clusterReferences</c>.
        /// </summary>
        [FieldOffset(4)]
        public int ClusterReferencesStride;

        /// <summary>
        ///     <c>ClusterReferences</c> is the device memory containing the address of the clusters.
        /// </summary>
        [FieldOffset(8)]
        public VkDeviceAddress ClusterReferences;
    }
}
