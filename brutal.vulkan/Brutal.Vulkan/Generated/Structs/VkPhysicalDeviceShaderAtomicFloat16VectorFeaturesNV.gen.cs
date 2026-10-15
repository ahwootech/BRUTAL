namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV.html">VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV</see> - Structure describing features supported by VK_NV_shader_atomic_float16_vector
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_shader_atomic_float16_vector
    ///         typedef struct VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderFloat16VectorAtomics;
    ///         } VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderFloat16VectorAtomics</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderFloat16VectorAtomics;
    }
}
