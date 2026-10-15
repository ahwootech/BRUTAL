namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeInfoKHR.html">VkVideoEncodeInfoKHR</see> - Structure specifying video encode parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef struct VkVideoEncodeInfoKHR {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkVideoEncodeFlagsKHR                 flags;
    ///             VkBuffer                              dstBuffer;
    ///             VkDeviceSize                          dstBufferOffset;
    ///             VkDeviceSize                          dstBufferRange;
    ///             VkVideoPictureResourceInfoKHR         srcPictureResource;
    ///             const VkVideoReferenceSlotInfoKHR*    pSetupReferenceSlot;
    ///             uint32_t                              referenceSlotCount;
    ///             const VkVideoReferenceSlotInfoKHR*    pReferenceSlots;
    ///             uint32_t                              precedingExternallyEncodedBytes;
    ///         } VkVideoEncodeInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public unsafe partial struct VkVideoEncodeInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeInfoKHR;

        /// <summary>
        ///     <c>Next</c> is a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeFlagsKHR Flags;

        /// <summary>
        ///     <c>DstBuffer</c> is the destination video bitstream buffer to write the encoded bitstream to.
        /// </summary>
        [FieldOffset(24)]
        public VkBuffer DstBuffer;

        /// <summary>
        ///     <c>DstBufferOffset</c> is the starting offset in bytes from the start of <c>dstBuffer</c> to write the encoded bitstream to.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 DstBufferOffset;

        /// <summary>
        ///     <c>DstBufferRange</c> is the maximum bitstream size in bytes that <i>can</i> be written to <c>dstBuffer</c>, starting from <c>dstBufferOffset</c>.
        /// </summary>
        [FieldOffset(40)]
        public ByteSize64 DstBufferRange;

        /// <summary>
        ///     <c>SrcPictureResource</c> is the video picture resource to use as the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-input-picture">encode input picture^</see>.
        /// </summary>
        [FieldOffset(48)]
        public VkVideoPictureResourceInfoKHR SrcPictureResource;

        /// <summary>
        ///     <c>SetupReferenceSlot</c> is `NULL` or a pointer to a <c>VkVideoReferenceSlotInfoKHR</c> structure specifying the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-reconstructed-picture-info">reconstructed picture information^</see>.
        /// </summary>
        [FieldOffset(96)]
        public VkVideoReferenceSlotInfoKHR* SetupReferenceSlot;

        /// <summary>
        ///     <c>ReferenceSlotCount</c> is the number of elements in the <c>pReferenceSlots</c> array.
        /// </summary>
        [FieldOffset(104)]
        public int ReferenceSlotCount;

        /// <summary>
        ///     <c>ReferenceSlots</c> is `NULL` or a pointer to an array of <c>VkVideoReferenceSlotInfoKHR</c> structures describing the DPB slots and corresponding <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#reference-picture">reference picture^</see> resources to use in this video encode operation (the set of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#active-reference-pictures">active reference pictures^</see>).
        /// </summary>
        [FieldOffset(112)]
        public VkVideoReferenceSlotInfoKHR* ReferenceSlots;

        /// <summary>
        ///     <c>PrecedingExternallyEncodedBytes</c> is the number of bytes externally encoded by the application to the video bitstream and is used to update the internal state of the implementation&apos;s <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control">rate control^</see> algorithm to account for the bitrate budget consumed by these externally encoded bytes.
        /// </summary>
        [FieldOffset(120)]
        public int PrecedingExternallyEncodedBytes;
    }
}
