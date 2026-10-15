namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT.html">VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT</see> - Structure describing shader module identifier properties of an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_module_identifier
    ///         typedef struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint8_t            shaderModuleIdentifierAlgorithmUUID[VK_UUID_SIZE];
    ///         } VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderModuleIdentifierPropertiesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        ///
        [FieldOffset(16)]
        public fixed byte ShaderModuleIdentifierAlgorithmUUID[16];
    }
}
