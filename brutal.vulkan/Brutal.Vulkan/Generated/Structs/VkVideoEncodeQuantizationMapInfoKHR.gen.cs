namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeQuantizationMapInfoKHR.html">VkVideoEncodeQuantizationMapInfoKHR</see> - Structure specifying quantization map information to use for video encode operations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeQuantizationMapInfoKHR</c> structure <i>can</i> be included in
    ///         the <c>pNext</c> chain of the <c>VkVideoEncodeInfoKHR</c> structure passed to
    ///         the <c>vkCmdEncodeVideoKHR</c> command to specify the quantization map used
    ///         by the issued video encode operations.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeQuantizationMapInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_quantization_map
    ///         typedef struct VkVideoEncodeQuantizationMapInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkImageView        quantizationMap;
    ///             VkExtent2D         quantizationMapExtent;
    ///         } VkVideoEncodeQuantizationMapInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoEncodeQuantizationMapInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeQuantizationMapInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>QuantizationMap</c> specifies the image view to use as the quantization map.
        /// </summary>
        [FieldOffset(16)]
        public VkImageView QuantizationMap;

        /// <summary>
        ///     <c>QuantizationMapExtent</c> specifies the extent of the image subregion of <c>quantizationMap</c> to use as the quantization map starting at offset <c>(0,0)</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkExtent2D QuantizationMapExtent;
    }
}
