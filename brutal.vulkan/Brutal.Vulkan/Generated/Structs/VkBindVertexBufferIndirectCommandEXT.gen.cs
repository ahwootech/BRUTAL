namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindVertexBufferIndirectCommandEXT.html">VkBindVertexBufferIndirectCommandEXT</see> - Structure specifying input data for a single vertex buffer command token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBindVertexBufferIndirectCommandEXT</c> structure specifies the input
    ///         data for the <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_EXT</c> token.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkBindVertexBufferIndirectCommandEXT {
    ///             VkDeviceAddress    bufferAddress;
    ///             uint32_t           size;
    ///             uint32_t           stride;
    ///         } VkBindVertexBufferIndirectCommandEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkBindVertexBufferIndirectCommandEXT()
    {
        /// <summary>
        ///     <c>BufferAddress</c> specifies a physical address of the <c>VkBuffer</c> used as vertex input binding.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress BufferAddress;

        /// <summary>
        ///     <c>Size</c> is the byte size range which is available for this operation from the provided address.
        /// </summary>
        [FieldOffset(8)]
        public int Size;

        /// <summary>
        ///     <c>Stride</c> is the byte size stride for this vertex input binding as in <c>VkVertexInputBindingDescription::stride</c>.
        /// </summary>
        [FieldOffset(12)]
        public int Stride;
    }
}
