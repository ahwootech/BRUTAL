namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkInputAttachmentAspectReference.html">VkInputAttachmentAspectReference</see> - Structure specifying a subpass/input attachment pair and an aspect mask that &lt;i&gt;can&lt;/i&gt; be read.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkInputAttachmentAspectReference</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkInputAttachmentAspectReference {
    ///             uint32_t              subpass;
    ///             uint32_t              inputAttachmentIndex;
    ///             VkImageAspectFlags    aspectMask;
    ///         } VkInputAttachmentAspectReference;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkInputAttachmentAspectReference()
    {
        /// <summary>
        ///     <c>Subpass</c> is an index into the <c>pSubpasses</c> array of the parent <c>VkRenderPassCreateInfo</c> structure.
        /// </summary>
        [FieldOffset(0)]
        public int Subpass;

        /// <summary>
        ///     <c>InputAttachmentIndex</c> is an index into the <c>pInputAttachments</c> of the specified subpass.
        /// </summary>
        [FieldOffset(4)]
        public int InputAttachmentIndex;

        /// <summary>
        ///     <c>AspectMask</c> is a mask of which aspect(s) <i>can</i> be accessed within the specified subpass.
        /// </summary>
        [FieldOffset(8)]
        public VkImageAspectFlags AspectMask;
    }
}
