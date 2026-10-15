namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImage.html">VkImage</see> - Opaque handle to an image object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Images are specialized resources that have multi-dimensional access, as
    ///         outlined in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#images">here</see> chapter.
    ///         Images <i>can</i> be used for various purposes, such as <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">rendering
    ///         attachments^</see>, <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#copies">for copy operations^</see>, or accessed through shaders
    ///         via <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors">resource descriptors^</see>.
    ///     </para>
    ///     <para>
    ///         Images are represented by <c>VkImage</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkImage)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkImage : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.Image;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkImage(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkImage NullHandle = new();
    }
}
