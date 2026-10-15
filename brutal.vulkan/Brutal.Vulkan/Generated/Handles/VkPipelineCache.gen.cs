namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCache.html">VkPipelineCache</see> - Opaque handle to a pipeline cache object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Pipeline cache objects allow the result of pipeline construction to be
    ///         reused between pipelines and between runs of an application.
    ///         Reuse between pipelines is achieved by passing the same pipeline cache
    ///         object when creating multiple related pipelines.
    ///         Reuse across runs of an application is achieved by retrieving pipeline cache
    ///         contents in one run of an application, saving the contents, and using them
    ///         to preinitialize a pipeline cache on a subsequent run.
    ///         The contents of the pipeline cache objects are managed by the
    ///         implementation.
    ///         Applications <i>can</i> manage the host memory consumed by a pipeline cache object
    ///         and control the amount of data retrieved from a pipeline cache object.
    ///     </para>
    ///     <para>
    ///         Pipeline cache objects are represented by <c>VkPipelineCache</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkPipelineCache)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkPipelineCache : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.PipelineCache;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkPipelineCache(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkPipelineCache NullHandle = new();
    }
}
