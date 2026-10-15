namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSparseImageFormatInfo2.html">VkPhysicalDeviceSparseImageFormatInfo2</see> - Structure specifying sparse image format inputs
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSparseImageFormatInfo2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceSparseImageFormatInfo2 {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkFormat                 format;
    ///             VkImageType              type;
    ///             VkSampleCountFlagBits    samples;
    ///             VkImageUsageFlags        usage;
    ///             VkImageTiling            tiling;
    ///         } VkPhysicalDeviceSparseImageFormatInfo2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceSparseImageFormatInfo2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSparseImageFormatInfo2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Format</c> is the image format.
        /// </summary>
        [FieldOffset(16)]
        public VkFormat Format;

        /// <summary>
        ///     <c>Type</c> is the dimensionality of the image.
        /// </summary>
        [FieldOffset(20)]
        public VkImageType Type;

        /// <summary>
        ///     <c>Samples</c> is a <c>VkSampleCountFlags</c> value specifying the number of samples per texel.
        /// </summary>
        [FieldOffset(24)]
        public VkSampleCountFlags Samples;

        /// <summary>
        ///     <c>Usage</c> is a bitmask of <c>VkImageUsageFlags</c> describing the intended usage of the image.
        /// </summary>
        [FieldOffset(28)]
        public VkImageUsageFlags Usage;

        /// <summary>
        ///     <c>Tiling</c> is the tiling arrangement of the texel blocks in memory.
        /// </summary>
        [FieldOffset(32)]
        public VkImageTiling Tiling;
    }
}
