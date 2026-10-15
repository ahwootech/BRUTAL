namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureTypeNV.html">VkClusterAccelerationStructureTypeNV</see> - Enum providing the type of cluster acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values which <i>can</i> be set in <c>VkClusterAccelerationStructureTypeNV</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef enum VkClusterAccelerationStructureTypeNV {
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_TYPE_CLUSTERS_BOTTOM_LEVEL_NV = 0,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_TYPE_TRIANGLE_CLUSTER_NV = 1,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_TYPE_TRIANGLE_CLUSTER_TEMPLATE_NV = 2,
    ///         } VkClusterAccelerationStructureTypeNV;
    ///     </code>
    /// </remarks>
    public enum VkClusterAccelerationStructureTypeNV : int
    {
        /// <summary>
        ///     <c>ClustersBottomLevelNV</c>  specifies a bottom level cluster acceleration structure.
        /// </summary>
        ClustersBottomLevelNV = 0,

        /// <summary>
        ///     <c>TriangleClusterNV</c>  specifies a cluster acceleration structure.
        /// </summary>
        TriangleClusterNV = 1,

        /// <summary>
        ///     <c>TriangleClusterTemplateNV</c>  specifies a template cluster acceleration structure.
        /// </summary>
        TriangleClusterTemplateNV = 2,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
