namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoSessionKHR.html">VkVideoSessionKHR</see> - Opaque handle to a video session object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Video sessions are objects that represent and maintain the state needed to
    ///         perform video decode or encode operations using a specific video profile.
    ///     </para>
    ///     <para>
    ///         Video sessions are represented by <c>VkVideoSessionKHR</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkVideoSessionKHR)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkVideoSessionKHR : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.VideoSessionKHR;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkVideoSessionKHR(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkVideoSessionKHR NullHandle = new();
    }
}
