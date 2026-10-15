namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceConfigurationAcquireInfoINTEL.html">VkPerformanceConfigurationAcquireInfoINTEL</see> - Acquire a configuration to capture performance data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerformanceConfigurationAcquireInfoINTEL</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         typedef struct VkPerformanceConfigurationAcquireInfoINTEL {
    ///             VkStructureType                        sType;
    ///             const void*                            pNext;
    ///             VkPerformanceConfigurationTypeINTEL    type;
    ///         } VkPerformanceConfigurationAcquireInfoINTEL;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPerformanceConfigurationAcquireInfoINTEL()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PerformanceConfigurationAcquireInfoINTEL;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Type</c> is one of the <c>VkPerformanceConfigurationTypeINTEL</c> type of performance configuration that will be acquired.
        /// </summary>
        [FieldOffset(16)]
        public VkPerformanceConfigurationTypeINTEL Type;
    }
}
