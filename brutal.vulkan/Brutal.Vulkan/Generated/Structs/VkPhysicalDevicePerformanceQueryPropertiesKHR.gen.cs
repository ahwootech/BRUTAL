namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePerformanceQueryPropertiesKHR.html">VkPhysicalDevicePerformanceQueryPropertiesKHR</see> - Structure describing performance query properties for an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePerformanceQueryPropertiesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_performance_query
    ///         typedef struct VkPhysicalDevicePerformanceQueryPropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           allowCommandBufferQueryCopies;
    ///         } VkPhysicalDevicePerformanceQueryPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePerformanceQueryPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePerformanceQueryPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AllowCommandBufferQueryCopies</c> is <c>VK_TRUE</c> if the performance query pools are allowed to be used with <c>vkCmdCopyQueryPoolResults</c>.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 AllowCommandBufferQueryCopies;
    }
}
