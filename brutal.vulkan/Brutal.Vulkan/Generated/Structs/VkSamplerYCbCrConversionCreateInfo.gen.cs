namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionCreateInfo.html">VkSamplerYcbcrConversionCreateInfo</see> - Structure specifying the parameters of the newly created conversion
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSamplerYcbcrConversionCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkSamplerYcbcrConversionCreateInfo {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkFormat                         format;
    ///             VkSamplerYcbcrModelConversion    ycbcrModel;
    ///             VkSamplerYcbcrRange              ycbcrRange;
    ///             VkComponentMapping               components;
    ///             VkChromaLocation                 xChromaOffset;
    ///             VkChromaLocation                 yChromaOffset;
    ///             VkFilter                         chromaFilter;
    ///             VkBool32                         forceExplicitReconstruction;
    ///         } VkSamplerYcbcrConversionCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkSamplerYCbCrConversionCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SamplerYCbCrConversionCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Format</c> is the format of the image from which color information will be retrieved.
        /// </summary>
        [FieldOffset(16)]
        public VkFormat Format;

        /// <summary>
        ///     <c>YcbcrModel</c> describes the color matrix for conversion between color models.
        /// </summary>
        [FieldOffset(20)]
        public VkSamplerYCbCrModelConversion YcbcrModel;

        /// <summary>
        ///     <c>YcbcrRange</c> describes whether the encoded values have headroom and foot room, or whether the encoding uses the full numerical range.
        /// </summary>
        [FieldOffset(24)]
        public VkSamplerYCbCrRange YcbcrRange;

        /// <summary>
        ///     <c>Components</c> applies a <i>swizzle</i> based on <c>VkComponentSwizzle</c> enums prior to range expansion and color model conversion.
        /// </summary>
        [FieldOffset(28)]
        public VkComponentMapping Components;

        /// <summary>
        ///     <c>XChromaOffset</c> describes the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-chroma-reconstruction">sample location^</see> associated with downsampled chroma components in the x dimension. <c>xChromaOffset</c> has no effect for formats in which chroma components are not downsampled horizontally.
        /// </summary>
        [FieldOffset(44)]
        public VkChromaLocation XChromaOffset;

        /// <summary>
        ///     <c>YChromaOffset</c> describes the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-chroma-reconstruction">sample location^</see> associated with downsampled chroma components in the y dimension. <c>yChromaOffset</c> has no effect for formats in which the chroma components are not downsampled vertically.
        /// </summary>
        [FieldOffset(48)]
        public VkChromaLocation YChromaOffset;

        /// <summary>
        ///     <c>ChromaFilter</c> is the filter for chroma reconstruction.
        /// </summary>
        [FieldOffset(52)]
        public VkFilter ChromaFilter;

        /// <summary>
        ///     <c>ForceExplicitReconstruction</c> <i>can</i> be used to ensure that reconstruction is done explicitly, if supported.
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 ForceExplicitReconstruction;
    }
}
