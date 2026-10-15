namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterDescriptionARM.html">VkPerformanceCounterDescriptionARM</see> - Structure providing more detailed information about a counter
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerformanceCounterDescriptionARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_performance_counters_by_region
    ///         typedef struct VkPerformanceCounterDescriptionARM {
    ///             VkStructureType                            sType;
    ///             void*                                      pNext;
    ///             VkPerformanceCounterDescriptionFlagsARM    flags;
    ///             char                                       name[VK_MAX_DESCRIPTION_SIZE];
    ///         } VkPerformanceCounterDescriptionARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 280)]
    public unsafe partial struct VkPerformanceCounterDescriptionARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PerformanceCounterDescriptionARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPerformanceCounterDescriptionFlagsARM Flags;

        ///
        [FieldOffset(20)]
        public fixed byte Name[256];
    }
}
