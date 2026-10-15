namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFragmentShadingRateAttachmentInfoKHR.html">VkFragmentShadingRateAttachmentInfoKHR</see> - Structure specifying a fragment shading rate attachment for a subpass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFragmentShadingRateAttachmentInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_fragment_shading_rate
    ///         typedef struct VkFragmentShadingRateAttachmentInfoKHR {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             const VkAttachmentReference2*    pFragmentShadingRateAttachment;
    ///             VkExtent2D                       shadingRateAttachmentTexelSize;
    ///         } VkFragmentShadingRateAttachmentInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkFragmentShadingRateAttachmentInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FragmentShadingRateAttachmentInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FragmentShadingRateAttachment</c> is `NULL` or a pointer to a <c>VkAttachmentReference2</c> structure defining the fragment shading rate attachment for this subpass.
        /// </summary>
        [FieldOffset(16)]
        public VkAttachmentReference2* FragmentShadingRateAttachment;

        /// <summary>
        ///     <c>ShadingRateAttachmentTexelSize</c> specifies the size of the portion of the framebuffer corresponding to each texel in <c>pFragmentShadingRateAttachment</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkExtent2D ShadingRateAttachmentTexelSize;
    }
}
