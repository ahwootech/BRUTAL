namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayModeStereoPropertiesNV.html">VkDisplayModeStereoPropertiesNV</see> - Structure describing the stereo properties of a display mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayModeStereoPropertiesNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_display_stereo
    ///         typedef struct VkDisplayModeStereoPropertiesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           hdmi3DSupported;
    ///         } VkDisplayModeStereoPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDisplayModeStereoPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DisplayModeStereoPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Hdmi3DSupported</c> indicates whether this display mode can be used for a display surface configured for <c>VK_DISPLAY_SURFACE_STEREO_TYPE_HDMI_3D_NV</c>.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 Hdmi3DSupported;
    }
}
