namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderFmaFeaturesKHR.html">VkPhysicalDeviceShaderFmaFeaturesKHR</see> - Structure indicating support for SPV_KHR_fma OpFmaKHR
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderFmaFeaturesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_shader_fma
    ///         typedef struct VkPhysicalDeviceShaderFmaFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderFmaFloat16;
    ///             VkBool32           shaderFmaFloat32;
    ///             VkBool32           shaderFmaFloat64;
    ///         } VkPhysicalDeviceShaderFmaFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceShaderFmaFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderFmaFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderFmaFloat16</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderFmaFloat16;

        /// <summary>
        ///     <c>ShaderFmaFloat32</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderFmaFloat32;

        /// <summary>
        ///     <c>ShaderFmaFloat64</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ShaderFmaFloat64;
    }
}
