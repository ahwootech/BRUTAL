namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkWriteIndirectExecutionSetShaderEXT.html">VkWriteIndirectExecutionSetShaderEXT</see> - Struct specifying shader object update information for an indirect execution set
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkWriteIndirectExecutionSetShaderEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands with VK_EXT_shader_object
    ///         typedef struct VkWriteIndirectExecutionSetShaderEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           index;
    ///             VkShaderEXT        shader;
    ///         } VkWriteIndirectExecutionSetShaderEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkWriteIndirectExecutionSetShaderEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.WriteIndirectExecutionSetShaderEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Index</c> is the element of the set to update
        /// </summary>
        [FieldOffset(16)]
        public int Index;

        /// <summary>
        ///     <c>Shader</c> is the shader to store in the indirect execution set
        /// </summary>
        [FieldOffset(24)]
        public VkShaderEXT Shader;
    }
}
