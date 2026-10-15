namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageViewCaptureDescriptorDataInfoEXT.html">VkImageViewCaptureDescriptorDataInfoEXT</see> - Structure specifying an image view for descriptor capture
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Information about the image view to get descriptor buffer capture data for
    ///         is passed in a <c>VkImageViewCaptureDescriptorDataInfoEXT</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer
    ///         typedef struct VkImageViewCaptureDescriptorDataInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkImageView        imageView;
    ///         } VkImageViewCaptureDescriptorDataInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageViewCaptureDescriptorDataInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageViewCaptureDescriptorDataInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageView</c> is the <c>VkImageView</c> handle of the image view to get opaque capture data for.
        /// </summary>
        [FieldOffset(16)]
        public VkImageView ImageView;
    }
}
