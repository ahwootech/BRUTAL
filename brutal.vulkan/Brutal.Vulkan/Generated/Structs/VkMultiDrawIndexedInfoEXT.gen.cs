namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMultiDrawIndexedInfoEXT.html">VkMultiDrawIndexedInfoEXT</see> - Structure specifying a multi-draw command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMultiDrawIndexedInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_multi_draw
    ///         typedef struct VkMultiDrawIndexedInfoEXT {
    ///             uint32_t    firstIndex;
    ///             uint32_t    indexCount;
    ///             int32_t     vertexOffset;
    ///         } VkMultiDrawIndexedInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkMultiDrawIndexedInfoEXT()
    {
        /// <summary>
        ///     <c>FirstIndex</c> is the first index to draw.
        /// </summary>
        [FieldOffset(0)]
        public int FirstIndex;

        /// <summary>
        ///     <c>IndexCount</c> is the number of vertices to draw.
        /// </summary>
        [FieldOffset(4)]
        public int IndexCount;

        /// <summary>
        ///     <c>VertexOffset</c> is the value added to the vertex index before indexing into the vertex buffer for indexed multidraws.
        /// </summary>
        [FieldOffset(8)]
        public int VertexOffset;
    }
}
