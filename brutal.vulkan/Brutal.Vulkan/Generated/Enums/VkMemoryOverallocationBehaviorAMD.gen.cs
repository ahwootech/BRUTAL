namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryOverallocationBehaviorAMD.html">VkMemoryOverallocationBehaviorAMD</see> - Specify memory overallocation behavior
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values for
    ///         <c>VkDeviceMemoryOverallocationCreateInfoAMD::overallocationBehavior</c>
    ///         include:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_memory_overallocation_behavior
    ///         typedef enum VkMemoryOverallocationBehaviorAMD {
    ///             VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD = 0,
    ///             VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD = 1,
    ///             VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD = 2,
    ///         } VkMemoryOverallocationBehaviorAMD;
    ///     </code>
    /// </remarks>
    public enum VkMemoryOverallocationBehaviorAMD : int
    {
        /// <summary>
        ///     <c>DefaultAMD</c> lets the implementation decide if overallocation is allowed.
        /// </summary>
        DefaultAMD = 0,

        /// <summary>
        ///     <c>AllowedAMD</c> specifies overallocation is allowed if platform permits.
        /// </summary>
        AllowedAMD = 1,

        /// <summary>
        ///     <c>DisallowedAMD</c> specifies the application is not allowed to allocate device memory beyond the heap sizes reported by <c>VkPhysicalDeviceMemoryProperties</c>. Allocations that are not explicitly made by the application within the scope of the Vulkan instance are not accounted for.
        /// </summary>
        DisallowedAMD = 2,

        /// <summary>
        ///     <c>MaxEnumAMD</c>
        /// </summary>
        MaxEnumAMD = 0x7FFFFFFF,
    }
}
