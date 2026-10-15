namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceOverrideInfoINTEL.html">VkPerformanceOverrideInfoINTEL</see> - Performance override information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerformanceOverrideInfoINTEL</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         typedef struct VkPerformanceOverrideInfoINTEL {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkPerformanceOverrideTypeINTEL    type;
    ///             VkBool32                          enable;
    ///             uint64_t                          parameter;
    ///         } VkPerformanceOverrideInfoINTEL;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPerformanceOverrideInfoINTEL()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PerformanceOverrideInfoINTEL;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Type</c> is the particular <c>VkPerformanceOverrideTypeINTEL</c> to set.
        /// </summary>
        [FieldOffset(16)]
        public VkPerformanceOverrideTypeINTEL Type;

        /// <summary>
        ///     <c>Enable</c> defines whether the override is enabled.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 Enable;

        /// <summary>
        ///     <c>Parameter</c> is a potential required parameter for the override.
        /// </summary>
        [FieldOffset(24)]
        public nint Parameter;
    }
}
