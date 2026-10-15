namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryAllocateFlagBits.html">VkMemoryAllocateFlagBits</see> - Bitmask specifying flags for a device memory allocation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkMemoryAllocateFlagsInfo::flags</c>,
    ///         controlling device memory allocation, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkMemoryAllocateFlagBits {
    ///             VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT = 0x00000001,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT = 0x00000002,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT = 0x00000004,
    ///             // Provided by VK_EXT_zero_initialize_device_memory
    ///             VK_MEMORY_ALLOCATE_ZERO_INITIALIZE_BIT_EXT = 0x00000008,
    ///             // Provided by VK_KHR_device_group
    ///             VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT_KHR = VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT,
    ///             // Provided by VK_KHR_buffer_device_address
    ///             VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT_KHR = VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT,
    ///             // Provided by VK_KHR_buffer_device_address
    ///             VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT,
    ///         } VkMemoryAllocateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkMemoryAllocateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DeviceMaskBit</c> specifies that memory will be allocated for the devices in <c>VkMemoryAllocateFlagsInfo::deviceMask</c>.
        /// </summary>
        DeviceMaskBit = 0x00000001,

        /// <summary>
        ///     <c>DeviceAddressBit</c>
        /// </summary>
        DeviceAddressBit = 0x00000002,

        /// <summary>
        ///     <c>DeviceAddressCaptureReplayBit</c>
        /// </summary>
        DeviceAddressCaptureReplayBit = 0x00000004,

        /// <summary>
        ///     <c>ZeroInitializeBitEXT</c>
        /// </summary>
        ZeroInitializeBitEXT = 0x00000008,

        /// <summary>
        ///     <c>DeviceMaskBitKHR</c>
        /// </summary>
        DeviceMaskBitKHR = DeviceMaskBit,

        /// <summary>
        ///     <c>DeviceAddressBitKHR</c>
        /// </summary>
        DeviceAddressBitKHR = DeviceAddressBit,

        /// <summary>
        ///     <c>DeviceAddressCaptureReplayBitKHR</c>
        /// </summary>
        DeviceAddressCaptureReplayBitKHR = DeviceAddressCaptureReplayBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
