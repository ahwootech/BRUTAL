namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMicromapEXT.html">VkMicromapEXT</see> - Opaque handle to a micromap object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkMicromapEXT
    ///     </para>
    ///     <para>
    ///         Micromaps are represented by <c>VkMicromapEXT</c> handles for use with
    ///         `<c>VK_EXT_opacity_micromap</c>` commands:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkMicromapEXT)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkMicromapEXT : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.MicromapEXT;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkMicromapEXT(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkMicromapEXT NullHandle = new();
    }
}
