namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutNV.html">VkIndirectCommandsLayoutNV</see> - Opaque handle to an indirect commands layout object
    /// </summary>
    /// <remarks>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkIndirectCommandsLayoutNV)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkIndirectCommandsLayoutNV : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.IndirectCommandsLayoutNV;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkIndirectCommandsLayoutNV(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkIndirectCommandsLayoutNV NullHandle = new();
    }
}
