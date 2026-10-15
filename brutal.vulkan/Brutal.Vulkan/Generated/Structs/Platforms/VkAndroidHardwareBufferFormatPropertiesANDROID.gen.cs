using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Android
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAndroidHardwareBufferFormatPropertiesANDROID.html">VkAndroidHardwareBufferFormatPropertiesANDROID</see> - Structure describing the image format properties of an Android hardware buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To obtain format properties of an Android hardware buffer, include a
    ///         <c>VkAndroidHardwareBufferFormatPropertiesANDROID</c> structure in the
    ///         <c>pNext</c> chain of the <c>VkAndroidHardwareBufferPropertiesANDROID</c>
    ///         structure passed to <c>vkGetAndroidHardwareBufferPropertiesANDROID</c>.
    ///         This structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ANDROID_external_memory_android_hardware_buffer
    ///         typedef struct VkAndroidHardwareBufferFormatPropertiesANDROID {
    ///             VkStructureType                  sType;
    ///             void*                            pNext;
    ///             VkFormat                         format;
    ///             uint64_t                         externalFormat;
    ///             VkFormatFeatureFlags             formatFeatures;
    ///             VkComponentMapping               samplerYcbcrConversionComponents;
    ///             VkSamplerYcbcrModelConversion    suggestedYcbcrModel;
    ///             VkSamplerYcbcrRange              suggestedYcbcrRange;
    ///             VkChromaLocation                 suggestedXChromaOffset;
    ///             VkChromaLocation                 suggestedYChromaOffset;
    ///         } VkAndroidHardwareBufferFormatPropertiesANDROID;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    [SupportedOSPlatform("android")]
    public unsafe partial struct VkAndroidHardwareBufferFormatPropertiesANDROID()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ANDROIDHardwareBufferFormatPropertiesANDROID;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Format</c> is the Vulkan format corresponding to the Android hardware buffer&apos;s format, or <c>VK_FORMAT_UNDEFINED</c> if there is not an equivalent Vulkan format.
        /// </summary>
        [FieldOffset(16)]
        public VkFormat Format;

        /// <summary>
        ///     <c>ExternalFormat</c> is an implementation-defined external format identifier for use with <c>VkExternalFormatANDROID</c>. It <i>must</i> not be zero.
        /// </summary>
        [FieldOffset(24)]
        public nint ExternalFormat;

        /// <summary>
        ///     <c>FormatFeatures</c> describes the capabilities of this external format when used with an image bound to memory imported from <c>buffer</c>.
        /// </summary>
        [FieldOffset(32)]
        public VkFormatFeatureFlags FormatFeatures;

        /// <summary>
        ///     <c>SamplerYcbcrConversionComponents</c> is the component swizzle that <i>should</i> be used in <c>VkSamplerYcbcrConversionCreateInfo</c>.
        /// </summary>
        [FieldOffset(36)]
        public VkComponentMapping SamplerYcbcrConversionComponents;

        /// <summary>
        ///     <c>SuggestedYcbcrModel</c> is a suggested color model to use in the <c>VkSamplerYcbcrConversionCreateInfo</c>.
        /// </summary>
        [FieldOffset(52)]
        public VkSamplerYCbCrModelConversion SuggestedYcbcrModel;

        /// <summary>
        ///     <c>SuggestedYcbcrRange</c> is a suggested numerical value range to use in <c>VkSamplerYcbcrConversionCreateInfo</c>.
        /// </summary>
        [FieldOffset(56)]
        public VkSamplerYCbCrRange SuggestedYcbcrRange;

        /// <summary>
        ///     <c>SuggestedXChromaOffset</c> is a suggested X chroma offset to use in <c>VkSamplerYcbcrConversionCreateInfo</c>.
        /// </summary>
        [FieldOffset(60)]
        public VkChromaLocation SuggestedXChromaOffset;

        /// <summary>
        ///     <c>SuggestedYChromaOffset</c> is a suggested Y chroma offset to use in <c>VkSamplerYcbcrConversionCreateInfo</c>.
        /// </summary>
        [FieldOffset(64)]
        public VkChromaLocation SuggestedYChromaOffset;
    }
}
