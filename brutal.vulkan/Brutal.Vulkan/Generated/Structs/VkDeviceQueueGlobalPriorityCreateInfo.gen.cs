namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceQueueGlobalPriorityCreateInfo.html">VkDeviceQueueGlobalPriorityCreateInfo</see> - Specify a system wide priority
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Queues <i>can</i> be created with a system-wide priority by adding a
    ///         <c>VkDeviceQueueGlobalPriorityCreateInfo</c> structure to the <c>pNext</c>
    ///         chain of <c>VkDeviceQueueCreateInfo</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkDeviceQueueGlobalPriorityCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkDeviceQueueGlobalPriorityCreateInfo {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkQueueGlobalPriority    globalPriority;
    ///         } VkDeviceQueueGlobalPriorityCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDeviceQueueGlobalPriorityCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceQueueGlobalPriorityCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>GlobalPriority</c> is the system-wide priority associated to these queues as specified by <c>VkQueueGlobalPriority</c>
        /// </summary>
        [FieldOffset(16)]
        public VkQueueGlobalPriority GlobalPriority;
    }
}
