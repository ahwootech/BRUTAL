namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesEXT.html">VkPhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesEXT</see> - Structure describing uniform buffer unsized array features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesEXT</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_uniform_buffer_unsized_array
    ///         typedef struct VkPhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderUniformBufferUnsizedArray;
    ///         } VkPhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderUniformBufferUnsizedArray</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderUniformBufferUnsizedArray;
    }
}
