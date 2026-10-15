namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceQueueInfo2.html">VkDeviceQueueInfo2</see> - Structure specifying the parameters used for device queue creation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceQueueInfo2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkDeviceQueueInfo2 {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkDeviceQueueCreateFlags    flags;
    ///             uint32_t                    queueFamilyIndex;
    ///             uint32_t                    queueIndex;
    ///         } VkDeviceQueueInfo2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDeviceQueueInfo2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceQueueInfo2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure. The <c>pNext</c> chain of <c>VkDeviceQueueInfo2</c> <i>can</i> be used to provide additional device queue parameters to <c>vkGetDeviceQueue2</c>.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a <c>VkDeviceQueueCreateFlags</c> value indicating the flags used to create the device queue.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceQueueCreateFlags Flags;

        /// <summary>
        ///     <c>QueueFamilyIndex</c> is the index of the queue family to which the queue belongs.
        /// </summary>
        [FieldOffset(20)]
        public int QueueFamilyIndex;

        /// <summary>
        ///     <c>QueueIndex</c> is the index of the queue to retrieve from within the set of queues that share both the queue family and flags specified.
        /// </summary>
        [FieldOffset(24)]
        public int QueueIndex;
    }
}
