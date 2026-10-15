namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageCaptureDescriptorDataInfoEXT.html">VkImageCaptureDescriptorDataInfoEXT</see> - Structure specifying an image for descriptor capture
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Information about the image to get descriptor buffer capture data for is
    ///         passed in a <c>VkImageCaptureDescriptorDataInfoEXT</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer
    ///         typedef struct VkImageCaptureDescriptorDataInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkImage            image;
    ///         } VkImageCaptureDescriptorDataInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageCaptureDescriptorDataInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageCaptureDescriptorDataInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Image</c> is the <c>VkImage</c> handle of the image to get opaque capture data for.
        /// </summary>
        [FieldOffset(16)]
        public VkImage Image;
    }
}
