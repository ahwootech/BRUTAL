namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreationFeedbackInfoEXT.html">VkRenderPassCreationFeedbackInfoEXT</see> - Feedback about the creation of a render pass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderPassCreationFeedbackInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_subpass_merge_feedback
    ///         typedef struct VkRenderPassCreationFeedbackInfoEXT {
    ///             uint32_t    postMergeSubpassCount;
    ///         } VkRenderPassCreationFeedbackInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct VkRenderPassCreationFeedbackInfoEXT()
    {
        /// <summary>
        ///     <c>PostMergeSubpassCount</c> is the subpass count after merge.
        /// </summary>
        [FieldOffset(0)]
        public int PostMergeSubpassCount;
    }
}
