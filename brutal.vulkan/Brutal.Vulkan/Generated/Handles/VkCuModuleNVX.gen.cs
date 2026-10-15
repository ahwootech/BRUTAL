namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCuModuleNVX.html">VkCuModuleNVX</see> - Stub description of VkCuModuleNVX
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NVX_binary_import
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkCuModuleNVX)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkCuModuleNVX : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.CuModuleNVX;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkCuModuleNVX(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkCuModuleNVX NullHandle = new();
    }
}
