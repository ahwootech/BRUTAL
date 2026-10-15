namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVertexInputBindingDescription2EXT.html">VkVertexInputBindingDescription2EXT</see> - Structure specifying the extended vertex input binding description
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVertexInputBindingDescription2EXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_object, VK_EXT_vertex_input_dynamic_state
    ///         typedef struct VkVertexInputBindingDescription2EXT {
    ///             VkStructureType      sType;
    ///             void*                pNext;
    ///             uint32_t             binding;
    ///             uint32_t             stride;
    ///             VkVertexInputRate    inputRate;
    ///             uint32_t             divisor;
    ///         } VkVertexInputBindingDescription2EXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVertexInputBindingDescription2EXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VertexInputBindingDescription2EXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Binding</c> is the binding number that this structure describes.
        /// </summary>
        [FieldOffset(16)]
        public int Binding;

        /// <summary>
        ///     <c>Stride</c> is the byte stride between consecutive elements within the buffer.
        /// </summary>
        [FieldOffset(20)]
        public int Stride;

        /// <summary>
        ///     <c>InputRate</c> is a <c>VkVertexInputRate</c> value specifying whether vertex attribute addressing is a function of the vertex index or of the instance index.
        /// </summary>
        [FieldOffset(24)]
        public VkVertexInputRate InputRate;

        /// <summary>
        ///     <c>Divisor</c> <i>must</i> be `1`
        /// </summary>
        [FieldOffset(28)]
        public int Divisor;
    }
}
