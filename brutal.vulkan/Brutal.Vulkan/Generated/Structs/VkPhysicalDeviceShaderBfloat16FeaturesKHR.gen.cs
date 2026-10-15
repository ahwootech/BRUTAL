namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderBfloat16FeaturesKHR.html">VkPhysicalDeviceShaderBfloat16FeaturesKHR</see> - Structure describing bfloat16 features that can be supported by the implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderBfloat16FeaturesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_shader_bfloat16
    ///         typedef struct VkPhysicalDeviceShaderBfloat16FeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderBFloat16Type;
    ///             VkBool32           shaderBFloat16DotProduct;
    ///             VkBool32           shaderBFloat16CooperativeMatrix;
    ///         } VkPhysicalDeviceShaderBfloat16FeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceShaderBfloat16FeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderBfloat16FeaturesKHR;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderBFloat16Type</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderBFloat16Type;

        /// <summary>
        ///     <c>ShaderBFloat16DotProduct</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderBFloat16DotProduct;

        /// <summary>
        ///     <c>ShaderBFloat16CooperativeMatrix</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ShaderBFloat16CooperativeMatrix;
    }
}
