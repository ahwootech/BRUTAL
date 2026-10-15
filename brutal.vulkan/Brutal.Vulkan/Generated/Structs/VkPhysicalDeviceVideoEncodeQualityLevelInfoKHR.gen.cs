namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR.html">VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR</see> - Structure describing the video encode profile and quality level to query properties for
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef struct VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             const VkVideoProfileInfoKHR*    pVideoProfile;
    ///             uint32_t                        qualityLevel;
    ///         } VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVideoEncodeQualityLevelInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VideoProfile</c> is a pointer to a <c>VkVideoProfileInfoKHR</c> structure specifying the video profile to query the video encode quality level properties for.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoProfileInfoKHR* VideoProfile;

        /// <summary>
        ///     <c>QualityLevel</c> is the video encode quality level to query properties for.
        /// </summary>
        [FieldOffset(24)]
        public int QualityLevel;
    }
}
