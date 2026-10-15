namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableStatisticKHR.html">VkPipelineExecutableStatisticKHR</see> - Structure describing a compile time pipeline executable statistic
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineExecutableStatisticKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_executable_properties
    ///         typedef struct VkPipelineExecutableStatisticKHR {
    ///             VkStructureType                           sType;
    ///             void*                                     pNext;
    ///             char                                      name[VK_MAX_DESCRIPTION_SIZE];
    ///             char                                      description[VK_MAX_DESCRIPTION_SIZE];
    ///             VkPipelineExecutableStatisticFormatKHR    format;
    ///             VkPipelineExecutableStatisticValueKHR     value;
    ///         } VkPipelineExecutableStatisticKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 544)]
    public unsafe partial struct VkPipelineExecutableStatisticKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineExecutableStatisticKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        ///
        [FieldOffset(16)]
        public fixed byte Name[256];

        ///
        [FieldOffset(272)]
        public fixed byte Description[256];

        /// <summary>
        ///     <c>Format</c> is a <c>VkPipelineExecutableStatisticFormatKHR</c> value specifying the format of the data found in <c>value</c>.
        /// </summary>
        [FieldOffset(528)]
        public VkPipelineExecutableStatisticFormatKHR Format;

        /// <summary>
        ///     <c>Value</c> is the value of this statistic.
        /// </summary>
        [FieldOffset(536)]
        public VkPipelineExecutableStatisticValueKHR Value;
    }
}
