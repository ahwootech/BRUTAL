namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayModeKHR.html">VkDisplayModeKHR</see> - Opaque handle to a display mode object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Display modes are represented by <c>VkDisplayModeKHR</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_display
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkDisplayModeKHR)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkDisplayModeKHR : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.DisplayModeKHR;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkDisplayModeKHR(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkDisplayModeKHR NullHandle = new();
    }
}
