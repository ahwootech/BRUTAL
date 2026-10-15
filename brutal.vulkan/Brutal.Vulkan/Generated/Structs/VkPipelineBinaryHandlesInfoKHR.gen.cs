namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryHandlesInfoKHR.html">VkPipelineBinaryHandlesInfoKHR</see> - Structure containing newly created pipeline binaries
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineBinaryHandlesInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_binary
    ///         typedef struct VkPipelineBinaryHandlesInfoKHR {
    ///             VkStructureType         sType;
    ///             const void*             pNext;
    ///             uint32_t                pipelineBinaryCount;
    ///             VkPipelineBinaryKHR*    pPipelineBinaries;
    ///         } VkPipelineBinaryHandlesInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineBinaryHandlesInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineBinaryHandlesInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineBinaryCount</c> is the number of binaries associated with this pipeline or the number of entries in the <c>pPipelineBinaries</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int PipelineBinaryCount;

        /// <summary>
        ///     <c>PipelineBinaries</c> is `NULL` or a pointer to an array of <c>VkPipelineBinaryKHR</c> handles in which the resulting pipeline binaries are returned.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineBinaryKHR* PipelineBinaries;
    }
}
