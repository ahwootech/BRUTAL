namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryMotionTrianglesDataNV.html">VkAccelerationStructureGeometryMotionTrianglesDataNV</see> - Structure specifying vertex motion in a bottom-level acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureGeometryMotionTrianglesDataNV
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureGeometryMotionTrianglesDataNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_motion_blur
    ///         typedef struct VkAccelerationStructureGeometryMotionTrianglesDataNV {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkDeviceOrHostAddressConstKHR    vertexData;
    ///         } VkAccelerationStructureGeometryMotionTrianglesDataNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkAccelerationStructureGeometryMotionTrianglesDataNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureGeometryMotionTrianglesDataNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VertexData</c> is a pointer to vertex data for this geometry at time 1.0
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceOrHostAddressConstKHR VertexData;
    }
}
