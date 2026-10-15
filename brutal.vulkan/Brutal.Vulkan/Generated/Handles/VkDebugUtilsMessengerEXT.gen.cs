namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsMessengerEXT.html">VkDebugUtilsMessengerEXT</see> - Opaque handle to a debug messenger object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A <c>VkDebugUtilsMessengerEXT</c> is a messenger object which handles passing
    ///         along debug messages to a provided debug callback.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_debug_utils
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkDebugUtilsMessengerEXT)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkDebugUtilsMessengerEXT : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.DebugUtilsMessengerEXT;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkDebugUtilsMessengerEXT(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkDebugUtilsMessengerEXT NullHandle = new();
    }
}
