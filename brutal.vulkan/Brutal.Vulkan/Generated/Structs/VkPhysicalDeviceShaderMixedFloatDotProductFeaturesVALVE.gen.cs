namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE.html">VkPhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE</see> - Structure describing support for mixed float dot products
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_shader_mixed_float_dot_product
    ///         typedef struct VkPhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderMixedFloatDotProductFloat16AccFloat32;
    ///             VkBool32           shaderMixedFloatDotProductFloat16AccFloat16;
    ///             VkBool32           shaderMixedFloatDotProductBFloat16Acc;
    ///             VkBool32           shaderMixedFloatDotProductFloat8AccFloat32;
    ///         } VkPhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderMixedFloatDotProductFloat16AccFloat32</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderMixedFloatDotProductFloat16AccFloat32;

        /// <summary>
        ///     <c>ShaderMixedFloatDotProductFloat16AccFloat16</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderMixedFloatDotProductFloat16AccFloat16;

        /// <summary>
        ///     <c>ShaderMixedFloatDotProductBFloat16Acc</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ShaderMixedFloatDotProductBFloat16Acc;

        /// <summary>
        ///     <c>ShaderMixedFloatDotProductFloat8AccFloat32</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 ShaderMixedFloatDotProductFloat8AccFloat32;
    }
}
