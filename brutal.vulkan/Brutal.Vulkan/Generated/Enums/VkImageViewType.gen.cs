namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageViewType.html">VkImageViewType</see> - Image view types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The types of image views that <i>can</i> be created are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkImageViewType {
    ///             VK_IMAGE_VIEW_TYPE_1D = 0,
    ///             VK_IMAGE_VIEW_TYPE_2D = 1,
    ///             VK_IMAGE_VIEW_TYPE_3D = 2,
    ///             VK_IMAGE_VIEW_TYPE_CUBE = 3,
    ///             VK_IMAGE_VIEW_TYPE_1D_ARRAY = 4,
    ///             VK_IMAGE_VIEW_TYPE_2D_ARRAY = 5,
    ///             VK_IMAGE_VIEW_TYPE_CUBE_ARRAY = 6,
    ///         } VkImageViewType;
    ///     </code>
    /// </remarks>
    public enum VkImageViewType : int
    {
        /// <summary>
        ///     <c>_1D</c>
        /// </summary>
        _1D = 0,

        /// <summary>
        ///     <c>_2D</c>
        /// </summary>
        _2D = 1,

        /// <summary>
        ///     <c>_3D</c>
        /// </summary>
        _3D = 2,

        /// <summary>
        ///     <c>Cube</c>
        /// </summary>
        Cube = 3,

        /// <summary>
        ///     <c>_1DArray</c>
        /// </summary>
        _1DArray = 4,

        /// <summary>
        ///     <c>_2DArray</c>
        /// </summary>
        _2DArray = 5,

        /// <summary>
        ///     <c>CubeArray</c>
        /// </summary>
        CubeArray = 6,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
