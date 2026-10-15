namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDepthClampRangeEXT.html">VkDepthClampRangeEXT</see> - Structure specifying a depth clamp range
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDepthClampRangeEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_depth_clamp_control
    ///         typedef struct VkDepthClampRangeEXT {
    ///             float    minDepthClamp;
    ///             float    maxDepthClamp;
    ///         } VkDepthClampRangeEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkDepthClampRangeEXT()
    {
        /// <summary>
        ///     <c>MinDepthClamp</c> sets <c>z~min~</c> in the depth clamp range of the viewport.
        /// </summary>
        [FieldOffset(0)]
        public float MinDepthClamp;

        /// <summary>
        ///     <c>MaxDepthClamp</c> sets <c>z~max~</c> in the depth clamp range of the viewport.
        /// </summary>
        [FieldOffset(4)]
        public float MaxDepthClamp;
    }
}
