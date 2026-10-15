namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceQueuePerfHintPropertiesQCOM.html">VkPhysicalDeviceQueuePerfHintPropertiesQCOM</see> - Structure describing queue perf hint properties for a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceQueuePerfHintPropertiesQCOM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_queue_perf_hint
    ///         typedef struct VkPhysicalDeviceQueuePerfHintPropertiesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkQueueFlags       supportedQueues;
    ///         } VkPhysicalDeviceQueuePerfHintPropertiesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceQueuePerfHintPropertiesQCOM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceQueuePerfHintPropertiesQCOM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SupportedQueues</c>
        /// </summary>
        [FieldOffset(16)]
        public VkQueueFlags SupportedQueues;
    }
}
