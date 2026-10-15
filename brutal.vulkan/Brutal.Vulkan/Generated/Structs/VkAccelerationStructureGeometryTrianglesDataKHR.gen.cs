namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryTrianglesDataKHR.html">VkAccelerationStructureGeometryTrianglesDataKHR</see> - Structure specifying a triangle geometry in a bottom-level acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureGeometryTrianglesDataKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureGeometryTrianglesDataKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkAccelerationStructureGeometryTrianglesDataKHR {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkFormat                         vertexFormat;
    ///             VkDeviceOrHostAddressConstKHR    vertexData;
    ///             VkDeviceSize                     vertexStride;
    ///             uint32_t                         maxVertex;
    ///             VkIndexType                      indexType;
    ///             VkDeviceOrHostAddressConstKHR    indexData;
    ///             VkDeviceOrHostAddressConstKHR    transformData;
    ///         } VkAccelerationStructureGeometryTrianglesDataKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkAccelerationStructureGeometryTrianglesDataKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureGeometryTrianglesDataKHR;

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
        ///     <c>VertexData</c> is a device or host address of memory containing vertex data for this geometry.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceOrHostAddressConstKHR VertexData;

        /// <summary>
        ///     <c>VertexStride</c> is the stride in bytes between each vertex.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 VertexStride;

        /// <summary>
        ///     <c>MaxVertex</c> is the number of vertices in <c>vertexData</c> minus one.
        /// </summary>
        [FieldOffset(40)]
        public int MaxVertex;

        /// <summary>
        ///     <c>IndexType</c> is the <c>VkIndexType</c> of each index element.
        /// </summary>
        [FieldOffset(44)]
        public VkIndexType IndexType;

        /// <summary>
        ///     <c>IndexData</c> is a device or host address of memory containing index data for this geometry. When <c>indexType</c> is <c>VK_INDEX_TYPE_NONE_KHR</c> it <i>must</i> be `NULL`.
        /// </summary>
        [FieldOffset(48)]
        public VkDeviceOrHostAddressConstKHR IndexData;

        /// <summary>
        ///     <c>TransformData</c> is a device or host address to memory containing an optional reference to a <c>VkTransformMatrixKHR</c> structure describing a transformation from the space in which the vertices in this geometry are described to the space in which the acceleration structure is defined.
        /// </summary>
        [FieldOffset(56)]
        public VkDeviceOrHostAddressConstKHR TransformData;
    }
}
