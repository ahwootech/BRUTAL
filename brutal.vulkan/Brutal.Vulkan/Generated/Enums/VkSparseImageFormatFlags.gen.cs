namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSparseImageFormatFlagBits.html">VkSparseImageFormatFlagBits</see> - Bitmask specifying additional information about a sparse image resource
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in <c>VkSparseImageFormatProperties::flags</c>,
    ///         specifying additional information about the sparse resource, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkSparseImageFormatFlagBits {
    ///             VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT = 0x00000001,
    ///             VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT = 0x00000002,
    ///             VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT = 0x00000004,
    ///         } VkSparseImageFormatFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkSparseImageFormatFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>SingleMiptailBit</c> specifies that the image uses a single mip tail region for all array layers.
        /// </summary>
        SingleMiptailBit = 0x00000001,

        /// <summary>
        ///     <c>AlignedMipSizeBit</c> specifies that the first mip level whose dimensions are not integer multiples of the corresponding dimensions of the sparse image block begins the mip tail region.
        /// </summary>
        AlignedMipSizeBit = 0x00000002,

        /// <summary>
        ///     <c>NonstandardBlockSizeBit</c> specifies that the image uses non-standard sparse image block dimensions, and the <c>imageGranularity</c> values do not match the standard sparse image block dimensions for the given format.
        /// </summary>
        NonstandardBlockSizeBit = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
