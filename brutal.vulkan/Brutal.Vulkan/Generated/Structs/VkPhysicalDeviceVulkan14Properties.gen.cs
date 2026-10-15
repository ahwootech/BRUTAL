namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan14Properties.html">VkPhysicalDeviceVulkan14Properties</see> - Structure specifying physical device properties for functionality promoted to Vulkan 1.4
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVulkan14Properties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceVulkan14Properties {
    ///             VkStructureType                       sType;
    ///             void*                                 pNext;
    ///             uint32_t                              lineSubPixelPrecisionBits;
    ///             uint32_t                              maxVertexAttribDivisor;
    ///             VkBool32                              supportsNonZeroFirstInstance;
    ///             uint32_t                              maxPushDescriptors;
    ///             VkBool32                              dynamicRenderingLocalReadDepthStencilAttachments;
    ///             VkBool32                              dynamicRenderingLocalReadMultisampledAttachments;
    ///             VkBool32                              earlyFragmentMultisampleCoverageAfterSampleCounting;
    ///             VkBool32                              earlyFragmentSampleMaskTestBeforeSampleCounting;
    ///             VkBool32                              depthStencilSwizzleOneSupport;
    ///             VkBool32                              polygonModePointSize;
    ///             VkBool32                              nonStrictSinglePixelWideLinesUseParallelogram;
    ///             VkBool32                              nonStrictWideLinesUseParallelogram;
    ///             VkBool32                              blockTexelViewCompatibleMultipleLayers;
    ///             uint32_t                              maxCombinedImageSamplerDescriptorCount;
    ///             VkBool32                              fragmentShadingRateClampCombinerInputs;
    ///             VkPipelineRobustnessBufferBehavior    defaultRobustnessStorageBuffers;
    ///             VkPipelineRobustnessBufferBehavior    defaultRobustnessUniformBuffers;
    ///             VkPipelineRobustnessBufferBehavior    defaultRobustnessVertexInputs;
    ///             VkPipelineRobustnessImageBehavior     defaultRobustnessImages;
    ///             uint32_t                              copySrcLayoutCount;
    ///             VkImageLayout*                        pCopySrcLayouts;
    ///             uint32_t                              copyDstLayoutCount;
    ///             VkImageLayout*                        pCopyDstLayouts;
    ///             uint8_t                               optimalTilingLayoutUUID[VK_UUID_SIZE];
    ///             VkBool32                              identicalMemoryTypeRequirements;
    ///         } VkPhysicalDeviceVulkan14Properties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public unsafe partial struct VkPhysicalDeviceVulkan14Properties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVulkan14Properties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LineSubPixelPrecisionBits</c>
        /// </summary>
        [FieldOffset(16)]
        public int LineSubPixelPrecisionBits;

        /// <summary>
        ///     <c>MaxVertexAttribDivisor</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxVertexAttribDivisor;

        /// <summary>
        ///     <c>SupportsNonZeroFirstInstance</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 SupportsNonZeroFirstInstance;

        /// <summary>
        ///     <c>MaxPushDescriptors</c>
        /// </summary>
        [FieldOffset(28)]
        public int MaxPushDescriptors;

        /// <summary>
        ///     <c>DynamicRenderingLocalReadDepthStencilAttachments</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 DynamicRenderingLocalReadDepthStencilAttachments;

        /// <summary>
        ///     <c>DynamicRenderingLocalReadMultisampledAttachments</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 DynamicRenderingLocalReadMultisampledAttachments;

        /// <summary>
        ///     <c>EarlyFragmentMultisampleCoverageAfterSampleCounting</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 EarlyFragmentMultisampleCoverageAfterSampleCounting;

        /// <summary>
        ///     <c>EarlyFragmentSampleMaskTestBeforeSampleCounting</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 EarlyFragmentSampleMaskTestBeforeSampleCounting;

        /// <summary>
        ///     <c>DepthStencilSwizzleOneSupport</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 DepthStencilSwizzleOneSupport;

        /// <summary>
        ///     <c>PolygonModePointSize</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 PolygonModePointSize;

        /// <summary>
        ///     <c>NonStrictSinglePixelWideLinesUseParallelogram</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 NonStrictSinglePixelWideLinesUseParallelogram;

        /// <summary>
        ///     <c>NonStrictWideLinesUseParallelogram</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 NonStrictWideLinesUseParallelogram;

        /// <summary>
        ///     <c>BlockTexelViewCompatibleMultipleLayers</c>
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 BlockTexelViewCompatibleMultipleLayers;

        /// <summary>
        ///     <c>MaxCombinedImageSamplerDescriptorCount</c>
        /// </summary>
        [FieldOffset(68)]
        public int MaxCombinedImageSamplerDescriptorCount;

        /// <summary>
        ///     <c>FragmentShadingRateClampCombinerInputs</c>
        /// </summary>
        [FieldOffset(72)]
        public Brutal.Bool32 FragmentShadingRateClampCombinerInputs;

        /// <summary>
        ///     <c>DefaultRobustnessStorageBuffers</c>
        /// </summary>
        [FieldOffset(76)]
        public VkPipelineRobustnessBufferBehavior DefaultRobustnessStorageBuffers;

        /// <summary>
        ///     <c>DefaultRobustnessUniformBuffers</c>
        /// </summary>
        [FieldOffset(80)]
        public VkPipelineRobustnessBufferBehavior DefaultRobustnessUniformBuffers;

        /// <summary>
        ///     <c>DefaultRobustnessVertexInputs</c>
        /// </summary>
        [FieldOffset(84)]
        public VkPipelineRobustnessBufferBehavior DefaultRobustnessVertexInputs;

        /// <summary>
        ///     <c>DefaultRobustnessImages</c>
        /// </summary>
        [FieldOffset(88)]
        public VkPipelineRobustnessImageBehavior DefaultRobustnessImages;

        /// <summary>
        ///     <c>CopySrcLayoutCount</c>
        /// </summary>
        [FieldOffset(92)]
        public int CopySrcLayoutCount;

        /// <summary>
        ///     <c>CopySrcLayouts</c>
        /// </summary>
        [FieldOffset(96)]
        public VkImageLayout* CopySrcLayouts;

        /// <summary>
        ///     <c>CopyDstLayoutCount</c>
        /// </summary>
        [FieldOffset(104)]
        public int CopyDstLayoutCount;

        /// <summary>
        ///     <c>CopyDstLayouts</c>
        /// </summary>
        [FieldOffset(112)]
        public VkImageLayout* CopyDstLayouts;

        ///
        [FieldOffset(120)]
        public fixed byte OptimalTilingLayoutUUID[16];

        /// <summary>
        ///     <c>IdenticalMemoryTypeRequirements</c>
        /// </summary>
        [FieldOffset(136)]
        public Brutal.Bool32 IdenticalMemoryTypeRequirements;
    }
}
