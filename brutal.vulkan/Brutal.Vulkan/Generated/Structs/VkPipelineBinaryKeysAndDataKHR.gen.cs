namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryKeysAndDataKHR.html">VkPipelineBinaryKeysAndDataKHR</see> - Structure specifying arrays of key and data pairs
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineBinaryKeysAndDataKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_binary
    ///         typedef struct VkPipelineBinaryKeysAndDataKHR {
    ///             uint32_t                          binaryCount;
    ///             const VkPipelineBinaryKeyKHR*     pPipelineBinaryKeys;
    ///             const VkPipelineBinaryDataKHR*    pPipelineBinaryData;
    ///         } VkPipelineBinaryKeysAndDataKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineBinaryKeysAndDataKHR()
    {
        /// <summary>
        ///     <c>BinaryCount</c> is the size of the <c>pPipelineBinaryKeys</c> and <c>pPipelineBinaryData</c> arrays
        /// </summary>
        [FieldOffset(0)]
        public int BinaryCount;

        /// <summary>
        ///     <c>PipelineBinaryKeys</c> is a pointer to an array of <c>VkPipelineBinaryKeyKHR</c> structures containing the pipeline binary keys
        /// </summary>
        [FieldOffset(8)]
        public VkPipelineBinaryKeyKHR* PipelineBinaryKeys;

        /// <summary>
        ///     <c>PipelineBinaryData</c> is a pointer to an array of <c>VkPipelineBinaryDataKHR</c> structures containing the pipeline binary data
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineBinaryDataKHR* PipelineBinaryData;
    }
}
