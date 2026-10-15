namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBuildAccelerationStructureModeKHR.html">VkBuildAccelerationStructureModeKHR</see> - Enum specifying the type of build operation to perform
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBuildAccelerationStructureModeKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkBuildAccelerationStructureModeKHR</c> enumeration is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef enum VkBuildAccelerationStructureModeKHR {
    ///             VK_BUILD_ACCELERATION_STRUCTURE_MODE_BUILD_KHR = 0,
    ///             VK_BUILD_ACCELERATION_STRUCTURE_MODE_UPDATE_KHR = 1,
    ///         } VkBuildAccelerationStructureModeKHR;
    ///     </code>
    /// </remarks>
    public enum VkBuildAccelerationStructureModeKHR : int
    {
        /// <summary>
        ///     <c>BuildKHR</c> specifies that the destination acceleration structure will be built using the specified geometries.
        /// </summary>
        BuildKHR = 0,

        /// <summary>
        ///     <c>UpdateKHR</c> specifies that the destination acceleration structure will be built using data in a source acceleration structure, updated by the specified geometries.
        /// </summary>
        UpdateKHR = 1,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
