namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceMemoryOverallocationCreateInfoAMD.html">VkDeviceMemoryOverallocationCreateInfoAMD</see> - Specify memory overallocation behavior for a Vulkan device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To specify whether device memory allocation is allowed beyond the size
    ///         reported by <c>VkPhysicalDeviceMemoryProperties</c>, add a
    ///         <c>VkDeviceMemoryOverallocationCreateInfoAMD</c> structure to the <c>pNext</c>
    ///         chain of the <c>VkDeviceCreateInfo</c> structure.
    ///         If this structure is not specified, it is as if the
    ///         <c>VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD</c> value is used.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_memory_overallocation_behavior
    ///         typedef struct VkDeviceMemoryOverallocationCreateInfoAMD {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkMemoryOverallocationBehaviorAMD    overallocationBehavior;
    ///         } VkDeviceMemoryOverallocationCreateInfoAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDeviceMemoryOverallocationCreateInfoAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceMemoryOverallocationCreateInfoAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>OverallocationBehavior</c> is the desired overallocation behavior.
        /// </summary>
        [FieldOffset(16)]
        public VkMemoryOverallocationBehaviorAMD OverallocationBehavior;
    }
}
