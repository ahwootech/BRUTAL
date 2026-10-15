namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeQualityLevelPropertiesKHR.html">VkVideoEncodeQualityLevelPropertiesKHR</see> - Structure describing the video encode quality level properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeQualityLevelPropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef struct VkVideoEncodeQualityLevelPropertiesKHR {
    ///             VkStructureType                            sType;
    ///             void*                                      pNext;
    ///             VkVideoEncodeRateControlModeFlagBitsKHR    preferredRateControlMode;
    ///             uint32_t                                   preferredRateControlLayerCount;
    ///         } VkVideoEncodeQualityLevelPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeQualityLevelPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeQualityLevelPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PreferredRateControlMode</c> is a <c>VkVideoEncodeRateControlModeFlagsKHR</c> value indicating the preferred <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control-modes">rate control mode^</see> to use with the video encode quality level.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeRateControlModeFlagsKHR PreferredRateControlMode;

        /// <summary>
        ///     <c>PreferredRateControlLayerCount</c> indicates the preferred number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control-layers">rate control layers^</see> to use with the video encode quality level.
        /// </summary>
        [FieldOffset(20)]
        public int PreferredRateControlLayerCount;
    }
}
