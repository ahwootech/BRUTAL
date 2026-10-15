namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeProfileRgbConversionInfoVALVE.html">VkVideoEncodeProfileRgbConversionInfoVALVE</see> - Structure describing video encode RGB conversion for a video profile
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A video profile supporting video encode {RGBprime} conversion is specified
    ///         by an <c>pVideoProfile</c>-&gt;videoCodecOperation specifying an encode
    ///         operation and including a <c>VkVideoEncodeProfileRgbConversionInfoVALVE</c>
    ///         structure in the <c>pNext</c> chain of the <c>VkVideoProfileInfoKHR</c>
    ///         structure and enabling <c>performEncodeRgbConversion</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeProfileRgbConversionInfoVALVE</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_video_encode_rgb_conversion
    ///         typedef struct VkVideoEncodeProfileRgbConversionInfoVALVE {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           performEncodeRgbConversion;
    ///         } VkVideoEncodeProfileRgbConversionInfoVALVE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeProfileRGBConversionInfoVALVE()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeProfileRGBConversionInfoVALVE;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PerformEncodeRgbConversion</c> is a boolean value indicating whether video encode {RGBprime} conversion will be used for the encode operation.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PerformEncodeRgbConversion;
    }
}
