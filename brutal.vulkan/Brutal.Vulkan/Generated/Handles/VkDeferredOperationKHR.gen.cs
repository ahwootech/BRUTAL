namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeferredOperationKHR.html">VkDeferredOperationKHR</see> - A deferred operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeferredOperationKHR</c> handle is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_deferred_host_operations
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkDeferredOperationKHR)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkDeferredOperationKHR : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.DeferredOperationKHR;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkDeferredOperationKHR(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkDeferredOperationKHR NullHandle = new();
    }
}
