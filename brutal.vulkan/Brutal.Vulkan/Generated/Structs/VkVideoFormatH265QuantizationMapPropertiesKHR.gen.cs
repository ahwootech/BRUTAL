namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoFormatH265QuantizationMapPropertiesKHR.html">VkVideoFormatH265QuantizationMapPropertiesKHR</see> - Structure describing H.265 quantization map properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoFormatPropertiesKHR</c>, the
    ///         <c>VkVideoFormatH265QuantizationMapPropertiesKHR</c> structure <i>can</i> be
    ///         included in the <c>pNext</c> chain of the <c>VkVideoFormatPropertiesKHR</c>
    ///         structure to retrieve video format properties specific to video encode
    ///         quantization maps used with an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-profile">H.265 encode profile^</see>.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoFormatH265QuantizationMapPropertiesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265 with VK_KHR_video_encode_quantization_map
    ///         typedef struct VkVideoFormatH265QuantizationMapPropertiesKHR {
    ///             VkStructureType                     sType;
    ///             void*                               pNext;
    ///             VkVideoEncodeH265CtbSizeFlagsKHR    compatibleCtbSizes;
    ///         } VkVideoFormatH265QuantizationMapPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoFormatH265QuantizationMapPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoFormatH265QuantizationMapPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CompatibleCtbSizes</c> is a bitmask of <c>VkVideoEncodeH265CtbSizeFlagsKHR</c> indicating the CTB sizes that quantization maps using this video format are compatible with. + [NOTE]
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeH265CtbSizeFlagsKHR CompatibleCtbSizes;
    }
}
