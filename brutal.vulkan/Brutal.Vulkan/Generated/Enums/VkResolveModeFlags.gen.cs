namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkResolveModeFlagBits.html">VkResolveModeFlagBits</see> - Bitmask indicating supported depth and stencil resolve modes
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Multisample values in a multisample attachment are combined according to the
    ///         resolve mode used:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef enum VkResolveModeFlagBits {
    ///             VK_RESOLVE_MODE_NONE = 0,
    ///             VK_RESOLVE_MODE_SAMPLE_ZERO_BIT = 0x00000001,
    ///             VK_RESOLVE_MODE_AVERAGE_BIT = 0x00000002,
    ///             VK_RESOLVE_MODE_MIN_BIT = 0x00000004,
    ///             VK_RESOLVE_MODE_MAX_BIT = 0x00000008,
    ///             // Provided by VK_ANDROID_external_format_resolve with VK_KHR_dynamic_rendering or VK_VERSION_1_3
    ///             VK_RESOLVE_MODE_EXTERNAL_FORMAT_DOWNSAMPLE_BIT_ANDROID = 0x00000010,
    ///             // Provided by VK_EXT_custom_resolve with VK_KHR_dynamic_rendering or VK_VERSION_1_3
    ///             VK_RESOLVE_MODE_CUSTOM_BIT_EXT = 0x00000020,
    ///             // Provided by VK_KHR_depth_stencil_resolve
    ///             VK_RESOLVE_MODE_NONE_KHR = VK_RESOLVE_MODE_NONE,
    ///             // Provided by VK_KHR_depth_stencil_resolve
    ///             VK_RESOLVE_MODE_SAMPLE_ZERO_BIT_KHR = VK_RESOLVE_MODE_SAMPLE_ZERO_BIT,
    ///             // Provided by VK_KHR_depth_stencil_resolve
    ///             VK_RESOLVE_MODE_AVERAGE_BIT_KHR = VK_RESOLVE_MODE_AVERAGE_BIT,
    ///             // Provided by VK_KHR_depth_stencil_resolve
    ///             VK_RESOLVE_MODE_MIN_BIT_KHR = VK_RESOLVE_MODE_MIN_BIT,
    ///             // Provided by VK_KHR_depth_stencil_resolve
    ///             VK_RESOLVE_MODE_MAX_BIT_KHR = VK_RESOLVE_MODE_MAX_BIT,
    ///             // Provided by VK_ANDROID_external_format_resolve with VK_KHR_dynamic_rendering or VK_VERSION_1_3
    ///             // VK_RESOLVE_MODE_EXTERNAL_FORMAT_DOWNSAMPLE_ANDROID is a legacy alias
    ///             VK_RESOLVE_MODE_EXTERNAL_FORMAT_DOWNSAMPLE_ANDROID = VK_RESOLVE_MODE_EXTERNAL_FORMAT_DOWNSAMPLE_BIT_ANDROID,
    ///         } VkResolveModeFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkResolveModeFlags : int
    {
        /// <summary>
        ///     <c>None</c> specifies that no resolve operation is done.
        /// </summary>
        None = 0,

        /// <summary>
        ///     <c>SampleZeroBit</c> specifies that result of the resolve operation is equal to the value of sample 0.
        /// </summary>
        SampleZeroBit = 0x00000001,

        /// <summary>
        ///     <c>AverageBit</c> specifies that result of the resolve operation is the average of the sample values.
        /// </summary>
        AverageBit = 0x00000002,

        /// <summary>
        ///     <c>MinBit</c> specifies that result of the resolve operation is the minimum of the sample values.
        /// </summary>
        MinBit = 0x00000004,

        /// <summary>
        ///     <c>MaxBit</c> specifies that result of the resolve operation is the maximum of the sample values.  If no resolve mode is otherwise specified, <c>VK_RESOLVE_MODE_AVERAGE_BIT</c> is used.  If <c>VK_RESOLVE_MODE_AVERAGE_BIT</c> is used, and the source format is a floating-point or normalized type, the sample values for each pixel are resolved with implementation-defined numerical precision.  If the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#formats-numericformat">numeric format^</see> of the resolve attachment uses sRGB encoding, the implementation <i>should</i> convert samples from nonlinear to linear before averaging samples as described in the &quot;`sRGB EOTF`&quot; section of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#data-format">Khronos Data Format Specification^</see>. In this case, the implementation <i>must</i> convert the linear averaged value to nonlinear before writing the resolved result to resolve attachment.
        /// </summary>
        MaxBit = 0x00000008,

        /// <summary>
        ///     <c>ExternalFormatDownsampleBitANDROID</c>
        /// </summary>
        ExternalFormatDownsampleBitANDROID = 0x00000010,

        /// <summary>
        ///     <c>CustomBitEXT</c>
        /// </summary>
        CustomBitEXT = 0x00000020,

        /// <summary>
        ///     <c>NoneKHR</c>
        /// </summary>
        NoneKHR = None,

        /// <summary>
        ///     <c>SampleZeroBitKHR</c>
        /// </summary>
        SampleZeroBitKHR = SampleZeroBit,

        /// <summary>
        ///     <c>AverageBitKHR</c>
        /// </summary>
        AverageBitKHR = AverageBit,

        /// <summary>
        ///     <c>MinBitKHR</c>
        /// </summary>
        MinBitKHR = MinBit,

        /// <summary>
        ///     <c>MaxBitKHR</c>
        /// </summary>
        MaxBitKHR = MaxBit,

        /// <summary>
        ///     <c>ExternalFormatDownsampleANDROID</c>
        /// </summary>
        ExternalFormatDownsampleANDROID = ExternalFormatDownsampleBitANDROID,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
