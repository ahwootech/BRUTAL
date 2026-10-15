namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoReferenceIntraRefreshInfoKHR.html">VkVideoReferenceIntraRefreshInfoKHR</see> - Structure specifying video reference picture intra refresh parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoReferenceIntraRefreshInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_intra_refresh
    ///         typedef struct VkVideoReferenceIntraRefreshInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           dirtyIntraRefreshRegions;
    ///         } VkVideoReferenceIntraRefreshInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoReferenceIntraRefreshInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoReferenceIntraRefreshInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DirtyIntraRefreshRegions</c> is the number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-dirty-intra-refresh-regions">dirty intra refresh regions^</see> in the reference picture.
        /// </summary>
        [FieldOffset(16)]
        public int DirtyIntraRefreshRegions;
    }
}
