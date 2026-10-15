namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265QuantizationMapCapabilitiesKHR.html">VkVideoEncodeH265QuantizationMapCapabilitiesKHR</see> - Structure describing H.265 encode quantization map capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> to query the
    ///         capabilities of an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-profile">H.265 encode profile^</see>, the
    ///         <c>VkVideoEncodeH265QuantizationMapCapabilitiesKHR</c> structure <i>can</i> be
    ///         included in the <c>pNext</c> chain of the <c>VkVideoCapabilitiesKHR</c>
    ///         structure to retrieve additional video encode quantization map capabilities
    ///         specific to H.265 encode profiles.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeH265QuantizationMapCapabilitiesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265 with VK_KHR_video_encode_quantization_map
    ///         typedef struct VkVideoEncodeH265QuantizationMapCapabilitiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             int32_t            minQpDelta;
    ///             int32_t            maxQpDelta;
    ///         } VkVideoEncodeH265QuantizationMapCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeH265QuantizationMapCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH265QuantizationMapCapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MinQpDelta</c> indicates the minimum QP delta value supported for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-qp-delta-map">H.265 QP delta maps^</see>.
        /// </summary>
        [FieldOffset(16)]
        public int MinQpDelta;

        /// <summary>
        ///     <c>MaxQpDelta</c> indicates the maximum QP delta value supported for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-qp-delta-map">H.265 QP delta maps^</see>.
        /// </summary>
        [FieldOffset(20)]
        public int MaxQpDelta;
    }
}
