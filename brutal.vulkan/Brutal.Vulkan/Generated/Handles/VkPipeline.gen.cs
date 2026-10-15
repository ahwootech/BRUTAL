namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipeline.html">VkPipeline</see> - Opaque handle to a pipeline object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Compute,
    ///         pipelines are each represented by <c>VkPipeline</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkPipeline)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkPipeline : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.Pipeline;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkPipeline(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkPipeline NullHandle = new();
    }
}
