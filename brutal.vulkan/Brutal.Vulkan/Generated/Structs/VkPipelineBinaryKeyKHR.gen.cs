namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryKeyKHR.html">VkPipelineBinaryKeyKHR</see> - Structure specifying a key to a pipeline binary
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineBinaryKeyKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_binary
    ///         typedef struct VkPipelineBinaryKeyKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           keySize;
    ///             uint8_t            key[VK_MAX_PIPELINE_BINARY_KEY_SIZE_KHR];
    ///         } VkPipelineBinaryKeyKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkPipelineBinaryKeyKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineBinaryKeyKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>KeySize</c> is the size, in bytes, of valid data returned in <c>key</c>.
        /// </summary>
        [FieldOffset(16)]
        public int KeySize;

        ///
        [FieldOffset(20)]
        public fixed byte Key[32];
    }
}
