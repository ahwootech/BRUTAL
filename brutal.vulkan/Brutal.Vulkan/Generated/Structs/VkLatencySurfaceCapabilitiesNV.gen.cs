namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkLatencySurfaceCapabilitiesNV.html">VkLatencySurfaceCapabilitiesNV</see> - Structure describing surface optimized presentation modes for use with low latency mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkLatencySurfaceCapabilitiesNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_low_latency2
    ///         typedef struct VkLatencySurfaceCapabilitiesNV {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             uint32_t             presentModeCount;
    ///             VkPresentModeKHR*    pPresentModes;
    ///         } VkLatencySurfaceCapabilitiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkLatencySurfaceCapabilitiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.LatencySurfaceCapabilitiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentModeCount</c> is the number of presentation modes provided.
        /// </summary>
        [FieldOffset(16)]
        public int PresentModeCount;

        /// <summary>
        ///     <c>PresentModes</c> is list of presentation modes optimized for use with low latency mode with <c>presentModeCount</c> entries.
        /// </summary>
        [FieldOffset(24)]
        public VkPresentModeKHR* PresentModes;
    }
}
