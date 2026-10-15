namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoCapabilitiesKHR.html">VkVideoCapabilitiesKHR</see> - Structure describing general video capabilities for a video profile
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoCapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkVideoCapabilitiesKHR {
    ///             VkStructureType              sType;
    ///             void*                        pNext;
    ///             VkVideoCapabilityFlagsKHR    flags;
    ///             VkDeviceSize                 minBitstreamBufferOffsetAlignment;
    ///             VkDeviceSize                 minBitstreamBufferSizeAlignment;
    ///             VkExtent2D                   pictureAccessGranularity;
    ///             VkExtent2D                   minCodedExtent;
    ///             VkExtent2D                   maxCodedExtent;
    ///             uint32_t                     maxDpbSlots;
    ///             uint32_t                     maxActiveReferencePictures;
    ///             VkExtensionProperties        stdHeaderVersion;
    ///         } VkVideoCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 336)]
    public unsafe partial struct VkVideoCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoCapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkVideoCapabilityFlagsKHR</c> specifying capability flags.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoCapabilityFlagsKHR Flags;

        /// <summary>
        ///     <c>MinBitstreamBufferOffsetAlignment</c> is the minimum alignment for bitstream buffer offsets.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 MinBitstreamBufferOffsetAlignment;

        /// <summary>
        ///     <c>MinBitstreamBufferSizeAlignment</c> is the minimum alignment for bitstream buffer range sizes.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 MinBitstreamBufferSizeAlignment;

        /// <summary>
        ///     <c>PictureAccessGranularity</c> is the granularity at which image access to video picture resources happen.
        /// </summary>
        [FieldOffset(40)]
        public VkExtent2D PictureAccessGranularity;

        /// <summary>
        ///     <c>MinCodedExtent</c> is the minimum width and height of the coded frames.
        /// </summary>
        [FieldOffset(48)]
        public VkExtent2D MinCodedExtent;

        /// <summary>
        ///     <c>MaxCodedExtent</c> is the maximum width and height of the coded frames.
        /// </summary>
        [FieldOffset(56)]
        public VkExtent2D MaxCodedExtent;

        /// <summary>
        ///     <c>MaxDpbSlots</c> is the maximum number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#dpb-slot">DPB slots^</see> supported by a single video session.
        /// </summary>
        [FieldOffset(64)]
        public int MaxDpbSlots;

        /// <summary>
        ///     <c>MaxActiveReferencePictures</c> is the maximum number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#active-reference-pictures">active reference pictures^</see> a single video coding operation <i>can</i> use.
        /// </summary>
        [FieldOffset(68)]
        public int MaxActiveReferencePictures;

        /// <summary>
        ///     <c>StdHeaderVersion</c>
        /// </summary>
        [FieldOffset(72)]
        public VkExtensionProperties StdHeaderVersion;
    }
}
