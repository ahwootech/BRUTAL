namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeQualityLevelInfoKHR.html">VkVideoEncodeQualityLevelInfoKHR</see> - Structure specifying used video encode quality level
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeQualityLevelInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef struct VkVideoEncodeQualityLevelInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           qualityLevel;
    ///         } VkVideoEncodeQualityLevelInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeQualityLevelInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeQualityLevelInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>QualityLevel</c> is the used video encode quality level.
        /// </summary>
        [FieldOffset(16)]
        public int QualityLevel;
    }
}
