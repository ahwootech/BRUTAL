namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubmitFlagBits.html">VkSubmitFlagBits</see> - Bitmask specifying behavior of a submission
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkSubmitInfo2::flags</c>, specifying
    ///         submission behavior, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef enum VkSubmitFlagBits {
    ///             VK_SUBMIT_PROTECTED_BIT = 0x00000001,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_SUBMIT_PROTECTED_BIT_KHR = VK_SUBMIT_PROTECTED_BIT,
    ///         } VkSubmitFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkSubmitFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ProtectedBit</c> specifies that this batch is a protected submission.
        /// </summary>
        ProtectedBit = 0x00000001,

        /// <summary>
        ///     <c>ProtectedBitKHR</c>
        /// </summary>
        ProtectedBitKHR = ProtectedBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
