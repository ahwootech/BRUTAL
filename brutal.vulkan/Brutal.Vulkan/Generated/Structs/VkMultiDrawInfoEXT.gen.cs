namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMultiDrawInfoEXT.html">VkMultiDrawInfoEXT</see> - Structure specifying a multi-draw command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMultiDrawInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_multi_draw
    ///         typedef struct VkMultiDrawInfoEXT {
    ///             uint32_t    firstVertex;
    ///             uint32_t    vertexCount;
    ///         } VkMultiDrawInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkMultiDrawInfoEXT()
    {
        /// <summary>
        ///     <c>FirstVertex</c> is the first vertex to draw.
        /// </summary>
        [FieldOffset(0)]
        public int FirstVertex;

        /// <summary>
        ///     <c>VertexCount</c> is the number of vertices to draw.
        /// </summary>
        [FieldOffset(4)]
        public int VertexCount;
    }
}
