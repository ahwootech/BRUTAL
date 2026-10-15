namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoReferenceSlotInfoKHR.html">VkVideoReferenceSlotInfoKHR</see> - Structure specifying information about a reference picture slot
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoReferenceSlotInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkVideoReferenceSlotInfoKHR {
    ///             VkStructureType                         sType;
    ///             const void*                             pNext;
    ///             int32_t                                 slotIndex;
    ///             const VkVideoPictureResourceInfoKHR*    pPictureResource;
    ///         } VkVideoReferenceSlotInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoReferenceSlotInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoReferenceSlotInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SlotIndex</c> is the index of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#dpb-slot">DPB slot^</see> or a negative integer value.
        /// </summary>
        [FieldOffset(16)]
        public int SlotIndex;

        /// <summary>
        ///     <c>PictureResource</c> is `NULL` or a pointer to a <c>VkVideoPictureResourceInfoKHR</c> structure describing the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#video-picture-resources">video picture resource^</see> associated with the DPB slot index specified by <c>slotIndex</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkVideoPictureResourceInfoKHR* PictureResource;
    }
}
