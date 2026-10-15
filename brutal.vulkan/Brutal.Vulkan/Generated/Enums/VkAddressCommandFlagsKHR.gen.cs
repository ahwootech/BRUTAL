namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAddressCommandFlagBitsKHR.html">VkAddressCommandFlagBitsKHR</see> - Bitmask specifying address copy parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in a <c>VkAddressCommandFlagsKHR</c> mask are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands
    ///         typedef enum VkAddressCommandFlagBitsKHR {
    ///             VK_ADDRESS_COMMAND_PROTECTED_BIT_KHR = 0x00000001,
    ///             VK_ADDRESS_COMMAND_FULLY_BOUND_BIT_KHR = 0x00000002,
    ///             VK_ADDRESS_COMMAND_STORAGE_BUFFER_USAGE_BIT_KHR = 0x00000004,
    ///             VK_ADDRESS_COMMAND_UNKNOWN_STORAGE_BUFFER_USAGE_BIT_KHR = 0x00000008,
    ///             // Provided by VK_KHR_device_address_commands with VK_EXT_transform_feedback
    ///             VK_ADDRESS_COMMAND_TRANSFORM_FEEDBACK_BUFFER_USAGE_BIT_KHR = 0x00000010,
    ///             // Provided by VK_KHR_device_address_commands with VK_EXT_transform_feedback
    ///             VK_ADDRESS_COMMAND_UNKNOWN_TRANSFORM_FEEDBACK_BUFFER_USAGE_BIT_KHR = 0x00000020,
    ///         } VkAddressCommandFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkAddressCommandFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ProtectedBitKHR</c> specifies that an address range is allocated from protected memory.
        /// </summary>
        ProtectedBitKHR = 0x00000001,

        /// <summary>
        ///     <c>FullyBoundBitKHR</c> specifies that an address range will be fully bound to physical memory when accessed.
        /// </summary>
        FullyBoundBitKHR = 0x00000002,

        /// <summary>
        ///     <c>StorageBufferUsageBitKHR</c> specifies that all buffers containing any part of an address range were created with the <c>VK_BUFFER_USAGE_STORAGE_BUFFER_BIT</c> usage.
        /// </summary>
        StorageBufferUsageBitKHR = 0x00000004,

        /// <summary>
        ///     <c>UnknownStorageBufferUsageBitKHR</c> specifies that whether buffers containing an any part of an address range were created with <c>VK_BUFFER_USAGE_STORAGE_BUFFER_BIT</c> usage or not is unknown.  If neither <c>VK_ADDRESS_COMMAND_STORAGE_BUFFER_USAGE_BIT_KHR</c> nor <c>VK_ADDRESS_COMMAND_UNKNOWN_STORAGE_BUFFER_USAGE_BIT_KHR</c> are specified, the address range <i>must</i> not be aliased with any buffer allocated with the <c>VK_BUFFER_USAGE_STORAGE_BUFFER_BIT</c>.  [NOTE]
        /// </summary>
        UnknownStorageBufferUsageBitKHR = 0x00000008,

        /// <summary>
        ///     <c>TransformFeedbackBufferUsageBitKHR</c>
        /// </summary>
        TransformFeedbackBufferUsageBitKHR = 0x00000010,

        /// <summary>
        ///     <c>UnknownTransformFeedbackBufferUsageBitKHR</c>
        /// </summary>
        UnknownTransformFeedbackBufferUsageBitKHR = 0x00000020,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
