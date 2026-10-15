namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM.html">VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM</see> - Structure describing shader core builtins properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_shader_core_builtins
    ///         typedef struct VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint64_t           shaderCoreMask;
    ///             uint32_t           shaderCoreCount;
    ///             uint32_t           shaderWarpsPerCore;
    ///         } VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderCoreBuiltinsPropertiesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderCoreMask</c>
        /// </summary>
        [FieldOffset(16)]
        public nint ShaderCoreMask;

        /// <summary>
        ///     <c>ShaderCoreCount</c>
        /// </summary>
        [FieldOffset(24)]
        public int ShaderCoreCount;

        /// <summary>
        ///     <c>ShaderWarpsPerCore</c>
        /// </summary>
        [FieldOffset(28)]
        public int ShaderWarpsPerCore;
    }
}
