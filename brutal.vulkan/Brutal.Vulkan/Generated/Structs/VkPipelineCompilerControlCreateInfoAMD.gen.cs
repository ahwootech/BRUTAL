namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCompilerControlCreateInfoAMD.html">VkPipelineCompilerControlCreateInfoAMD</see> - Structure used to pass compilation control flags to a pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The compilation of a pipeline <i>can</i> be tuned by adding a
    ///         <c>VkPipelineCompilerControlCreateInfoAMD</c> structure to the <c>pNext</c>
    ///         chain of <c>VkGraphicsPipelineCreateInfo</c> or
    ///         <c>VkComputePipelineCreateInfo</c>.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_pipeline_compiler_control
    ///         typedef struct VkPipelineCompilerControlCreateInfoAMD {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkPipelineCompilerControlFlagsAMD    compilerControlFlags;
    ///         } VkPipelineCompilerControlCreateInfoAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineCompilerControlCreateInfoAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineCompilerControlCreateInfoAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CompilerControlFlags</c> is a bitmask of <c>VkPipelineCompilerControlFlagsAMD</c> affecting how the pipeline will be compiled.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineCompilerControlFlagsAMD CompilerControlFlags;
    }
}
