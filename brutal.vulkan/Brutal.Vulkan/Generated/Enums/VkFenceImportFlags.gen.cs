namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFenceImportFlagBits.html">VkFenceImportFlagBits</see> - Bitmask specifying additional parameters of fence payload import
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///     </para>
    ///     <para>
    ///         * platform-specific fence import structures (the current specification
    ///         build has none enabled)
    ///     </para>
    ///     <para>
    ///         specifying additional parameters of a fence import operation are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkFenceImportFlagBits {
    ///             VK_FENCE_IMPORT_TEMPORARY_BIT = 0x00000001,
    ///             // Provided by VK_KHR_external_fence
    ///             VK_FENCE_IMPORT_TEMPORARY_BIT_KHR = VK_FENCE_IMPORT_TEMPORARY_BIT,
    ///         } VkFenceImportFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkFenceImportFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>TemporaryBit</c> specifies that the fence payload will be imported only temporarily, as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-fences-importing">Importing Fence Payloads^</see>, regardless of the permanence of <c>handleType</c>.
        /// </summary>
        TemporaryBit = 0x00000001,

        /// <summary>
        ///     <c>TemporaryBitKHR</c>
        /// </summary>
        TemporaryBitKHR = TemporaryBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
