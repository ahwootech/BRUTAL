namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueryPool.html">VkQueryPool</see> - Opaque handle to a query pool object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Queries are managed using <i>query pool</i> objects.
    ///         Each query pool is a collection of a specific number of queries of a
    ///         particular type.
    ///     </para>
    ///     <para>
    ///         Query pools are represented by <c>VkQueryPool</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkQueryPool)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkQueryPool : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.QueryPool;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkQueryPool(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkQueryPool NullHandle = new();
    }
}
