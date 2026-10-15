namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCacheCreateFlagBits.html">VkPipelineCacheCreateFlagBits</see> - Bitmask specifying the behavior of the pipeline cache
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkPipelineCacheCreateInfo::flags</c>,
    ///         specifying behavior of the pipeline cache, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0, VK_KHR_maintenance8, VK_EXT_pipeline_creation_cache_control
    ///         typedef enum VkPipelineCacheCreateFlagBits {
    ///             // Provided by VK_VERSION_1_3
    ///             VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT = 0x00000001,
    ///             // Provided by VK_KHR_maintenance8
    ///             VK_PIPELINE_CACHE_CREATE_INTERNALLY_SYNCHRONIZED_MERGE_BIT_KHR = 0x00000008,
    ///             // Provided by VK_EXT_pipeline_creation_cache_control
    ///             VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT_EXT = VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT,
    ///         } VkPipelineCacheCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPipelineCacheCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ExternallySynchronizedBit</c>
        /// </summary>
        ExternallySynchronizedBit = 0x00000001,

        /// <summary>
        ///     <c>InternallySynchronizedMergeBitKHR</c>
        /// </summary>
        InternallySynchronizedMergeBitKHR = 0x00000008,

        /// <summary>
        ///     <c>ExternallySynchronizedBitEXT</c>
        /// </summary>
        ExternallySynchronizedBitEXT = ExternallySynchronizedBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
