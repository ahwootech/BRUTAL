namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineCompilerControlCreateInfoARM.html">VkDataGraphPipelineCompilerControlCreateInfoARM</see> - Structure specifying compiler control parameters of a newly created data graph pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineCompilerControlCreateInfoARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineCompilerControlCreateInfoARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkDataGraphPipelineCompilerControlCreateInfoARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             const char*        pVendorOptions;
    ///         } VkDataGraphPipelineCompilerControlCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDataGraphPipelineCompilerControlCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineCompilerControlCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VendorOptions</c> is a null-terminated UTF-8 string specifying implementation-specific options that affect the creation of a data graph pipeline.
        /// </summary>
        [FieldOffset(16)]
        public byte* VendorOptions;
    }
}
