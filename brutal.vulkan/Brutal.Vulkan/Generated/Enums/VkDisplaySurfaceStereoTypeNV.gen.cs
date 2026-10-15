namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplaySurfaceStereoTypeNV.html">VkDisplaySurfaceStereoTypeNV</see> - 3D Stereo type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkDisplaySurfaceStereoCreateInfoNV::stereoType</c>, specifying the
    ///         type of 3D stereo presentation the display will be configured for, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_display_stereo
    ///         typedef enum VkDisplaySurfaceStereoTypeNV {
    ///             VK_DISPLAY_SURFACE_STEREO_TYPE_NONE_NV = 0,
    ///             VK_DISPLAY_SURFACE_STEREO_TYPE_ONBOARD_DIN_NV = 1,
    ///             VK_DISPLAY_SURFACE_STEREO_TYPE_HDMI_3D_NV = 2,
    ///             VK_DISPLAY_SURFACE_STEREO_TYPE_INBAND_DISPLAYPORT_NV = 3,
    ///         } VkDisplaySurfaceStereoTypeNV;
    ///     </code>
    /// </remarks>
    public enum VkDisplaySurfaceStereoTypeNV : int
    {
        /// <summary>
        ///     <c>NoneNV</c> specifies no configuration for stereo presentation. This is the default behavior if <c>VkDisplaySurfaceStereoCreateInfoNV</c> is not provided.
        /// </summary>
        NoneNV = 0,

        /// <summary>
        ///     <c>OnboardDinNV</c> specifies configuration for glasses that connect via a DIN connector on the back of the graphics card.
        /// </summary>
        OnboardDinNV = 1,

        /// <summary>
        ///     <c>Hdmi3DNV</c> specifies configuration for HDMI 3D compatible display devices with their own stereo emitters. This is also known as HDMI Frame Packed Stereo, where the left and right eye images are stacked into a single frame with a doubled pixel clock and refresh rate.
        /// </summary>
        Hdmi3DNV = 2,

        /// <summary>
        ///     <c>InbandDisplayportNV</c> specifies configuration for DisplayPort display devices with in-band stereo signaling and emitters.
        /// </summary>
        InbandDisplayportNV = 3,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
