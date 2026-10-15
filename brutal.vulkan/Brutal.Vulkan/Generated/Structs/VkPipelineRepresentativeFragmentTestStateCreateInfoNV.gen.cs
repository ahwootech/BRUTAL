namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineRepresentativeFragmentTestStateCreateInfoNV.html">VkPipelineRepresentativeFragmentTestStateCreateInfoNV</see> - Structure specifying representative fragment test
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkGraphicsPipelineCreateInfo</c> includes a
    ///         <c>VkPipelineRepresentativeFragmentTestStateCreateInfoNV</c> structure, then
    ///         that structure includes parameters controlling the representative fragment
    ///         test.
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineRepresentativeFragmentTestStateCreateInfoNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_representative_fragment_test
    ///         typedef struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           representativeFragmentTestEnable;
    ///         } VkPipelineRepresentativeFragmentTestStateCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineRepresentativeFragmentTestStateCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RepresentativeFragmentTestEnable</c> controls whether the representative fragment test is enabled.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RepresentativeFragmentTestEnable;
    }
}
