namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDrawIndexedIndirectCommand.html">VkDrawIndexedIndirectCommand</see> - Structure specifying an indexed indirect drawing command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDrawIndexedIndirectCommand
    ///     </para>
    ///     <para>
    ///         The <c>VkDrawIndexedIndirectCommand</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkDrawIndexedIndirectCommand {
    ///             uint32_t    indexCount;
    ///             uint32_t    instanceCount;
    ///             uint32_t    firstIndex;
    ///             int32_t     vertexOffset;
    ///             uint32_t    firstInstance;
    ///         } VkDrawIndexedIndirectCommand;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct VkDrawIndexedIndirectCommand()
    {
        /// <summary>
        ///     <c>IndexCount</c> is the number of vertices to draw.
        /// </summary>
        [FieldOffset(0)]
        public int IndexCount;

        /// <summary>
        ///     <c>InstanceCount</c> is the number of instances to draw.
        /// </summary>
        [FieldOffset(4)]
        public int InstanceCount;

        /// <summary>
        ///     <c>FirstIndex</c> is the base index within the index buffer.
        /// </summary>
        [FieldOffset(8)]
        public int FirstIndex;

        /// <summary>
        ///     <c>VertexOffset</c> is the value added to the vertex index before indexing into the vertex buffer.
        /// </summary>
        [FieldOffset(12)]
        public int VertexOffset;

        /// <summary>
        ///     <c>FirstInstance</c> is the instance ID of the first instance to draw.
        /// </summary>
        [FieldOffset(16)]
        public int FirstInstance;
    }
}
