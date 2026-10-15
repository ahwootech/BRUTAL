namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsMemoryRequirementsInfoEXT.html">VkGeneratedCommandsMemoryRequirementsInfoEXT</see> - Structure specifying parameters for the reservation of preprocess buffer space
    /// </summary>
    /// <remarks>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkGeneratedCommandsMemoryRequirementsInfoEXT {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             VkIndirectExecutionSetEXT      indirectExecutionSet;
    ///             VkIndirectCommandsLayoutEXT    indirectCommandsLayout;
    ///             uint32_t                       maxSequenceCount;
    ///             uint32_t                       maxDrawCount;
    ///         } VkGeneratedCommandsMemoryRequirementsInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkGeneratedCommandsMemoryRequirementsInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GeneratedCommandsMemoryRequirementsInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>IndirectExecutionSet</c> is the indirect execution set to be used for binding shaders.
        /// </summary>
        [FieldOffset(16)]
        public VkIndirectExecutionSetEXT IndirectExecutionSet;

        /// <summary>
        ///     <c>IndirectCommandsLayout</c> is the <c>VkIndirectCommandsLayoutEXT</c> that this buffer memory is intended to be used with.
        /// </summary>
        [FieldOffset(24)]
        public VkIndirectCommandsLayoutEXT IndirectCommandsLayout;

        /// <summary>
        ///     <c>MaxSequenceCount</c> is the maximum number of sequences that this buffer memory can be used with.
        /// </summary>
        [FieldOffset(32)]
        public int MaxSequenceCount;

        /// <summary>
        ///     <c>MaxDrawCount</c> is the maximum number of indirect draws that can be executed by any COUNT-type multi-draw indirect tokens. The draw count in the indirect buffer is clamped to this value for these token types.
        /// </summary>
        [FieldOffset(36)]
        public int MaxDrawCount;
    }
}
