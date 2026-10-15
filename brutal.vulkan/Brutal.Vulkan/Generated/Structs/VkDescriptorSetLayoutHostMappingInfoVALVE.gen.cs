namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutHostMappingInfoVALVE.html">VkDescriptorSetLayoutHostMappingInfoVALVE</see> - Stub description of VkDescriptorSetLayoutHostMappingInfoVALVE
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_descriptor_set_host_mapping
    ///         typedef struct VkDescriptorSetLayoutHostMappingInfoVALVE {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             size_t             descriptorOffset;
    ///             uint32_t           descriptorSize;
    ///         } VkDescriptorSetLayoutHostMappingInfoVALVE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDescriptorSetLayoutHostMappingInfoVALVE()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorSetLayoutHostMappingInfoVALVE;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DescriptorOffset</c>
        /// </summary>
        [FieldOffset(16)]
        public nuint DescriptorOffset;

        /// <summary>
        ///     <c>DescriptorSize</c>
        /// </summary>
        [FieldOffset(24)]
        public int DescriptorSize;
    }
}
