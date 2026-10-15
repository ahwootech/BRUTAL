namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineSampleLocationsStateCreateInfoEXT.html">VkPipelineSampleLocationsStateCreateInfoEXT</see> - Structure specifying sample locations for a pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Applications <i>can</i> also control the sample locations used for rasterization.
    ///     </para>
    ///     <para>
    ///         If the <c>pNext</c> chain of the <c>VkPipelineMultisampleStateCreateInfo</c>
    ///         structure specified at pipeline creation time includes a
    ///         <c>VkPipelineSampleLocationsStateCreateInfoEXT</c> structure, then that
    ///         structure controls the sample locations used when rasterizing primitives
    ///         with the pipeline.
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineSampleLocationsStateCreateInfoEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_sample_locations
    ///         typedef struct VkPipelineSampleLocationsStateCreateInfoEXT {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkBool32                    sampleLocationsEnable;
    ///             VkSampleLocationsInfoEXT    sampleLocationsInfo;
    ///         } VkPipelineSampleLocationsStateCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkPipelineSampleLocationsStateCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineSampleLocationsStateCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SampleLocationsEnable</c> controls whether custom sample locations are used. If <c>sampleLocationsEnable</c> is <c>VK_FALSE</c>, the default sample locations are used and the values specified in <c>sampleLocationsInfo</c> are ignored.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SampleLocationsEnable;

        /// <summary>
        ///     <c>SampleLocationsInfo</c> is the sample locations to use during rasterization if <c>sampleLocationsEnable</c> is <c>VK_TRUE</c> and the graphics pipeline is not created with <c>VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkSampleLocationsInfoEXT SampleLocationsInfo;
    }
}
