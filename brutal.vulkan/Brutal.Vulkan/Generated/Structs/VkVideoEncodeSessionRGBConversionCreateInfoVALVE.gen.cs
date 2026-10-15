namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeSessionRgbConversionCreateInfoVALVE.html">VkVideoEncodeSessionRgbConversionCreateInfoVALVE</see> - Structure specifying video encode RGB conversion parameters for a video session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeSessionRgbConversionCreateInfoVALVE</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_video_encode_rgb_conversion
    ///         typedef struct VkVideoEncodeSessionRgbConversionCreateInfoVALVE {
    ///             VkStructureType                                  sType;
    ///             const void*                                      pNext;
    ///             VkVideoEncodeRgbModelConversionFlagBitsVALVE     rgbModel;
    ///             VkVideoEncodeRgbRangeCompressionFlagBitsVALVE    rgbRange;
    ///             VkVideoEncodeRgbChromaOffsetFlagBitsVALVE        xChromaOffset;
    ///             VkVideoEncodeRgbChromaOffsetFlagBitsVALVE        yChromaOffset;
    ///         } VkVideoEncodeSessionRgbConversionCreateInfoVALVE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoEncodeSessionRGBConversionCreateInfoVALVE()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeSessionRGBConversionCreateInfoVALVE;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RgbModel</c> is the used <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rgb-conversion-model-conversion">{RGBprime} model conversion^</see> for the {RGBprime} conversion.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeRGBModelConversionFlagsVALVE RgbModel;

        /// <summary>
        ///     <c>RgbRange</c> is the used <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rgb-conversion-range-compression">{RGBprime} range compression^</see> for the {RGBprime} conversion.
        /// </summary>
        [FieldOffset(20)]
        public VkVideoEncodeRGBRangeCompressionFlagsVALVE RgbRange;

        /// <summary>
        ///     <c>XChromaOffset</c> describes the output location of downsampled chroma components in the x dimension for the {RGBprime} conversion.
        /// </summary>
        [FieldOffset(24)]
        public VkVideoEncodeRGBChromaOffsetFlagsVALVE XChromaOffset;

        /// <summary>
        ///     <c>YChromaOffset</c> describes the output location of downsampled chroma components in the y dimension for the {RGBprime} conversion.
        /// </summary>
        [FieldOffset(28)]
        public VkVideoEncodeRGBChromaOffsetFlagsVALVE YChromaOffset;
    }
}
