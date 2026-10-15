namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayKHR.html">VkDisplayKHR</see> - Opaque handle to a display object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Displays are represented by <c>VkDisplayKHR</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_display
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkDisplayKHR)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkDisplayKHR : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.DisplayKHR;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkDisplayKHR(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkDisplayKHR NullHandle = new();
    }
}
