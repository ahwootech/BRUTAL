namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceInlineUniformBlockFeatures.html">VkPhysicalDeviceInlineUniformBlockFeatures</see> - Structure describing inline uniform block features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceInlineUniformBlockFeatures</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceInlineUniformBlockFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           inlineUniformBlock;
    ///             VkBool32           descriptorBindingInlineUniformBlockUpdateAfterBind;
    ///         } VkPhysicalDeviceInlineUniformBlockFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceInlineUniformBlockFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceInlineUniformBlockFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>InlineUniformBlock</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 InlineUniformBlock;

        /// <summary>
        ///     <c>DescriptorBindingInlineUniformBlockUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DescriptorBindingInlineUniformBlockUpdateAfterBind;
    }
}
