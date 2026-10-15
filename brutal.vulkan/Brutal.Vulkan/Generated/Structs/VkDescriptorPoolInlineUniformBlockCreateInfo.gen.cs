namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolInlineUniformBlockCreateInfo.html">VkDescriptorPoolInlineUniformBlockCreateInfo</see> - Structure specifying the maximum number of inline uniform block bindings of a newly created descriptor pool
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         In order to be able to allocate descriptor sets having
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-inlineuniformblock">inline uniform block^</see> bindings the
    ///         descriptor pool <i>must</i> be created with specifying the inline uniform block
    ///         binding capacity of the descriptor pool, in addition to the total inline
    ///         uniform data capacity in bytes which is specified through a
    ///         <c>VkDescriptorPoolSize</c> structure with a <c>descriptorType</c> value of
    ///         <c>VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK</c>.
    ///         This <i>can</i> be done by adding a
    ///         <c>VkDescriptorPoolInlineUniformBlockCreateInfo</c> structure to the
    ///         <c>pNext</c> chain of <c>VkDescriptorPoolCreateInfo</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkDescriptorPoolInlineUniformBlockCreateInfo</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkDescriptorPoolInlineUniformBlockCreateInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           maxInlineUniformBlockBindings;
    ///         } VkDescriptorPoolInlineUniformBlockCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDescriptorPoolInlineUniformBlockCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorPoolInlineUniformBlockCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxInlineUniformBlockBindings</c> is the number of inline uniform block bindings to allocate.
        /// </summary>
        [FieldOffset(16)]
        public int MaxInlineUniformBlockBindings;
    }
}
