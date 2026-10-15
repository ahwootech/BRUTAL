namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineShaderStageModuleIdentifierCreateInfoEXT.html">VkPipelineShaderStageModuleIdentifierCreateInfoEXT</see> - Structure specifying an identifier for a shader module
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         An identifier <i>can</i> be provided instead of shader code in an attempt to
    ///         compile pipelines without providing complete SPIR-V to the implementation.
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineShaderStageModuleIdentifierCreateInfoEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_module_identifier
    ///         typedef struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           identifierSize;
    ///             const uint8_t*     pIdentifier;
    ///         } VkPipelineShaderStageModuleIdentifierCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineShaderStageModuleIdentifierCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>IdentifierSize</c> is the size, in bytes, of the buffer pointed to by <c>pIdentifier</c>.
        /// </summary>
        [FieldOffset(16)]
        public int IdentifierSize;

        /// <summary>
        ///     <c>Identifier</c> is a pointer to a buffer of opaque data specifying an identifier.
        /// </summary>
        [FieldOffset(24)]
        public byte* Identifier;
    }
}
