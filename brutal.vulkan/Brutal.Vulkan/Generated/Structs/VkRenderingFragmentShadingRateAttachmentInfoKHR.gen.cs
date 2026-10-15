namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderingFragmentShadingRateAttachmentInfoKHR.html">VkRenderingFragmentShadingRateAttachmentInfoKHR</see> - Structure specifying fragment shading rate attachment information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderingFragmentShadingRateAttachmentInfoKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_fragment_shading_rate with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///         typedef struct VkRenderingFragmentShadingRateAttachmentInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkImageView        imageView;
    ///             VkImageLayout      imageLayout;
    ///             VkExtent2D         shadingRateAttachmentTexelSize;
    ///         } VkRenderingFragmentShadingRateAttachmentInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkRenderingFragmentShadingRateAttachmentInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderingFragmentShadingRateAttachmentInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageView</c> is the image view that will be used as a fragment shading rate attachment.
        /// </summary>
        [FieldOffset(16)]
        public VkImageView ImageView;

        /// <summary>
        ///     <c>ImageLayout</c> is the layout that <c>imageView</c> will be in during rendering.
        /// </summary>
        [FieldOffset(24)]
        public VkImageLayout ImageLayout;

        /// <summary>
        ///     <c>ShadingRateAttachmentTexelSize</c> specifies the number of pixels corresponding to each texel in <c>imageView</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkExtent2D ShadingRateAttachmentTexelSize;
    }
}
