namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureCompatibilityKHR.html">VkAccelerationStructureCompatibilityKHR</see> - Acceleration structure compatibility
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>pCompatibility</c> returned by
    ///         <c>vkGetDeviceAccelerationStructureCompatibilityKHR</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef enum VkAccelerationStructureCompatibilityKHR {
    ///             VK_ACCELERATION_STRUCTURE_COMPATIBILITY_COMPATIBLE_KHR = 0,
    ///             VK_ACCELERATION_STRUCTURE_COMPATIBILITY_INCOMPATIBLE_KHR = 1,
    ///         } VkAccelerationStructureCompatibilityKHR;
    ///     </code>
    /// </remarks>
    public enum VkAccelerationStructureCompatibilityKHR : int
    {
        /// <summary>
        ///     <c>CompatibleKHR</c> if the <c>pVersionData</c> version acceleration structure is compatible with <c>device</c>.
        /// </summary>
        CompatibleKHR = 0,

        /// <summary>
        ///     <c>IncompatibleKHR</c> if the <c>pVersionData</c> version acceleration structure is not compatible with <c>device</c>.
        /// </summary>
        IncompatibleKHR = 1,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
