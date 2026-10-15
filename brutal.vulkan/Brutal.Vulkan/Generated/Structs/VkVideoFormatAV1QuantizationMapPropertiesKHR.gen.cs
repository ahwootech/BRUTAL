namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoFormatAV1QuantizationMapPropertiesKHR.html">VkVideoFormatAV1QuantizationMapPropertiesKHR</see> - Structure describing AV1 quantization map properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoFormatPropertiesKHR</c>, the
    ///         <c>VkVideoFormatAV1QuantizationMapPropertiesKHR</c> structure <i>can</i> be
    ///         included in the <c>pNext</c> chain of the <c>VkVideoFormatPropertiesKHR</c>
    ///         structure to retrieve video format properties specific to video encode
    ///         quantization maps used with an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-profile">AV1 encode profile^</see>.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoFormatAV1QuantizationMapPropertiesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1 with VK_KHR_video_encode_quantization_map
    ///         typedef struct VkVideoFormatAV1QuantizationMapPropertiesKHR {
    ///             VkStructureType                           sType;
    ///             void*                                     pNext;
    ///             VkVideoEncodeAV1SuperblockSizeFlagsKHR    compatibleSuperblockSizes;
    ///         } VkVideoFormatAV1QuantizationMapPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoFormatAV1QuantizationMapPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoFormatAV1QuantizationMapPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CompatibleSuperblockSizes</c> is a bitmask of <c>VkVideoEncodeAV1SuperblockSizeFlagsKHR</c> indicating the AV1 superblock sizes that quantization maps using this video format are compatible with. + [NOTE]
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeAV1SuperblockSizeFlagsKHR CompatibleSuperblockSizes;
    }
}
