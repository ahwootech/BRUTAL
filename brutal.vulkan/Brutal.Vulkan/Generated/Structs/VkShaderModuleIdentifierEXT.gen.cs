namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderModuleIdentifierEXT.html">VkShaderModuleIdentifierEXT</see> - A unique identifier for a shader module
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <c>VkShaderModuleIdentifierEXT</c> represents a shader module identifier
    ///         returned by the implementation.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_module_identifier
    ///         typedef struct VkShaderModuleIdentifierEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           identifierSize;
    ///             uint8_t            identifier[VK_MAX_SHADER_MODULE_IDENTIFIER_SIZE_EXT];
    ///         } VkShaderModuleIdentifierEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkShaderModuleIdentifierEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ShaderModuleIdentifierEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>IdentifierSize</c> is the size, in bytes, of valid data returned in <c>identifier</c>.
        /// </summary>
        [FieldOffset(16)]
        public int IdentifierSize;

        ///
        [FieldOffset(20)]
        public fixed byte Identifier[32];
    }
}
