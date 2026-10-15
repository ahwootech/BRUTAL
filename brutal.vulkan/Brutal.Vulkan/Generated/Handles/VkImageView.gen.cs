namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageView.html">VkImageView</see> - Opaque handle to an image view object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Image objects are not directly accessed by pipeline shaders for reading or
    ///         writing image data.
    ///         Instead, <i>image views</i> representing contiguous ranges of the image
    ///         subresources and containing additional metadata are used for that purpose.
    ///         Views <i>must</i> be created on images of compatible types, and <i>must</i> represent a
    ///         valid subset of image subresources.
    ///     </para>
    ///     <para>
    ///         Image views are represented by <c>VkImageView</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkImageView)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkImageView : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.ImageView;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkImageView(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkImageView NullHandle = new();
    }
}
