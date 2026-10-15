namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeQuantizationMapCapabilitiesKHR.html">VkVideoEncodeQuantizationMapCapabilitiesKHR</see> - Structure describing video encode quantization map capabilities for a video profile
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> with
    ///         <c>pVideoProfile</c>-&gt;videoCodecOperation specifying an encode operation, the
    ///         <c>VkVideoEncodeQuantizationMapCapabilitiesKHR</c> structure <i>can</i> be included
    ///         in the <c>pNext</c> chain of the <c>VkVideoCapabilitiesKHR</c> structure to
    ///         retrieve capabilities specific to video encode quantization maps.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeQuantizationMapCapabilitiesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_quantization_map
    ///         typedef struct VkVideoEncodeQuantizationMapCapabilitiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkExtent2D         maxQuantizationMapExtent;
    ///         } VkVideoEncodeQuantizationMapCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeQuantizationMapCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeQuantizationMapCapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxQuantizationMapExtent</c> indicates the maximum supported width and height of quantization maps.
        /// </summary>
        [FieldOffset(16)]
        public VkExtent2D MaxQuantizationMapExtent;
    }
}
