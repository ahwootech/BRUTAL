namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubpassSampleLocationsEXT.html">VkSubpassSampleLocationsEXT</see> - Structure specifying the sample locations state to use for layout transitions of attachments performed after a given subpass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSubpassSampleLocationsEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_sample_locations
    ///         typedef struct VkSubpassSampleLocationsEXT {
    ///             uint32_t                    subpassIndex;
    ///             VkSampleLocationsInfoEXT    sampleLocationsInfo;
    ///         } VkSubpassSampleLocationsEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct VkSubpassSampleLocationsEXT()
    {
        /// <summary>
        ///     <c>SubpassIndex</c> is the index of the subpass for which the sample locations state is provided.
        /// </summary>
        [FieldOffset(0)]
        public int SubpassIndex;

        /// <summary>
        ///     <c>SampleLocationsInfo</c> is the sample locations state to use for the layout transition of the depth/stencil attachment away from the image layout the attachment is used with in the subpass specified in <c>subpassIndex</c>.
        /// </summary>
        [FieldOffset(8)]
        public VkSampleLocationsInfoEXT SampleLocationsInfo;
    }
}
