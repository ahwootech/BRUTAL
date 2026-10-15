namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAttachmentSampleLocationsEXT.html">VkAttachmentSampleLocationsEXT</see> - Structure specifying the sample locations state to use in the initial layout transition of attachments
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkAttachmentSampleLocationsEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_sample_locations
    ///         typedef struct VkAttachmentSampleLocationsEXT {
    ///             uint32_t                    attachmentIndex;
    ///             VkSampleLocationsInfoEXT    sampleLocationsInfo;
    ///         } VkAttachmentSampleLocationsEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct VkAttachmentSampleLocationsEXT()
    {
        /// <summary>
        ///     <c>AttachmentIndex</c> is the index of the attachment for which the sample locations state is provided.
        /// </summary>
        [FieldOffset(0)]
        public int AttachmentIndex;

        /// <summary>
        ///     <c>SampleLocationsInfo</c> is the sample locations state to use for the layout transition of the given attachment from the initial layout of the attachment to the image layout specified for the attachment in the first subpass using it.
        /// </summary>
        [FieldOffset(8)]
        public VkSampleLocationsInfoEXT SampleLocationsInfo;
    }
}
