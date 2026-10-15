namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyVideoPropertiesKHR.html">VkQueueFamilyVideoPropertiesKHR</see> - Structure describing video codec operations supported by a queue family
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueueFamilyVideoPropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkQueueFamilyVideoPropertiesKHR {
    ///             VkStructureType                  sType;
    ///             void*                            pNext;
    ///             VkVideoCodecOperationFlagsKHR    videoCodecOperations;
    ///         } VkQueueFamilyVideoPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkQueueFamilyVideoPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueueFamilyVideoPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VideoCodecOperations</c> is a bitmask of <c>VkVideoCodecOperationFlagsKHR</c> that indicates the set of video codec operations supported by the queue family.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoCodecOperationFlagsKHR VideoCodecOperations;
    }
}
