namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoBeginCodingInfoKHR.html">VkVideoBeginCodingInfoKHR</see> - Structure specifying video coding scope begin information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoBeginCodingInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkVideoBeginCodingInfoKHR {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkVideoBeginCodingFlagsKHR            flags;
    ///             VkVideoSessionKHR                     videoSession;
    ///             VkVideoSessionParametersKHR           videoSessionParameters;
    ///             uint32_t                              referenceSlotCount;
    ///             const VkVideoReferenceSlotInfoKHR*    pReferenceSlots;
    ///         } VkVideoBeginCodingInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkVideoBeginCodingInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoBeginCodingInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoBeginCodingFlagsKHR Flags;

        /// <summary>
        ///     <c>VideoSession</c> is the video session object to be bound for the processing of the video commands.
        /// </summary>
        [FieldOffset(24)]
        public VkVideoSessionKHR VideoSession;

        /// <summary>
        ///     <c>VideoSessionParameters</c> is <c>VK_NULL_HANDLE</c> or a handle of a <c>VkVideoSessionParametersKHR</c> object to be used for the processing of the video commands. If <c>VK_NULL_HANDLE</c>, then no video session parameters object is bound for the duration of the video coding scope.
        /// </summary>
        [FieldOffset(32)]
        public VkVideoSessionParametersKHR VideoSessionParameters;

        /// <summary>
        ///     <c>ReferenceSlotCount</c> is the number of elements in the <c>pReferenceSlots</c> array.
        /// </summary>
        [FieldOffset(40)]
        public int ReferenceSlotCount;

        /// <summary>
        ///     <c>ReferenceSlots</c> is a pointer to an array of <c>VkVideoReferenceSlotInfoKHR</c> structures specifying the information used to determine the set of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#bound-reference-picture-resources">bound reference picture resources^</see> for the video coding scope and their initial association with <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#dpb-slot">DPB slot^</see> indices.
        /// </summary>
        [FieldOffset(48)]
        public VkVideoReferenceSlotInfoKHR* ReferenceSlots;
    }
}
