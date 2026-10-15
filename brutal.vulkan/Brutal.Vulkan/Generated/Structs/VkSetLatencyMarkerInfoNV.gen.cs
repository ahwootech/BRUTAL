namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSetLatencyMarkerInfoNV.html">VkSetLatencyMarkerInfoNV</see> - Structure specifying the parameters of vkSetLatencyMarkerNV
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSetLatencyMarkerInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_low_latency2
    ///         typedef struct VkSetLatencyMarkerInfoNV {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             uint64_t             presentID;
    ///             VkLatencyMarkerNV    marker;
    ///         } VkSetLatencyMarkerInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSetLatencyMarkerInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SetLatencyMarkerInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentID</c> is an application provided value that is used to associate the timestamp with a <c>vkQueuePresentKHR</c> command using for a given present.
        /// </summary>
        [FieldOffset(16)]
        public nint PresentID;

        /// <summary>
        ///     <c>Marker</c> is the type of timestamp to be recorded.
        /// </summary>
        [FieldOffset(24)]
        public VkLatencyMarkerNV Marker;
    }
}
