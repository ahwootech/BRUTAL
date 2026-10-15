namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterDescriptionKHR.html">VkPerformanceCounterDescriptionKHR</see> - Structure providing more detailed information about a counter
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerformanceCounterDescriptionKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_performance_query
    ///         typedef struct VkPerformanceCounterDescriptionKHR {
    ///             VkStructureType                            sType;
    ///             void*                                      pNext;
    ///             VkPerformanceCounterDescriptionFlagsKHR    flags;
    ///             char                                       name[VK_MAX_DESCRIPTION_SIZE];
    ///             char                                       category[VK_MAX_DESCRIPTION_SIZE];
    ///             char                                       description[VK_MAX_DESCRIPTION_SIZE];
    ///         } VkPerformanceCounterDescriptionKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 792)]
    public unsafe partial struct VkPerformanceCounterDescriptionKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PerformanceCounterDescriptionKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkPerformanceCounterDescriptionFlagsKHR</c> indicating the usage behavior for the counter.
        /// </summary>
        [FieldOffset(16)]
        public VkPerformanceCounterDescriptionFlagsKHR Flags;

        ///
        [FieldOffset(20)]
        public fixed byte Name[256];

        ///
        [FieldOffset(276)]
        public fixed byte Category[256];

        ///
        [FieldOffset(532)]
        public fixed byte Description[256];
    }
}
