namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTransformFeedbackPropertiesEXT.html">VkPhysicalDeviceTransformFeedbackPropertiesEXT</see> - Structure describing transform feedback properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTransformFeedbackPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_transform_feedback
    ///         typedef struct VkPhysicalDeviceTransformFeedbackPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxTransformFeedbackStreams;
    ///             uint32_t           maxTransformFeedbackBuffers;
    ///             VkDeviceSize       maxTransformFeedbackBufferSize;
    ///             uint32_t           maxTransformFeedbackStreamDataSize;
    ///             uint32_t           maxTransformFeedbackBufferDataSize;
    ///             uint32_t           maxTransformFeedbackBufferDataStride;
    ///             VkBool32           transformFeedbackQueries;
    ///             VkBool32           transformFeedbackStreamsLinesTriangles;
    ///             VkBool32           transformFeedbackRasterizationStreamSelect;
    ///             VkBool32           transformFeedbackDraw;
    ///         } VkPhysicalDeviceTransformFeedbackPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkPhysicalDeviceTransformFeedbackPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTransformFeedbackPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxTransformFeedbackStreams</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxTransformFeedbackStreams;

        /// <summary>
        ///     <c>MaxTransformFeedbackBuffers</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxTransformFeedbackBuffers;

        /// <summary>
        ///     <c>MaxTransformFeedbackBufferSize</c>
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 MaxTransformFeedbackBufferSize;

        /// <summary>
        ///     <c>MaxTransformFeedbackStreamDataSize</c>
        /// </summary>
        [FieldOffset(32)]
        public int MaxTransformFeedbackStreamDataSize;

        /// <summary>
        ///     <c>MaxTransformFeedbackBufferDataSize</c>
        /// </summary>
        [FieldOffset(36)]
        public int MaxTransformFeedbackBufferDataSize;

        /// <summary>
        ///     <c>MaxTransformFeedbackBufferDataStride</c>
        /// </summary>
        [FieldOffset(40)]
        public int MaxTransformFeedbackBufferDataStride;

        /// <summary>
        ///     <c>TransformFeedbackQueries</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 TransformFeedbackQueries;

        /// <summary>
        ///     <c>TransformFeedbackStreamsLinesTriangles</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 TransformFeedbackStreamsLinesTriangles;

        /// <summary>
        ///     <c>TransformFeedbackRasterizationStreamSelect</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 TransformFeedbackRasterizationStreamSelect;

        /// <summary>
        ///     <c>TransformFeedbackDraw</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 TransformFeedbackDraw;
    }
}
