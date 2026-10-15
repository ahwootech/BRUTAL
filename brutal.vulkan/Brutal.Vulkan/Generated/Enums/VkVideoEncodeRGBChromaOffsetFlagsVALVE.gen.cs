namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRgbChromaOffsetFlagBitsVALVE.html">VkVideoEncodeRgbChromaOffsetFlagBitsVALVE</see> - Position of downsampled chroma samples for encode RGB conversion
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The model-converted values are chroma subsampled and quantized, according to
    ///         the <c>chromaSubsampling</c>, <c>lumaBitDepth</c> and <c>chromaBitDepth</c>
    ///         values specified by the bound video session.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeRgbChromaOffsetFlagsVALVE</c> enum defines the
    ///         location of downsampled chroma component samples relative to the luma
    ///         samples for video encode {RGBprime} conversion, and is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_video_encode_rgb_conversion
    ///         typedef enum VkVideoEncodeRgbChromaOffsetFlagBitsVALVE {
    ///             VK_VIDEO_ENCODE_RGB_CHROMA_OFFSET_COSITED_EVEN_BIT_VALVE = 0x00000001,
    ///             VK_VIDEO_ENCODE_RGB_CHROMA_OFFSET_MIDPOINT_BIT_VALVE = 0x00000002,
    ///         } VkVideoEncodeRgbChromaOffsetFlagBitsVALVE;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeRGBChromaOffsetFlagsVALVE : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>CositedEvenBitVALVE</c> specifies that downsampled chroma samples are aligned with luma samples with even coordinates.
        /// </summary>
        CositedEvenBitVALVE = 0x00000001,

        /// <summary>
        ///     <c>MidpointBitVALVE</c> specifies that downsampled chroma samples are located half way between each even luma sample and the nearest higher odd luma sample.  The output location of downsampled chroma components are specified by the <c>xChromaOffset</c> and <c>yChromaOffset</c> values of the <c>VkVideoEncodeSessionRgbConversionCreateInfoVALVE</c> structure:  Chroma subsampling is described in more detail in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-chroma-reconstruction">Chroma Reconstruction^</see> section.
        /// </summary>
        MidpointBitVALVE = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnumVALVE</c>
        /// </summary>
        FlagBitsMaxEnumVALVE = 0x7FFFFFFF,
    }
}
