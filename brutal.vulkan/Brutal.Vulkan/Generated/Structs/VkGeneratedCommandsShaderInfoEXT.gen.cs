namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsShaderInfoEXT.html">VkGeneratedCommandsShaderInfoEXT</see> - Structure specifying shader objects for use with indirect command preprocessing
    /// </summary>
    /// <remarks>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkGeneratedCommandsShaderInfoEXT {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             uint32_t              shaderCount;
    ///             const VkShaderEXT*    pShaders;
    ///         } VkGeneratedCommandsShaderInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkGeneratedCommandsShaderInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GeneratedCommandsShaderInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderCount</c> is the size of the <c>pShaders</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int ShaderCount;

        /// <summary>
        ///     <c>Shaders</c> is a pointer to an array of shader objects.
        /// </summary>
        [FieldOffset(24)]
        public VkShaderEXT* Shaders;
    }
}
