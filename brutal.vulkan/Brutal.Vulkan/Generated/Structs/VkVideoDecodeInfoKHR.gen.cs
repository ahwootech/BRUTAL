namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeInfoKHR.html">VkVideoDecodeInfoKHR</see> - Structure specifying video decode parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoDecodeInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_queue
    ///         typedef struct VkVideoDecodeInfoKHR {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkVideoDecodeFlagsKHR                 flags;
    ///             VkBuffer                              srcBuffer;
    ///             VkDeviceSize                          srcBufferOffset;
    ///             VkDeviceSize                          srcBufferRange;
    ///             VkVideoPictureResourceInfoKHR         dstPictureResource;
    ///             const VkVideoReferenceSlotInfoKHR*    pSetupReferenceSlot;
    ///             uint32_t                              referenceSlotCount;
    ///             const VkVideoReferenceSlotInfoKHR*    pReferenceSlots;
    ///         } VkVideoDecodeInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public unsafe partial struct VkVideoDecodeInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoDecodeFlagsKHR Flags;

        /// <summary>
        ///     <c>SrcBuffer</c> is the source video bitstream buffer to read the encoded bitstream from.
        /// </summary>
        [FieldOffset(24)]
        public VkBuffer SrcBuffer;

        /// <summary>
        ///     <c>SrcBufferOffset</c> is the starting offset in bytes from the start of <c>srcBuffer</c> to read the encoded bitstream from.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 SrcBufferOffset;

        /// <summary>
        ///     <c>SrcBufferRange</c> is the size in bytes of the encoded bitstream to decode from <c>srcBuffer</c>, starting from <c>srcBufferOffset</c>.
        /// </summary>
        [FieldOffset(40)]
        public ByteSize64 SrcBufferRange;

        /// <summary>
        ///     <c>DstPictureResource</c> is the video picture resource to use as the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-output-picture">decode output picture^</see>.
        /// </summary>
        [FieldOffset(48)]
        public VkVideoPictureResourceInfoKHR DstPictureResource;

        /// <summary>
        ///     <c>SetupReferenceSlot</c> is `NULL` or a pointer to a <c>VkVideoReferenceSlotInfoKHR</c> structure specifying the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-reconstructed-picture-info">reconstructed picture information^</see>.
        /// </summary>
        [FieldOffset(96)]
        public VkVideoReferenceSlotInfoKHR* SetupReferenceSlot;

        /// <summary>
        ///     <c>ReferenceSlotCount</c> is the number of elements in the <c>pReferenceSlots</c> array.
        /// </summary>
        [FieldOffset(104)]
        public int ReferenceSlotCount;

        /// <summary>
        ///     <c>ReferenceSlots</c> is `NULL` or a pointer to an array of <c>VkVideoReferenceSlotInfoKHR</c> structures describing the DPB slots and corresponding <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#reference-picture">reference picture^</see> resources to use in this video decode operation (the set of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#active-reference-pictures">active reference pictures^</see>).
        /// </summary>
        [FieldOffset(112)]
        public VkVideoReferenceSlotInfoKHR* ReferenceSlots;
    }
}
