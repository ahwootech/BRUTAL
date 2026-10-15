namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureOpTypeNV.html">VkClusterAccelerationStructureOpTypeNV</see> - Enum providing the type of operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values which <i>can</i> be set in <c>VkClusterAccelerationStructureOpTypeNV</c>
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef enum VkClusterAccelerationStructureOpTypeNV {
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_MOVE_OBJECTS_NV = 0,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_BUILD_CLUSTERS_BOTTOM_LEVEL_NV = 1,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_BUILD_TRIANGLE_CLUSTER_NV = 2,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_BUILD_TRIANGLE_CLUSTER_TEMPLATE_NV = 3,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_INSTANTIATE_TRIANGLE_CLUSTER_NV = 4,
    ///             VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_GET_CLUSTER_TEMPLATE_INDICES_NV = 5,
    ///         } VkClusterAccelerationStructureOpTypeNV;
    ///     </code>
    /// </remarks>
    public enum VkClusterAccelerationStructureOpTypeNV : int
    {
        /// <summary>
        ///     <c>MoveObjectsNV</c>  specifies that a cluster acceleration structure, cluster acceleration structure template or a bottom level acceleration structure built from cluster acceleration structures will be moved. If a cluster acceleration structure is moved, the bottom level cluster acceleration structures containing it will have to be re-built. If used with <c>VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_COMPUTE_SIZES_NV</c>, it returns the size of existing cluster acceleration structures.
        /// </summary>
        MoveObjectsNV = 0,

        /// <summary>
        ///     <c>BuildClustersBottomLevelNV</c>  specifies that bottom level cluster acceleration structures will be built.
        /// </summary>
        BuildClustersBottomLevelNV = 1,

        /// <summary>
        ///     <c>BuildTriangleClusterNV</c>  specifies that cluster acceleration structures will be built.
        /// </summary>
        BuildTriangleClusterNV = 2,

        /// <summary>
        ///     <c>BuildTriangleClusterTemplateNV</c>  specifies that a template for cluster acceleration structure will be built.
        /// </summary>
        BuildTriangleClusterTemplateNV = 3,

        /// <summary>
        ///     <c>InstantiateTriangleClusterNV</c>  specifies that a template for a cluster acceleration structure will be instantiated, resulting in a built cluster acceleration structure.
        /// </summary>
        InstantiateTriangleClusterNV = 4,

        /// <summary>
        ///     <c>GetClusterTemplateIndicesNV</c>  specifies that the vertex indices of the cluster template acceleration structure will be fetched.
        /// </summary>
        GetClusterTemplateIndicesNV = 5,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
