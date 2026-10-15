namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreationFeedbackCreateInfoEXT.html">VkRenderPassCreationFeedbackCreateInfoEXT</see> - Request feedback about the creation of render pass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To obtain feedback about the creation of a render pass, include a
    ///         <c>VkRenderPassCreationFeedbackCreateInfoEXT</c> structure in the <c>pNext</c>
    ///         chain of <c>VkRenderPassCreateInfo2</c>.
    ///         The <c>VkRenderPassCreationFeedbackCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_subpass_merge_feedback
    ///         typedef struct VkRenderPassCreationFeedbackCreateInfoEXT {
    ///             VkStructureType                         sType;
    ///             const void*                             pNext;
    ///             VkRenderPassCreationFeedbackInfoEXT*    pRenderPassFeedback;
    ///         } VkRenderPassCreationFeedbackCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkRenderPassCreationFeedbackCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassCreationFeedbackCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RenderPassFeedback</c> is a pointer to a <c>VkRenderPassCreationFeedbackInfoEXT</c> structure in which feedback is returned.
        /// </summary>
        [FieldOffset(16)]
        public VkRenderPassCreationFeedbackInfoEXT* RenderPassFeedback;
    }
}
