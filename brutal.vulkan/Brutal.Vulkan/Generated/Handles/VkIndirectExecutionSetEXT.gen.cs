namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetEXT.html">VkIndirectExecutionSetEXT</see> - Opaque handle to an indirect execution set object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Indirect Execution Sets contain sets of pipelines
    ///         which can be bound individually.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkIndirectExecutionSetEXT)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkIndirectExecutionSetEXT : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.IndirectExecutionSetEXT;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkIndirectExecutionSetEXT(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkIndirectExecutionSetEXT NullHandle = new();
    }
}
