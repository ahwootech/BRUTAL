namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsInfoEXT.html">VkGeneratedCommandsInfoEXT</see> - Structure specifying parameters for the generation of commands
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage:
    ///     </para>
    ///     <para>
    ///         The <c>VkGeneratedCommandsInfoEXT</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkGeneratedCommandsInfoEXT {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             VkShaderStageFlags             shaderStages;
    ///             VkIndirectExecutionSetEXT      indirectExecutionSet;
    ///             VkIndirectCommandsLayoutEXT    indirectCommandsLayout;
    ///             VkDeviceAddress                indirectAddress;
    ///             VkDeviceSize                   indirectAddressSize;
    ///             VkDeviceAddress                preprocessAddress;
    ///             VkDeviceSize                   preprocessSize;
    ///             uint32_t                       maxSequenceCount;
    ///             VkDeviceAddress                sequenceCountAddress;
    ///             uint32_t                       maxDrawCount;
    ///         } VkGeneratedCommandsInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkGeneratedCommandsInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GeneratedCommandsInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderStages</c> is the mask of shader stages used by the commands.
        /// </summary>
        [FieldOffset(16)]
        public VkShaderStageFlags ShaderStages;

        /// <summary>
        ///     <c>IndirectExecutionSet</c> is the indirect execution set to be used for binding shaders.
        /// </summary>
        [FieldOffset(24)]
        public VkIndirectExecutionSetEXT IndirectExecutionSet;

        /// <summary>
        ///     <c>IndirectCommandsLayout</c> is the <c>VkIndirectCommandsLayoutEXT</c> that specifies the command sequence data.
        /// </summary>
        [FieldOffset(32)]
        public VkIndirectCommandsLayoutEXT IndirectCommandsLayout;

        /// <summary>
        ///     <c>IndirectAddress</c> is an address that holds the indirect buffer data.
        /// </summary>
        [FieldOffset(40)]
        public VkDeviceAddress IndirectAddress;

        /// <summary>
        ///     <c>IndirectAddressSize</c> is the size in bytes of indirect buffer data starting at <c>indirectAddress</c>.
        /// </summary>
        [FieldOffset(48)]
        public ByteSize64 IndirectAddressSize;

        /// <summary>
        ///     <c>PreprocessAddress</c> specifies a physical address of the <c>VkBuffer</c> used for preprocessing the input data for execution. If this structure is used with <c>vkCmdExecuteGeneratedCommandsEXT</c> with its <c>isPreprocessed</c> set to <c>VK_TRUE</c>, then the preprocessing step is skipped but data in this address may: still be modified. The contents and the layout of this address are opaque to applications and <i>must</i> not be modified outside functions related to device-generated commands or copied to another buffer for reuse.
        /// </summary>
        [FieldOffset(56)]
        public VkDeviceAddress PreprocessAddress;

        /// <summary>
        ///     <c>PreprocessSize</c> is the maximum byte size within <c>preprocessAddress</c> that is available for preprocessing.
        /// </summary>
        [FieldOffset(64)]
        public ByteSize64 PreprocessSize;

        /// <summary>
        ///     <c>MaxSequenceCount</c> is used to determine the number of sequences to execute.
        /// </summary>
        [FieldOffset(72)]
        public int MaxSequenceCount;

        /// <summary>
        ///     <c>SequenceCountAddress</c> specifies an optional physical address of a single <c>uint32_t</c> value containing the requested number of sequences to execute.
        /// </summary>
        [FieldOffset(80)]
        public VkDeviceAddress SequenceCountAddress;

        /// <summary>
        ///     <c>MaxDrawCount</c> is the maximum number of indirect draws that can be executed by any COUNT-type multi-draw indirect tokens. The draw count in the indirect buffer is clamped to this value for these token types.
        /// </summary>
        [FieldOffset(88)]
        public int MaxDrawCount;
    }
}
