namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderObjectPropertiesEXT.html">VkPhysicalDeviceShaderObjectPropertiesEXT</see> - Structure describing shader object properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderObjectPropertiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_object
    ///         typedef struct VkPhysicalDeviceShaderObjectPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint8_t            shaderBinaryUUID[VK_UUID_SIZE];
    ///             uint32_t           shaderBinaryVersion;
    ///         } VkPhysicalDeviceShaderObjectPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceShaderObjectPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderObjectPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        ///
        [FieldOffset(16)]
        public fixed byte ShaderBinaryUUID[16];

        /// <summary>
        ///     <c>ShaderBinaryVersion</c>
        /// </summary>
        [FieldOffset(32)]
        public int ShaderBinaryVersion;
    }
}
