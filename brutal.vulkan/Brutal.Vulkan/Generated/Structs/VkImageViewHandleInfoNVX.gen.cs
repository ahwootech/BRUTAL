namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageViewHandleInfoNVX.html">VkImageViewHandleInfoNVX</see> - Structure specifying the image view for handle queries
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageViewHandleInfoNVX</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NVX_image_view_handle
    ///         typedef struct VkImageViewHandleInfoNVX {
    ///             VkStructureType     sType;
    ///             const void*         pNext;
    ///             VkImageView         imageView;
    ///             VkDescriptorType    descriptorType;
    ///             VkSampler           sampler;
    ///         } VkImageViewHandleInfoNVX;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkImageViewHandleInfoNVX()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageViewHandleInfoNVX;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageView</c> is the image view to query.
        /// </summary>
        [FieldOffset(16)]
        public VkImageView ImageView;

        /// <summary>
        ///     <c>DescriptorType</c> is the type of descriptor for which to query a handle.
        /// </summary>
        [FieldOffset(24)]
        public VkDescriptorType DescriptorType;

        /// <summary>
        ///     <c>Sampler</c> is the sampler to combine with the image view when generating the handle.
        /// </summary>
        [FieldOffset(32)]
        public VkSampler Sampler;
    }
}
