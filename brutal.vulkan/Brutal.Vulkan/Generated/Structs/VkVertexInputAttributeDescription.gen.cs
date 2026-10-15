namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVertexInputAttributeDescription.html">VkVertexInputAttributeDescription</see> - Structure specifying vertex input attribute description
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Each vertex input attribute is specified by the
    ///         <c>VkVertexInputAttributeDescription</c> structure, defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkVertexInputAttributeDescription {
    ///             uint32_t    location;
    ///             uint32_t    binding;
    ///             VkFormat    format;
    ///             uint32_t    offset;
    ///         } VkVertexInputAttributeDescription;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkVertexInputAttributeDescription()
    {
        /// <summary>
        ///     <c>Location</c> is the shader input location number for this attribute.
        /// </summary>
        [FieldOffset(0)]
        public int Location;

        /// <summary>
        ///     <c>Binding</c> is the binding number which this attribute takes its data from.
        /// </summary>
        [FieldOffset(4)]
        public int Binding;

        /// <summary>
        ///     <c>Format</c> is the size and type of the vertex attribute data.
        /// </summary>
        [FieldOffset(8)]
        public VkFormat Format;

        /// <summary>
        ///     <c>Offset</c> is a byte offset of this attribute relative to the start of an element in the vertex input binding.
        /// </summary>
        [FieldOffset(12)]
        public ByteSize32 Offset;
    }
}
