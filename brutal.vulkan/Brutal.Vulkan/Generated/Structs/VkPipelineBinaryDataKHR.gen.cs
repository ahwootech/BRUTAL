namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryDataKHR.html">VkPipelineBinaryDataKHR</see> - Structure specifying data and length of a pipeline binary
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineBinaryDataKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_binary
    ///         typedef struct VkPipelineBinaryDataKHR {
    ///             size_t    dataSize;
    ///             void*     pData;
    ///         } VkPipelineBinaryDataKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkPipelineBinaryDataKHR()
    {
        /// <summary>
        ///     <c>DataSize</c> is the size of the <c>pData</c> buffer in bytes.
        /// </summary>
        [FieldOffset(0)]
        public nuint DataSize;

        /// <summary>
        ///     <c>Data</c> is a pointer to a buffer of <c>size</c> bytes that contains pipeline binary data obtained from <c>vkGetPipelineBinaryDataKHR</c>.
        /// </summary>
        [FieldOffset(8)]
        public void* Data;
    }
}
