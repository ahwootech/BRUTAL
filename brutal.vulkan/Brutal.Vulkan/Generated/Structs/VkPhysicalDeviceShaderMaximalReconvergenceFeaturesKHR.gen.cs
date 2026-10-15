namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR.html">VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR</see> - Structure describing support for shader maximal reconvergence by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_shader_maximal_reconvergence
    ///         typedef struct VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderMaximalReconvergence;
    ///         } VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderMaximalReconvergenceFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderMaximalReconvergence</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderMaximalReconvergence;
    }
}
