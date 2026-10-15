namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureTriangleClusterInputNV.html">VkClusterAccelerationStructureTriangleClusterInputNV</see> - Parameters describing a cluster acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkClusterAccelerationStructureTriangleClusterInputNV
    ///     </para>
    ///     <para>
    ///         The <c>VkClusterAccelerationStructureTriangleClusterInputNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkClusterAccelerationStructureTriangleClusterInputNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkFormat           vertexFormat;
    ///             uint32_t           maxGeometryIndexValue;
    ///             uint32_t           maxClusterUniqueGeometryCount;
    ///             uint32_t           maxClusterTriangleCount;
    ///             uint32_t           maxClusterVertexCount;
    ///             uint32_t           maxTotalTriangleCount;
    ///             uint32_t           maxTotalVertexCount;
    ///             uint32_t           minPositionTruncateBitCount;
    ///         } VkClusterAccelerationStructureTriangleClusterInputNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkClusterAccelerationStructureTriangleClusterInputNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ClusterAccelerationStructureTriangleClusterInputNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VertexFormat</c> is the <c>VkFormat</c> of each vertex element.
        /// </summary>
        [FieldOffset(16)]
        public VkFormat VertexFormat;

        /// <summary>
        ///     <c>MaxGeometryIndexValue</c> is the maximum geometry index value for any constructed geometry.
        /// </summary>
        [FieldOffset(20)]
        public int MaxGeometryIndexValue;

        /// <summary>
        ///     <c>MaxClusterUniqueGeometryCount</c> is the maximum number of unique values of the geometry index for each cluster or cluster template.
        /// </summary>
        [FieldOffset(24)]
        public int MaxClusterUniqueGeometryCount;

        /// <summary>
        ///     <c>MaxClusterTriangleCount</c>
        /// </summary>
        [FieldOffset(28)]
        public int MaxClusterTriangleCount;

        /// <summary>
        ///     <c>MaxClusterVertexCount</c> is the maximum number of unique vertices in the cluster&apos;s index buffer.
        /// </summary>
        [FieldOffset(32)]
        public int MaxClusterVertexCount;

        /// <summary>
        ///     <c>MaxTotalTriangleCount</c> is the sum of all triangles across all clusters or cluster templates.
        /// </summary>
        [FieldOffset(36)]
        public int MaxTotalTriangleCount;

        /// <summary>
        ///     <c>MaxTotalVertexCount</c> is the maximum number of vertices across all clusters or cluster templates.
        /// </summary>
        [FieldOffset(40)]
        public int MaxTotalVertexCount;

        /// <summary>
        ///     <c>MinPositionTruncateBitCount</c>
        /// </summary>
        [FieldOffset(44)]
        public int MinPositionTruncateBitCount;
    }
}
