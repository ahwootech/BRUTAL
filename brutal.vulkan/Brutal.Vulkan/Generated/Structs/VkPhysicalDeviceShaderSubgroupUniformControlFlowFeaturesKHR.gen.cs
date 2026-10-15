namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR.html">VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR</see> - Structure describing support for shader subgroup uniform control flow by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_shader_subgroup_uniform_control_flow
    ///         typedef struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderSubgroupUniformControlFlow;
    ///         } VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderSubgroupUniformControlFlow</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderSubgroupUniformControlFlow;
    }
}
