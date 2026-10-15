namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetShaderInfoEXT.html">VkIndirectExecutionSetShaderInfoEXT</see> - Struct specifying parameters of a newly created indirect execution set containing only shader objects
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectExecutionSetShaderInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkIndirectExecutionSetShaderInfoEXT {
    ///             VkStructureType                                     sType;
    ///             const void*                                         pNext;
    ///             uint32_t                                            shaderCount;
    ///             const VkShaderEXT*                                  pInitialShaders;
    ///             const VkIndirectExecutionSetShaderLayoutInfoEXT*    pSetLayoutInfos;
    ///             uint32_t                                            maxShaderCount;
    ///             uint32_t                                            pushConstantRangeCount;
    ///             const VkPushConstantRange*                          pPushConstantRanges;
    ///         } VkIndirectExecutionSetShaderInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkIndirectExecutionSetShaderInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.IndirectExecutionSetShaderInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderCount</c> is the number of members in the <c>pInitialShaders</c> and <c>pSetLayoutInfos</c> arrays.
        /// </summary>
        [FieldOffset(16)]
        public int ShaderCount;

        /// <summary>
        ///     <c>InitialShaders</c> is a pointer to an array containing a <c>VkShaderEXT</c> object for each shader stage that will be used in the set. These shaders will be automatically added to the set beginning at index `0`.
        /// </summary>
        [FieldOffset(24)]
        public VkShaderEXT* InitialShaders;

        /// <summary>
        ///     <c>SetLayoutInfos</c> is NULL or a pointer to an array containing a <c>VkIndirectExecutionSetShaderLayoutInfoEXT</c> used by each corresponding <c>pInitialShaders</c> shader stage in the set.
        /// </summary>
        [FieldOffset(32)]
        public VkIndirectExecutionSetShaderLayoutInfoEXT* SetLayoutInfos;

        /// <summary>
        ///     <c>MaxShaderCount</c> is the maximum number of shader objects stored in the set.
        /// </summary>
        [FieldOffset(40)]
        public int MaxShaderCount;

        /// <summary>
        ///     <c>PushConstantRangeCount</c> is the number of members in the <c>pPushConstantRanges</c> array.
        /// </summary>
        [FieldOffset(44)]
        public int PushConstantRangeCount;

        /// <summary>
        ///     <c>PushConstantRanges</c> is a pointer to the array of <c>VkPushConstantRange</c> ranges used by all shaders in the set.
        /// </summary>
        [FieldOffset(48)]
        public VkPushConstantRange* PushConstantRanges;
    }
}
