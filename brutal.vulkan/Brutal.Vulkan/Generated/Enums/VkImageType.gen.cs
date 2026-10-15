namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageType.html">VkImageType</see> - Specifies the type of an image object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkImageCreateInfo::imageType</c>, specifying the
    ///         basic dimensionality of an image, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkImageType {
    ///             VK_IMAGE_TYPE_1D = 0,
    ///             VK_IMAGE_TYPE_2D = 1,
    ///             VK_IMAGE_TYPE_3D = 2,
    ///         } VkImageType;
    ///     </code>
    /// </remarks>
    public enum VkImageType : int
    {
        /// <summary>
        ///     <c>_1D</c> specifies a one-dimensional image.
        /// </summary>
        _1D = 0,

        /// <summary>
        ///     <c>_2D</c> specifies a two-dimensional image.
        /// </summary>
        _2D = 1,

        /// <summary>
        ///     <c>_3D</c> specifies a three-dimensional image.
        /// </summary>
        _3D = 2,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
