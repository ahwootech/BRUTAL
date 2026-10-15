namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceQueuePerfHintFeaturesQCOM.html">VkPhysicalDeviceQueuePerfHintFeaturesQCOM</see> - Structure describing queue perf hint features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceQueuePerfHintFeaturesQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_queue_perf_hint
    ///         typedef struct VkPhysicalDeviceQueuePerfHintFeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           queuePerfHint;
    ///         } VkPhysicalDeviceQueuePerfHintFeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceQueuePerfHintFeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceQueuePerfHintFeaturesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>QueuePerfHint</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 QueuePerfHint;
    }
}
