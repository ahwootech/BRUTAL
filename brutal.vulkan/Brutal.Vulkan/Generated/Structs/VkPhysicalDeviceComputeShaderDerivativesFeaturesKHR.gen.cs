namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceComputeShaderDerivativesFeaturesKHR.html">VkPhysicalDeviceComputeShaderDerivativesFeaturesKHR</see> - Structure describing compute shader derivative features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceComputeShaderDerivativesFeaturesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_compute_shader_derivatives
    ///         typedef struct VkPhysicalDeviceComputeShaderDerivativesFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           computeDerivativeGroupQuads;
    ///             VkBool32           computeDerivativeGroupLinear;
    ///         } VkPhysicalDeviceComputeShaderDerivativesFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceComputeShaderDerivativesFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceComputeShaderDerivativesFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ComputeDerivativeGroupQuads</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ComputeDerivativeGroupQuads;

        /// <summary>
        ///     <c>ComputeDerivativeGroupLinear</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ComputeDerivativeGroupLinear;
    }
}
