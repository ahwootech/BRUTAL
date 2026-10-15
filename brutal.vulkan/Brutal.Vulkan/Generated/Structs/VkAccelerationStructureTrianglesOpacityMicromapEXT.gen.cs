namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureTrianglesOpacityMicromapEXT.html">VkAccelerationStructureTrianglesOpacityMicromapEXT</see> - Structure specifying an opacity micromap in a bottom-level acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureTrianglesOpacityMicromapEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureTrianglesOpacityMicromapEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef struct VkAccelerationStructureTrianglesOpacityMicromapEXT {
    ///             VkStructureType                     sType;
    ///             void*                               pNext;
    ///             VkIndexType                         indexType;
    ///             VkDeviceOrHostAddressConstKHR       indexBuffer;
    ///             VkDeviceSize                        indexStride;
    ///             uint32_t                            baseTriangle;
    ///             uint32_t                            usageCountsCount;
    ///             const VkMicromapUsageEXT*           pUsageCounts;
    ///             const VkMicromapUsageEXT* const*    ppUsageCounts;
    ///             VkMicromapEXT                       micromap;
    ///         } VkAccelerationStructureTrianglesOpacityMicromapEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkAccelerationStructureTrianglesOpacityMicromapEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureTrianglesOpacityMicromapEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>IndexType</c> is the type of triangle indices used when indexing this micromap.
        /// </summary>
        [FieldOffset(16)]
        public VkIndexType IndexType;

        /// <summary>
        ///     <c>IndexBuffer</c> is a device or host address of memory containing the triangle indices. When <c>indexType</c> is <c>VK_INDEX_TYPE_NONE_KHR</c> it <i>must</i> be `NULL`.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceOrHostAddressConstKHR IndexBuffer;

        /// <summary>
        ///     <c>IndexStride</c> is the byte stride between triangle indices.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 IndexStride;

        /// <summary>
        ///     <c>BaseTriangle</c> is the base value added to the non-negative triangle indices.
        /// </summary>
        [FieldOffset(40)]
        public int BaseTriangle;

        /// <summary>
        ///     <c>UsageCountsCount</c> specifies the number of usage counts structures that will be used to determine the size of this micromap.
        /// </summary>
        [FieldOffset(44)]
        public int UsageCountsCount;

        /// <summary>
        ///     <c>UsageCounts</c> is a pointer to an array of <c>VkMicromapUsageEXT</c> structures.
        /// </summary>
        [FieldOffset(48)]
        public VkMicromapUsageEXT* UsageCounts;

        /// <summary>
        ///     <c>ppUsageCounts</c> is a pointer to an array of pointers to <c>VkMicromapUsageEXT</c> structures.
        /// </summary>
        [FieldOffset(56)]
        public VkMicromapUsageEXT** ppUsageCounts;

        /// <summary>
        ///     <c>Micromap</c> is the handle to the micromap object to include in this geometry.
        /// </summary>
        [FieldOffset(64)]
        public VkMicromapEXT Micromap;
    }
}
