namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDepthClampModeEXT.html">VkDepthClampModeEXT</see> - Modes that determine the depth clamp range
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkPipelineViewportDepthClampControlCreateInfoEXT::depthClampMode</c>,
    ///         specifying which range should be used for depth clamping, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_depth_clamp_control
    ///         typedef enum VkDepthClampModeEXT {
    ///             VK_DEPTH_CLAMP_MODE_VIEWPORT_RANGE_EXT = 0,
    ///             VK_DEPTH_CLAMP_MODE_USER_DEFINED_RANGE_EXT = 1,
    ///         } VkDepthClampModeEXT;
    ///     </code>
    /// </remarks>
    public enum VkDepthClampModeEXT : int
    {
        /// <summary>
        ///     <c>ViewportRangeEXT</c> specifies that the depth clamp range follows the viewport depth range. The depth clamp range of each viewport will implicitly be set to <c>z~min~ = min(n,f)</c> and <c>z~max~ = max(n,f)</c>, where <c>n</c> and <c>f</c> are the <c>minDepth</c> and <c>maxDepth</c> depth range values of the viewport.
        /// </summary>
        ViewportRangeEXT = 0,

        /// <summary>
        ///     <c>UserDefinedRangeEXT</c> specifies that a single user-defined depth clamp range will be used for all viewports. The user-defined depth clamp range is defined by the <c>minDepthClamp</c> and <c>maxDepthClamp</c> members of <c>VkDepthClampRangeEXT</c>.
        /// </summary>
        UserDefinedRangeEXT = 1,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
