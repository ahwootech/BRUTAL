namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoPictureResourceInfoKHR.html">VkVideoPictureResourceInfoKHR</see> - Structure specifying the parameters of a video picture resource
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoPictureResourceInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkVideoPictureResourceInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkOffset2D         codedOffset;
    ///             VkExtent2D         codedExtent;
    ///             uint32_t           baseArrayLayer;
    ///             VkImageView        imageViewBinding;
    ///         } VkVideoPictureResourceInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkVideoPictureResourceInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoPictureResourceInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CodedOffset</c> is the offset in texels of the image subregion to use.
        /// </summary>
        [FieldOffset(16)]
        public VkOffset2D CodedOffset;

        /// <summary>
        ///     <c>CodedExtent</c> is the size in pixels of the coded image data.
        /// </summary>
        [FieldOffset(24)]
        public VkExtent2D CodedExtent;

        /// <summary>
        ///     <c>BaseArrayLayer</c> is the array layer of the image view specified in <c>imageViewBinding</c> to use as the video picture resource.
        /// </summary>
        [FieldOffset(32)]
        public int BaseArrayLayer;

        /// <summary>
        ///     <c>ImageViewBinding</c> is an image view representing the video picture resource.
        /// </summary>
        [FieldOffset(40)]
        public VkImageView ImageViewBinding;
    }
}
