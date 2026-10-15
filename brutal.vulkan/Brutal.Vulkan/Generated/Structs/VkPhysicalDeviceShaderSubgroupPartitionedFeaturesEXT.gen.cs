namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderSubgroupPartitionedFeaturesEXT.html">VkPhysicalDeviceShaderSubgroupPartitionedFeaturesEXT</see> - Structure describing shader subgroup partitioned features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderSubgroupPartitionedFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_subgroup_partitioned
    ///         typedef struct VkPhysicalDeviceShaderSubgroupPartitionedFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderSubgroupPartitioned;
    ///         } VkPhysicalDeviceShaderSubgroupPartitionedFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderSubgroupPartitionedFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderSubgroupPartitionedFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderSubgroupPartitioned</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderSubgroupPartitioned;
    }
}
