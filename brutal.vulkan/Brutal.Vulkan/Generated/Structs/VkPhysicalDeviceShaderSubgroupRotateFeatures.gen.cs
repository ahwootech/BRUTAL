namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderSubgroupRotateFeatures.html">VkPhysicalDeviceShaderSubgroupRotateFeatures</see> - Structure describing whether subgroup rotation is enabled
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderSubgroupRotateFeatures</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceShaderSubgroupRotateFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderSubgroupRotate;
    ///             VkBool32           shaderSubgroupRotateClustered;
    ///         } VkPhysicalDeviceShaderSubgroupRotateFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderSubgroupRotateFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderSubgroupRotateFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderSubgroupRotate</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderSubgroupRotate;

        /// <summary>
        ///     <c>ShaderSubgroupRotateClustered</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderSubgroupRotateClustered;
    }
}
