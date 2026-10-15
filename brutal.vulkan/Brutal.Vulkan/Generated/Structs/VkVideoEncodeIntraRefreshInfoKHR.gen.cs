namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeIntraRefreshInfoKHR.html">VkVideoEncodeIntraRefreshInfoKHR</see> - Structure specifying video encode intra refresh parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeIntraRefreshInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_intra_refresh
    ///         typedef struct VkVideoEncodeIntraRefreshInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           intraRefreshCycleDuration;
    ///             uint32_t           intraRefreshIndex;
    ///         } VkVideoEncodeIntraRefreshInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeIntraRefreshInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeIntraRefreshInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>IntraRefreshCycleDuration</c> is the used <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-intra-refresh-cycle-duration">intra refresh cycle duration^</see>.
        /// </summary>
        [FieldOffset(16)]
        public int IntraRefreshCycleDuration;

        /// <summary>
        ///     <c>IntraRefreshIndex</c> is the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-intra-refresh-index">intra refresh index^</see> of the encoded picture.
        /// </summary>
        [FieldOffset(20)]
        public int IntraRefreshIndex;
    }
}
