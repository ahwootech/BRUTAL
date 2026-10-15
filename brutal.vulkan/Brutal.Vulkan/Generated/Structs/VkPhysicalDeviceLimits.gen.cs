namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLimits.html">VkPhysicalDeviceLimits</see> - Structure reporting implementation-dependent physical device limits
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceLimits</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPhysicalDeviceLimits {
    ///             uint32_t              maxImageDimension1D;
    ///             uint32_t              maxImageDimension2D;
    ///             uint32_t              maxImageDimension3D;
    ///             uint32_t              maxImageDimensionCube;
    ///             uint32_t              maxImageArrayLayers;
    ///             uint32_t              maxTexelBufferElements;
    ///             uint32_t              maxUniformBufferRange;
    ///             uint32_t              maxStorageBufferRange;
    ///             uint32_t              maxPushConstantsSize;
    ///             uint32_t              maxMemoryAllocationCount;
    ///             uint32_t              maxSamplerAllocationCount;
    ///             VkDeviceSize          bufferImageGranularity;
    ///             VkDeviceSize          sparseAddressSpaceSize;
    ///             uint32_t              maxBoundDescriptorSets;
    ///             uint32_t              maxPerStageDescriptorSamplers;
    ///             uint32_t              maxPerStageDescriptorUniformBuffers;
    ///             uint32_t              maxPerStageDescriptorStorageBuffers;
    ///             uint32_t              maxPerStageDescriptorSampledImages;
    ///             uint32_t              maxPerStageDescriptorStorageImages;
    ///             uint32_t              maxPerStageDescriptorInputAttachments;
    ///             uint32_t              maxPerStageResources;
    ///             uint32_t              maxDescriptorSetSamplers;
    ///             uint32_t              maxDescriptorSetUniformBuffers;
    ///             uint32_t              maxDescriptorSetUniformBuffersDynamic;
    ///             uint32_t              maxDescriptorSetStorageBuffers;
    ///             uint32_t              maxDescriptorSetStorageBuffersDynamic;
    ///             uint32_t              maxDescriptorSetSampledImages;
    ///             uint32_t              maxDescriptorSetStorageImages;
    ///             uint32_t              maxDescriptorSetInputAttachments;
    ///             uint32_t              maxVertexInputAttributes;
    ///             uint32_t              maxVertexInputBindings;
    ///             uint32_t              maxVertexInputAttributeOffset;
    ///             uint32_t              maxVertexInputBindingStride;
    ///             uint32_t              maxVertexOutputComponents;
    ///             uint32_t              maxTessellationGenerationLevel;
    ///             uint32_t              maxTessellationPatchSize;
    ///             uint32_t              maxTessellationControlPerVertexInputComponents;
    ///             uint32_t              maxTessellationControlPerVertexOutputComponents;
    ///             uint32_t              maxTessellationControlPerPatchOutputComponents;
    ///             uint32_t              maxTessellationControlTotalOutputComponents;
    ///             uint32_t              maxTessellationEvaluationInputComponents;
    ///             uint32_t              maxTessellationEvaluationOutputComponents;
    ///             uint32_t              maxGeometryShaderInvocations;
    ///             uint32_t              maxGeometryInputComponents;
    ///             uint32_t              maxGeometryOutputComponents;
    ///             uint32_t              maxGeometryOutputVertices;
    ///             uint32_t              maxGeometryTotalOutputComponents;
    ///             uint32_t              maxFragmentInputComponents;
    ///             uint32_t              maxFragmentOutputAttachments;
    ///             uint32_t              maxFragmentDualSrcAttachments;
    ///             uint32_t              maxFragmentCombinedOutputResources;
    ///             uint32_t              maxComputeSharedMemorySize;
    ///             uint32_t              maxComputeWorkGroupCount[3];
    ///             uint32_t              maxComputeWorkGroupInvocations;
    ///             uint32_t              maxComputeWorkGroupSize[3];
    ///             uint32_t              subPixelPrecisionBits;
    ///             uint32_t              subTexelPrecisionBits;
    ///             uint32_t              mipmapPrecisionBits;
    ///             uint32_t              maxDrawIndexedIndexValue;
    ///             uint32_t              maxDrawIndirectCount;
    ///             float                 maxSamplerLodBias;
    ///             float                 maxSamplerAnisotropy;
    ///             uint32_t              maxViewports;
    ///             uint32_t              maxViewportDimensions[2];
    ///             float                 viewportBoundsRange[2];
    ///             uint32_t              viewportSubPixelBits;
    ///             size_t                minMemoryMapAlignment;
    ///             VkDeviceSize          minTexelBufferOffsetAlignment;
    ///             VkDeviceSize          minUniformBufferOffsetAlignment;
    ///             VkDeviceSize          minStorageBufferOffsetAlignment;
    ///             int32_t               minTexelOffset;
    ///             uint32_t              maxTexelOffset;
    ///             int32_t               minTexelGatherOffset;
    ///             uint32_t              maxTexelGatherOffset;
    ///             float                 minInterpolationOffset;
    ///             float                 maxInterpolationOffset;
    ///             uint32_t              subPixelInterpolationOffsetBits;
    ///             uint32_t              maxFramebufferWidth;
    ///             uint32_t              maxFramebufferHeight;
    ///             uint32_t              maxFramebufferLayers;
    ///             VkSampleCountFlags    framebufferColorSampleCounts;
    ///             VkSampleCountFlags    framebufferDepthSampleCounts;
    ///             VkSampleCountFlags    framebufferStencilSampleCounts;
    ///             VkSampleCountFlags    framebufferNoAttachmentsSampleCounts;
    ///             uint32_t              maxColorAttachments;
    ///             VkSampleCountFlags    sampledImageColorSampleCounts;
    ///             VkSampleCountFlags    sampledImageIntegerSampleCounts;
    ///             VkSampleCountFlags    sampledImageDepthSampleCounts;
    ///             VkSampleCountFlags    sampledImageStencilSampleCounts;
    ///             VkSampleCountFlags    storageImageSampleCounts;
    ///             uint32_t              maxSampleMaskWords;
    ///             VkBool32              timestampComputeAndGraphics;
    ///             float                 timestampPeriod;
    ///             uint32_t              maxClipDistances;
    ///             uint32_t              maxCullDistances;
    ///             uint32_t              maxCombinedClipAndCullDistances;
    ///             uint32_t              discreteQueuePriorities;
    ///             float                 pointSizeRange[2];
    ///             float                 lineWidthRange[2];
    ///             float                 pointSizeGranularity;
    ///             float                 lineWidthGranularity;
    ///             VkBool32              strictLines;
    ///             VkBool32              standardSampleLocations;
    ///             VkDeviceSize          optimalBufferCopyOffsetAlignment;
    ///             VkDeviceSize          optimalBufferCopyRowPitchAlignment;
    ///             VkDeviceSize          nonCoherentAtomSize;
    ///         } VkPhysicalDeviceLimits;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 504)]
    public partial struct VkPhysicalDeviceLimits()
    {
        /// <summary>
        ///     <c>MaxImageDimension1D</c>
        /// </summary>
        [FieldOffset(0)]
        public int MaxImageDimension1D;

        /// <summary>
        ///     <c>MaxImageDimension2D</c>
        /// </summary>
        [FieldOffset(4)]
        public int MaxImageDimension2D;

        /// <summary>
        ///     <c>MaxImageDimension3D</c>
        /// </summary>
        [FieldOffset(8)]
        public int MaxImageDimension3D;

        /// <summary>
        ///     <c>MaxImageDimensionCube</c>
        /// </summary>
        [FieldOffset(12)]
        public int MaxImageDimensionCube;

        /// <summary>
        ///     <c>MaxImageArrayLayers</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxImageArrayLayers;

        /// <summary>
        ///     <c>MaxTexelBufferElements</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxTexelBufferElements;

        /// <summary>
        ///     <c>MaxUniformBufferRange</c>
        /// </summary>
        [FieldOffset(24)]
        public int MaxUniformBufferRange;

        /// <summary>
        ///     <c>MaxStorageBufferRange</c>
        /// </summary>
        [FieldOffset(28)]
        public int MaxStorageBufferRange;

        /// <summary>
        ///     <c>MaxPushConstantsSize</c>
        /// </summary>
        [FieldOffset(32)]
        public int MaxPushConstantsSize;

        /// <summary>
        ///     <c>MaxMemoryAllocationCount</c>
        /// </summary>
        [FieldOffset(36)]
        public int MaxMemoryAllocationCount;

        /// <summary>
        ///     <c>MaxSamplerAllocationCount</c>
        /// </summary>
        [FieldOffset(40)]
        public int MaxSamplerAllocationCount;

        /// <summary>
        ///     <c>BufferImageGranularity</c>
        /// </summary>
        [FieldOffset(48)]
        public ByteSize64 BufferImageGranularity;

        /// <summary>
        ///     <c>SparseAddressSpaceSize</c>
        /// </summary>
        [FieldOffset(56)]
        public ByteSize64 SparseAddressSpaceSize;

        /// <summary>
        ///     <c>MaxBoundDescriptorSets</c>
        /// </summary>
        [FieldOffset(64)]
        public int MaxBoundDescriptorSets;

        /// <summary>
        ///     <c>MaxPerStageDescriptorSamplers</c>
        /// </summary>
        [FieldOffset(68)]
        public int MaxPerStageDescriptorSamplers;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUniformBuffers</c>
        /// </summary>
        [FieldOffset(72)]
        public int MaxPerStageDescriptorUniformBuffers;

        /// <summary>
        ///     <c>MaxPerStageDescriptorStorageBuffers</c>
        /// </summary>
        [FieldOffset(76)]
        public int MaxPerStageDescriptorStorageBuffers;

        /// <summary>
        ///     <c>MaxPerStageDescriptorSampledImages</c>
        /// </summary>
        [FieldOffset(80)]
        public int MaxPerStageDescriptorSampledImages;

        /// <summary>
        ///     <c>MaxPerStageDescriptorStorageImages</c>
        /// </summary>
        [FieldOffset(84)]
        public int MaxPerStageDescriptorStorageImages;

        /// <summary>
        ///     <c>MaxPerStageDescriptorInputAttachments</c>
        /// </summary>
        [FieldOffset(88)]
        public int MaxPerStageDescriptorInputAttachments;

        /// <summary>
        ///     <c>MaxPerStageResources</c>
        /// </summary>
        [FieldOffset(92)]
        public int MaxPerStageResources;

        /// <summary>
        ///     <c>MaxDescriptorSetSamplers</c>
        /// </summary>
        [FieldOffset(96)]
        public int MaxDescriptorSetSamplers;

        /// <summary>
        ///     <c>MaxDescriptorSetUniformBuffers</c>
        /// </summary>
        [FieldOffset(100)]
        public int MaxDescriptorSetUniformBuffers;

        /// <summary>
        ///     <c>MaxDescriptorSetUniformBuffersDynamic</c>
        /// </summary>
        [FieldOffset(104)]
        public int MaxDescriptorSetUniformBuffersDynamic;

        /// <summary>
        ///     <c>MaxDescriptorSetStorageBuffers</c>
        /// </summary>
        [FieldOffset(108)]
        public int MaxDescriptorSetStorageBuffers;

        /// <summary>
        ///     <c>MaxDescriptorSetStorageBuffersDynamic</c>
        /// </summary>
        [FieldOffset(112)]
        public int MaxDescriptorSetStorageBuffersDynamic;

        /// <summary>
        ///     <c>MaxDescriptorSetSampledImages</c>
        /// </summary>
        [FieldOffset(116)]
        public int MaxDescriptorSetSampledImages;

        /// <summary>
        ///     <c>MaxDescriptorSetStorageImages</c>
        /// </summary>
        [FieldOffset(120)]
        public int MaxDescriptorSetStorageImages;

        /// <summary>
        ///     <c>MaxDescriptorSetInputAttachments</c>
        /// </summary>
        [FieldOffset(124)]
        public int MaxDescriptorSetInputAttachments;

        /// <summary>
        ///     <c>MaxVertexInputAttributes</c>
        /// </summary>
        [FieldOffset(128)]
        public int MaxVertexInputAttributes;

        /// <summary>
        ///     <c>MaxVertexInputBindings</c>
        /// </summary>
        [FieldOffset(132)]
        public int MaxVertexInputBindings;

        /// <summary>
        ///     <c>MaxVertexInputAttributeOffset</c>
        /// </summary>
        [FieldOffset(136)]
        public int MaxVertexInputAttributeOffset;

        /// <summary>
        ///     <c>MaxVertexInputBindingStride</c>
        /// </summary>
        [FieldOffset(140)]
        public int MaxVertexInputBindingStride;

        /// <summary>
        ///     <c>MaxVertexOutputComponents</c>
        /// </summary>
        [FieldOffset(144)]
        public int MaxVertexOutputComponents;

        /// <summary>
        ///     <c>MaxTessellationGenerationLevel</c>
        /// </summary>
        [FieldOffset(148)]
        public int MaxTessellationGenerationLevel;

        /// <summary>
        ///     <c>MaxTessellationPatchSize</c>
        /// </summary>
        [FieldOffset(152)]
        public int MaxTessellationPatchSize;

        /// <summary>
        ///     <c>MaxTessellationControlPerVertexInputComponents</c>
        /// </summary>
        [FieldOffset(156)]
        public int MaxTessellationControlPerVertexInputComponents;

        /// <summary>
        ///     <c>MaxTessellationControlPerVertexOutputComponents</c>
        /// </summary>
        [FieldOffset(160)]
        public int MaxTessellationControlPerVertexOutputComponents;

        /// <summary>
        ///     <c>MaxTessellationControlPerPatchOutputComponents</c>
        /// </summary>
        [FieldOffset(164)]
        public int MaxTessellationControlPerPatchOutputComponents;

        /// <summary>
        ///     <c>MaxTessellationControlTotalOutputComponents</c>
        /// </summary>
        [FieldOffset(168)]
        public int MaxTessellationControlTotalOutputComponents;

        /// <summary>
        ///     <c>MaxTessellationEvaluationInputComponents</c>
        /// </summary>
        [FieldOffset(172)]
        public int MaxTessellationEvaluationInputComponents;

        /// <summary>
        ///     <c>MaxTessellationEvaluationOutputComponents</c>
        /// </summary>
        [FieldOffset(176)]
        public int MaxTessellationEvaluationOutputComponents;

        /// <summary>
        ///     <c>MaxGeometryShaderInvocations</c>
        /// </summary>
        [FieldOffset(180)]
        public int MaxGeometryShaderInvocations;

        /// <summary>
        ///     <c>MaxGeometryInputComponents</c>
        /// </summary>
        [FieldOffset(184)]
        public int MaxGeometryInputComponents;

        /// <summary>
        ///     <c>MaxGeometryOutputComponents</c>
        /// </summary>
        [FieldOffset(188)]
        public int MaxGeometryOutputComponents;

        /// <summary>
        ///     <c>MaxGeometryOutputVertices</c>
        /// </summary>
        [FieldOffset(192)]
        public int MaxGeometryOutputVertices;

        /// <summary>
        ///     <c>MaxGeometryTotalOutputComponents</c>
        /// </summary>
        [FieldOffset(196)]
        public int MaxGeometryTotalOutputComponents;

        /// <summary>
        ///     <c>MaxFragmentInputComponents</c>
        /// </summary>
        [FieldOffset(200)]
        public int MaxFragmentInputComponents;

        /// <summary>
        ///     <c>MaxFragmentOutputAttachments</c>
        /// </summary>
        [FieldOffset(204)]
        public int MaxFragmentOutputAttachments;

        /// <summary>
        ///     <c>MaxFragmentDualSrcAttachments</c>
        /// </summary>
        [FieldOffset(208)]
        public int MaxFragmentDualSrcAttachments;

        /// <summary>
        ///     <c>MaxFragmentCombinedOutputResources</c>
        /// </summary>
        [FieldOffset(212)]
        public int MaxFragmentCombinedOutputResources;

        /// <summary>
        ///     <c>MaxComputeSharedMemorySize</c>
        /// </summary>
        [FieldOffset(216)]
        public int MaxComputeSharedMemorySize;

        /// <summary>
        ///     <c>MaxComputeWorkGroupCount</c>
        /// </summary>
        [FieldOffset(220)]
        public uint3 MaxComputeWorkGroupCount;

        /// <summary>
        ///     <c>MaxComputeWorkGroupInvocations</c>
        /// </summary>
        [FieldOffset(232)]
        public int MaxComputeWorkGroupInvocations;

        /// <summary>
        ///     <c>MaxComputeWorkGroupSize</c>
        /// </summary>
        [FieldOffset(236)]
        public uint3 MaxComputeWorkGroupSize;

        /// <summary>
        ///     <c>SubPixelPrecisionBits</c>
        /// </summary>
        [FieldOffset(248)]
        public int SubPixelPrecisionBits;

        /// <summary>
        ///     <c>SubTexelPrecisionBits</c>
        /// </summary>
        [FieldOffset(252)]
        public int SubTexelPrecisionBits;

        /// <summary>
        ///     <c>MipmapPrecisionBits</c>
        /// </summary>
        [FieldOffset(256)]
        public int MipmapPrecisionBits;

        /// <summary>
        ///     <c>MaxDrawIndexedIndexValue</c>
        /// </summary>
        [FieldOffset(260)]
        public int MaxDrawIndexedIndexValue;

        /// <summary>
        ///     <c>MaxDrawIndirectCount</c>
        /// </summary>
        [FieldOffset(264)]
        public int MaxDrawIndirectCount;

        /// <summary>
        ///     <c>MaxSamplerLodBias</c>
        /// </summary>
        [FieldOffset(268)]
        public float MaxSamplerLodBias;

        /// <summary>
        ///     <c>MaxSamplerAnisotropy</c>
        /// </summary>
        [FieldOffset(272)]
        public float MaxSamplerAnisotropy;

        /// <summary>
        ///     <c>MaxViewports</c>
        /// </summary>
        [FieldOffset(276)]
        public int MaxViewports;

        /// <summary>
        ///     <c>MaxViewportDimensions</c>
        /// </summary>
        [FieldOffset(280)]
        public uint2 MaxViewportDimensions;

        /// <summary>
        ///     <c>ViewportBoundsRange</c>
        /// </summary>
        [FieldOffset(288)]
        public float2 ViewportBoundsRange;

        /// <summary>
        ///     <c>ViewportSubPixelBits</c>
        /// </summary>
        [FieldOffset(296)]
        public int ViewportSubPixelBits;

        /// <summary>
        ///     <c>MinMemoryMapAlignment</c>
        /// </summary>
        [FieldOffset(304)]
        public nuint MinMemoryMapAlignment;

        /// <summary>
        ///     <c>MinTexelBufferOffsetAlignment</c>
        /// </summary>
        [FieldOffset(312)]
        public ByteSize64 MinTexelBufferOffsetAlignment;

        /// <summary>
        ///     <c>MinUniformBufferOffsetAlignment</c>
        /// </summary>
        [FieldOffset(320)]
        public ByteSize64 MinUniformBufferOffsetAlignment;

        /// <summary>
        ///     <c>MinStorageBufferOffsetAlignment</c>
        /// </summary>
        [FieldOffset(328)]
        public ByteSize64 MinStorageBufferOffsetAlignment;

        /// <summary>
        ///     <c>MinTexelOffset</c>
        /// </summary>
        [FieldOffset(336)]
        public int MinTexelOffset;

        /// <summary>
        ///     <c>MaxTexelOffset</c>
        /// </summary>
        [FieldOffset(340)]
        public int MaxTexelOffset;

        /// <summary>
        ///     <c>MinTexelGatherOffset</c>
        /// </summary>
        [FieldOffset(344)]
        public int MinTexelGatherOffset;

        /// <summary>
        ///     <c>MaxTexelGatherOffset</c>
        /// </summary>
        [FieldOffset(348)]
        public int MaxTexelGatherOffset;

        /// <summary>
        ///     <c>MinInterpolationOffset</c>
        /// </summary>
        [FieldOffset(352)]
        public float MinInterpolationOffset;

        /// <summary>
        ///     <c>MaxInterpolationOffset</c>
        /// </summary>
        [FieldOffset(356)]
        public float MaxInterpolationOffset;

        /// <summary>
        ///     <c>SubPixelInterpolationOffsetBits</c>
        /// </summary>
        [FieldOffset(360)]
        public int SubPixelInterpolationOffsetBits;

        /// <summary>
        ///     <c>MaxFramebufferWidth</c>
        /// </summary>
        [FieldOffset(364)]
        public int MaxFramebufferWidth;

        /// <summary>
        ///     <c>MaxFramebufferHeight</c>
        /// </summary>
        [FieldOffset(368)]
        public int MaxFramebufferHeight;

        /// <summary>
        ///     <c>MaxFramebufferLayers</c>
        /// </summary>
        [FieldOffset(372)]
        public int MaxFramebufferLayers;

        /// <summary>
        ///     <c>FramebufferColorSampleCounts</c>
        /// </summary>
        [FieldOffset(376)]
        public VkSampleCountFlags FramebufferColorSampleCounts;

        /// <summary>
        ///     <c>FramebufferDepthSampleCounts</c>
        /// </summary>
        [FieldOffset(380)]
        public VkSampleCountFlags FramebufferDepthSampleCounts;

        /// <summary>
        ///     <c>FramebufferStencilSampleCounts</c>
        /// </summary>
        [FieldOffset(384)]
        public VkSampleCountFlags FramebufferStencilSampleCounts;

        /// <summary>
        ///     <c>FramebufferNoAttachmentsSampleCounts</c>
        /// </summary>
        [FieldOffset(388)]
        public VkSampleCountFlags FramebufferNoAttachmentsSampleCounts;

        /// <summary>
        ///     <c>MaxColorAttachments</c>
        /// </summary>
        [FieldOffset(392)]
        public int MaxColorAttachments;

        /// <summary>
        ///     <c>SampledImageColorSampleCounts</c>
        /// </summary>
        [FieldOffset(396)]
        public VkSampleCountFlags SampledImageColorSampleCounts;

        /// <summary>
        ///     <c>SampledImageIntegerSampleCounts</c>
        /// </summary>
        [FieldOffset(400)]
        public VkSampleCountFlags SampledImageIntegerSampleCounts;

        /// <summary>
        ///     <c>SampledImageDepthSampleCounts</c>
        /// </summary>
        [FieldOffset(404)]
        public VkSampleCountFlags SampledImageDepthSampleCounts;

        /// <summary>
        ///     <c>SampledImageStencilSampleCounts</c>
        /// </summary>
        [FieldOffset(408)]
        public VkSampleCountFlags SampledImageStencilSampleCounts;

        /// <summary>
        ///     <c>StorageImageSampleCounts</c>
        /// </summary>
        [FieldOffset(412)]
        public VkSampleCountFlags StorageImageSampleCounts;

        /// <summary>
        ///     <c>MaxSampleMaskWords</c>
        /// </summary>
        [FieldOffset(416)]
        public int MaxSampleMaskWords;

        /// <summary>
        ///     <c>TimestampComputeAndGraphics</c>
        /// </summary>
        [FieldOffset(420)]
        public Brutal.Bool32 TimestampComputeAndGraphics;

        /// <summary>
        ///     <c>TimestampPeriod</c>
        /// </summary>
        [FieldOffset(424)]
        public float TimestampPeriod;

        /// <summary>
        ///     <c>MaxClipDistances</c>
        /// </summary>
        [FieldOffset(428)]
        public int MaxClipDistances;

        /// <summary>
        ///     <c>MaxCullDistances</c>
        /// </summary>
        [FieldOffset(432)]
        public int MaxCullDistances;

        /// <summary>
        ///     <c>MaxCombinedClipAndCullDistances</c>
        /// </summary>
        [FieldOffset(436)]
        public int MaxCombinedClipAndCullDistances;

        /// <summary>
        ///     <c>DiscreteQueuePriorities</c>
        /// </summary>
        [FieldOffset(440)]
        public int DiscreteQueuePriorities;

        /// <summary>
        ///     <c>PointSizeRange</c>
        /// </summary>
        [FieldOffset(444)]
        public float2 PointSizeRange;

        /// <summary>
        ///     <c>LineWidthRange</c>
        /// </summary>
        [FieldOffset(452)]
        public float2 LineWidthRange;

        /// <summary>
        ///     <c>PointSizeGranularity</c>
        /// </summary>
        [FieldOffset(460)]
        public float PointSizeGranularity;

        /// <summary>
        ///     <c>LineWidthGranularity</c>
        /// </summary>
        [FieldOffset(464)]
        public float LineWidthGranularity;

        /// <summary>
        ///     <c>StrictLines</c>
        /// </summary>
        [FieldOffset(468)]
        public Brutal.Bool32 StrictLines;

        /// <summary>
        ///     <c>StandardSampleLocations</c>
        /// </summary>
        [FieldOffset(472)]
        public Brutal.Bool32 StandardSampleLocations;

        /// <summary>
        ///     <c>OptimalBufferCopyOffsetAlignment</c>
        /// </summary>
        [FieldOffset(480)]
        public ByteSize64 OptimalBufferCopyOffsetAlignment;

        /// <summary>
        ///     <c>OptimalBufferCopyRowPitchAlignment</c>
        /// </summary>
        [FieldOffset(488)]
        public ByteSize64 OptimalBufferCopyRowPitchAlignment;

        /// <summary>
        ///     <c>NonCoherentAtomSize</c>
        /// </summary>
        [FieldOffset(496)]
        public ByteSize64 NonCoherentAtomSize;
    }
}
