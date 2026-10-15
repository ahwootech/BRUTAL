namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyGlobalPriorityProperties.html">VkQueueFamilyGlobalPriorityProperties</see> - Return structure for queue family global priority information query
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueueFamilyGlobalPriorityProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkQueueFamilyGlobalPriorityProperties {
    ///             VkStructureType          sType;
    ///             void*                    pNext;
    ///             uint32_t                 priorityCount;
    ///             VkQueueGlobalPriority    priorities[VK_MAX_GLOBAL_PRIORITY_SIZE];
    ///         } VkQueueFamilyGlobalPriorityProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkQueueFamilyGlobalPriorityProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueueFamilyGlobalPriorityProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PriorityCount</c> is the number of supported global queue priorities in this queue family, and it <i>must</i> be greater than 0.
        /// </summary>
        [FieldOffset(16)]
        public int PriorityCount;

        /// <summary>
        ///     <c>Priorities</c> is an array of <c>VK_MAX_GLOBAL_PRIORITY_SIZE</c> <c>VkQueueGlobalPriority</c> enums representing all supported global queue priorities in this queue family. The first <c>priorityCount</c> elements of the array will be valid.
        /// </summary>
        [FieldOffset(20)]
        public VkQueueGlobalPriority_16 Priorities;
    }
}
