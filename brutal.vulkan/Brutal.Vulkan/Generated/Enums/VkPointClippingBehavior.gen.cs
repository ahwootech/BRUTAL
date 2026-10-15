namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPointClippingBehavior.html">VkPointClippingBehavior</see> - Enum specifying the point clipping behavior
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkPhysicalDevicePointClippingProperties::pointClippingBehavior</c>,
    ///         specifying clipping behavior of a point primitive whose vertex lies outside
    ///         the clip volume, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkPointClippingBehavior {
    ///             VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES = 0,
    ///             VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY = 1,
    ///             // Provided by VK_KHR_maintenance2
    ///             VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES_KHR = VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES,
    ///             // Provided by VK_KHR_maintenance2
    ///             VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY_KHR = VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY,
    ///         } VkPointClippingBehavior;
    ///     </code>
    /// </remarks>
    public enum VkPointClippingBehavior : int
    {
        /// <summary>
        ///     <c>AllClipPlanes</c> specifies that the primitive is discarded if the vertex lies outside any clip plane, including the planes bounding the view volume.
        /// </summary>
        AllClipPlanes = 0,

        /// <summary>
        ///     <c>UserClipPlanesOnly</c> specifies that the primitive is discarded only if the vertex lies outside any user clip plane.
        /// </summary>
        UserClipPlanesOnly = 1,

        /// <summary>
        ///     <c>AllClipPlanesKHR</c>
        /// </summary>
        AllClipPlanesKHR = AllClipPlanes,

        /// <summary>
        ///     <c>UserClipPlanesOnlyKHR</c>
        /// </summary>
        UserClipPlanesOnlyKHR = UserClipPlanesOnly,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
