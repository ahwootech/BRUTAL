namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT.html">VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT</see> - Structure describing whether querying and providing an identifier of a shader module is supported by the implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_module_identifier
    ///         typedef struct VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderModuleIdentifier;
    ///         } VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderModuleIdentifierFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderModuleIdentifier</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderModuleIdentifier;
    }
}
