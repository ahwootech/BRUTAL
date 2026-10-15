namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderCoreProperties2AMD.html">VkPhysicalDeviceShaderCoreProperties2AMD</see> - Structure describing shader core properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderCoreProperties2AMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_shader_core_properties2
    ///         typedef struct VkPhysicalDeviceShaderCoreProperties2AMD {
    ///             VkStructureType                   sType;
    ///             void*                             pNext;
    ///             VkShaderCorePropertiesFlagsAMD    shaderCoreFeatures;
    ///             uint32_t                          activeComputeUnitCount;
    ///         } VkPhysicalDeviceShaderCoreProperties2AMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderCoreProperties2AMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderCoreProperties2AMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderCoreFeatures</c>
        /// </summary>
        [FieldOffset(16)]
        public VkShaderCorePropertiesFlagsAMD ShaderCoreFeatures;

        /// <summary>
        ///     <c>ActiveComputeUnitCount</c>
        /// </summary>
        [FieldOffset(20)]
        public int ActiveComputeUnitCount;
    }
}
