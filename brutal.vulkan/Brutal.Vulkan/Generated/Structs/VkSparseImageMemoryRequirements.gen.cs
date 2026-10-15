namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSparseImageMemoryRequirements.html">VkSparseImageMemoryRequirements</see> - Structure specifying sparse image memory requirements
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSparseImageMemoryRequirements</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSparseImageMemoryRequirements {
    ///             VkSparseImageFormatProperties    formatProperties;
    ///             uint32_t                         imageMipTailFirstLod;
    ///             VkDeviceSize                     imageMipTailSize;
    ///             VkDeviceSize                     imageMipTailOffset;
    ///             VkDeviceSize                     imageMipTailStride;
    ///         } VkSparseImageMemoryRequirements;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct VkSparseImageMemoryRequirements()
    {
        /// <summary>
        ///     <c>FormatProperties</c> is a <c>VkSparseImageFormatProperties</c> structure specifying properties of the image format.
        /// </summary>
        [FieldOffset(0)]
        public VkSparseImageFormatProperties FormatProperties;

        /// <summary>
        ///     <c>ImageMipTailFirstLod</c> is the first mip level at which image subresources are included in the mip tail region.
        /// </summary>
        [FieldOffset(20)]
        public int ImageMipTailFirstLod;

        /// <summary>
        ///     <c>ImageMipTailSize</c> is the memory size (in bytes) of the mip tail region. If <c>formatProperties</c>.flags contains <c>VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT</c>, this is the size of the whole mip tail, otherwise this is the size of the mip tail of a single array layer. This value is guaranteed to be a multiple of the sparse block size in bytes.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 ImageMipTailSize;

        /// <summary>
        ///     <c>ImageMipTailOffset</c> is the opaque memory offset used with <c>VkSparseImageOpaqueMemoryBindInfo</c> to bind the mip tail region(s).
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 ImageMipTailOffset;

        /// <summary>
        ///     <c>ImageMipTailStride</c> is the offset stride between each array-layer&apos;s mip tail, if <c>formatProperties</c>.flags does not contain <c>VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT</c> (otherwise the value is undefined:).
        /// </summary>
        [FieldOffset(40)]
        public ByteSize64 ImageMipTailStride;
    }
}
