namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultShaderAbortMessageInfoKHR.html">VkDeviceFaultShaderAbortMessageInfoKHR</see> - Structure specifying message data from &lt;c&gt;OpAbortKHR&lt;/c&gt;
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceFaultShaderAbortMessageInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_shader_abort
    ///         typedef struct VkDeviceFaultShaderAbortMessageInfoKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint64_t           messageDataSize;
    ///             void*              pMessageData;
    ///         } VkDeviceFaultShaderAbortMessageInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDeviceFaultShaderAbortMessageInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceFaultShaderAbortMessageInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MessageDataSize</c> is the size of <c>pMessageData</c> in bytes. If <c>pMessageData</c> is `NULL`, this value is populated by the implementation.
        /// </summary>
        [FieldOffset(16)]
        public nint MessageDataSize;

        /// <summary>
        ///     <c>MessageData</c> is `NULL` or a pointer to <c>messageDataSize</c> bytes of data, which will be populated with data for messages reported via <c>OpAbortKHR</c>. If `pMessageData` is `NULL` then <c>messageDataSize</c> will be populated with the required size.
        /// </summary>
        [FieldOffset(24)]
        public void* MessageData;
    }
}
