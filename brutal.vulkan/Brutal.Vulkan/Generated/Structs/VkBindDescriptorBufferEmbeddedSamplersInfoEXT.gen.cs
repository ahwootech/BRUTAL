namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindDescriptorBufferEmbeddedSamplersInfoEXT.html">VkBindDescriptorBufferEmbeddedSamplersInfoEXT</see> - Structure specifying embedded immutable sampler offsets to set in a command buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBindDescriptorBufferEmbeddedSamplersInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkBindDescriptorBufferEmbeddedSamplersInfoEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance6 with VK_EXT_descriptor_buffer
    ///         typedef struct VkBindDescriptorBufferEmbeddedSamplersInfoEXT {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             VkShaderStageFlags    stageFlags;
    ///             VkPipelineLayout      layout;
    ///             uint32_t              set;
    ///         } VkBindDescriptorBufferEmbeddedSamplersInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkBindDescriptorBufferEmbeddedSamplersInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindDescriptorBufferEmbeddedSamplersInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StageFlags</c> is a bitmask of <c>VkShaderStageFlags</c> specifying the shader stages that will use the embedded immutable samplers.
        /// </summary>
        [FieldOffset(16)]
        public VkShaderStageFlags StageFlags;

        /// <summary>
        ///     <c>Layout</c> is a <c>VkPipelineLayout</c> object used to program the bindings.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineLayout Layout;

        /// <summary>
        ///     <c>Set</c> is the number of the set to be bound.
        /// </summary>
        [FieldOffset(32)]
        public int Set;
    }
}
