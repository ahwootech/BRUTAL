namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineLayout.html">VkPipelineLayout</see> - Opaque handle to a pipeline layout object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Access to descriptor sets from a pipeline is accomplished through a
    ///         <i>pipeline layout</i>.
    ///         Zero or more descriptor set layouts and zero or more push constant ranges
    ///         are combined to form a pipeline layout object describing the complete set of
    ///         resources that <i>can</i> be accessed by a pipeline.
    ///         The pipeline layout represents a sequence of descriptor sets with each
    ///         having a specific layout.
    ///         This sequence of layouts is used to determine the interface between shader
    ///         stages and shader resources.
    ///         Each pipeline is created using a pipeline layout.
    ///     </para>
    ///     <para>
    ///         Pipeline layout objects are represented by <c>VkPipelineLayout</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkPipelineLayout)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkPipelineLayout : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.PipelineLayout;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkPipelineLayout(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkPipelineLayout NullHandle = new();
    }
}
