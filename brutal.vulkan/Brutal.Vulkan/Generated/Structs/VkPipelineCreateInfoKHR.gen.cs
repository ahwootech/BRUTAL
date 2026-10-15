namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCreateInfoKHR.html">VkPipelineCreateInfoKHR</see> - Structure specifying a pipeline createinfo chain
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_binary
    ///         typedef struct VkPipelineCreateInfoKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///         } VkPipelineCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkPipelineCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;
    }
}
