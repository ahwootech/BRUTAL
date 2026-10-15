namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerCaptureDescriptorDataInfoEXT.html">VkSamplerCaptureDescriptorDataInfoEXT</see> - Structure specifying a sampler for descriptor capture
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Information about the sampler to get descriptor buffer capture data for is
    ///         passed in a <c>VkSamplerCaptureDescriptorDataInfoEXT</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer
    ///         typedef struct VkSamplerCaptureDescriptorDataInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkSampler          sampler;
    ///         } VkSamplerCaptureDescriptorDataInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSamplerCaptureDescriptorDataInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SamplerCaptureDescriptorDataInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Sampler</c> is the <c>VkSampler</c> handle of the sampler to get opaque capture data for.
        /// </summary>
        [FieldOffset(16)]
        public VkSampler Sampler;
    }
}
