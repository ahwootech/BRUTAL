namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsStreamNV.html">VkIndirectCommandsStreamNV</see> - Structure specifying input streams for generated command tokens
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectCommandsStreamNV</c> structure specifies the input data for
    ///         one or more tokens at processing time.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef struct VkIndirectCommandsStreamNV {
    ///             VkBuffer        buffer;
    ///             VkDeviceSize    offset;
    ///         } VkIndirectCommandsStreamNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkIndirectCommandsStreamNV()
    {
        /// <summary>
        ///     <c>Buffer</c> specifies the <c>VkBuffer</c> storing the functional arguments for each sequence. These arguments <i>can</i> be written by the device.
        /// </summary>
        [FieldOffset(0)]
        public VkBuffer Buffer;

        /// <summary>
        ///     <c>Offset</c> specified an offset into <c>buffer</c> where the arguments start.
        /// </summary>
        [FieldOffset(8)]
        public ByteSize64 Offset;
    }
}
