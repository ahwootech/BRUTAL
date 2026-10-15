namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkScopeKHR.html">VkScopeKHR</see> - Specify SPIR-V scope
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values for <c>VkScopeKHR</c> include:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_cooperative_matrix
    ///         typedef enum VkScopeKHR {
    ///             VK_SCOPE_DEVICE_KHR = 1,
    ///             VK_SCOPE_WORKGROUP_KHR = 2,
    ///             VK_SCOPE_SUBGROUP_KHR = 3,
    ///             VK_SCOPE_QUEUE_FAMILY_KHR = 5,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_SCOPE_DEVICE_NV = VK_SCOPE_DEVICE_KHR,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_SCOPE_WORKGROUP_NV = VK_SCOPE_WORKGROUP_KHR,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_SCOPE_SUBGROUP_NV = VK_SCOPE_SUBGROUP_KHR,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_SCOPE_QUEUE_FAMILY_NV = VK_SCOPE_QUEUE_FAMILY_KHR,
    ///         } VkScopeKHR;
    ///     </code>
    /// </remarks>
    public enum VkScopeKHR : int
    {
        /// <summary>
        ///     <c>DeviceKHR</c> corresponds to SPIR-V <c>Device</c> scope.
        /// </summary>
        DeviceKHR = 1,

        /// <summary>
        ///     <c>WorkgroupKHR</c> corresponds to SPIR-V <c>Workgroup</c> scope.
        /// </summary>
        WorkgroupKHR = 2,

        /// <summary>
        ///     <c>SubgroupKHR</c> corresponds to SPIR-V <c>Subgroup</c> scope.
        /// </summary>
        SubgroupKHR = 3,

        /// <summary>
        ///     <c>QueueFamilyKHR</c> corresponds to SPIR-V <c>QueueFamily</c> scope.  All enum values match the corresponding SPIR-V value.
        /// </summary>
        QueueFamilyKHR = 5,

        /// <summary>
        ///     <c>DeviceNV</c>
        /// </summary>
        DeviceNV = DeviceKHR,

        /// <summary>
        ///     <c>WorkgroupNV</c>
        /// </summary>
        WorkgroupNV = WorkgroupKHR,

        /// <summary>
        ///     <c>SubgroupNV</c>
        /// </summary>
        SubgroupNV = SubgroupKHR,

        /// <summary>
        ///     <c>QueueFamilyNV</c>
        /// </summary>
        QueueFamilyNV = QueueFamilyKHR,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
