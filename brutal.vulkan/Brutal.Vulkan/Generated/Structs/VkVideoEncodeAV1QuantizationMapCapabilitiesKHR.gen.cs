namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1QuantizationMapCapabilitiesKHR.html">VkVideoEncodeAV1QuantizationMapCapabilitiesKHR</see> - Structure describing AV1 encode quantization map capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> to query the
    ///         capabilities of an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-profile">AV1 encode profile^</see>, the
    ///         <c>VkVideoEncodeAV1QuantizationMapCapabilitiesKHR</c> structure <i>can</i> be
    ///         included in the <c>pNext</c> chain of the <c>VkVideoCapabilitiesKHR</c>
    ///         structure to retrieve additional video encode quantization map capabilities
    ///         specific to AV1 encode profiles.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeAV1QuantizationMapCapabilitiesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1 with VK_KHR_video_encode_quantization_map
    ///         typedef struct VkVideoEncodeAV1QuantizationMapCapabilitiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             int32_t            minQIndexDelta;
    ///             int32_t            maxQIndexDelta;
    ///         } VkVideoEncodeAV1QuantizationMapCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeAV1QuantizationMapCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeAV1QuantizationMapCapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MinQIndexDelta</c> indicates the minimum quantizer index delta value supported for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-qindex-delta-map">AV1 quantizer index delta maps^</see>.
        /// </summary>
        [FieldOffset(16)]
        public int MinQIndexDelta;

        /// <summary>
        ///     <c>MaxQIndexDelta</c> indicates the maximum quantizer index delta value supported for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-qindex-delta-map">AV1 quantizer index delta maps^</see>.
        /// </summary>
        [FieldOffset(20)]
        public int MaxQIndexDelta;
    }
}
