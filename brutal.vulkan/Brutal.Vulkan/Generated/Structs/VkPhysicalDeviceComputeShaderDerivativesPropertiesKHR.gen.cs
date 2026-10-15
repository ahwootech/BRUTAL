namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceComputeShaderDerivativesPropertiesKHR.html">VkPhysicalDeviceComputeShaderDerivativesPropertiesKHR</see> - Structure describing compute shader derivative operations supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceComputeShaderDerivativesPropertiesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_compute_shader_derivatives
    ///         typedef struct VkPhysicalDeviceComputeShaderDerivativesPropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           meshAndTaskShaderDerivatives;
    ///         } VkPhysicalDeviceComputeShaderDerivativesPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceComputeShaderDerivativesPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceComputeShaderDerivativesPropertiesKHR;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MeshAndTaskShaderDerivatives</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 MeshAndTaskShaderDerivatives;
    }
}
