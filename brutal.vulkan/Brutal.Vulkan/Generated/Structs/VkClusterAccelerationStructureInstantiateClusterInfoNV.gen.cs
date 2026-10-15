namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureInstantiateClusterInfoNV.html">VkClusterAccelerationStructureInstantiateClusterInfoNV</see> - Parameters describing instantiate operation for a template cluster acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkClusterAccelerationStructureInstantiateClusterInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkClusterAccelerationStructureInstantiateClusterInfoNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkClusterAccelerationStructureInstantiateClusterInfoNV {
    ///             uint32_t                    clusterIdOffset;
    ///             uint32_t                    geometryIndexOffset:24;
    ///             uint32_t                    reserved:8;
    ///             VkDeviceAddress             clusterTemplateAddress;
    ///             VkStridedDeviceAddressNV    vertexBuffer;
    ///         } VkClusterAccelerationStructureInstantiateClusterInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct VkClusterAccelerationStructureInstantiateClusterInfoNV()
    {
        /// <summary>
        ///     <c>ClusterIdOffset</c> is an unsigned offset applied to the <c>clusterID</c> value stored in the cluster template.
        /// </summary>
        [FieldOffset(0)]
        public int ClusterIdOffset;

        /// <summary>
        ///     <c>GeometryIndexOffset</c> is a signed offset applied to the geometry index of each triangle.
        /// </summary>
        [FieldOffset(4)]
        private int _geometryIndexOffset;

        /// <summary>
        ///     <c>Reserved</c> is reserved for future use.
        /// </summary>
        [FieldOffset(4)]
        private int _reserved;

        /// <summary>
        ///     <c>ClusterTemplateAddress</c> is the address of a previously built cluster template.
        /// </summary>
        [FieldOffset(8)]
        public VkDeviceAddress ClusterTemplateAddress;

        /// <summary>
        ///     <c>VertexBuffer</c> is a <c>VkStridedDeviceAddressNV</c> structure containing the vertex data for the indexed triangles stored in the cluster template. If the address in <c>VkStridedDeviceAddressNV</c> is `0` the vertex data is sourced from the cluster template.
        /// </summary>
        [FieldOffset(16)]
        public VkStridedDeviceAddressNV VertexBuffer;
    }

    public partial struct VkClusterAccelerationStructureInstantiateClusterInfoNV
    {
        /// <inheritdoc cref="_geometryIndexOffset"/>
        public int GeometryIndexOffset
        {
            get => BitFields.ExtractRange(_geometryIndexOffset, start: 0, length: 24);
            set => BitFields.SetRange(ref _geometryIndexOffset, start: 0, length: 24, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 24, length: 8);
            set => BitFields.SetRange(ref _reserved, start: 24, length: 8, value);
        }
    }
}
