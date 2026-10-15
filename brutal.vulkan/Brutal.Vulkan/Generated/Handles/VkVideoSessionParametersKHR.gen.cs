namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoSessionParametersKHR.html">VkVideoSessionParametersKHR</see> - Opaque handle to a video session parameters object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Video session parameters are represented by
    ///         <c>VkVideoSessionParametersKHR</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkVideoSessionParametersKHR)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkVideoSessionParametersKHR : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.VideoSessionParametersKHR;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkVideoSessionParametersKHR(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkVideoSessionParametersKHR NullHandle = new();
    }
}
