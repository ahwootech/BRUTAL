namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPeerMemoryFeatureFlagBits.html">VkPeerMemoryFeatureFlagBits</see> - Bitmask specifying supported peer memory features
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>vkGetDeviceGroupPeerMemoryFeatures::pPeerMemoryFeatures</c>,
    ///         indicating supported peer memory features, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkPeerMemoryFeatureFlagBits {
    ///             VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT = 0x00000001,
    ///             VK_PEER_MEMORY_FEATURE_COPY_DST_BIT = 0x00000002,
    ///             VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT = 0x00000004,
    ///             VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT = 0x00000008,
    ///             // Provided by VK_KHR_device_group
    ///             VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT_KHR = VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT,
    ///             // Provided by VK_KHR_device_group
    ///             VK_PEER_MEMORY_FEATURE_COPY_DST_BIT_KHR = VK_PEER_MEMORY_FEATURE_COPY_DST_BIT,
    ///             // Provided by VK_KHR_device_group
    ///             VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT_KHR = VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT,
    ///             // Provided by VK_KHR_device_group
    ///             VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT_KHR = VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT,
    ///         } VkPeerMemoryFeatureFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPeerMemoryFeatureFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>CopySrcBit</c> specifies that the memory <i>can</i> be accessed as the source of any ftext:vkCmdCopy* command.
        /// </summary>
        CopySrcBit = 0x00000001,

        /// <summary>
        ///     <c>CopyDstBit</c> specifies that the memory <i>can</i> be accessed as the destination of any ftext:vkCmdCopy* command.
        /// </summary>
        CopyDstBit = 0x00000002,

        /// <summary>
        ///     <c>GenericSrcBit</c> specifies that the memory <i>can</i> be read as any memory access type.
        /// </summary>
        GenericSrcBit = 0x00000004,

        /// <summary>
        ///     <c>GenericDstBit</c> specifies that the memory <i>can</i> be written as any memory access type. Shader atomics are considered to be writes.  [NOTE]
        /// </summary>
        GenericDstBit = 0x00000008,

        /// <summary>
        ///     <c>CopySrcBitKHR</c>
        /// </summary>
        CopySrcBitKHR = CopySrcBit,

        /// <summary>
        ///     <c>CopyDstBitKHR</c>
        /// </summary>
        CopyDstBitKHR = CopyDstBit,

        /// <summary>
        ///     <c>GenericSrcBitKHR</c>
        /// </summary>
        GenericSrcBitKHR = GenericSrcBit,

        /// <summary>
        ///     <c>GenericDstBitKHR</c>
        /// </summary>
        GenericDstBitKHR = GenericDstBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
