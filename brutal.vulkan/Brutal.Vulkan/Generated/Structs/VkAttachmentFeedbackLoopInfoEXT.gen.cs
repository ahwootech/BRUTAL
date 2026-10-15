namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAttachmentFeedbackLoopInfoEXT.html">VkAttachmentFeedbackLoopInfoEXT</see> - Structure specifying whether feedback loop is enabled for an attachment
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-feedbackloop">enable feedback loop^</see> for an attachment, the
    ///         <c>VkAttachmentFeedbackLoopInfoEXT</c> structure <i>can</i> be added to the
    ///         <c>pNext</c> chain of <c>VkRenderingAttachmentInfo</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkAttachmentFeedbackLoopInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_unified_image_layouts with VK_EXT_attachment_feedback_loop_layout and (VK_VERSION_1_3 or VK_KHR_dynamic_rendering)
    ///         typedef struct VkAttachmentFeedbackLoopInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           feedbackLoopEnable;
    ///         } VkAttachmentFeedbackLoopInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkAttachmentFeedbackLoopInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AttachmentFeedbackLoopInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FeedbackLoopEnable</c> specifies that <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-feedbackloop">feedback loop is enabled^</see> for the attachment identified by <c>VkRenderingAttachmentInfo::imageView</c>.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 FeedbackLoopEnable;
    }
}
