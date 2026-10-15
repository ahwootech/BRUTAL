namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeQuantizationMapSessionParametersCreateInfoKHR.html">VkVideoEncodeQuantizationMapSessionParametersCreateInfoKHR</see> - Structure specifying quantization map texel size for video session parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeQuantizationMapSessionParametersCreateInfoKHR</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_quantization_map
    ///         typedef struct VkVideoEncodeQuantizationMapSessionParametersCreateInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkExtent2D         quantizationMapTexelSize;
    ///         } VkVideoEncodeQuantizationMapSessionParametersCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeQuantizationMapSessionParametersCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.VideoEncodeQuantizationMapSessionParametersCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>QuantizationMapTexelSize</c> specifies the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-quantization-map-texel-size">quantization map texel size^</see> a video session parameters object created with <c>VK_VIDEO_SESSION_PARAMETERS_CREATE_QUANTIZATION_MAP_COMPATIBLE_BIT_KHR</c> is compatible with.
        /// </summary>
        [FieldOffset(16)]
        public VkExtent2D QuantizationMapTexelSize;
    }
}
