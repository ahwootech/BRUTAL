namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassSubpassFeedbackInfoEXT.html">VkRenderPassSubpassFeedbackInfoEXT</see> - Feedback about the creation of subpass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderPassSubpassFeedbackInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_subpass_merge_feedback
    ///         typedef struct VkRenderPassSubpassFeedbackInfoEXT {
    ///             VkSubpassMergeStatusEXT    subpassMergeStatus;
    ///             char                       description[VK_MAX_DESCRIPTION_SIZE];
    ///             uint32_t                   postMergeIndex;
    ///         } VkRenderPassSubpassFeedbackInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 264)]
    public unsafe partial struct VkRenderPassSubpassFeedbackInfoEXT()
    {
        /// <summary>
        ///     <c>SubpassMergeStatus</c> is a <c>VkSubpassMergeStatusEXT</c> value specifying information about whether the subpass is merged with the previous subpass and the reason why it is not merged.
        /// </summary>
        [FieldOffset(0)]
        public VkSubpassMergeStatusEXT SubpassMergeStatus;

        ///
        [FieldOffset(4)]
        public fixed byte Description[256];

        /// <summary>
        ///     <c>PostMergeIndex</c> is the subpass index after the subpass merging.
        /// </summary>
        [FieldOffset(260)]
        public int PostMergeIndex;
    }
}
