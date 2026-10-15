namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFeatures.html">VkPhysicalDeviceFeatures</see> - Structure describing the fine-grained features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFeatures</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPhysicalDeviceFeatures {
    ///             VkBool32    robustBufferAccess;
    ///             VkBool32    fullDrawIndexUint32;
    ///             VkBool32    imageCubeArray;
    ///             VkBool32    independentBlend;
    ///             VkBool32    geometryShader;
    ///             VkBool32    tessellationShader;
    ///             VkBool32    sampleRateShading;
    ///             VkBool32    dualSrcBlend;
    ///             VkBool32    logicOp;
    ///             VkBool32    multiDrawIndirect;
    ///             VkBool32    drawIndirectFirstInstance;
    ///             VkBool32    depthClamp;
    ///             VkBool32    depthBiasClamp;
    ///             VkBool32    fillModeNonSolid;
    ///             VkBool32    depthBounds;
    ///             VkBool32    wideLines;
    ///             VkBool32    largePoints;
    ///             VkBool32    alphaToOne;
    ///             VkBool32    multiViewport;
    ///             VkBool32    samplerAnisotropy;
    ///             VkBool32    textureCompressionETC2;
    ///             VkBool32    textureCompressionASTC_LDR;
    ///             VkBool32    textureCompressionBC;
    ///             VkBool32    occlusionQueryPrecise;
    ///             VkBool32    pipelineStatisticsQuery;
    ///             VkBool32    vertexPipelineStoresAndAtomics;
    ///             VkBool32    fragmentStoresAndAtomics;
    ///             VkBool32    shaderTessellationAndGeometryPointSize;
    ///             VkBool32    shaderImageGatherExtended;
    ///             VkBool32    shaderStorageImageExtendedFormats;
    ///             VkBool32    shaderStorageImageMultisample;
    ///             VkBool32    shaderStorageImageReadWithoutFormat;
    ///             VkBool32    shaderStorageImageWriteWithoutFormat;
    ///             VkBool32    shaderUniformBufferArrayDynamicIndexing;
    ///             VkBool32    shaderSampledImageArrayDynamicIndexing;
    ///             VkBool32    shaderStorageBufferArrayDynamicIndexing;
    ///             VkBool32    shaderStorageImageArrayDynamicIndexing;
    ///             VkBool32    shaderClipDistance;
    ///             VkBool32    shaderCullDistance;
    ///             VkBool32    shaderFloat64;
    ///             VkBool32    shaderInt64;
    ///             VkBool32    shaderInt16;
    ///             VkBool32    shaderResourceResidency;
    ///             VkBool32    shaderResourceMinLod;
    ///             VkBool32    sparseBinding;
    ///             VkBool32    sparseResidencyBuffer;
    ///             VkBool32    sparseResidencyImage2D;
    ///             VkBool32    sparseResidencyImage3D;
    ///             VkBool32    sparseResidency2Samples;
    ///             VkBool32    sparseResidency4Samples;
    ///             VkBool32    sparseResidency8Samples;
    ///             VkBool32    sparseResidency16Samples;
    ///             VkBool32    sparseResidencyAliased;
    ///             VkBool32    variableMultisampleRate;
    ///             VkBool32    inheritedQueries;
    ///         } VkPhysicalDeviceFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 220)]
    public partial struct VkPhysicalDeviceFeatures()
    {
        /// <summary>
        ///     <c>RobustBufferAccess</c>
        /// </summary>
        [FieldOffset(0)]
        public Brutal.Bool32 RobustBufferAccess;

        /// <summary>
        ///     <c>FullDrawIndexUint32</c>
        /// </summary>
        [FieldOffset(4)]
        public Brutal.Bool32 FullDrawIndexUint32;

        /// <summary>
        ///     <c>ImageCubeArray</c>
        /// </summary>
        [FieldOffset(8)]
        public Brutal.Bool32 ImageCubeArray;

        /// <summary>
        ///     <c>IndependentBlend</c>
        /// </summary>
        [FieldOffset(12)]
        public Brutal.Bool32 IndependentBlend;

        /// <summary>
        ///     <c>GeometryShader</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 GeometryShader;

        /// <summary>
        ///     <c>TessellationShader</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 TessellationShader;

        /// <summary>
        ///     <c>SampleRateShading</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 SampleRateShading;

        /// <summary>
        ///     <c>DualSrcBlend</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 DualSrcBlend;

        /// <summary>
        ///     <c>LogicOp</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 LogicOp;

        /// <summary>
        ///     <c>MultiDrawIndirect</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 MultiDrawIndirect;

        /// <summary>
        ///     <c>DrawIndirectFirstInstance</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 DrawIndirectFirstInstance;

        /// <summary>
        ///     <c>DepthClamp</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 DepthClamp;

        /// <summary>
        ///     <c>DepthBiasClamp</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 DepthBiasClamp;

        /// <summary>
        ///     <c>FillModeNonSolid</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 FillModeNonSolid;

        /// <summary>
        ///     <c>DepthBounds</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 DepthBounds;

        /// <summary>
        ///     <c>WideLines</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 WideLines;

        /// <summary>
        ///     <c>LargePoints</c>
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 LargePoints;

        /// <summary>
        ///     <c>AlphaToOne</c>
        /// </summary>
        [FieldOffset(68)]
        public Brutal.Bool32 AlphaToOne;

        /// <summary>
        ///     <c>MultiViewport</c>
        /// </summary>
        [FieldOffset(72)]
        public Brutal.Bool32 MultiViewport;

        /// <summary>
        ///     <c>SamplerAnisotropy</c>
        /// </summary>
        [FieldOffset(76)]
        public Brutal.Bool32 SamplerAnisotropy;

        /// <summary>
        ///     <c>TextureCompressionETC2</c>
        /// </summary>
        [FieldOffset(80)]
        public Brutal.Bool32 TextureCompressionETC2;

        /// <summary>
        ///     <c>TextureCompressionASTCLDR</c>
        /// </summary>
        [FieldOffset(84)]
        public Brutal.Bool32 TextureCompressionASTCLDR;

        /// <summary>
        ///     <c>TextureCompressionBC</c>
        /// </summary>
        [FieldOffset(88)]
        public Brutal.Bool32 TextureCompressionBC;

        /// <summary>
        ///     <c>OcclusionQueryPrecise</c>
        /// </summary>
        [FieldOffset(92)]
        public Brutal.Bool32 OcclusionQueryPrecise;

        /// <summary>
        ///     <c>PipelineStatisticsQuery</c>
        /// </summary>
        [FieldOffset(96)]
        public Brutal.Bool32 PipelineStatisticsQuery;

        /// <summary>
        ///     <c>VertexPipelineStoresAndAtomics</c>
        /// </summary>
        [FieldOffset(100)]
        public Brutal.Bool32 VertexPipelineStoresAndAtomics;

        /// <summary>
        ///     <c>FragmentStoresAndAtomics</c>
        /// </summary>
        [FieldOffset(104)]
        public Brutal.Bool32 FragmentStoresAndAtomics;

        /// <summary>
        ///     <c>ShaderTessellationAndGeometryPointSize</c>
        /// </summary>
        [FieldOffset(108)]
        public Brutal.Bool32 ShaderTessellationAndGeometryPointSize;

        /// <summary>
        ///     <c>ShaderImageGatherExtended</c>
        /// </summary>
        [FieldOffset(112)]
        public Brutal.Bool32 ShaderImageGatherExtended;

        /// <summary>
        ///     <c>ShaderStorageImageExtendedFormats</c>
        /// </summary>
        [FieldOffset(116)]
        public Brutal.Bool32 ShaderStorageImageExtendedFormats;

        /// <summary>
        ///     <c>ShaderStorageImageMultisample</c>
        /// </summary>
        [FieldOffset(120)]
        public Brutal.Bool32 ShaderStorageImageMultisample;

        /// <summary>
        ///     <c>ShaderStorageImageReadWithoutFormat</c>
        /// </summary>
        [FieldOffset(124)]
        public Brutal.Bool32 ShaderStorageImageReadWithoutFormat;

        /// <summary>
        ///     <c>ShaderStorageImageWriteWithoutFormat</c>
        /// </summary>
        [FieldOffset(128)]
        public Brutal.Bool32 ShaderStorageImageWriteWithoutFormat;

        /// <summary>
        ///     <c>ShaderUniformBufferArrayDynamicIndexing</c>
        /// </summary>
        [FieldOffset(132)]
        public Brutal.Bool32 ShaderUniformBufferArrayDynamicIndexing;

        /// <summary>
        ///     <c>ShaderSampledImageArrayDynamicIndexing</c>
        /// </summary>
        [FieldOffset(136)]
        public Brutal.Bool32 ShaderSampledImageArrayDynamicIndexing;

        /// <summary>
        ///     <c>ShaderStorageBufferArrayDynamicIndexing</c>
        /// </summary>
        [FieldOffset(140)]
        public Brutal.Bool32 ShaderStorageBufferArrayDynamicIndexing;

        /// <summary>
        ///     <c>ShaderStorageImageArrayDynamicIndexing</c>
        /// </summary>
        [FieldOffset(144)]
        public Brutal.Bool32 ShaderStorageImageArrayDynamicIndexing;

        /// <summary>
        ///     <c>ShaderClipDistance</c>
        /// </summary>
        [FieldOffset(148)]
        public Brutal.Bool32 ShaderClipDistance;

        /// <summary>
        ///     <c>ShaderCullDistance</c>
        /// </summary>
        [FieldOffset(152)]
        public Brutal.Bool32 ShaderCullDistance;

        /// <summary>
        ///     <c>ShaderFloat64</c>
        /// </summary>
        [FieldOffset(156)]
        public Brutal.Bool32 ShaderFloat64;

        /// <summary>
        ///     <c>ShaderInt64</c>
        /// </summary>
        [FieldOffset(160)]
        public Brutal.Bool32 ShaderInt64;

        /// <summary>
        ///     <c>ShaderInt16</c>
        /// </summary>
        [FieldOffset(164)]
        public Brutal.Bool32 ShaderInt16;

        /// <summary>
        ///     <c>ShaderResourceResidency</c>
        /// </summary>
        [FieldOffset(168)]
        public Brutal.Bool32 ShaderResourceResidency;

        /// <summary>
        ///     <c>ShaderResourceMinLod</c>
        /// </summary>
        [FieldOffset(172)]
        public Brutal.Bool32 ShaderResourceMinLod;

        /// <summary>
        ///     <c>SparseBinding</c>
        /// </summary>
        [FieldOffset(176)]
        public Brutal.Bool32 SparseBinding;

        /// <summary>
        ///     <c>SparseResidencyBuffer</c>
        /// </summary>
        [FieldOffset(180)]
        public Brutal.Bool32 SparseResidencyBuffer;

        /// <summary>
        ///     <c>SparseResidencyImage2D</c>
        /// </summary>
        [FieldOffset(184)]
        public Brutal.Bool32 SparseResidencyImage2D;

        /// <summary>
        ///     <c>SparseResidencyImage3D</c>
        /// </summary>
        [FieldOffset(188)]
        public Brutal.Bool32 SparseResidencyImage3D;

        /// <summary>
        ///     <c>SparseResidency2Samples</c>
        /// </summary>
        [FieldOffset(192)]
        public Brutal.Bool32 SparseResidency2Samples;

        /// <summary>
        ///     <c>SparseResidency4Samples</c>
        /// </summary>
        [FieldOffset(196)]
        public Brutal.Bool32 SparseResidency4Samples;

        /// <summary>
        ///     <c>SparseResidency8Samples</c>
        /// </summary>
        [FieldOffset(200)]
        public Brutal.Bool32 SparseResidency8Samples;

        /// <summary>
        ///     <c>SparseResidency16Samples</c>
        /// </summary>
        [FieldOffset(204)]
        public Brutal.Bool32 SparseResidency16Samples;

        /// <summary>
        ///     <c>SparseResidencyAliased</c>
        /// </summary>
        [FieldOffset(208)]
        public Brutal.Bool32 SparseResidencyAliased;

        /// <summary>
        ///     <c>VariableMultisampleRate</c>
        /// </summary>
        [FieldOffset(212)]
        public Brutal.Bool32 VariableMultisampleRate;

        /// <summary>
        ///     <c>InheritedQueries</c>
        /// </summary>
        [FieldOffset(216)]
        public Brutal.Bool32 InheritedQueries;
    }
}
