namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVertexInputBindingDescription.html">VkVertexInputBindingDescription</see> - Structure specifying vertex input binding description
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Each vertex input binding is specified by the
    ///         <c>VkVertexInputBindingDescription</c> structure, defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkVertexInputBindingDescription {
    ///             uint32_t             binding;
    ///             uint32_t             stride;
    ///             VkVertexInputRate    inputRate;
    ///         } VkVertexInputBindingDescription;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkVertexInputBindingDescription()
    {
        /// <summary>
        ///     <c>Binding</c> is the binding number that this structure describes.
        /// </summary>
        [FieldOffset(0)]
        public int Binding;

        /// <summary>
        ///     <c>Stride</c> is the byte stride between consecutive elements within the buffer.
        /// </summary>
        [FieldOffset(4)]
        public ByteSize32 Stride;

        /// <summary>
        ///     <c>InputRate</c> is a <c>VkVertexInputRate</c> value specifying whether vertex attribute addressing is a function of the vertex index or of the instance index.
        /// </summary>
        [FieldOffset(8)]
        public VkVertexInputRate InputRate;
    }
}
