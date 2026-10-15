namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceConservativeRasterizationPropertiesEXT.html">VkPhysicalDeviceConservativeRasterizationPropertiesEXT</see> - Structure describing conservative raster properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceConservativeRasterizationPropertiesEXT</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_conservative_rasterization
    ///         typedef struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             float              primitiveOverestimationSize;
    ///             float              maxExtraPrimitiveOverestimationSize;
    ///             float              extraPrimitiveOverestimationSizeGranularity;
    ///             VkBool32           primitiveUnderestimation;
    ///             VkBool32           conservativePointAndLineRasterization;
    ///             VkBool32           degenerateTrianglesRasterized;
    ///             VkBool32           degenerateLinesRasterized;
    ///             VkBool32           fullyCoveredFragmentShaderInputVariable;
    ///             VkBool32           conservativeRasterizationPostDepthCoverage;
    ///         } VkPhysicalDeviceConservativeRasterizationPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceConservativeRasterizationPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PrimitiveOverestimationSize</c>
        /// </summary>
        [FieldOffset(16)]
        public float PrimitiveOverestimationSize;

        /// <summary>
        ///     <c>MaxExtraPrimitiveOverestimationSize</c>
        /// </summary>
        [FieldOffset(20)]
        public float MaxExtraPrimitiveOverestimationSize;

        /// <summary>
        ///     <c>ExtraPrimitiveOverestimationSizeGranularity</c>
        /// </summary>
        [FieldOffset(24)]
        public float ExtraPrimitiveOverestimationSizeGranularity;

        /// <summary>
        ///     <c>PrimitiveUnderestimation</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 PrimitiveUnderestimation;

        /// <summary>
        ///     <c>ConservativePointAndLineRasterization</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 ConservativePointAndLineRasterization;

        /// <summary>
        ///     <c>DegenerateTrianglesRasterized</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 DegenerateTrianglesRasterized;

        /// <summary>
        ///     <c>DegenerateLinesRasterized</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 DegenerateLinesRasterized;

        /// <summary>
        ///     <c>FullyCoveredFragmentShaderInputVariable</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 FullyCoveredFragmentShaderInputVariable;

        /// <summary>
        ///     <c>ConservativeRasterizationPostDepthCoverage</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 ConservativeRasterizationPostDepthCoverage;
    }
}
