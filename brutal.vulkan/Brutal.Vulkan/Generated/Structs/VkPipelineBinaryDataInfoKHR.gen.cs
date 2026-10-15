namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryDataInfoKHR.html">VkPipelineBinaryDataInfoKHR</see> - Structure specifying a pipeline binary to retrieve binary data from
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineBinaryDataInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_binary
    ///         typedef struct VkPipelineBinaryDataInfoKHR {
    ///             VkStructureType        sType;
    ///             void*                  pNext;
    ///             VkPipelineBinaryKHR    pipelineBinary;
    ///         } VkPipelineBinaryDataInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineBinaryDataInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineBinaryDataInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineBinary</c> is the pipeline binary to get data from.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineBinaryKHR PipelineBinary;
    }
}
