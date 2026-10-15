namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureOpInputNV.html">VkClusterAccelerationStructureOpInputNV</see> - Union specifying cluster acceleration structure description
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkClusterAccelerationStructureOpInputNV
    ///     </para>
    ///     <para>
    ///         The <c>VkClusterAccelerationStructureOpInputNV</c> union is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef union VkClusterAccelerationStructureOpInputNV {
    ///             VkClusterAccelerationStructureClustersBottomLevelInputNV*    pClustersBottomLevel;
    ///             VkClusterAccelerationStructureTriangleClusterInputNV*        pTriangleClusters;
    ///             VkClusterAccelerationStructureMoveObjectsInputNV*            pMoveObjects;
    ///         } VkClusterAccelerationStructureOpInputNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct VkClusterAccelerationStructureOpInputNV()
    {
        /// <summary>
        ///     <c>ClustersBottomLevel</c> is a <c>VkClusterAccelerationStructureClustersBottomLevelInputNV</c> structure specifying an upper threshold on parameters to build multiple bottom level acceleration structures from multiple cluster level acceleration structures.
        /// </summary>
        [FieldOffset(0)]
        public VkClusterAccelerationStructureClustersBottomLevelInputNV* ClustersBottomLevel;

        /// <summary>
        ///     <c>TriangleClusters</c> is a <c>VkClusterAccelerationStructureTriangleClusterInputNV</c> structure specifying an upper threshold on parameters to build a regular or templated cluster acceleration structure.
        /// </summary>
        [FieldOffset(0)]
        public VkClusterAccelerationStructureTriangleClusterInputNV* TriangleClusters;

        /// <summary>
        ///     <c>MoveObjects</c> is a <c>VkClusterAccelerationStructureMoveObjectsInputNV</c> structure specifying an upper threshold on the number of bytes moved and the type of acceleration structure being moved.
        /// </summary>
        [FieldOffset(0)]
        public VkClusterAccelerationStructureMoveObjectsInputNV* MoveObjects;
    }
}
