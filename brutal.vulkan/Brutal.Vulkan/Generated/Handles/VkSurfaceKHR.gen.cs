namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceKHR.html">VkSurfaceKHR</see> - Opaque handle to a surface object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Native platform surface or window objects are abstracted by surface objects,
    ///         which are represented by <c>VkSurfaceKHR</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_surface
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkSurfaceKHR)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkSurfaceKHR : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.SurfaceKHR;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkSurfaceKHR(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkSurfaceKHR NullHandle = new();
    }
}
