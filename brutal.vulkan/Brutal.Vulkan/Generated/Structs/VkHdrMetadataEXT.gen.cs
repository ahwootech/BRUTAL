namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkHdrMetadataEXT.html">VkHdrMetadataEXT</see> - Specify HDR metadata
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkHdrMetadataEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_hdr_metadata
    ///         typedef struct VkHdrMetadataEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkXYColorEXT       displayPrimaryRed;
    ///             VkXYColorEXT       displayPrimaryGreen;
    ///             VkXYColorEXT       displayPrimaryBlue;
    ///             VkXYColorEXT       whitePoint;
    ///             float              maxLuminance;
    ///             float              minLuminance;
    ///             float              maxContentLightLevel;
    ///             float              maxFrameAverageLightLevel;
    ///         } VkHdrMetadataEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkHdrMetadataEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.HdrMetadataEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DisplayPrimaryRed</c> is a <c>VkXYColorEXT</c> structure specifying the red primary of the display used to optimize the content
        /// </summary>
        [FieldOffset(16)]
        public VkXYColorEXT DisplayPrimaryRed;

        /// <summary>
        ///     <c>DisplayPrimaryGreen</c> is a <c>VkXYColorEXT</c> structure specifying the green primary of the display used to optimize the content
        /// </summary>
        [FieldOffset(24)]
        public VkXYColorEXT DisplayPrimaryGreen;

        /// <summary>
        ///     <c>DisplayPrimaryBlue</c> is a <c>VkXYColorEXT</c> structure specifying the blue primary of the display used to optimize the content
        /// </summary>
        [FieldOffset(32)]
        public VkXYColorEXT DisplayPrimaryBlue;

        /// <summary>
        ///     <c>WhitePoint</c> is a <c>VkXYColorEXT</c> structure specifying the white-point of the display used to optimize the content
        /// </summary>
        [FieldOffset(40)]
        public VkXYColorEXT WhitePoint;

        /// <summary>
        ///     <c>MaxLuminance</c> is the maximum luminance of the display used to optimize the content in nits
        /// </summary>
        [FieldOffset(48)]
        public float MaxLuminance;

        /// <summary>
        ///     <c>MinLuminance</c> is the minimum luminance of the display used to optimize the content in nits
        /// </summary>
        [FieldOffset(52)]
        public float MinLuminance;

        /// <summary>
        ///     <c>MaxContentLightLevel</c> is the value in nits of the desired luminance for the brightest pixels in the displayed image.
        /// </summary>
        [FieldOffset(56)]
        public float MaxContentLightLevel;

        /// <summary>
        ///     <c>MaxFrameAverageLightLevel</c> is the value in nits of the average luminance of the frame which has the brightest average luminance anywhere in the content.
        /// </summary>
        [FieldOffset(60)]
        public float MaxFrameAverageLightLevel;
    }
}
