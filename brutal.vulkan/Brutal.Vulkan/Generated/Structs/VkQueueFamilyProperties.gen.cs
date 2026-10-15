namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyProperties.html">VkQueueFamilyProperties</see> - Structure providing information about a queue family
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueueFamilyProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkQueueFamilyProperties {
    ///             VkQueueFlags    queueFlags;
    ///             uint32_t        queueCount;
    ///             uint32_t        timestampValidBits;
    ///             VkExtent3D      minImageTransferGranularity;
    ///         } VkQueueFamilyProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkQueueFamilyProperties()
    {
        /// <summary>
        ///     <c>QueueFlags</c> is a bitmask of <c>VkQueueFlags</c> indicating capabilities of the queues in this queue family.
        /// </summary>
        [FieldOffset(0)]
        public VkQueueFlags QueueFlags;

        /// <summary>
        ///     <c>QueueCount</c> is the unsigned integer count of queues in this queue family. Each queue family <i>must</i> support at least one queue.
        /// </summary>
        [FieldOffset(4)]
        public int QueueCount;

        /// <summary>
        ///     <c>TimestampValidBits</c> is the unsigned integer count of meaningful bits in the timestamps written via <c>vkCmdWriteTimestamp</c>. The valid range for the count is 36 to 64 bits, or a value of 0, indicating no support for timestamps. Bits outside the valid range are guaranteed to be zeros.
        /// </summary>
        [FieldOffset(8)]
        public int TimestampValidBits;

        /// <summary>
        ///     <c>MinImageTransferGranularity</c> is the minimum granularity supported for image transfer operations on the queues in this queue family.
        /// </summary>
        [FieldOffset(12)]
        public VkExtent3D MinImageTransferGranularity;
    }
}
