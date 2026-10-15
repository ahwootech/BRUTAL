namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGeometryTrianglesNV.html">VkGeometryTrianglesNV</see> - Structure specifying a triangle geometry in a bottom-level acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkGeometryTrianglesNV
    ///     </para>
    ///     <para>
    ///         The <c>VkGeometryTrianglesNV</c> structure specifies triangle geometry in a
    ///         bottom-level acceleration structure and is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         typedef struct VkGeometryTrianglesNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBuffer           vertexData;
    ///             VkDeviceSize       vertexOffset;
    ///             uint32_t           vertexCount;
    ///             VkDeviceSize       vertexStride;
    ///             VkFormat           vertexFormat;
    ///             VkBuffer           indexData;
    ///             VkDeviceSize       indexOffset;
    ///             uint32_t           indexCount;
    ///             VkIndexType        indexType;
    ///             VkBuffer           transformData;
    ///             VkDeviceSize       transformOffset;
    ///         } VkGeometryTrianglesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkGeometryTrianglesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GeometryTrianglesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VertexData</c> is the buffer containing vertex data for this geometry.
        /// </summary>
        [FieldOffset(16)]
        public VkBuffer VertexData;

        /// <summary>
        ///     <c>VertexOffset</c> is the offset in bytes within <c>vertexData</c> containing vertex data for this geometry.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 VertexOffset;

        /// <summary>
        ///     <c>VertexCount</c> is the number of valid vertices.
        /// </summary>
        [FieldOffset(32)]
        public int VertexCount;

        /// <summary>
        ///     <c>VertexStride</c> is the stride in bytes between each vertex.
        /// </summary>
        [FieldOffset(40)]
        public ByteSize64 VertexStride;

        /// <summary>
        ///     <c>VertexFormat</c> is a <c>VkFormat</c> describing the format of each vertex element.
        /// </summary>
        [FieldOffset(48)]
        public VkFormat VertexFormat;

        /// <summary>
        ///     <c>IndexData</c> is the buffer containing index data for this geometry.
        /// </summary>
        [FieldOffset(56)]
        public VkBuffer IndexData;

        /// <summary>
        ///     <c>IndexOffset</c> is the offset in bytes within <c>indexData</c> containing index data for this geometry.
        /// </summary>
        [FieldOffset(64)]
        public ByteSize64 IndexOffset;

        /// <summary>
        ///     <c>IndexCount</c> is the number of indices to include in this geometry.
        /// </summary>
        [FieldOffset(72)]
        public int IndexCount;

        /// <summary>
        ///     <c>IndexType</c> is a <c>VkIndexType</c> describing the format of each index.
        /// </summary>
        [FieldOffset(76)]
        public VkIndexType IndexType;

        /// <summary>
        ///     <c>TransformData</c> is an optional buffer containing an <c>VkTransformMatrixNV</c> structure defining a transformation to be applied to this geometry.
        /// </summary>
        [FieldOffset(80)]
        public VkBuffer TransformData;

        /// <summary>
        ///     <c>TransformOffset</c> is the offset in bytes in <c>transformData</c> of the transform information described above.
        /// </summary>
        [FieldOffset(88)]
        public ByteSize64 TransformOffset;
    }
}
