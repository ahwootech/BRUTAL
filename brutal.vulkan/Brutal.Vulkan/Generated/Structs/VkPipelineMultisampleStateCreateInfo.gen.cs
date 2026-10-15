namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineMultisampleStateCreateInfo.html">VkPipelineMultisampleStateCreateInfo</see> - Structure specifying parameters of a newly created pipeline multisample state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineMultisampleStateCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineMultisampleStateCreateInfo {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             VkPipelineMultisampleStateCreateFlags    flags;
    ///             VkSampleCountFlagBits                    rasterizationSamples;
    ///             VkBool32                                 sampleShadingEnable;
    ///             float                                    minSampleShading;
    ///             const VkSampleMask*                      pSampleMask;
    ///             VkBool32                                 alphaToCoverageEnable;
    ///             VkBool32                                 alphaToOneEnable;
    ///         } VkPipelineMultisampleStateCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPipelineMultisampleStateCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineMultisampleStateCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineMultisampleStateCreateFlags Flags;

        /// <summary>
        ///     <c>RasterizationSamples</c> is a <c>VkSampleCountFlags</c> value specifying the number of samples used in rasterization.
        /// </summary>
        [FieldOffset(20)]
        public VkSampleCountFlags RasterizationSamples;

        /// <summary>
        ///     <c>SampleShadingEnable</c> <i>can</i> be used to enable <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-sampleshading">Sample Shading^</see>.
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 SampleShadingEnable;

        /// <summary>
        ///     <c>MinSampleShading</c> specifies a minimum fraction of sample shading if <c>sampleShadingEnable</c> is <c>VK_TRUE</c>.
        /// </summary>
        [FieldOffset(28)]
        public float MinSampleShading;

        /// <summary>
        ///     <c>SampleMask</c> is a pointer to an array of basetype:VkSampleMask values used in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-samplemask">sample mask test^</see>.
        /// </summary>
        [FieldOffset(32)]
        public VkSampleMask* SampleMask;

        /// <summary>
        ///     <c>AlphaToCoverageEnable</c> controls whether a temporary coverage value is generated based on the alpha component of the fragment&apos;s first color output as specified in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-covg">Multisample Coverage^</see> section.
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 AlphaToCoverageEnable;

        /// <summary>
        ///     <c>AlphaToOneEnable</c> controls whether the alpha component of the fragment&apos;s first color output is replaced with one as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-covg">Multisample Coverage^</see>.
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 AlphaToOneEnable;
    }
}
