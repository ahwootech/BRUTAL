namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassSubpassFeedbackCreateInfoEXT.html">VkRenderPassSubpassFeedbackCreateInfoEXT</see> - Request for feedback about the creation of subpass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Feedback about the creation of a subpass <i>can</i> be obtained by including a
    ///         <c>VkRenderPassSubpassFeedbackCreateInfoEXT</c> structure in the <c>pNext</c>
    ///         chain of <c>VkSubpassDescription2</c>.
    ///         <c>VkRenderPassSubpassFeedbackCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_subpass_merge_feedback
    ///         typedef struct VkRenderPassSubpassFeedbackCreateInfoEXT {
    ///             VkStructureType                        sType;
    ///             const void*                            pNext;
    ///             VkRenderPassSubpassFeedbackInfoEXT*    pSubpassFeedback;
    ///         } VkRenderPassSubpassFeedbackCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkRenderPassSubpassFeedbackCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassSubpassFeedbackCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SubpassFeedback</c> is a pointer to a <c>VkRenderPassSubpassFeedbackInfoEXT</c> structure in which feedback is returned.
        /// </summary>
        [FieldOffset(16)]
        public VkRenderPassSubpassFeedbackInfoEXT* SubpassFeedback;
    }
}
