namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDataGraphFeaturesARM.html">VkPhysicalDeviceDataGraphFeaturesARM</see> - Structure describing features to control data graph pipelines
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDataGraphFeaturesARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkPhysicalDeviceDataGraphFeaturesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           dataGraph;
    ///             VkBool32           dataGraphUpdateAfterBind;
    ///             VkBool32           dataGraphSpecializationConstants;
    ///             VkBool32           dataGraphDescriptorBuffer;
    ///             VkBool32           dataGraphShaderModule;
    ///         } VkPhysicalDeviceDataGraphFeaturesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceDataGraphFeaturesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDataGraphFeaturesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DataGraph</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DataGraph;

        /// <summary>
        ///     <c>DataGraphUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DataGraphUpdateAfterBind;

        /// <summary>
        ///     <c>DataGraphSpecializationConstants</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 DataGraphSpecializationConstants;

        /// <summary>
        ///     <c>DataGraphDescriptorBuffer</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 DataGraphDescriptorBuffer;

        /// <summary>
        ///     <c>DataGraphShaderModule</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 DataGraphShaderModule;
    }
}
