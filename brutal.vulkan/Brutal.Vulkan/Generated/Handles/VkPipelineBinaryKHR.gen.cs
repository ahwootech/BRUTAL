namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryKHR.html">VkPipelineBinaryKHR</see> - Opaque handle to a pipeline binary object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Pipeline binary objects allow the result of pipeline construction to be
    ///         reused between pipelines and between runs of an application.
    ///         Reuse is achieved by extracting pipeline binaries from a <c>VkPipeline</c>
    ///         object, associating them with a corresponding <c>VkPipelineBinaryKeyKHR</c>
    ///         and then adding a <c>VkPipelineBinaryInfoKHR</c> to the <c>pNext</c> chain of
    ///         any stext:Vk*PipelineCreateInfo when creating a pipeline.
    ///         Pipeline binaries can be reused between runs by extracting
    ///         <c>VkPipelineBinaryDataKHR</c> from <c>VkPipelineBinaryKHR</c> objects, saving
    ///         the contents, and then using them to create a <c>VkPipelineBinaryKHR</c>
    ///         object on subsequent runs.
    ///     </para>
    ///     <para>
    ///         When creating a pipeline that includes <c>VkPipelineBinaryInfoKHR</c> in the
    ///         <c>pNext</c> chain, or has the
    ///         <c>VK_PIPELINE_CREATE_2_CAPTURE_DATA_BIT_KHR</c> flag set, the use of
    ///         <c>VkPipelineCache</c> objects is not allowed.
    ///     </para>
    ///     <para>
    ///         Pipeline binary objects are represented by <c>VkPipelineBinaryKHR</c>
    ///         handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_binary
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkPipelineBinaryKHR)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkPipelineBinaryKHR : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.PipelineBinaryKHR;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkPipelineBinaryKHR(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkPipelineBinaryKHR NullHandle = new();
    }
}
