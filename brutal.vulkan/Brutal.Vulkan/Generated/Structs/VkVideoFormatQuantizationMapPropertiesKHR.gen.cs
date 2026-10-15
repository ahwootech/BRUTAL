namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoFormatQuantizationMapPropertiesKHR.html">VkVideoFormatQuantizationMapPropertiesKHR</see> - Structure describing quantization map properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoFormatPropertiesKHR</c>, the
    ///         <c>VkVideoFormatQuantizationMapPropertiesKHR</c> structure <i>can</i> be included
    ///         in the <c>pNext</c> chain of the <c>VkVideoFormatPropertiesKHR</c> structure
    ///         to retrieve video format properties specific to video encode quantization
    ///         maps.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoFormatQuantizationMapPropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_quantization_map
    ///         typedef struct VkVideoFormatQuantizationMapPropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkExtent2D         quantizationMapTexelSize;
    ///         } VkVideoFormatQuantizationMapPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoFormatQuantizationMapPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoFormatQuantizationMapPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>QuantizationMapTexelSize</c> indicates the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-quantization-map-texel-size">quantization map texel size^</see> of the video format, i.e. the number of pixels corresponding to each quantization map texel.
        /// </summary>
        [FieldOffset(16)]
        public VkExtent2D QuantizationMapTexelSize;
    }
}
