namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSparseMemoryBindFlagBits.html">VkSparseMemoryBindFlagBits</see> - Bitmask specifying usage of a sparse memory binding operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkSparseMemoryBind::flags</c>, specifying
    ///         usage of a sparse memory binding operation, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkSparseMemoryBindFlagBits {
    ///             VK_SPARSE_MEMORY_BIND_METADATA_BIT = 0x00000001,
    ///         } VkSparseMemoryBindFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkSparseMemoryBindFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>MetadataBit</c> specifies that the memory being bound is only for the metadata aspect.
        /// </summary>
        MetadataBit = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
