namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM.html">VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM</see> - Structure describing the shader core builtins features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_shader_core_builtins
    ///         typedef struct VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderCoreBuiltins;
    ///         } VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderCoreBuiltinsFeaturesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderCoreBuiltins</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderCoreBuiltins;
    }
}
