namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindIndexBufferIndirectCommandEXT.html">VkBindIndexBufferIndirectCommandEXT</see> - Structure specifying input data for a single index buffer command token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBindIndexBufferIndirectCommandEXT</c> structure specifies the input
    ///         data for the <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_EXT</c> token.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkBindIndexBufferIndirectCommandEXT {
    ///             VkDeviceAddress    bufferAddress;
    ///             uint32_t           size;
    ///             VkIndexType        indexType;
    ///         } VkBindIndexBufferIndirectCommandEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkBindIndexBufferIndirectCommandEXT()
    {
        /// <summary>
        ///     <c>BufferAddress</c> specifies a physical address of the <c>VkBuffer</c> used as index buffer.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress BufferAddress;

        /// <summary>
        ///     <c>Size</c> is the byte size range which is available for this operation from the provided address.
        /// </summary>
        [FieldOffset(8)]
        public int Size;

        /// <summary>
        ///     <c>IndexType</c> is a <c>VkIndexType</c> value specifying how indices are treated.
        /// </summary>
        [FieldOffset(12)]
        public VkIndexType IndexType;
    }
}
