namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDebugReportCallbackEXT.html">VkDebugReportCallbackEXT</see> - Opaque handle to a debug report callback object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Debug report callbacks are represented by <c>VkDebugReportCallbackEXT</c>
    ///         handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_debug_report
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkDebugReportCallbackEXT)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkDebugReportCallbackEXT : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.DebugReportCallbackEXT;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkDebugReportCallbackEXT(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkDebugReportCallbackEXT NullHandle = new();
    }
}
