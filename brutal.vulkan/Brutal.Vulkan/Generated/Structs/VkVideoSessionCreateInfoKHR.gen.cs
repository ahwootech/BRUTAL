namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoSessionCreateInfoKHR.html">VkVideoSessionCreateInfoKHR</see> - Structure specifying parameters of a newly created video session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoSessionCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkVideoSessionCreateInfoKHR {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             uint32_t                        queueFamilyIndex;
    ///             VkVideoSessionCreateFlagsKHR    flags;
    ///             const VkVideoProfileInfoKHR*    pVideoProfile;
    ///             VkFormat                        pictureFormat;
    ///             VkExtent2D                      maxCodedExtent;
    ///             VkFormat                        referencePictureFormat;
    ///             uint32_t                        maxDpbSlots;
    ///             uint32_t                        maxActiveReferencePictures;
    ///             const VkExtensionProperties*    pStdHeaderVersion;
    ///         } VkVideoSessionCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkVideoSessionCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoSessionCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>QueueFamilyIndex</c> is the index of the queue family the created video session will be used with.
        /// </summary>
        [FieldOffset(16)]
        public int QueueFamilyIndex;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkVideoSessionCreateFlagsKHR</c> specifying creation flags.
        /// </summary>
        [FieldOffset(20)]
        public VkVideoSessionCreateFlagsKHR Flags;

        /// <summary>
        ///     <c>VideoProfile</c> is a pointer to a <c>VkVideoProfileInfoKHR</c> structure specifying the video profile the created video session will be used with.
        /// </summary>
        [FieldOffset(24)]
        public VkVideoProfileInfoKHR* VideoProfile;

        /// <summary>
        ///     <c>PictureFormat</c> is the image format the created video session will be used with.
        /// </summary>
        [FieldOffset(32)]
        public VkFormat PictureFormat;

        /// <summary>
        ///     <c>MaxCodedExtent</c> is the maximum width and height of the coded frames the created video session will be used with.
        /// </summary>
        [FieldOffset(36)]
        public VkExtent2D MaxCodedExtent;

        /// <summary>
        ///     <c>ReferencePictureFormat</c> is the image format of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#reference-picture">reference pictures^</see> stored in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#dpb">DPB^</see> the created video session will be used with.
        /// </summary>
        [FieldOffset(44)]
        public VkFormat ReferencePictureFormat;

        /// <summary>
        ///     <c>MaxDpbSlots</c> is the maximum number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#dpb-slot">DPB Slots^</see> that <i>can</i> be used with the created video session.
        /// </summary>
        [FieldOffset(48)]
        public int MaxDpbSlots;

        /// <summary>
        ///     <c>MaxActiveReferencePictures</c> is the maximum number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#active-reference-pictures">active reference pictures^</see> that <i>can</i> be used in a single video coding operation using the created video session.
        /// </summary>
        [FieldOffset(52)]
        public int MaxActiveReferencePictures;

        /// <summary>
        ///     <c>StdHeaderVersion</c> is a pointer to a <c>VkExtensionProperties</c> structure requesting the Video Std header version to use for the <c>videoCodecOperation</c> specified in <c>pVideoProfile</c>.
        /// </summary>
        [FieldOffset(56)]
        public VkExtensionProperties* StdHeaderVersion;
    }
}
