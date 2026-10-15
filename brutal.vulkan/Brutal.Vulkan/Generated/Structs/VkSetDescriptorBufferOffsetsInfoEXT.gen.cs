namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSetDescriptorBufferOffsetsInfoEXT.html">VkSetDescriptorBufferOffsetsInfoEXT</see> - Structure specifying descriptor buffer offsets to set in a command buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkSetDescriptorBufferOffsetsInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkSetDescriptorBufferOffsetsInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance6 with VK_EXT_descriptor_buffer
    ///         typedef struct VkSetDescriptorBufferOffsetsInfoEXT {
    ///             VkStructureType        sType;
    ///             const void*            pNext;
    ///             VkShaderStageFlags     stageFlags;
    ///             VkPipelineLayout       layout;
    ///             uint32_t               firstSet;
    ///             uint32_t               setCount;
    ///             const uint32_t*        pBufferIndices;
    ///             const VkDeviceSize*    pOffsets;
    ///         } VkSetDescriptorBufferOffsetsInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkSetDescriptorBufferOffsetsInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SetDescriptorBufferOffsetsInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StageFlags</c> is a bitmask of <c>VkShaderStageFlags</c> specifying the shader stages the descriptor sets will be bound to
        /// </summary>
        [FieldOffset(16)]
        public VkShaderStageFlags StageFlags;

        /// <summary>
        ///     <c>Layout</c> is a <c>VkPipelineLayout</c> object used to program the bindings.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineLayout Layout;

        /// <summary>
        ///     <c>FirstSet</c> is the number of the first set to be bound.
        /// </summary>
        [FieldOffset(32)]
        public int FirstSet;

        /// <summary>
        ///     <c>SetCount</c> is the number of elements in the <c>pBufferIndices</c> and <c>pOffsets</c> arrays.
        /// </summary>
        [FieldOffset(36)]
        public int SetCount;

        /// <summary>
        ///     <c>BufferIndices</c> is a pointer to an array of indices into the descriptor buffer binding points set by <c>vkCmdBindDescriptorBuffersEXT</c>.
        /// </summary>
        [FieldOffset(40)]
        public int* BufferIndices;

        /// <summary>
        ///     <c>Offsets</c> is a pointer to an array of basetype:VkDeviceSize offsets to apply to the bound descriptor buffers.
        /// </summary>
        [FieldOffset(48)]
        public ByteSize64* Offsets;
    }
}
