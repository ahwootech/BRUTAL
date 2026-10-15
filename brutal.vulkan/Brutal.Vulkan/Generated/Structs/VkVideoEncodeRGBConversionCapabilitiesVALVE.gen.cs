namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRgbConversionCapabilitiesVALVE.html">VkVideoEncodeRgbConversionCapabilitiesVALVE</see> - Structure describing video encode rgb conversion capabilities for a video profile
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> with
    ///         <c>pVideoProfile</c>-&gt;videoCodecOperation specifying an encode operation, the
    ///         <c>VkVideoEncodeRgbConversionCapabilitiesVALVE</c> structure <i>can</i> be included
    ///         in the <c>pNext</c> chain of the <c>VkVideoCapabilitiesKHR</c> structure to
    ///         retrieve capabilities specific to video encode {RGBprime} conversion.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeRgbConversionCapabilitiesVALVE</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_video_encode_rgb_conversion
    ///         typedef struct VkVideoEncodeRgbConversionCapabilitiesVALVE {
    ///             VkStructureType                               sType;
    ///             void*                                         pNext;
    ///             VkVideoEncodeRgbModelConversionFlagsVALVE     rgbModels;
    ///             VkVideoEncodeRgbRangeCompressionFlagsVALVE    rgbRanges;
    ///             VkVideoEncodeRgbChromaOffsetFlagsVALVE        xChromaOffsets;
    ///             VkVideoEncodeRgbChromaOffsetFlagsVALVE        yChromaOffsets;
    ///         } VkVideoEncodeRgbConversionCapabilitiesVALVE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoEncodeRGBConversionCapabilitiesVALVE()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeRGBConversionCapabilitiesVALVE;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RgbModels</c> is a bitmask of <c>VkVideoEncodeRgbModelConversionFlagsVALVE</c> describing supported <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rgb-conversion-model-conversion">model conversions^</see> for video encode {RGBprime} conversion.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeRGBModelConversionFlagsVALVE RgbModels;

        /// <summary>
        ///     <c>RgbRanges</c> is a bitmask of <c>VkVideoEncodeRgbRangeCompressionFlagsVALVE</c> describing supported <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rgb-conversion-range-compression">range compressions^</see> for video encode {RGBprime} conversion.
        /// </summary>
        [FieldOffset(20)]
        public VkVideoEncodeRGBRangeCompressionFlagsVALVE RgbRanges;

        /// <summary>
        ///     <c>XChromaOffsets</c> is a bitmask of <c>VkVideoEncodeRgbChromaOffsetFlagsVALVE</c> describing supported offsets of the output location of the downsampled chroma component on the X axis for video encode {RGBprime} conversion.
        /// </summary>
        [FieldOffset(24)]
        public VkVideoEncodeRGBChromaOffsetFlagsVALVE XChromaOffsets;

        /// <summary>
        ///     <c>YChromaOffsets</c> is a bitmask of <c>VkVideoEncodeRgbChromaOffsetFlagsVALVE</c> describing supported offsets of the output location of the downsampled chroma component on the Y axis for video encode {RGBprime} conversion.
        /// </summary>
        [FieldOffset(28)]
        public VkVideoEncodeRGBChromaOffsetFlagsVALVE YChromaOffsets;
    }
}
