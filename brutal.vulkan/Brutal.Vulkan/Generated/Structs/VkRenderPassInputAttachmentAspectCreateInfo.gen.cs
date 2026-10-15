namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassInputAttachmentAspectCreateInfo.html">VkRenderPassInputAttachmentAspectCreateInfo</see> - Structure specifying, for a given subpass/input attachment pair, which aspect &lt;i&gt;can&lt;/i&gt; be read.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderPassInputAttachmentAspectCreateInfo</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkRenderPassInputAttachmentAspectCreateInfo {
    ///             VkStructureType                            sType;
    ///             const void*                                pNext;
    ///             uint32_t                                   aspectReferenceCount;
    ///             const VkInputAttachmentAspectReference*    pAspectReferences;
    ///         } VkRenderPassInputAttachmentAspectCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkRenderPassInputAttachmentAspectCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassInputAttachmentAspectCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AspectReferenceCount</c> is the number of elements in the <c>pAspectReferences</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int AspectReferenceCount;

        /// <summary>
        ///     <c>AspectReferences</c> is a pointer to an array of <c>aspectReferenceCount</c> <c>VkInputAttachmentAspectReference</c> structures containing a mask describing which aspect(s) <i>can</i> be accessed for a given input attachment within a given subpass.
        /// </summary>
        [FieldOffset(24)]
        public VkInputAttachmentAspectReference* AspectReferences;
    }
}
