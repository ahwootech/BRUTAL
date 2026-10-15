namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAddressCopyFlagBitsKHR.html">VkAddressCopyFlagBitsKHR</see> - Bitmask specifying address copy parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in a <c>VkAddressCopyFlagsKHR</c> mask are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_copy_memory_indirect
    ///         typedef enum VkAddressCopyFlagBitsKHR {
    ///             VK_ADDRESS_COPY_DEVICE_LOCAL_BIT_KHR = 0x00000001,
    ///             VK_ADDRESS_COPY_SPARSE_BIT_KHR = 0x00000002,
    ///             VK_ADDRESS_COPY_PROTECTED_BIT_KHR = 0x00000004,
    ///         } VkAddressCopyFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkAddressCopyFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DeviceLocalBitKHR</c> specifies that the address range is expected to be resident in device local memory. Specifying this value is optional, but may: lead to improved performance if set accurately.
        /// </summary>
        DeviceLocalBitKHR = 0x00000001,

        /// <summary>
        ///     <c>SparseBitKHR</c> specifies that the address range may not be fully bound to physical memory when accessed.
        /// </summary>
        SparseBitKHR = 0x00000002,

        /// <summary>
        ///     <c>ProtectedBitKHR</c> specifies that the address range is allocated from protected memory.
        /// </summary>
        ProtectedBitKHR = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
