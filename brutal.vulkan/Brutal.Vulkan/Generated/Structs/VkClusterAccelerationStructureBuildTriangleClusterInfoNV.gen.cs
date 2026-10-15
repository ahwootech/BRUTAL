namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureBuildTriangleClusterInfoNV.html">VkClusterAccelerationStructureBuildTriangleClusterInfoNV</see> - Parameters describing build operation for a cluster acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkClusterAccelerationStructureBuildTriangleClusterInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkClusterAccelerationStructureBuildTriangleClusterInfoNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkClusterAccelerationStructureBuildTriangleClusterInfoNV {
    ///             uint32_t                                                         clusterID;
    ///             VkClusterAccelerationStructureClusterFlagsNV                     clusterFlags;
    ///             uint32_t                                                         triangleCount:9;
    ///             uint32_t                                                         vertexCount:9;
    ///             uint32_t                                                         positionTruncateBitCount:6;
    ///             uint32_t                                                         indexType:4;
    ///             uint32_t                                                         opacityMicromapIndexType:4;
    ///             VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV    baseGeometryIndexAndGeometryFlags;
    ///             uint16_t                                                         indexBufferStride;
    ///             uint16_t                                                         vertexBufferStride;
    ///             uint16_t                                                         geometryIndexAndFlagsBufferStride;
    ///             uint16_t                                                         opacityMicromapIndexBufferStride;
    ///             VkDeviceAddress                                                  indexBuffer;
    ///             VkDeviceAddress                                                  vertexBuffer;
    ///             VkDeviceAddress                                                  geometryIndexAndFlagsBuffer;
    ///             VkDeviceAddress                                                  opacityMicromapArray;
    ///             VkDeviceAddress                                                  opacityMicromapIndexBuffer;
    ///         } VkClusterAccelerationStructureBuildTriangleClusterInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct VkClusterAccelerationStructureBuildTriangleClusterInfoNV()
    {
        /// <summary>
        ///     <c>ClusterID</c> is a user specified identifier assigned to this cluster.
        /// </summary>
        [FieldOffset(0)]
        public int ClusterID;

        /// <summary>
        ///     <c>ClusterFlags</c> is a bitmask of <c>VkClusterAccelerationStructureClusterFlagsNV</c> values describing flags how the cluster should be built.
        /// </summary>
        [FieldOffset(4)]
        public VkClusterAccelerationStructureClusterFlagsNV ClusterFlags;

        /// <summary>
        ///     <c>TriangleCount</c> is the number of triangles in this cluster.
        /// </summary>
        [FieldOffset(8)]
        private int _triangleCount;

        /// <summary>
        ///     <c>VertexCount</c> is the number of unique vertices in this cluster.
        /// </summary>
        [FieldOffset(8)]
        private int _vertexCount;

        /// <summary>
        ///     <c>PositionTruncateBitCount</c> is the number of bits starting at the lowest bit (i.e. the LSBs of the mantissa), of each vertex position that will be truncated to zero to improve floating-point compression.
        /// </summary>
        [FieldOffset(8)]
        private int _positionTruncateBitCount;

        /// <summary>
        ///     <c>IndexType</c> is a single <c>VkClusterAccelerationStructureIndexFormatFlagsNV</c> value specifying the index type in <c>indexBuffer</c>.
        /// </summary>
        [FieldOffset(8)]
        private int _indexType;

        /// <summary>
        ///     <c>OpacityMicromapIndexType</c> is a single <c>VkClusterAccelerationStructureIndexFormatFlagsNV</c> value specifying the index type in <c>opacityMicromapIndexBuffer</c>.
        /// </summary>
        [FieldOffset(8)]
        private int _opacityMicromapIndexType;

        /// <summary>
        ///     <c>BaseGeometryIndexAndGeometryFlags</c> is a <c>VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV</c> value specifying the base geometry index and flags for all triangles in the cluster.
        /// </summary>
        [FieldOffset(12)]
        public VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV BaseGeometryIndexAndGeometryFlags;

        /// <summary>
        ///     <c>IndexBufferStride</c> is the stride in bytes in <c>indexBuffer</c> with `0` meaning the values are tightly-packed.
        /// </summary>
        [FieldOffset(16)]
        public ushort IndexBufferStride;

        /// <summary>
        ///     <c>VertexBufferStride</c> is the stride in bytes in <c>vertexBuffer</c> with `0` meaning the values are tightly-packed.
        /// </summary>
        [FieldOffset(18)]
        public ushort VertexBufferStride;

        /// <summary>
        ///     <c>GeometryIndexAndFlagsBufferStride</c> is the stride in bytes in <c>geometryIndexAndFlagsBuffer</c> with `0` meaning the values are tightly-packed.
        /// </summary>
        [FieldOffset(20)]
        public ushort GeometryIndexAndFlagsBufferStride;

        /// <summary>
        ///     <c>OpacityMicromapIndexBufferStride</c> is the stride in bytes in <c>opacityMicromapIndexBuffer</c> with `0` meaning the values are tightly-packed.
        /// </summary>
        [FieldOffset(22)]
        public ushort OpacityMicromapIndexBufferStride;

        /// <summary>
        ///     <c>IndexBuffer</c> is a device address containing the indices of the vertices in the cluster and are of type <c>indexType</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceAddress IndexBuffer;

        /// <summary>
        ///     <c>VertexBuffer</c> is a device address containing the vertex data of the triangles in the cluster with format specified in <c>VkClusterAccelerationStructureTriangleClusterInputNV::vertexFormat</c>.
        /// </summary>
        [FieldOffset(32)]
        public VkDeviceAddress VertexBuffer;

        /// <summary>
        ///     <c>GeometryIndexAndFlagsBuffer</c>
        /// </summary>
        [FieldOffset(40)]
        public VkDeviceAddress GeometryIndexAndFlagsBuffer;

        /// <summary>
        ///     <c>OpacityMicromapArray</c> is either `0` or specifies the address of a valid opacity micromap array to reference from the cluster acceleration structure. If it is `0`, then opacity micromaps will be disabled for this cluster acceleration structure.
        /// </summary>
        [FieldOffset(48)]
        public VkDeviceAddress OpacityMicromapArray;

        /// <summary>
        ///     <c>OpacityMicromapIndexBuffer</c> is either `0` or specifies the address of a strided array with size equal to the number of triangles or indices into the opacity micromap array. If <c>opacityMicromapIndexBuffer</c> is `0` then the index used is the index of the triangle in the geometry.
        /// </summary>
        [FieldOffset(56)]
        public VkDeviceAddress OpacityMicromapIndexBuffer;
    }

    public partial struct VkClusterAccelerationStructureBuildTriangleClusterInfoNV
    {
        /// <inheritdoc cref="_triangleCount"/>
        public int TriangleCount
        {
            get => BitFields.ExtractRange(_triangleCount, start: 0, length: 9);
            set => BitFields.SetRange(ref _triangleCount, start: 0, length: 9, value);
        }

        /// <inheritdoc cref="_vertexCount"/>
        public int VertexCount
        {
            get => BitFields.ExtractRange(_vertexCount, start: 9, length: 9);
            set => BitFields.SetRange(ref _vertexCount, start: 9, length: 9, value);
        }

        /// <inheritdoc cref="_positionTruncateBitCount"/>
        public int PositionTruncateBitCount
        {
            get => BitFields.ExtractRange(_positionTruncateBitCount, start: 18, length: 6);
            set => BitFields.SetRange(ref _positionTruncateBitCount, start: 18, length: 6, value);
        }

        /// <inheritdoc cref="_indexType"/>
        public int IndexType
        {
            get => BitFields.ExtractRange(_indexType, start: 24, length: 4);
            set => BitFields.SetRange(ref _indexType, start: 24, length: 4, value);
        }

        /// <inheritdoc cref="_opacityMicromapIndexType"/>
        public int OpacityMicromapIndexType
        {
            get => BitFields.ExtractRange(_opacityMicromapIndexType, start: 28, length: 4);
            set => BitFields.SetRange(ref _opacityMicromapIndexType, start: 28, length: 4, value);
        }
    }
}
