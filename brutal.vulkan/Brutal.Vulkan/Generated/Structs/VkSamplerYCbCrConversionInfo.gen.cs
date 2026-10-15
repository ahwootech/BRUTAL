namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionInfo.html">VkSamplerYcbcrConversionInfo</see> - Structure specifying {YCbCr} conversion to a sampler or image view
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To create a sampler with {YCbCr} conversion enabled, add a
    ///         <c>VkSamplerYcbcrConversionInfo</c> structure to the <c>pNext</c> chain of the
    ///         <c>VkSamplerCreateInfo</c> structure.
    ///         To create a sampler {YCbCr} conversion, the
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-samplerYcbcrConversion"><c>samplerYcbcrConversion</c>^</see> feature
    ///         <i>must</i> be enabled.
    ///         Conversion <i>must</i> be fixed at pipeline creation time, through use of
    ///         a combined image sampler with an immutable sampler in
    ///         <c>VkDescriptorSetLayoutBinding</c>.
    ///     </para>
    ///     <para>
    ///         A <c>VkSamplerYcbcrConversionInfo</c> <i>must</i> be provided for samplers to be
    ///         used with image views that access <c>VK_IMAGE_ASPECT_COLOR_BIT</c> if the
    ///         format is one of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#formats-requiring-sampler-ycbcr-conversion">formats
    ///         that require a sampler {YCbCr} conversion^</see>
    ///         .
    ///     </para>
    ///     <para>
    ///         The <c>VkSamplerYcbcrConversionInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkSamplerYcbcrConversionInfo {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkSamplerYcbcrConversion    conversion;
    ///         } VkSamplerYcbcrConversionInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSamplerYCbCrConversionInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SamplerYCbCrConversionInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Conversion</c> is a <c>VkSamplerYcbcrConversion</c> handle created with <c>vkCreateSamplerYcbcrConversion</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkSamplerYCbCrConversion Conversion;
    }
}
