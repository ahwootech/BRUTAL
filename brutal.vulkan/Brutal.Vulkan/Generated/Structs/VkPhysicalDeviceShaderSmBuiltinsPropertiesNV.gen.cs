namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderSMBuiltinsPropertiesNV.html">VkPhysicalDeviceShaderSMBuiltinsPropertiesNV</see> - Structure describing shader SM Builtins properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderSMBuiltinsPropertiesNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_shader_sm_builtins
    ///         typedef struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           shaderSMCount;
    ///             uint32_t           shaderWarpsPerSM;
    ///         } VkPhysicalDeviceShaderSMBuiltinsPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderSmBuiltinsPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderSmBuiltinsPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderSMCount</c>
        /// </summary>
        [FieldOffset(16)]
        public int ShaderSMCount;

        /// <summary>
        ///     <c>ShaderWarpsPerSM</c>
        /// </summary>
        [FieldOffset(20)]
        public int ShaderWarpsPerSM;
    }
}
