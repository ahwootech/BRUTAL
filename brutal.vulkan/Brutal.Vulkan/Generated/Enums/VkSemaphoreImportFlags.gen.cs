namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSemaphoreImportFlagBits.html">VkSemaphoreImportFlagBits</see> - Bitmask specifying additional parameters of semaphore payload import
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///     </para>
    ///     <para>
    ///         * platform-specific semaphore import structures (the current specification
    ///         build has none enabled)
    ///     </para>
    ///     <para>
    ///         specifying additional parameters of a semaphore import operation are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkSemaphoreImportFlagBits {
    ///             VK_SEMAPHORE_IMPORT_TEMPORARY_BIT = 0x00000001,
    ///             // Provided by VK_KHR_external_semaphore
    ///             VK_SEMAPHORE_IMPORT_TEMPORARY_BIT_KHR = VK_SEMAPHORE_IMPORT_TEMPORARY_BIT,
    ///         } VkSemaphoreImportFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkSemaphoreImportFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>TemporaryBit</c> specifies that the semaphore payload will be imported only temporarily, as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-semaphores-importing">Importing Semaphore Payloads^</see>, regardless of the permanence of <c>handleType</c>.
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
