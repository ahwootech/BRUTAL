namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindIndexBufferIndirectCommandNV.html">VkBindIndexBufferIndirectCommandNV</see> - Structure specifying input data for a single index buffer command token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBindIndexBufferIndirectCommandNV</c> structure specifies the input
    ///         data for the <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV</c> token.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef struct VkBindIndexBufferIndirectCommandNV {
    ///             VkDeviceAddress    bufferAddress;
    ///             uint32_t           size;
    ///             VkIndexType        indexType;
    ///         } VkBindIndexBufferIndirectCommandNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkBindIndexBufferIndirectCommandNV()
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
        ///     <c>IndexType</c> is a <c>VkIndexType</c> value specifying how indices are treated. Instead of the Vulkan enum values, a custom `uint32_t` value <i>can</i> be mapped to <c>VkIndexType</c> by specifying the <c>VkIndirectCommandsLayoutTokenNV::pIndexTypes</c> and <c>VkIndirectCommandsLayoutTokenNV::pIndexTypeValues</c> arrays.
        /// </summary>
        [FieldOffset(12)]
        public VkIndexType IndexType;
    }
}
