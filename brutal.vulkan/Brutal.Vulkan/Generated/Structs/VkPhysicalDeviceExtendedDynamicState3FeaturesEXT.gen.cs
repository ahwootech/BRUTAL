namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedDynamicState3FeaturesEXT.html">VkPhysicalDeviceExtendedDynamicState3FeaturesEXT</see> - Structure describing what extended dynamic state is supported by the implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExtendedDynamicState3FeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_extended_dynamic_state3
    ///         typedef struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           extendedDynamicState3TessellationDomainOrigin;
    ///             VkBool32           extendedDynamicState3DepthClampEnable;
    ///             VkBool32           extendedDynamicState3PolygonMode;
    ///             VkBool32           extendedDynamicState3RasterizationSamples;
    ///             VkBool32           extendedDynamicState3SampleMask;
    ///             VkBool32           extendedDynamicState3AlphaToCoverageEnable;
    ///             VkBool32           extendedDynamicState3AlphaToOneEnable;
    ///             VkBool32           extendedDynamicState3LogicOpEnable;
    ///             VkBool32           extendedDynamicState3ColorBlendEnable;
    ///             VkBool32           extendedDynamicState3ColorBlendEquation;
    ///             VkBool32           extendedDynamicState3ColorWriteMask;
    ///             VkBool32           extendedDynamicState3RasterizationStream;
    ///             VkBool32           extendedDynamicState3ConservativeRasterizationMode;
    ///             VkBool32           extendedDynamicState3ExtraPrimitiveOverestimationSize;
    ///             VkBool32           extendedDynamicState3DepthClipEnable;
    ///             VkBool32           extendedDynamicState3SampleLocationsEnable;
    ///             VkBool32           extendedDynamicState3ColorBlendAdvanced;
    ///             VkBool32           extendedDynamicState3ProvokingVertexMode;
    ///             VkBool32           extendedDynamicState3LineRasterizationMode;
    ///             VkBool32           extendedDynamicState3LineStippleEnable;
    ///             VkBool32           extendedDynamicState3DepthClipNegativeOneToOne;
    ///             VkBool32           extendedDynamicState3ViewportWScalingEnable;
    ///             VkBool32           extendedDynamicState3ViewportSwizzle;
    ///             VkBool32           extendedDynamicState3CoverageToColorEnable;
    ///             VkBool32           extendedDynamicState3CoverageToColorLocation;
    ///             VkBool32           extendedDynamicState3CoverageModulationMode;
    ///             VkBool32           extendedDynamicState3CoverageModulationTableEnable;
    ///             VkBool32           extendedDynamicState3CoverageModulationTable;
    ///             VkBool32           extendedDynamicState3CoverageReductionMode;
    ///             VkBool32           extendedDynamicState3RepresentativeFragmentTestEnable;
    ///             VkBool32           extendedDynamicState3ShadingRateImageEnable;
    ///         } VkPhysicalDeviceExtendedDynamicState3FeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public unsafe partial struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExtendedDynamicState3FeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExtendedDynamicState3TessellationDomainOrigin</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ExtendedDynamicState3TessellationDomainOrigin;

        /// <summary>
        ///     <c>ExtendedDynamicState3DepthClampEnable</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ExtendedDynamicState3DepthClampEnable;

        /// <summary>
        ///     <c>ExtendedDynamicState3PolygonMode</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ExtendedDynamicState3PolygonMode;

        /// <summary>
        ///     <c>ExtendedDynamicState3RasterizationSamples</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 ExtendedDynamicState3RasterizationSamples;

        /// <summary>
        ///     <c>ExtendedDynamicState3SampleMask</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 ExtendedDynamicState3SampleMask;

        /// <summary>
        ///     <c>ExtendedDynamicState3AlphaToCoverageEnable</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 ExtendedDynamicState3AlphaToCoverageEnable;

        /// <summary>
        ///     <c>ExtendedDynamicState3AlphaToOneEnable</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 ExtendedDynamicState3AlphaToOneEnable;

        /// <summary>
        ///     <c>ExtendedDynamicState3LogicOpEnable</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 ExtendedDynamicState3LogicOpEnable;

        /// <summary>
        ///     <c>ExtendedDynamicState3ColorBlendEnable</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 ExtendedDynamicState3ColorBlendEnable;

        /// <summary>
        ///     <c>ExtendedDynamicState3ColorBlendEquation</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 ExtendedDynamicState3ColorBlendEquation;

        /// <summary>
        ///     <c>ExtendedDynamicState3ColorWriteMask</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 ExtendedDynamicState3ColorWriteMask;

        /// <summary>
        ///     <c>ExtendedDynamicState3RasterizationStream</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 ExtendedDynamicState3RasterizationStream;

        /// <summary>
        ///     <c>ExtendedDynamicState3ConservativeRasterizationMode</c>
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 ExtendedDynamicState3ConservativeRasterizationMode;

        /// <summary>
        ///     <c>ExtendedDynamicState3ExtraPrimitiveOverestimationSize</c>
        /// </summary>
        [FieldOffset(68)]
        public Brutal.Bool32 ExtendedDynamicState3ExtraPrimitiveOverestimationSize;

        /// <summary>
        ///     <c>ExtendedDynamicState3DepthClipEnable</c>
        /// </summary>
        [FieldOffset(72)]
        public Brutal.Bool32 ExtendedDynamicState3DepthClipEnable;

        /// <summary>
        ///     <c>ExtendedDynamicState3SampleLocationsEnable</c>
        /// </summary>
        [FieldOffset(76)]
        public Brutal.Bool32 ExtendedDynamicState3SampleLocationsEnable;

        /// <summary>
        ///     <c>ExtendedDynamicState3ColorBlendAdvanced</c>
        /// </summary>
        [FieldOffset(80)]
        public Brutal.Bool32 ExtendedDynamicState3ColorBlendAdvanced;

        /// <summary>
        ///     <c>ExtendedDynamicState3ProvokingVertexMode</c>
        /// </summary>
        [FieldOffset(84)]
        public Brutal.Bool32 ExtendedDynamicState3ProvokingVertexMode;

        /// <summary>
        ///     <c>ExtendedDynamicState3LineRasterizationMode</c>
        /// </summary>
        [FieldOffset(88)]
        public Brutal.Bool32 ExtendedDynamicState3LineRasterizationMode;

        /// <summary>
        ///     <c>ExtendedDynamicState3LineStippleEnable</c>
        /// </summary>
        [FieldOffset(92)]
        public Brutal.Bool32 ExtendedDynamicState3LineStippleEnable;

        /// <summary>
        ///     <c>ExtendedDynamicState3DepthClipNegativeOneToOne</c>
        /// </summary>
        [FieldOffset(96)]
        public Brutal.Bool32 ExtendedDynamicState3DepthClipNegativeOneToOne;

        /// <summary>
        ///     <c>ExtendedDynamicState3ViewportWScalingEnable</c>
        /// </summary>
        [FieldOffset(100)]
        public Brutal.Bool32 ExtendedDynamicState3ViewportWScalingEnable;

        /// <summary>
        ///     <c>ExtendedDynamicState3ViewportSwizzle</c>
        /// </summary>
        [FieldOffset(104)]
        public Brutal.Bool32 ExtendedDynamicState3ViewportSwizzle;

        /// <summary>
        ///     <c>ExtendedDynamicState3CoverageToColorEnable</c>
        /// </summary>
        [FieldOffset(108)]
        public Brutal.Bool32 ExtendedDynamicState3CoverageToColorEnable;

        /// <summary>
        ///     <c>ExtendedDynamicState3CoverageToColorLocation</c>
        /// </summary>
        [FieldOffset(112)]
        public Brutal.Bool32 ExtendedDynamicState3CoverageToColorLocation;

        /// <summary>
        ///     <c>ExtendedDynamicState3CoverageModulationMode</c>
        /// </summary>
        [FieldOffset(116)]
        public Brutal.Bool32 ExtendedDynamicState3CoverageModulationMode;

        /// <summary>
        ///     <c>ExtendedDynamicState3CoverageModulationTableEnable</c>
        /// </summary>
        [FieldOffset(120)]
        public Brutal.Bool32 ExtendedDynamicState3CoverageModulationTableEnable;

        /// <summary>
        ///     <c>ExtendedDynamicState3CoverageModulationTable</c>
        /// </summary>
        [FieldOffset(124)]
        public Brutal.Bool32 ExtendedDynamicState3CoverageModulationTable;

        /// <summary>
        ///     <c>ExtendedDynamicState3CoverageReductionMode</c>
        /// </summary>
        [FieldOffset(128)]
        public Brutal.Bool32 ExtendedDynamicState3CoverageReductionMode;

        /// <summary>
        ///     <c>ExtendedDynamicState3RepresentativeFragmentTestEnable</c>
        /// </summary>
        [FieldOffset(132)]
        public Brutal.Bool32 ExtendedDynamicState3RepresentativeFragmentTestEnable;

        /// <summary>
        ///     <c>ExtendedDynamicState3ShadingRateImageEnable</c>
        /// </summary>
        [FieldOffset(136)]
        public Brutal.Bool32 ExtendedDynamicState3ShadingRateImageEnable;
    }
}
