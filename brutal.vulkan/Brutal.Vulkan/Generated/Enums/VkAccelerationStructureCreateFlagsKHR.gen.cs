namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureCreateFlagBitsKHR.html">VkAccelerationStructureCreateFlagBitsKHR</see> - Bitmask specifying additional creation parameters for acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkAccelerationStructureCreateInfoKHR::createFlags</c>, specifying
    ///         additional creation parameters for acceleration structures, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef enum VkAccelerationStructureCreateFlagBitsKHR {
    ///             VK_ACCELERATION_STRUCTURE_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = 0x00000001,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_ACCELERATION_STRUCTURE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = 0x00000008,
    ///             // Provided by VK_NV_ray_tracing_motion_blur
    ///             VK_ACCELERATION_STRUCTURE_CREATE_MOTION_BIT_NV = 0x00000004,
    ///         } VkAccelerationStructureCreateFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkAccelerationStructureCreateFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DeviceAddressCaptureReplayBitKHR</c>  specifies that the acceleration structure&apos;s address <i>can</i> be saved and reused on a subsequent run.
        /// </summary>
        DeviceAddressCaptureReplayBitKHR = 0x00000001,

        /// <summary>
        ///     <c>DescriptorBufferCaptureReplayBitEXT</c>
        /// </summary>
        DescriptorBufferCaptureReplayBitEXT = 0x00000008,

        /// <summary>
        ///     <c>MotionBitNV</c>
        /// </summary>
        MotionBitNV = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
