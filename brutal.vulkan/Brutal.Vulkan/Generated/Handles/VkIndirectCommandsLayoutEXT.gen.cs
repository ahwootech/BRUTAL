namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutEXT.html">VkIndirectCommandsLayoutEXT</see> - Opaque handle to an indirect commands layout object
    /// </summary>
    /// <remarks>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkIndirectCommandsLayoutEXT)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkIndirectCommandsLayoutEXT : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.IndirectCommandsLayoutEXT;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkIndirectCommandsLayoutEXT(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkIndirectCommandsLayoutEXT NullHandle = new();
    }
}
