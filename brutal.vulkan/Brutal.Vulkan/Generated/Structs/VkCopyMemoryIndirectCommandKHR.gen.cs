namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryIndirectCommandKHR.html">VkCopyMemoryIndirectCommandKHR</see> - Structure specifying indirect memory region copy operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyMemoryIndirectCommandKHR
    ///     </para>
    ///     <para>
    ///         The structure describing source and destination memory regions,
    ///         <c>VkCopyMemoryIndirectCommandKHR</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_copy_memory_indirect
    ///         typedef struct VkCopyMemoryIndirectCommandKHR {
    ///             VkDeviceAddress    srcAddress;
    ///             VkDeviceAddress    dstAddress;
    ///             VkDeviceSize       size;
    ///         } VkCopyMemoryIndirectCommandKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkCopyMemoryIndirectCommandKHR()
    {
        /// <summary>
        ///     <c>SrcAddress</c> is the starting address of the source device memory to copy from.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress SrcAddress;

        /// <summary>
        ///     <c>DstAddress</c> is the starting address of the destination device memory to copy to.
        /// </summary>
        [FieldOffset(8)]
        public VkDeviceAddress DstAddress;

        /// <summary>
        ///     <c>Size</c> is the size of the copy in bytes.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 Size;
    }
}
