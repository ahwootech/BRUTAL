namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderFloat8FeaturesEXT.html">VkPhysicalDeviceShaderFloat8FeaturesEXT</see> - Structure describing float8 features that can be supported by the implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderFloat8FeaturesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_float8
    ///         typedef struct VkPhysicalDeviceShaderFloat8FeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderFloat8;
    ///             VkBool32           shaderFloat8CooperativeMatrix;
    ///         } VkPhysicalDeviceShaderFloat8FeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderFloat8FeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderFloat8FeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderFloat8</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderFloat8;

        /// <summary>
        ///     <c>ShaderFloat8CooperativeMatrix</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderFloat8CooperativeMatrix;
    }
}
