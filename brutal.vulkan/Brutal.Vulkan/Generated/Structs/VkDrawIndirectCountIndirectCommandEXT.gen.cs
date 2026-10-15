namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDrawIndirectCountIndirectCommandEXT.html">VkDrawIndirectCountIndirectCommandEXT</see> - Structure specifying input data for a single draw-type command token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDrawIndirectCountIndirectCommandEXT</c> structure specifies the
    ///         input data for all draw-type tokens.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkDrawIndirectCountIndirectCommandEXT {
    ///             VkDeviceAddress    bufferAddress;
    ///             uint32_t           stride;
    ///             uint32_t           commandCount;
    ///         } VkDrawIndirectCountIndirectCommandEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkDrawIndirectCountIndirectCommandEXT()
    {
        /// <summary>
        ///     <c>BufferAddress</c> specifies a physical address of the <c>VkBuffer</c> used for draw commands.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress BufferAddress;

        /// <summary>
        ///     <c>Stride</c> is the byte size stride for the command arguments
        /// </summary>
        [FieldOffset(8)]
        public int Stride;

        /// <summary>
        ///     <c>CommandCount</c> is the number of commands to execute
        /// </summary>
        [FieldOffset(12)]
        public int CommandCount;
    }
}
