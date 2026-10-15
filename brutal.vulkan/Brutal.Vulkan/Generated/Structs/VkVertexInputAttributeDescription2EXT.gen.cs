namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVertexInputAttributeDescription2EXT.html">VkVertexInputAttributeDescription2EXT</see> - Structure specifying the extended vertex input attribute description
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVertexInputAttributeDescription2EXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_object, VK_EXT_vertex_input_dynamic_state
    ///         typedef struct VkVertexInputAttributeDescription2EXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           location;
    ///             uint32_t           binding;
    ///             VkFormat           format;
    ///             uint32_t           offset;
    ///         } VkVertexInputAttributeDescription2EXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVertexInputAttributeDescription2EXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VertexInputAttributeDescription2EXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Location</c> is the shader input location number for this attribute.
        /// </summary>
        [FieldOffset(16)]
        public int Location;

        /// <summary>
        ///     <c>Binding</c> is the binding number which this attribute takes its data from.
        /// </summary>
        [FieldOffset(20)]
        public int Binding;

        /// <summary>
        ///     <c>Format</c> is the size and type of the vertex attribute data.
        /// </summary>
        [FieldOffset(24)]
        public VkFormat Format;

        /// <summary>
        ///     <c>Offset</c> is a byte offset of this attribute relative to the start of an element in the vertex input binding.
        /// </summary>
        [FieldOffset(28)]
        public int Offset;
    }
}
