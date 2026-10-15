namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureTrianglesOpacityMicromapKHR.html">VkAccelerationStructureTrianglesOpacityMicromapKHR</see> - Structure specifying an opacity micromap in a bottom-level acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureTrianglesOpacityMicromapKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureTrianglesOpacityMicromapKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_opacity_micromap
    ///         typedef struct VkAccelerationStructureTrianglesOpacityMicromapKHR {
    ///             VkStructureType               sType;
    ///             void*                         pNext;
    ///             VkIndexType                   indexType;
    ///             VkDeviceAddress               indexBuffer;
    ///             VkDeviceSize                  indexStride;
    ///             uint32_t                      baseTriangle;
    ///             VkAccelerationStructureKHR    micromap;
    ///         } VkAccelerationStructureTrianglesOpacityMicromapKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkAccelerationStructureTrianglesOpacityMicromapKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureTrianglesOpacityMicromapKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>IndexType</c> is the type of triangle indices used when indexing this micromap
        /// </summary>
        [FieldOffset(16)]
        public VkIndexType IndexType;

        /// <summary>
        ///     <c>IndexBuffer</c> is the address containing the triangle indices
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceAddress IndexBuffer;

        /// <summary>
        ///     <c>IndexStride</c> is the byte stride between triangle indices
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 IndexStride;

        /// <summary>
        ///     <c>BaseTriangle</c> is the base value added to the non-negative triangle indices
        /// </summary>
        [FieldOffset(40)]
        public int BaseTriangle;

        /// <summary>
        ///     <c>Micromap</c> is the handle to the micromap object to include in this geometry
        /// </summary>
        [FieldOffset(48)]
        public VkAccelerationStructureKHR Micromap;
    }
}
