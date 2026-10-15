namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineVertexInputStateCreateInfo.html">VkPipelineVertexInputStateCreateInfo</see> - Structure specifying parameters of a newly created pipeline vertex input state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineVertexInputStateCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineVertexInputStateCreateInfo {
    ///             VkStructureType                             sType;
    ///             const void*                                 pNext;
    ///             VkPipelineVertexInputStateCreateFlags       flags;
    ///             uint32_t                                    vertexBindingDescriptionCount;
    ///             const VkVertexInputBindingDescription*      pVertexBindingDescriptions;
    ///             uint32_t                                    vertexAttributeDescriptionCount;
    ///             const VkVertexInputAttributeDescription*    pVertexAttributeDescriptions;
    ///         } VkPipelineVertexInputStateCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPipelineVertexInputStateCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineVertexInputStateCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineVertexInputStateCreateFlags Flags;

        /// <summary>
        ///     <c>VertexBindingDescriptionCount</c> is the number of vertex binding descriptions provided in <c>pVertexBindingDescriptions</c>.
        /// </summary>
        [FieldOffset(20)]
        public int VertexBindingDescriptionCount;

        /// <summary>
        ///     <c>VertexBindingDescriptions</c> is a pointer to an array of <c>VkVertexInputBindingDescription</c> structures.
        /// </summary>
        [FieldOffset(24)]
        public VkVertexInputBindingDescription* VertexBindingDescriptions;

        /// <summary>
        ///     <c>VertexAttributeDescriptionCount</c> is the number of vertex attribute descriptions provided in <c>pVertexAttributeDescriptions</c>.
        /// </summary>
        [FieldOffset(32)]
        public int VertexAttributeDescriptionCount;

        /// <summary>
        ///     <c>VertexAttributeDescriptions</c> is a pointer to an array of <c>VkVertexInputAttributeDescription</c> structures.
        /// </summary>
        [FieldOffset(40)]
        public VkVertexInputAttributeDescription* VertexAttributeDescriptions;
    }
}
