namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMultisampledRenderToSingleSampledInfoEXT.html">VkMultisampledRenderToSingleSampledInfoEXT</see> - Structure containing info for multisampled rendering to single-sampled attachments in a subpass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkSubpassDescription2</c>
    ///         includes a <c>VkMultisampledRenderToSingleSampledInfoEXT</c> structure, then
    ///         that structure describes how multisampled rendering is performed on single
    ///         sampled attachments in that subpass.
    ///     </para>
    ///     <para>
    ///         The <c>VkMultisampledRenderToSingleSampledInfoEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_multisampled_render_to_single_sampled
    ///         typedef struct VkMultisampledRenderToSingleSampledInfoEXT {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkBool32                 multisampledRenderToSingleSampledEnable;
    ///             VkSampleCountFlagBits    rasterizationSamples;
    ///         } VkMultisampledRenderToSingleSampledInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkMultisampledRenderToSingleSampledInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MultisampledRenderToSingleSampledInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MultisampledRenderToSingleSampledEnable</c> controls whether multisampled rendering to single-sampled attachments is performed as described <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#multisampled-render-to-single-sampled">below^</see>.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 MultisampledRenderToSingleSampledEnable;

        /// <summary>
        ///     <c>RasterizationSamples</c> is a <c>VkSampleCountFlags</c> specifying the number of samples used in rasterization.
        /// </summary>
        [FieldOffset(20)]
        public VkSampleCountFlags RasterizationSamples;
    }
}
