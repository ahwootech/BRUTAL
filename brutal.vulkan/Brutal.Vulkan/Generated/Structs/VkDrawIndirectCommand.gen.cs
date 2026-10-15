namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDrawIndirectCommand.html">VkDrawIndirectCommand</see> - Structure specifying an indirect drawing command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDrawIndirectCommand
    ///     </para>
    ///     <para>
    ///         The <c>VkDrawIndirectCommand</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkDrawIndirectCommand {
    ///             uint32_t    vertexCount;
    ///             uint32_t    instanceCount;
    ///             uint32_t    firstVertex;
    ///             uint32_t    firstInstance;
    ///         } VkDrawIndirectCommand;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkDrawIndirectCommand()
    {
        /// <summary>
        ///     <c>VertexCount</c> is the number of vertices to draw.
        /// </summary>
        [FieldOffset(0)]
        public int VertexCount;

        /// <summary>
        ///     <c>InstanceCount</c> is the number of instances to draw.
        /// </summary>
        [FieldOffset(4)]
        public int InstanceCount;

        /// <summary>
        ///     <c>FirstVertex</c> is the index of the first vertex to draw.
        /// </summary>
        [FieldOffset(8)]
        public int FirstVertex;

        /// <summary>
        ///     <c>FirstInstance</c> is the instance ID of the first instance to draw.
        /// </summary>
        [FieldOffset(12)]
        public int FirstInstance;
    }
}
