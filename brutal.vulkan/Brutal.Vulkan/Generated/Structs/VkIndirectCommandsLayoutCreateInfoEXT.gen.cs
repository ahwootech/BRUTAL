namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutCreateInfoEXT.html">VkIndirectCommandsLayoutCreateInfoEXT</see> - Structure specifying the parameters of a newly created indirect commands layout object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectCommandsLayoutCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkIndirectCommandsLayoutCreateInfoEXT {
    ///             VkStructureType                            sType;
    ///             const void*                                pNext;
    ///             VkIndirectCommandsLayoutUsageFlagsEXT      flags;
    ///             VkShaderStageFlags                         shaderStages;
    ///             uint32_t                                   indirectStride;
    ///             VkPipelineLayout                           pipelineLayout;
    ///             uint32_t                                   tokenCount;
    ///             const VkIndirectCommandsLayoutTokenEXT*    pTokens;
    ///         } VkIndirectCommandsLayoutCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkIndirectCommandsLayoutCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.IndirectCommandsLayoutCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkIndirectCommandsLayoutUsageFlagsEXT</c> specifying usage rules for this layout.
        /// </summary>
        [FieldOffset(16)]
        public VkIndirectCommandsLayoutUsageFlagsEXT Flags;

        /// <summary>
        ///     <c>ShaderStages</c> is the <c>VkShaderStageFlags</c> that this layout supports.
        /// </summary>
        [FieldOffset(20)]
        public VkShaderStageFlags ShaderStages;

        /// <summary>
        ///     <c>IndirectStride</c> is the distance in bytes between sequences in the indirect buffer
        /// </summary>
        [FieldOffset(24)]
        public int IndirectStride;

        /// <summary>
        ///     <c>PipelineLayout</c> is the optional <c>VkPipelineLayout</c> that tokens in this layout use. If the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-dynamicGeneratedPipelineLayout"><c>dynamicGeneratedPipelineLayout</c>^</see> feature is enabled, <c>pipelineLayout</c> <i>can</i> be <c>VK_NULL_HANDLE</c> and the layout <i>must</i> be specified by chaining the <c>VkPipelineLayoutCreateInfo</c> structure off the <c>pNext</c>.
        /// </summary>
        [FieldOffset(32)]
        public VkPipelineLayout PipelineLayout;

        /// <summary>
        ///     <c>TokenCount</c> is the length of the individual command sequence.
        /// </summary>
        [FieldOffset(40)]
        public int TokenCount;

        /// <summary>
        ///     <c>Tokens</c> is a pointer to an array of <c>VkIndirectCommandsLayoutTokenEXT</c> describing each command token in detail.
        /// </summary>
        [FieldOffset(48)]
        public VkIndirectCommandsLayoutTokenEXT* Tokens;
    }
}
