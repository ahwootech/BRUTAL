namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetShaderLayoutInfoEXT.html">VkIndirectExecutionSetShaderLayoutInfoEXT</see> - Struct specifying descriptor layout parameters of a newly created indirect execution set containing only shader objects
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectExecutionSetShaderLayoutInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkIndirectExecutionSetShaderLayoutInfoEXT {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             uint32_t                        setLayoutCount;
    ///             const VkDescriptorSetLayout*    pSetLayouts;
    ///         } VkIndirectExecutionSetShaderLayoutInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkIndirectExecutionSetShaderLayoutInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.IndirectExecutionSetShaderLayoutInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SetLayoutCount</c> is the number of members in the <c>pSetLayouts</c> array
        /// </summary>
        [FieldOffset(16)]
        public int SetLayoutCount;

        /// <summary>
        ///     <c>SetLayouts</c> is a pointer to an array containing <c>VkDescriptorSetLayout</c> objects used by the shader stage. The implementation <i>must</i> not access these objects outside of the duration of the command this structure is passed to.
        /// </summary>
        [FieldOffset(24)]
        public VkDescriptorSetLayout* SetLayouts;
    }
}
