namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureBuildTypeKHR.html">VkAccelerationStructureBuildTypeKHR</see> - Acceleration structure build type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureBuildTypeKHR
    ///     </para>
    ///     <para>
    ///         Possible values of <c>buildType</c> in
    ///         <c>vkGetAccelerationStructureBuildSizesKHR</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef enum VkAccelerationStructureBuildTypeKHR {
    ///             VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR = 0,
    ///             VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR = 1,
    ///             VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR = 2,
    ///         } VkAccelerationStructureBuildTypeKHR;
    ///     </code>
    /// </remarks>
    public enum VkAccelerationStructureBuildTypeKHR : int
    {
        /// <summary>
        ///     <c>HostKHR</c> requests the memory requirement for operations performed by the host.
        /// </summary>
        HostKHR = 0,

        /// <summary>
        ///     <c>DeviceKHR</c> requests the memory requirement for operations performed by the device.
        /// </summary>
        DeviceKHR = 1,

        /// <summary>
        ///     <c>HostOrDeviceKHR</c> requests the memory requirement for operations performed by either the host, or the device.
        /// </summary>
        HostOrDeviceKHR = 2,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
