namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFormatProperties4KHR.html">VkFormatProperties4KHR</see> - Structure specifying additional image format properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFormatProperties4KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_extended_flags
    ///         typedef struct VkFormatProperties4KHR {
    ///             VkStructureType             sType;
    ///             void*                       pNext;
    ///             VkFormatFeatureFlags4KHR    linearTilingFeatures;
    ///             VkFormatFeatureFlags4KHR    optimalTilingFeatures;
    ///             VkFormatFeatureFlags4KHR    bufferFeatures;
    ///         } VkFormatProperties4KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkFormatProperties4KHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FormatProperties4KHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LinearTilingFeatures</c> is a bitmask of <c>VkFormatFeatureFlags4KHR</c> specifying features supported by images created with a <c>tiling</c> parameter of <c>VK_IMAGE_TILING_LINEAR</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkFormatFeatureFlags4KHR LinearTilingFeatures;

        /// <summary>
        ///     <c>OptimalTilingFeatures</c> is a bitmask of <c>VkFormatFeatureFlags4KHR</c> specifying features supported by images created with a <c>tiling</c> parameter of <c>VK_IMAGE_TILING_OPTIMAL</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkFormatFeatureFlags4KHR OptimalTilingFeatures;

        /// <summary>
        ///     <c>BufferFeatures</c> is a bitmask of <c>VkFormatFeatureFlags4KHR</c> specifying features supported by buffers.
        /// </summary>
        [FieldOffset(32)]
        public VkFormatFeatureFlags4KHR BufferFeatures;
    }
}
