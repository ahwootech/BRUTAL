namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePortabilitySubsetFeaturesKHR.html">VkPhysicalDevicePortabilitySubsetFeaturesKHR</see> - Structure describing the features that may not be supported by an implementation of the Vulkan 1.0 Portability Subset
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePortabilitySubsetFeaturesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_portability_subset
    ///         typedef struct VkPhysicalDevicePortabilitySubsetFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           constantAlphaColorBlendFactors;
    ///             VkBool32           events;
    ///             VkBool32           imageViewFormatReinterpretation;
    ///             VkBool32           imageViewFormatSwizzle;
    ///             VkBool32           imageView2DOn3DImage;
    ///             VkBool32           multisampleArrayImage;
    ///             VkBool32           mutableComparisonSamplers;
    ///             VkBool32           pointPolygons;
    ///             VkBool32           samplerMipLodBias;
    ///             VkBool32           separateStencilMaskRef;
    ///             VkBool32           shaderSampleRateInterpolationFunctions;
    ///             VkBool32           tessellationIsolines;
    ///             VkBool32           tessellationPointMode;
    ///             VkBool32           triangleFans;
    ///             VkBool32           vertexAttributeAccessBeyondStride;
    ///         } VkPhysicalDevicePortabilitySubsetFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public unsafe partial struct VkPhysicalDevicePortabilitySubsetFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePortabilitySubsetFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ConstantAlphaColorBlendFactors</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ConstantAlphaColorBlendFactors;

        /// <summary>
        ///     <c>Events</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 Events;

        /// <summary>
        ///     <c>ImageViewFormatReinterpretation</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ImageViewFormatReinterpretation;

        /// <summary>
        ///     <c>ImageViewFormatSwizzle</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 ImageViewFormatSwizzle;

        /// <summary>
        ///     <c>ImageView2DOn3DImage</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 ImageView2DOn3DImage;

        /// <summary>
        ///     <c>MultisampleArrayImage</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 MultisampleArrayImage;

        /// <summary>
        ///     <c>MutableComparisonSamplers</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 MutableComparisonSamplers;

        /// <summary>
        ///     <c>PointPolygons</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 PointPolygons;

        /// <summary>
        ///     <c>SamplerMipLodBias</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 SamplerMipLodBias;

        /// <summary>
        ///     <c>SeparateStencilMaskRef</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 SeparateStencilMaskRef;

        /// <summary>
        ///     <c>ShaderSampleRateInterpolationFunctions</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 ShaderSampleRateInterpolationFunctions;

        /// <summary>
        ///     <c>TessellationIsolines</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 TessellationIsolines;

        /// <summary>
        ///     <c>TessellationPointMode</c>
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 TessellationPointMode;

        /// <summary>
        ///     <c>TriangleFans</c>
        /// </summary>
        [FieldOffset(68)]
        public Brutal.Bool32 TriangleFans;

        /// <summary>
        ///     <c>VertexAttributeAccessBeyondStride</c>
        /// </summary>
        [FieldOffset(72)]
        public Brutal.Bool32 VertexAttributeAccessBeyondStride;
    }
}
