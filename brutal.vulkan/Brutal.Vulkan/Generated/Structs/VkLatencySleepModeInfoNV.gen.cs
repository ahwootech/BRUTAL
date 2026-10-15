namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkLatencySleepModeInfoNV.html">VkLatencySleepModeInfoNV</see> - Structure to set low latency mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkLatencySleepModeInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_low_latency2
    ///         typedef struct VkLatencySleepModeInfoNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           lowLatencyMode;
    ///             VkBool32           lowLatencyBoost;
    ///             uint32_t           minimumIntervalUs;
    ///         } VkLatencySleepModeInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkLatencySleepModeInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.LatencySleepModeInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LowLatencyMode</c> is the toggle to enable or disable low latency mode.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 LowLatencyMode;

        /// <summary>
        ///     <c>LowLatencyBoost</c> allows an application to hint to the GPU to increase performance to provide additional latency savings at a cost of increased power consumption.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 LowLatencyBoost;

        /// <summary>
        ///     <c>MinimumIntervalUs</c> is the microseconds between <c>vkQueuePresentKHR</c> calls for a given swapchain that <c>vkLatencySleepNV</c> will enforce.
        /// </summary>
        [FieldOffset(24)]
        public int MinimumIntervalUs;
    }
}
