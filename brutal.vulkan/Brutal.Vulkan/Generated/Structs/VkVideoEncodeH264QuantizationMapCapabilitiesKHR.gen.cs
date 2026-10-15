namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264QuantizationMapCapabilitiesKHR.html">VkVideoEncodeH264QuantizationMapCapabilitiesKHR</see> - Structure describing H.264 encode quantization map capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> to query the
    ///         capabilities of an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-profile">H.264 encode profile^</see>, the
    ///         <c>VkVideoEncodeH264QuantizationMapCapabilitiesKHR</c> structure <i>can</i> be
    ///         included in the <c>pNext</c> chain of the <c>VkVideoCapabilitiesKHR</c>
    ///         structure to retrieve additional video encode quantization map capabilities
    ///         specific to H.264 encode profiles.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeH264QuantizationMapCapabilitiesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264 with VK_KHR_video_encode_quantization_map
    ///         typedef struct VkVideoEncodeH264QuantizationMapCapabilitiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             int32_t            minQpDelta;
    ///             int32_t            maxQpDelta;
    ///         } VkVideoEncodeH264QuantizationMapCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeH264QuantizationMapCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH264QuantizationMapCapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MinQpDelta</c> indicates the minimum QP delta value supported for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-qp-delta-map">H.264 QP delta maps^</see>.
        /// </summary>
        [FieldOffset(16)]
        public int MinQpDelta;

        /// <summary>
        ///     <c>MaxQpDelta</c> indicates the maximum QP delta value supported for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-qp-delta-map">H.264 QP delta maps^</see>.
        /// </summary>
        [FieldOffset(20)]
        public int MaxQpDelta;
    }
}
