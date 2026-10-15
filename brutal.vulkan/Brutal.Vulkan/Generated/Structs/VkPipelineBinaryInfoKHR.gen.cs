namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryInfoKHR.html">VkPipelineBinaryInfoKHR</see> - Structure specifying pipeline binaries to use during pipeline creation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineBinaryInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_binary
    ///         typedef struct VkPipelineBinaryInfoKHR {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             uint32_t                      binaryCount;
    ///             const VkPipelineBinaryKHR*    pPipelineBinaries;
    ///         } VkPipelineBinaryInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineBinaryInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineBinaryInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>BinaryCount</c> is the number of elements in the <c>pPipelineBinaries</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int BinaryCount;

        /// <summary>
        ///     <c>PipelineBinaries</c> is a pointer to an array of <c>VkPipelineBinaryKHR</c> handles.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineBinaryKHR* PipelineBinaries;
    }
}
