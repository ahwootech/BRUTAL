namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainTimingPropertiesEXT.html">VkSwapchainTimingPropertiesEXT</see> - Structure containing the RC duration of a display
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSwapchainTimingPropertiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef struct VkSwapchainTimingPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint64_t           refreshDuration;
    ///             uint64_t           refreshInterval;
    ///         } VkSwapchainTimingPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSwapchainTimingPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SwapchainTimingPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RefreshDuration</c> is zero or an indication of the duration of a refresh cycle.
        /// </summary>
        [FieldOffset(16)]
        public nint RefreshDuration;

        /// <summary>
        ///     <c>RefreshInterval</c> is zero or a duration in nanoseconds indicating the interval between refresh cycle durations.
        /// </summary>
        [FieldOffset(24)]
        public nint RefreshInterval;
    }
}
