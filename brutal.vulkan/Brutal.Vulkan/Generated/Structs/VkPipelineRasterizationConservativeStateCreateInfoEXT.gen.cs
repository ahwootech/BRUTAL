namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationConservativeStateCreateInfoEXT.html">VkPipelineRasterizationConservativeStateCreateInfoEXT</see> - Structure specifying conservative raster state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkPipelineRasterizationStateCreateInfo</c>
    ///         includes a <c>VkPipelineRasterizationConservativeStateCreateInfoEXT</c>
    ///         structure, then that structure includes parameters controlling conservative
    ///         rasterization.
    ///     </para>
    ///     <para>
    ///         <c>VkPipelineRasterizationConservativeStateCreateInfoEXT</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_conservative_rasterization
    ///         typedef struct VkPipelineRasterizationConservativeStateCreateInfoEXT {
    ///             VkStructureType                                           sType;
    ///             const void*                                               pNext;
    ///             VkPipelineRasterizationConservativeStateCreateFlagsEXT    flags;
    ///             VkConservativeRasterizationModeEXT                        conservativeRasterizationMode;
    ///             float                                                     extraPrimitiveOverestimationSize;
    ///         } VkPipelineRasterizationConservativeStateCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineRasterizationConservativeStateCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineRasterizationConservativeStateCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineRasterizationConservativeStateCreateFlagsEXT Flags;

        /// <summary>
        ///     <c>ConservativeRasterizationMode</c> is the conservative rasterization mode to use.
        /// </summary>
        [FieldOffset(20)]
        public VkConservativeRasterizationModeEXT ConservativeRasterizationMode;

        /// <summary>
        ///     <c>ExtraPrimitiveOverestimationSize</c> is the extra size in pixels to increase the generating primitive during conservative rasterization at each of its edges in `X` and `Y` equally in screen space beyond the base overestimation specified in <c>VkPhysicalDeviceConservativeRasterizationPropertiesEXT::primitiveOverestimationSize</c>. If <c>conservativeRasterizationMode</c> is not <c>VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT</c>, this value is ignored.
        /// </summary>
        [FieldOffset(24)]
        public float ExtraPrimitiveOverestimationSize;
    }
}
