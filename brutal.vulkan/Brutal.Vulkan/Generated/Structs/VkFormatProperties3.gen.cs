namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFormatProperties3.html">VkFormatProperties3</see> - Structure specifying image format properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To query supported format extended features which are properties of the
    ///         physical device, add <c>VkFormatProperties3</c> structure to the <c>pNext</c>
    ///         chain of <c>VkFormatProperties2</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkFormatProperties3</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkFormatProperties3 {
    ///             VkStructureType          sType;
    ///             void*                    pNext;
    ///             VkFormatFeatureFlags2    linearTilingFeatures;
    ///             VkFormatFeatureFlags2    optimalTilingFeatures;
    ///             VkFormatFeatureFlags2    bufferFeatures;
    ///         } VkFormatProperties3;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkFormatProperties3()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FormatProperties3;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LinearTilingFeatures</c> is a bitmask of <c>VkFormatFeatureFlags2</c> specifying features supported by images created with a <c>tiling</c> parameter of <c>VK_IMAGE_TILING_LINEAR</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkFormatFeatureFlags2 LinearTilingFeatures;

        /// <summary>
        ///     <c>OptimalTilingFeatures</c> is a bitmask of <c>VkFormatFeatureFlags2</c> specifying features supported by images created with a <c>tiling</c> parameter of <c>VK_IMAGE_TILING_OPTIMAL</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkFormatFeatureFlags2 OptimalTilingFeatures;

        /// <summary>
        ///     <c>BufferFeatures</c> is a bitmask of <c>VkFormatFeatureFlags2</c> specifying features supported by buffers.
        /// </summary>
        [FieldOffset(32)]
        public VkFormatFeatureFlags2 BufferFeatures;
    }
}
