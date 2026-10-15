namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutTokenEXT.html">VkIndirectCommandsLayoutTokenEXT</see> - Struct specifying the details of an indirect command layout token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectCommandsLayoutTokenEXT</c> structure specifies details to
    ///         the function arguments that need to be known at layout creation time:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkIndirectCommandsLayoutTokenEXT {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkIndirectCommandsTokenTypeEXT    type;
    ///             VkIndirectCommandsTokenDataEXT    data;
    ///             uint32_t                          offset;
    ///         } VkIndirectCommandsLayoutTokenEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkIndirectCommandsLayoutTokenEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.IndirectCommandsLayoutTokenEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Type</c> specifies the <c>VkIndirectCommandsTokenTypeEXT</c> for <c>data</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkIndirectCommandsTokenTypeEXT Type;

        /// <summary>
        ///     <c>Data</c> specifies a <c>VkIndirectCommandsTokenDataEXT</c> containing token-specific details for command execution. It is ignored if <c>type</c> does not match any member of the <c>VkIndirectCommandsTokenDataEXT</c> union.
        /// </summary>
        [FieldOffset(24)]
        public VkIndirectCommandsTokenDataEXT Data;

        /// <summary>
        ///     <c>Offset</c> is the relative byte offset for the token within one sequence of the indirect buffer. The data stored at that offset is the command data for the token, e.g. <c>VkDispatchIndirectCommand</c>.
        /// </summary>
        [FieldOffset(32)]
        public int Offset;
    }
}
