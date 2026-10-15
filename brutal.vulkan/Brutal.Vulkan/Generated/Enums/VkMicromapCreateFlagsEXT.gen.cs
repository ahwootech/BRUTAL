namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMicromapCreateFlagBitsEXT.html">VkMicromapCreateFlagBitsEXT</see> - Bitmask specifying additional creation parameters for micromap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkMicromapCreateInfoEXT::createFlags</c>,
    ///         specifying additional creation parameters for micromaps, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef enum VkMicromapCreateFlagBitsEXT {
    ///             VK_MICROMAP_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT = 0x00000001,
    ///         } VkMicromapCreateFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkMicromapCreateFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DeviceAddressCaptureReplayBitEXT</c> specifies that the micromap&apos;s address <i>can</i> be saved and reused on a subsequent run.
        /// </summary>
        DeviceAddressCaptureReplayBitEXT = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
