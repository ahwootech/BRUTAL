namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDepthBiasRepresentationEXT.html">VkDepthBiasRepresentationEXT</see> - Specify the depth bias representation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkDepthBiasRepresentationInfoEXT::depthBiasRepresentation</c>,
    ///         specifying the depth bias representation are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_depth_bias_control
    ///         typedef enum VkDepthBiasRepresentationEXT {
    ///             VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORMAT_EXT = 0,
    ///             VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORCE_UNORM_EXT = 1,
    ///             VK_DEPTH_BIAS_REPRESENTATION_FLOAT_EXT = 2,
    ///         } VkDepthBiasRepresentationEXT;
    ///     </code>
    /// </remarks>
    public enum VkDepthBiasRepresentationEXT : int
    {
        /// <summary>
        ///     <c>LeastRepresentableValueFormatEXT</c>  specifies that the depth bias representation is a factor of the format&apos;s <c>r</c> as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-depthbias-computation">here</see>.
        /// </summary>
        LeastRepresentableValueFormatEXT = 0,

        /// <summary>
        ///     <c>LeastRepresentableValueForceUNormEXT</c>  specifies that the depth bias representation is a factor of a constant <c>r</c> defined by the bit-size or mantissa of the format as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-depthbias-computation">here</see>.
        /// </summary>
        LeastRepresentableValueForceUNormEXT = 1,

        /// <summary>
        ///     <c>FloatEXT</c> specifies that the depth bias representation is a factor of constant <c>r</c> equal to 1.
        /// </summary>
        FloatEXT = 2,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
