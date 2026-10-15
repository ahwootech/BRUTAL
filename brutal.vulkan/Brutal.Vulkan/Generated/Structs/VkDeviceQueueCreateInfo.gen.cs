namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceQueueCreateInfo.html">VkDeviceQueueCreateInfo</see> - Structure specifying parameters of a newly created device queue
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceQueueCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkDeviceQueueCreateInfo {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkDeviceQueueCreateFlags    flags;
    ///             uint32_t                    queueFamilyIndex;
    ///             uint32_t                    queueCount;
    ///             const float*                pQueuePriorities;
    ///         } VkDeviceQueueCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDeviceQueueCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceQueueCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceQueueCreateFlags Flags;

        /// <summary>
        ///     <c>QueueFamilyIndex</c> is an unsigned integer indicating the index of the queue family in which to create the queues on this device. This index corresponds to the index of an element of the <c>pQueueFamilyProperties</c> array that was returned by <c>vkGetPhysicalDeviceQueueFamilyProperties</c>.
        /// </summary>
        [FieldOffset(20)]
        public int QueueFamilyIndex;

        /// <summary>
        ///     <c>QueueCount</c> is an unsigned integer specifying the number of queues to create in the queue family indicated by <c>queueFamilyIndex</c>, and with the behavior specified by <c>flags</c>.
        /// </summary>
        [FieldOffset(24)]
        public int QueueCount;

        /// <summary>
        ///     <c>QueuePriorities</c> is a pointer to an array of <c>queueCount</c> normalized floating-point values, specifying priorities of work that will be submitted to each created queue. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#devsandqueues-priority">Queue Priority^</see> for more information.
        /// </summary>
        [FieldOffset(32)]
        public float* QueuePriorities;
    }
}
