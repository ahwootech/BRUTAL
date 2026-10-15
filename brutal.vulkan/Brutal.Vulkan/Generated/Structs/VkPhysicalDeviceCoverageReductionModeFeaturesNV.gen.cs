namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCoverageReductionModeFeaturesNV.html">VkPhysicalDeviceCoverageReductionModeFeaturesNV</see> - Structure describing the coverage reduction mode features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCoverageReductionModeFeaturesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_coverage_reduction_mode
    ///         typedef struct VkPhysicalDeviceCoverageReductionModeFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           coverageReductionMode;
    ///         } VkPhysicalDeviceCoverageReductionModeFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCoverageReductionModeFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCoverageReductionModeFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CoverageReductionMode</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 CoverageReductionMode;
    }
}
