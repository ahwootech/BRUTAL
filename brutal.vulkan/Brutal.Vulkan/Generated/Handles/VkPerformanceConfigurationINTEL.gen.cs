namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceConfigurationINTEL.html">VkPerformanceConfigurationINTEL</see> - Device configuration for performance queries
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Before submitting command buffers containing performance queries commands to
    ///         a device queue, the application <i>must</i> acquire and set a performance query
    ///         configuration.
    ///         The configuration can be released once all command buffers containing
    ///         performance query commands are not in a pending state.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkPerformanceConfigurationINTEL)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkPerformanceConfigurationINTEL : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.PerformanceConfigurationINTEL;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkPerformanceConfigurationINTEL(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkPerformanceConfigurationINTEL NullHandle = new();
    }
}
