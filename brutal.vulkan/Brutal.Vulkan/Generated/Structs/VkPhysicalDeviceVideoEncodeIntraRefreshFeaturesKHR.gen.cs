namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVideoEncodeIntraRefreshFeaturesKHR.html">VkPhysicalDeviceVideoEncodeIntraRefreshFeaturesKHR</see> - Structure describing the video encode intra refresh features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVideoEncodeIntraRefreshFeaturesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_intra_refresh
    ///         typedef struct VkPhysicalDeviceVideoEncodeIntraRefreshFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           videoEncodeIntraRefresh;
    ///         } VkPhysicalDeviceVideoEncodeIntraRefreshFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceVideoEncodeIntraRefreshFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVideoEncodeIntraRefreshFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VideoEncodeIntraRefresh</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 VideoEncodeIntraRefresh;
    }
}
