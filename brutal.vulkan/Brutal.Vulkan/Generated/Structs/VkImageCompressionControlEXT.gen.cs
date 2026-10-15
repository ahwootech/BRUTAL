namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageCompressionControlEXT.html">VkImageCompressionControlEXT</see> - Specify image compression properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> list of <c>VkImageCreateInfo</c> includes a
    ///         <c>VkImageCompressionControlEXT</c> structure, then that structure describes
    ///         compression controls for this image.
    ///     </para>
    ///     <para>
    ///         The <c>VkImageCompressionControlEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_compression_control
    ///         typedef struct VkImageCompressionControlEXT {
    ///             VkStructureType                         sType;
    ///             const void*                             pNext;
    ///             VkImageCompressionFlagsEXT              flags;
    ///             uint32_t                                compressionControlPlaneCount;
    ///             VkImageCompressionFixedRateFlagsEXT*    pFixedRateFlags;
    ///         } VkImageCompressionControlEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkImageCompressionControlEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageCompressionControlEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkImageCompressionFlagsEXT</c> describing compression controls for the image.
        /// </summary>
        [FieldOffset(16)]
        public VkImageCompressionFlagsEXT Flags;

        /// <summary>
        ///     <c>CompressionControlPlaneCount</c> is the number of entries in the <c>pFixedRateFlags</c> array.
        /// </summary>
        [FieldOffset(20)]
        public int CompressionControlPlaneCount;

        /// <summary>
        ///     <c>FixedRateFlags</c> is `NULL` or a pointer to an array of <c>VkImageCompressionFixedRateFlagsEXT</c> bitfields describing allowed fixed-rate compression rates of each image plane. It is ignored if <c>flags</c> does not include <c>VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkImageCompressionFixedRateFlagsEXT* FixedRateFlags;
    }
}
