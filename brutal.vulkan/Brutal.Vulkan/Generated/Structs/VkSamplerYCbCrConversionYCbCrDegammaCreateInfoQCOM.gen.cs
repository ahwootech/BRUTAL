namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM.html">VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM</see> - Structure specifying {YCbCr} degamma parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Applications <i>can</i> enable sRGB to linear conversion for the R, G, and B
    ///         components of a {YCbCr} image during <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-YCbCr-degamma">sampling^</see> by
    ///         including <c>VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM</c> structure
    ///         in the <c>pNext</c> chain of <c>VkSamplerYcbcrConversionCreateInfo</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_ycbcr_degamma
    ///         typedef struct VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           enableYDegamma;
    ///             VkBool32           enableCbCrDegamma;
    ///         } VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSamplerYCbCrConversionYCbCrDegammaCreateInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SamplerYCbCrConversionYCbCrDegammaCreateInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>EnableYDegamma</c> indicates <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-YCbCr-degamma">sRGB to linear^</see> conversion is enabled for the G component.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 EnableYDegamma;

        /// <summary>
        ///     <c>EnableCbCrDegamma</c> indicates <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-YCbCr-degamma">sRGB to linear^</see> conversion is enabled for the R and B components.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 EnableCbCrDegamma;
    }
}
