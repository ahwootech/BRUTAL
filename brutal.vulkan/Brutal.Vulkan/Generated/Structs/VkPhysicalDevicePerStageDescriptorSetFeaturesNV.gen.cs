namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePerStageDescriptorSetFeaturesNV.html">VkPhysicalDevicePerStageDescriptorSetFeaturesNV</see> - Structure describing feature to allow descriptor set layout bindings to be per-stage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePerStageDescriptorSetFeaturesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_per_stage_descriptor_set
    ///         typedef struct VkPhysicalDevicePerStageDescriptorSetFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           perStageDescriptorSet;
    ///             VkBool32           dynamicPipelineLayout;
    ///         } VkPhysicalDevicePerStageDescriptorSetFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePerStageDescriptorSetFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePerStageDescriptorSetFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PerStageDescriptorSet</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PerStageDescriptorSet;

        /// <summary>
        ///     <c>DynamicPipelineLayout</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DynamicPipelineLayout;
    }
}
