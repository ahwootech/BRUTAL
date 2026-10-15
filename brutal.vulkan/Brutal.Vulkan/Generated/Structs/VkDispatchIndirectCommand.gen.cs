namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDispatchIndirectCommand.html">VkDispatchIndirectCommand</see> - Structure specifying an indirect dispatching command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDispatchIndirectCommand</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkDispatchIndirectCommand {
    ///             uint32_t    x;
    ///             uint32_t    y;
    ///             uint32_t    z;
    ///         } VkDispatchIndirectCommand;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkDispatchIndirectCommand()
    {
        /// <summary>
        ///     <c>X</c> is the number of local workgroups to dispatch in the X dimension.
        /// </summary>
        [FieldOffset(0)]
        public int X;

        /// <summary>
        ///     <c>Y</c> is the number of local workgroups to dispatch in the Y dimension.
        /// </summary>
        [FieldOffset(4)]
        public int Y;

        /// <summary>
        ///     <c>Z</c> is the number of local workgroups to dispatch in the Z dimension.
        /// </summary>
        [FieldOffset(8)]
        public int Z;
    }
}
