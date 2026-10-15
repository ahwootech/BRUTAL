namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOutOfBandQueueTypeInfoNV.html">VkOutOfBandQueueTypeInfoNV</see> - Structure used to describe the queue that is being marked as Out of Band
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkOutOfBandQueueTypeInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_low_latency2
    ///         typedef struct VkOutOfBandQueueTypeInfoNV {
    ///             VkStructureType           sType;
    ///             const void*               pNext;
    ///             VkOutOfBandQueueTypeNV    queueType;
    ///         } VkOutOfBandQueueTypeInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkOutOfBandQueueTypeInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.OutOfBandQueueTypeInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>QueueType</c> describes the usage of the queue to be marked as out of band.
        /// </summary>
        [FieldOffset(16)]
        public VkOutOfBandQueueTypeNV QueueType;
    }
}
