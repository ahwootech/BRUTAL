namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetBindingReferenceVALVE.html">VkDescriptorSetBindingReferenceVALVE</see> - Stub description of VkDescriptorSetBindingReferenceVALVE
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_descriptor_set_host_mapping
    ///         typedef struct VkDescriptorSetBindingReferenceVALVE {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkDescriptorSetLayout    descriptorSetLayout;
    ///             uint32_t                 binding;
    ///         } VkDescriptorSetBindingReferenceVALVE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDescriptorSetBindingReferenceVALVE()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorSetBindingReferenceVALVE;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DescriptorSetLayout</c>
        /// </summary>
        [FieldOffset(16)]
        public VkDescriptorSetLayout DescriptorSetLayout;

        /// <summary>
        ///     <c>Binding</c>
        /// </summary>
        [FieldOffset(24)]
        public int Binding;
    }
}
