namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE.html">VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE</see> - Stub description of VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_descriptor_set_host_mapping
    ///         typedef struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           descriptorSetHostMapping;
    ///         } VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDescriptorSetHostMappingFeaturesVALVE;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DescriptorSetHostMapping</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DescriptorSetHostMapping;
    }
}
