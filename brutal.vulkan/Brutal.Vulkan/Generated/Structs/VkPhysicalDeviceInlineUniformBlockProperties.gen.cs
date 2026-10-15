namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceInlineUniformBlockProperties.html">VkPhysicalDeviceInlineUniformBlockProperties</see> - Structure describing inline uniform block properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceInlineUniformBlockProperties</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceInlineUniformBlockProperties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxInlineUniformBlockSize;
    ///             uint32_t           maxPerStageDescriptorInlineUniformBlocks;
    ///             uint32_t           maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
    ///             uint32_t           maxDescriptorSetInlineUniformBlocks;
    ///             uint32_t           maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    ///         } VkPhysicalDeviceInlineUniformBlockProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceInlineUniformBlockProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceInlineUniformBlockProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxInlineUniformBlockSize</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxInlineUniformBlockSize;

        /// <summary>
        ///     <c>MaxPerStageDescriptorInlineUniformBlocks</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxPerStageDescriptorInlineUniformBlocks;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks</c>
        /// </summary>
        [FieldOffset(24)]
        public int MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;

        /// <summary>
        ///     <c>MaxDescriptorSetInlineUniformBlocks</c>
        /// </summary>
        [FieldOffset(28)]
        public int MaxDescriptorSetInlineUniformBlocks;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindInlineUniformBlocks</c>
        /// </summary>
        [FieldOffset(32)]
        public int MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    }
}
